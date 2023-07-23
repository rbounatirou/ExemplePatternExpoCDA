using PatternMemento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoucheMemento
{
    public class MementoTransaction : IMemento<Transaction>
    {
        private Transaction transactionClonee;
        private DateTime dateMemento;
        private IOriginator<Transaction> originator; 
        public MementoTransaction(IOriginator<Transaction> originator, Transaction transaction)
        {
            this.transactionClonee = (Transaction)transaction.Clone();
            this.originator = originator;
            this.dateMemento = DateTime.Now;
        }
        public DateTime GetDate()
        {
            return dateMemento;
        }

        public void Restore()
        {
            originator.SetState(transactionClonee);
        }
    }
}

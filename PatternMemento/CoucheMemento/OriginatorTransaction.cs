using PatternMemento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMemento
{
    public class OriginatorTransaction : IOriginator<Transaction>
    {
        private Transaction obj;

        public OriginatorTransaction(Transaction obj)
        {
            this.obj = obj;
        }
        public IMemento<Transaction> Save()
        {
            return new MementoTransaction(this, obj);
        }

        public void SetState(Transaction _obj)
        {
            obj = _obj;
        }

    }
}

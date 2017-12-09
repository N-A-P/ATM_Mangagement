using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Money
    {
        private int _MoneyID;

        public int MoneyID
        {
            get { return _MoneyID; }
            set { _MoneyID = value; }
        }

        private int _MoneyValue;

        public int MoneyValue
        {
            get { return _MoneyValue; }
            set { _MoneyValue = value; }
        }

        public Money(int id, int value)
        {
            this._MoneyID = id;
            this._MoneyValue = value;
        }
    }
}

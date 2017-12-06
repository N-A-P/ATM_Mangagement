using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Money
    {
        private string _MoneyID;

        public string MoneyID
        {
            get { return _MoneyID; }
            set { _MoneyID = value; }
        }

        private float _MoneyValue;

        public float MoneyValue
        {
            get { return _MoneyValue; }
            set { _MoneyValue = value; }
        }

        public Money(string id, float value)
        {
            this._MoneyID = id;
            this._MoneyValue = value;
        }
    }
}

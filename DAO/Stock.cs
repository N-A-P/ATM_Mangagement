using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Stock
    {
        private string _StockID;

        public string StockID
        {
            get { return _StockID; }
            set { _StockID = value; }
        }

        private string _MoneyID;

        public string MoneyID
        {
            get { return _MoneyID; }
            set { _MoneyID = value; }
        }

        private string _ATMID;

        public string ATMID
        {
            get { return _ATMID; }
            set { _ATMID = value; }
        }

        private int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        public Stock(string stockID, string moneyID, string atmID, int quantity)
        {
            this._StockID = stockID;
            this._MoneyID = moneyID;
            this._ATMID = atmID;
            this._Quantity = quantity;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Stock
    {
        private int _StockID;

        public int StockID
        {
            get { return _StockID; }
            set { _StockID = value; }
        }

        public Money Money { get; set; }

        private int _ATMID;

        public int ATMID
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

        public Stock() { }

        public Stock(int stockID, Money money, int quantity)
        {
            this._StockID = stockID;
            this.Money = money;
            this._Quantity = quantity;
        }
        
    }
}

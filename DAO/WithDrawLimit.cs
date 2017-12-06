using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class WithDrawLimit
    {
        private int _WDID;

        public int WDID
        {
            get { return _WDID; }
            set { _WDID = value; }
        }

        private int _Value;

        public int Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        public WithDrawLimit(int id, int value)
        {
            this._WDID = id;
            this._Value = value;
        }
        
    }
}

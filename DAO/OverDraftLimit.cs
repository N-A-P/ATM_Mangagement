using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class OverDraftLimit
    {
        private int _ODID;
        private int _Value;

        public int ODID
        {
            get { return _ODID; }
            set { _ODID = value; }
        }

        public int Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        
        public OverDraftLimit(int odId, int value)
        {
            this._ODID = odId;
            this._Value = value;
        }
    }
}

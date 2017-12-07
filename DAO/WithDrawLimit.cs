using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class WithDrawLimit
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

        public WithDrawLimit() { }

        public WithDrawLimit(int id, int value)
        {
            this._WDID = id;
            this._Value = value;
        }
        
        public WithDrawLimit(SqlDataReader dr) {
         while (dr.Read())
            {
                this._WDID = (int)dr["WDID"];
                this._Value = (int)dr["Value"];
            }      
        }
    }
}

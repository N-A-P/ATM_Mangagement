using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ATM
    {
        private int _ATMID;

        public int ATMID
        {
            get { return _ATMID; }
            set { _ATMID = value; }
        }

        private string _Branch;

        public string Branch
        {
            get { return _Branch; }
            set { _Branch = value; }
        }

        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public ATM() { }

        public ATM(int id, string branch, string address)
        {
            this._ATMID = id;
            this._Branch = branch;
            this._Address = address;
        }
    }
}

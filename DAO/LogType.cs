using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LogType
    {
        private int _LogTypeID;

        public int LogTypeID
        {
            get { return _LogTypeID; }
            set { _LogTypeID = value; }
        }

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public LogType() { }

        public LogType(int id, string des)
        {
            this._LogTypeID = id;
            this._Description = des;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Account
    {
        public string AccountID { get; set; }
        public string CustID { get; set; }
        public string AccountNo { get; set; }
        public string ODID { get; set; }
        public string WDID { get; set; }
        public string Balance { get; set; }

        public Account(string accId, string custId, string accNo, string odId, string wdId, string balance)
        {
            this.AccountID = accId;
            this.CustID = custId;
            this.AccountNo = accNo;
            this.ODID = odId;
            this.WDID = wdId;
            this.Balance = balance;
        }
    }
}

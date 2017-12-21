using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
   public class Account
    {
        public int AccountID { get; set; }
        public int CustID { get; set; }
        public string AccountNo { get; set; }
        public string ODID { get; set; }
        public string WDID { get; set; }
        public int Balance { get; set; }
        public Customer Customer { get; set; }
        public OverDraftLimit OverDraft { get; set; }
        public WithDrawLimit WithDraw { get; set; }

        public Account() { }

        public Account(int accId, string accNo, int balance, Customer customer, OverDraftLimit overDraft, WithDrawLimit withDraw)
        {
            this.AccountID = accId;
            this.AccountNo = accNo;
            this.Balance = balance;
            this.Customer = customer;
            this.OverDraft = overDraft;
            this.WithDraw = withDraw;
        }

        public Account(SqlDataReader dr)
        {
                this.AccountID = (int)dr["AccountID"];
                this.Balance = (int)dr["Balance"];
                this.AccountNo = dr["AccountNo"].ToString();
                this.CustID = (int)dr["CustID"];
                this.OverDraft = new OverDraftLimit(dr);
                this.WithDraw = new WithDrawLimit(dr);
        }
    }
}

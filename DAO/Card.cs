using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Card
    {
        public string CardNo { get; set; }
        public string Status { get; set; }
        public string AccountID { get; set; }
        public string PIN { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpriredDate { get; set; }
        public int Attempt { get; set; }

        public Card(string cardNo, string status, string accId, string Pin, DateTime startDate, DateTime expriredDate, int attempt)
        {
            this.CardNo = cardNo;
            this.Status = status;
            this.AccountID = accId;
            this.PIN = Pin;
            this.StartDate = startDate;
            this.ExpriredDate = expriredDate;
            this.Attempt = attempt;
        }
    }
}

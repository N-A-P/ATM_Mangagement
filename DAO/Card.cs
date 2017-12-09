using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Card
    {

        public string CardNo { get; set; }
        public int Status { get; set; }
        public int AccountID { get; set; }
        public string PIN { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpriredDate { get; set; }
        public int Attempt { get; set; }

        public Card() {
            this.CardNo = "";
            this.Attempt = 3;
        }

        public Card(string cardNo, int status, int accId, string Pin, DateTime startDate, DateTime expriredDate)
        {
            this.CardNo = cardNo;
            this.Status = status;
            this.AccountID = accId;
            this.PIN = Pin;
            this.StartDate = startDate;
            this.ExpriredDate = expriredDate;
            this.Attempt = 3;
        }

    }
}

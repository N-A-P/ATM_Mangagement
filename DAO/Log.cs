using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Log
    {
        public string LogID { get; set; }
        public string LogTypeID { get; set; }
        public string ATMID { get; set; }
        public string CardNo { get; set; }
        public DateTime LogDate { get; set; }
        public int Amount { get; set; }
        public string Details { get; set; }
        public string CardNoTo { get; set; }


        public Log(string logId, string logTypeID, string atmID, string cardNo, DateTime logDate, int amount, string details, string toCardNo)
        {
            this.LogID     = logId;
            this.LogTypeID = logTypeID;
            this.ATMID     = atmID;
            this.CardNo    = cardNo;
            this.LogDate   = logDate;
            this.Amount    = amount;
            this.Details   = details;
            this.CardNoTo = toCardNo;
        }
    }
}

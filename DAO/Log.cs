using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Log
    {
        public int LogID { get; set; }
        public int LogTypeID { get; set; }
        public int ATMID { get; set; }
        public string CardNo { get; set; }
        public DateTime LogDate { get; set; }
        public int Amount { get; set; }
        public string Details { get; set; }
        public string CardNoTo { get; set; }

        public Log() { }

        public Log(int logId, int logTypeID, int atmID, string cardNo, DateTime logDate, int amount, string details, string toCardNo)
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

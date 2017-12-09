using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;
using System.Data;

namespace BLL
{
    public class LogBLL
    {
        LogDAL logDAL = new LogDAL();
        public DataTable getLog(string cardNo)
        {
            return logDAL.getLogs(cardNo);
        }

        public void createLog(Log log) {
            logDAL.CreateLog(log);
        }

        public int getAmount(string cardNo) {
            return logDAL.getAmout(cardNo);
        }
    }
}

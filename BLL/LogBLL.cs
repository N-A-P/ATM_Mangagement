using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
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
    }
}

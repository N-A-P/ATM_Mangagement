using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BLL
{
    class ATMBLL
    {
        ATMDAL atmDAL = new ATMDAL();
        public ATM getInfoATM(int id)
        {
            ATM atm = atmDAL.getATMInfo(id);
            return atm;
        }
    }
}

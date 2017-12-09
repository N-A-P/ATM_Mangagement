using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DAL;

namespace BLL
{
    class TransferBLL
    {
        AccountBLL accBLL = new AccountBLL();
        public int checkAmount( string cardNo, int accID, int amount, int configID) {
            return accBLL.checkAmount(cardNo, accID, amount, 1, configID);
        }

        public void updateBalance(int accID, int newBalance) {
            accBLL.updateBalance(accID, newBalance, 1);
        }

    }
}

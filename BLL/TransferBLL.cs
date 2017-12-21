using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DAL;

namespace BLL
{
   public class TransferBLL
    {
        AccountBLL accBLL = new AccountBLL();
        public bool checkAmount(int accID, int amount) {
            bool result = false;
            int balance = accBLL.getBalance(accID);
            if (balance >= amount) {
                result = true;
            }
            return result; 
        }

        public void updateBalance(int accID, int newBalance, int status) {
            accBLL.updateBalance(accID, newBalance, status);
        }
    }
}

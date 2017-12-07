using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BLL
{
    public class AccountBLL
    {
        AccountDAL accDAL = new AccountDAL();

        public Account getAccInfo(int accID) {
            return accDAL.getAccInfo(accID);
        }
        
        public int getBalance(int accID) {
            int balance = 0;
            Account acc = getAccInfo(accID);
            balance = acc.Balance;
            return balance;
        }

        public int getWithdrawLimit(int accID)
        {
            int limit = 0;
            Account acc = getAccInfo(accID);
            WithDrawLimit wd = acc.WithDraw;
            limit = wd.Value;
            return limit;
        }

        public int getOverDraftLimit(int accID)
        {
            int limit = 0;
            Account acc = getAccInfo(accID);
            OverDraftLimit oD = acc.OverDraft;
            limit = oD.Value;
            return limit;
        }

        public void updateBalance(int accID, int newBalance) {
            accDAL.updateBalance(accID, newBalance);
        }

    }
}

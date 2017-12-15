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
        LogBLL logBLL = new LogBLL();
        ConfigBLL confBLL = new ConfigBLL();
        StockBLL stockBLL = new StockBLL();

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

        //1: Vuot muc thau chi
        //2: Vuot muc toi da rut trong ngay
        //3: Vuot muc toi da 1 lan rut
        //4: So tien rut nho hon toi thieu
        //5: So tien trong cay khong du
        // status   = 0: Rut tien
        // status   = 1: Nhan tien
        public int checkAmount(string cardNo, int accID, int amount, int status)
        {

            int currBalance = getBalance(accID);
            int withDrawLimit = getWithdrawLimit(accID);
            int overDrafLimit = getOverDraftLimit(accID);
            int amountTotal = logBLL.getAmount(cardNo);
            int totalMoney = stockBLL.getTotalMoney();
            int minDrawConf = confBLL.getMinDraw();
            int maxDrawConf = confBLL.getMaxDraw();

            if ((currBalance + overDrafLimit) < amount) {
                return 1;
            }

            if ((withDrawLimit + amountTotal) < amount) {
                return 2;
            }
            if (status == 0) {
                if (maxDrawConf < amount) {
                    return 3;
                }

                if (minDrawConf > amount) {
                    return 4;
                }

                if (totalMoney < amount) {
                    return 5;
                }
            }

            return 0;
        }

        // status 
        // 0: Rut tien
        // 1: Nhan tien
        public void updateBalance(int accID, int newBalance, int status) {
            int currBalance = accDAL.getBalance(accID);
            int newB = 0;
            if (status == 0)
            {
                newB = currBalance - newBalance;
            }
            else {
                newB = currBalance + newBalance;
            }
            accDAL.updateBalance(accID, newBalance);
        }
    }
}

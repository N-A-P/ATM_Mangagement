using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;
namespace BLL
{
    class StockBLL
    {
        StockDAL stockDAL = new StockDAL();
        public int getTotalMoney() {
            int total = 0;

            foreach (Stock st in stockDAL.getListStock(ConfigATM.ATMID)) {
                Money money = st.Money;
                total = total + (st.Quantity * money.MoneyValue);
            }
            return total;
        }

        public void updateStock(int amount) {

            List<Stock> listStocks = stockDAL.getListStock(ConfigATM.ATMID);
            List<int> listQuantitys = new List<int>();
            List<int> listMoneyIDs = new List<int>();
            List<int> listMoneyValues = new List<int>();

            //50,000
            //100,000
            //200,000
            //500,000

            foreach (Stock stock in listStocks) {
                listQuantitys.Add(stock.Quantity);
                listMoneyIDs.Add(stock.Money.MoneyID);
                listMoneyValues.Add(stock.Money.MoneyValue);
            }

            int i50 = 0;
            int i100 = 0;
            int i200 = 0;
            int i500 = 0;
            for (i50 = 0; i50 <= listQuantitys[0]; i50++) {
                for (i100 = 0; i100 <= listQuantitys[1]; i100++) {
                    for (i200 = 0; i200 <= listQuantitys[2]; i200++) {
                        for (i500 = 0; i500 <= listQuantitys[3]; i500++) {
                            if ((i500 * 500000 + i200 * 200000 + i100 * 100000 + i50 * 50000) == amount) {
                                break;
                            }
                        }
                    }
                }
            }
            //
            listQuantitys[0] -= i50;
            listQuantitys[1] -= i100;
            listQuantitys[2] -= i200;
            listQuantitys[3] -= i500;

            for (int j = 0; j < listMoneyIDs.Count - 1; j++) {
                stockDAL.updateStock(listQuantitys[j], listMoneyIDs[j]);
            }
        }
    }
}

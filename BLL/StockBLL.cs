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
    }
}

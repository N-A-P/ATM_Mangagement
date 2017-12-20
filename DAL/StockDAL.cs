using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;

namespace DAL
{
    public class StockDAL
    {
        public List<Stock> getListStock(int atmID) {
            ServiceManager.KetNoi();
            List<Stock> listStock = new List<Stock>();
            String cmdString =
                @"Select Stock.StockID, Stock.Quantity, Stock.MoneyID, Money.MoneyValue
            FROM ((Stock st 
                INNER JOIN ATM atm ON st.ATMID = atm.ATMID)
                INNER JOIN Money m ON st.MoneyID = m.MoneyID)
                Where st.ATMID = @id;";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            cmd.Parameters.AddWithValue("id", atmID);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                
                int stockID = (int)dr["StockID"];
                int quantity = (int)dr["Quantity"];
                int moneyID = (int)dr["MoneyID"];
                int moneyValue = (int)dr["MoneyValue"];
                Money money = new Money(moneyID, moneyValue);
                Stock st = new Stock(stockID, money, quantity);
                listStock.Add(st);
            }

            return listStock;
        }
    }
}

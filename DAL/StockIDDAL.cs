using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;

namespace DAL
{
    public class StockIDDAL
    {
        public List<Stock> getStock(int atmID) {
            ServiceManager.KetNoi();
            List<Stock> listStock = new List<Stock>();

            String cmdString =
                @"Select Stock, Money FROM 
                ((Stock st 
                INNER JOIN ATM atm ON st.ATMID = atm.ATMID)
                INNER JOIN Money m ON st.MoneyID = m.MoneyID)
                Where st.ATMID = @id;";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            cmd.Parameters.AddWithValue("id", atmID);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                Stock st = new Stock();
                int stockID = (int)dr["StockID"];
                int quantity = (int)dr["Quantity"];




            }


            return listStock;
        }
    }
}

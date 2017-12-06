using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CardDAL
    {
        public Card getCardInfo(string cardNo) 
        {
            ServiceManager.KetNoi();
            Card card = new Card();
            String cmdString = "SELECT * FROM Card WHERE CardNo = @cardNo";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            cmd.Parameters.AddWithValue("cardNo", cardNo);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                string no               = dr["CardNo"].ToString();
                string pin              = dr["PIN"].ToString();
                string status           = dr["Status"].ToString();
                DateTime startDate      = (DateTime)dr["StartDate"];
                DateTime expiredDate    = (DateTime)dr["ExpiredDate"];
                int accID               = (int)dr["AccountID"];
                card = new Card(no,status, accID, pin, startDate, expiredDate);
            }
            ServiceManager.DongKetNoi();
            return card;
        }
    }
}

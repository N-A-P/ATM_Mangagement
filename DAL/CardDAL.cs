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
                int status              = (int)dr["Status"];
                DateTime startDate      = (DateTime)dr["StartDate"];
                DateTime expiredDate    = (DateTime)dr["ExpiredDate"];
                int accID               = (int)dr["AccountID"];
                card = new Card(no,status, accID, pin, startDate, expiredDate);
            }
            ServiceManager.DongKetNoi();
            return card;
        }
        public void DisableCard(string cardNo)
        {
            ServiceManager.KetNoi();
            string cmdString = "update Card set Status=@disable where CardNo = @cardNo";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            cmd.Parameters.AddWithValue("cardNo", cardNo);
            cmd.Parameters.AddWithValue("disable", 0);
            cmd.ExecuteNonQuery();
            ServiceManager.DongKetNoi();
        }

        public void ChangePIN(string cardNo, string pin) {
            ServiceManager.KetNoi();
            string cmdString = "Update Card set PIN=@pin Where CardNo = @cardNo";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            cmd.Parameters.AddWithValue("cardNo", cardNo);
            cmd.Parameters.AddWithValue("pin", pin);
            cmd.ExecuteNonQuery();
            ServiceManager.DongKetNoi();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL
{
    public class ServiceManager
    {
        public static SqlConnection conn  = null;
        public static void KetNoi() {
            String connString = ConfigurationManager.ConnectionStrings["ATM"].ToString();
            conn = new SqlConnection(connString);
            conn.Open();
        }

        public static void DongKetNoi() {
            conn.Close();
        }

        public static void queryService(string str, SqlCommand cmd)
        {
            KetNoi();
            cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }

        public static SqlDataReader queryGetData(string cardNo)
        {
            KetNoi();
            String cmdString = "SELECT * FROM Card WHERE CardNo = @cardNo";
            SqlCommand cmd = new SqlCommand(cmdString,conn);
            cmd.Parameters.AddWithValue("cardNo", cardNo);
            SqlDataReader dr ;
            dr = cmd.ExecuteReader();
            DongKetNoi();
            return dr;
        }
    }
}

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
            String connString = ConfigurationManager.ConnectionStrings["ATM2"].ToString();
            conn = new SqlConnection(connString);
            conn.Open();
        }

        public static void DongKetNoi() {
            conn.Close();
        }
    }
}

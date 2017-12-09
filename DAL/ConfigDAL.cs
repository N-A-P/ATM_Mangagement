using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;
namespace DAL
{
    public class ConfigDAL
    {
        public Config getConfig(int configID) {
            ServiceManager.KetNoi();
            Config config = new Config();
            String cmdString =
                @"Select * FROM Config Where ConfigID = @configID";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            cmd.Parameters.AddWithValue("config", configID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                int conID = (int)dr["ConfigID"];
                int min = (int)dr["MinWithdraw"];
                int max = (int)dr["MaxWithdraw"];
                config = new Config(conID, min, max);
            }
            ServiceManager.DongKetNoi();
            return config;
        }
    }
}

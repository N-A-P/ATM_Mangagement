using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;

namespace DAL
{
    class LogTypeDAL
    {
        public LogType getLogType(int id)
        {
            ServiceManager.KetNoi();
            LogType logType = new LogType();
            string cmdString =
                            @"SELECT * FROM LogType WHERE LogTypeID = @id;";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int typeId = (int)dr["LogTypeID"];
                string desc = dr["Description"].ToString();         
                logType = new LogType(typeId, desc);
            }
            return logType;
        }
    }
}

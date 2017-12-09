using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LogDAL
    {
        public void CreateLog(Log log) { 
            ServiceManager.KetNoi();
            String cmdString = 
                            @"INSERT INTO LOG
                            VALUES (@logID, @logDate, @amount, @details, @logTypeId, @atmId, @cardNo, @toCard);";
            SqlCommand cmd =  new SqlCommand(cmdString,ServiceManager.conn);
            cmd.Parameters.AddWithValue("logID",log.LogID);
            cmd.Parameters.AddWithValue("logDate",log.LogDate);
            cmd.Parameters.AddWithValue("amount",log.Amount);
            cmd.Parameters.AddWithValue("details",log.Details);
            cmd.Parameters.AddWithValue("logTypeId",log.LogTypeID);
            cmd.Parameters.AddWithValue("atmId",log.ATMID);
            cmd.Parameters.AddWithValue("cardNo",log.CardNo);
            cmd.Parameters.AddWithValue("toCard",log.CardNoTo);
            
            cmd.ExecuteNonQuery();
            ServiceManager.DongKetNoi();
        }

        public DataTable getLogs(string cardNo) {
            ServiceManager.KetNoi();
            String cmdString =
            @"SELECT Log.LogID, Log.LogDate, Log.Amount, Log.Details, ATM.Branch, ATM.Address, Log.CardNo, Log.ToCard 
            FROM ((LOG log
            INNER JOIN ATM atm ON log.ATMID = atm.ATMID)
            INNER JOIN LogType lt ON log.LogTypeID = lt.LogTypeID)
            WHERE log.CardNo = @cardNo ;";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            cmd.Parameters.AddWithValue("cardNo", cardNo);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read()) {
            //    Log log = new Log();
            //    int logID = (int)dr["LogID"];
            //    DateTime logDate = (DateTime)dr["LogDate"];
            //    int amo = (int)dr["Amount"];
            //    string details = dr["Details"].ToString();
            //    int logTypeID = (int)dr["LogTypeID"];
            //    int atmID = (int)dr["ATMID"];
            //    string card = dr["CardNo"].ToString();
            //    string toCardNo = dr["ToCard"].ToString();
            //    log = new Log(logID, logTypeID, atmID, card, logDate, amo, details, toCardNo);
            //}
            ServiceManager.DongKetNoi();
            return dt;
        }
    }
}

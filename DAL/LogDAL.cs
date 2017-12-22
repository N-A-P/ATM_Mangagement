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
                            @"INSERT INTO Log (LogDate,Amount,Details,LogTypeID,ATMID,CardNo,ToCard)
                            VALUES (@logDate, @amount, @details, @logTypeId, @atmId, @cardNo, @toCard);";
            SqlCommand cmd =  new SqlCommand(cmdString,ServiceManager.conn);
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
            @"SELECT log.LogDate, log.Amount, log.Details, lt.Description, atm.Branch, atm.Address, log.CardNo, log.ToCard
            FROM ((LOG log
            INNER JOIN LogType lt ON log.LogTypeID = lt.LogTypeID)
            INNER JOIN ATM atm ON log.ATMID = atm.ATMID)
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

        public int getAmout(string cardNo) {
            string currDate = DateTime.Now.ToString("yyyy-MM-dd");
            int amount = 0;
            ServiceManager.KetNoi();
            String cmdString =
            @"SELECT Log.Amount
            FROM ((LOG log
            INNER JOIN ATM atm ON log.ATMID = atm.ATMID)
            INNER JOIN LogType lt ON log.LogTypeID = lt.LogTypeID)
            WHERE log.CardNo = @cardNo AND log.LogDate = @logDate;";

            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);

            cmd.Parameters.AddWithValue("cardNo", cardNo);
            cmd.Parameters.AddWithValue("logDate", currDate);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                int logTypeID = (int)dr["LogTypeID"];               
                int am = (int)dr["Amount"];
                if (logTypeID == 1) {
                    amount = amount + am;
                }            
            }
            ServiceManager.DongKetNoi();
            return amount;
        }
    }
}

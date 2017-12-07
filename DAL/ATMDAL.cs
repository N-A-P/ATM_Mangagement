using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;

namespace DAL
{
    public class ATMDAL
    {
        public ATM getATMInfo(int id) {
            ServiceManager.KetNoi();
            ATM atm =  new ATM();
            string cmdString =
                            @"SELECT * FROM ATM WHERE ATMID = @id;";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                int atmId = (int)dr["ATMID"];
                string branch = dr["Branch"].ToString();
                string addr = dr["Address"].ToString();
                atm = new ATM(atmId, branch, addr);
            }
            return atm ;
        }
    }
}

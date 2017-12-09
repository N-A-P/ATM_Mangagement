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
    public class AccountDAL
    {
        public Account getAccInfo(int accountID)
        {
            Account acc = new Account();
            ServiceManager.KetNoi();
            String cmdString = @"SELECT *
            FROM (((Account acc
            INNER JOIN Customer cust ON acc.CustID = cust.CustID)
            INNER JOIN OverDraft oD ON acc.ODID = oD.ODID)
            INNER JOIN WithdrawLimit wD ON acc.WDID = wD.WDID)
            WHERE acc.AccountID = @accId ;";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            cmd.Parameters.AddWithValue("accId",accountID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                acc = new Account(dr);
            }
            ServiceManager.DongKetNoi();
            return acc;
        }

        public int getBalance(int accountID)
        {
            int balance = 0;
            ServiceManager.KetNoi();
            String cmdString = @"SELECT Account.Balance
            FROM (((Account acc
            INNER JOIN Customer cust ON acc.CustID = cust.CustID)
            INNER JOIN OverDraft oD ON acc.ODID = oD.ODID)
            INNER JOIN WithdrawLimit wD ON acc.WDID = wD.WDID)
            WHERE acc.AccountID = @accId ;";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            cmd.Parameters.AddWithValue("accId", accountID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                balance = (int)dr["Balance"];
            }
            ServiceManager.DongKetNoi();
            return balance;
        }

        public void updateBalance(int accID, int newBalance)
        {
            ServiceManager.KetNoi();
            String cmdString =
                @"UPDATE Account 
                SET Balance = @newBalance
                WHERE AccountID = @accID ;";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            cmd.Parameters.AddWithValue("newBalance", newBalance);
            cmd.Parameters.AddWithValue("accID", accID);
            cmd.ExecuteNonQuery();
            ServiceManager.DongKetNoi();
        }
    }
}

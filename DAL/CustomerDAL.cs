using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;

namespace DAL
{
    public class CustomerDAL
    {
        public Customer getCusomer(int custID) {
            Customer cust = new Customer();
            ServiceManager.KetNoi();
            String cmdString = @"SELECT * FROM Customer WHERE CustID = @custId;";
            SqlCommand cmd = new SqlCommand(cmdString, ServiceManager.conn);
            cmd.Parameters.AddWithValue("custId", custID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = (int)dr["CustID"];
                string name = dr["Name"].ToString();
                string email = dr["Email"].ToString();
                string phone  = dr["Phone"].ToString();
                string addr = dr["Addr"].ToString();
                cust = new Customer(id,name,phone,email,addr);
            }
            ServiceManager.DongKetNoi();
            return cust;
        }

        public string getName(int custID) {
            Customer cust = getCusomer(custID);
            return cust.Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class Customer
    {
        public int CustID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Addr { get; set; }

        public Customer() { }

        public Customer(int id, string name, string phone, string email, string addr)
        {
            this.CustID = id;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Addr = addr;
        }
    }

}

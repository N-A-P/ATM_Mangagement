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
    public class CardDAL
    {
        public SqlDataReader getCardInfo(string cardNo) 
        {
            String cmdString = "SELECT FROM Card WHERE CardNo = @cardNo";
            SqlCommand cmd =  new SqlCommand();
            cmd.Parameters.AddWithValue("cardNo",cardNo);
            SqlDataReader dr = ServiceManager.queryGetData(cmdString,cmd);
            return dr;
        }
    }
}

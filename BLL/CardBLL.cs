using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BLL
    {
        CardDAL cardDAL = new CardDAL();
        public Boolean checkCard(string cardNo)
        {
            Boolean result = false;
            if (cardNo.Length != 13)
            {
                return false;
            }
            SqlDataReader dr = cardDAL.getCardInfo(cardNo);
            string card = "";
            while (dr.Read()) 
            {
               card = dr["CardNo"].ToString();            
            }
            if (card != "")
            {
                result = true;
            }
            return result;
        }

        public Boolean checkPIN(string cardNo, string PIN)
        {
            Boolean result = false;
            SqlDataReader dr = cardDAL.getCardInfo(cardNo);
            string pin = "";
            while (dr.Read())
            {
                pin = dr["PIN"].ToString();
            }
            if (PIN == pin)
            {
                result = true;
            }
            return result;
        }
    }
}

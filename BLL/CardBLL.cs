using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BLL
    {
        CardDAL cardDAL = new CardDAL();
        Card card = new Card();
        public Boolean checkCard(string cardNo)
        {
            Boolean result = false;
            //if (cardNo.Length != 13)
            //{
            //    return false;
            //}
            card = cardDAL.getCardInfo(cardNo);
            if (card.CardNo != "")
            {
                result = true;
            }
            if (card.Status == 0)
            {
                return false;
            }
            return result;
        }

        public Card getCardInfo(string cardNo) {
            return cardDAL.getCardInfo(cardNo);
        }

        public Boolean checkPIN(string cardNo, string PIN,int atemps)
        {
            
         Boolean result = false;
            card = cardDAL.getCardInfo(cardNo);
            if (card.PIN == PIN)
            {
                result = true;
            }
            if (atemps == 3 && result == false)
            {
                cardDAL.DisableCard(cardNo);
            }
            return result;
        }

        public void ChangePIN(string cardNo, string pin) {
            cardDAL.ChangePIN(cardNo, pin);
        }
    }
}

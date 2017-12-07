﻿using System;
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
            if (cardNo.Length != 13)
            {
                return false;
            }
            card = cardDAL.getCardInfo(cardNo);
            if (card.CardNo != "")
            {
                result = true;
            }
            return result;
        }

        public Boolean checkPIN(string cardNo, string PIN)
        {
            Boolean result = false;
            card = cardDAL.getCardInfo(cardNo);
            if (card.PIN == PIN)
            {
                result = true;
            }
            return result;
        }
    }
}
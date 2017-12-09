using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;
namespace BLL
{
    class ConfigBLL
    {
        ConfigDAL confDAL = new ConfigDAL();

        public int getMinDraw() {
            Config config = confDAL.getConfig(ConfigATM.ConfigID);
            return config.MinWithdraw;
        }

        public int getMaxDraw() {
            Config config = confDAL.getConfig(ConfigATM.ConfigID);
            return config.MaxWithdraw;
        }
    }
}

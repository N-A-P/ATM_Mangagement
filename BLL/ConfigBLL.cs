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

        public int getMinDraw(int id) {
            Config config = confDAL.getConfig(id);
            return config.MinWithdraw;
        }

        public int getMaxDraw(int id) {
            Config config = confDAL.getConfig(id);
            return config.MaxWithdraw;
        }
    }
}

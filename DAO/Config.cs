using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Config
    {
        public int ConfigID { get; set; }
        public int MinWithdraw { get; set; }
        public int MaxWithdraw { get; set; }
        public DateTime DateModified { get; set; }

        public Config() { }

        public Config(int id, int min, int max, DateTime modified)
        {
            this.ConfigID = id;
            this.MinWithdraw = min;
            this.MaxWithdraw = max;
            this.DateModified = modified;
        }

        public Config(int id, int min, int max) {
            this.ConfigID = id;
            this.MinWithdraw = min;
            this.MaxWithdraw = max;
        }
    }
}

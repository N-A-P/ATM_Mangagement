using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL custDAL = new CustomerDAL();

        public string getName(int custID) {
            return custDAL.getName(custID);
        }
    }
}

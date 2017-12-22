using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAO;
namespace GUI
{
    public partial class WithDraw : Form
    {
        public WithDraw()
        {
            InitializeComponent();
        }

        WithDrawBLL withDrawBLL = new WithDrawBLL();
        LogBLL logBLL = new LogBLL();
        public bool isSuccess = false;
        public bool isAmount = false;
        public int result = -1;

        private void WithDraw_Load(object sender, EventArgs e)
        {
            Form1.currentfunction = CurrentForm.withdraw;
        }

        public void withDraw(int amount)
        {
            isSuccess = false;
            isAmount = false;
            result = withDrawBLL.checkAmount(InfoUser.CARD.CardNo, InfoUser.CARD.AccountID, amount);
            if (result == 0)
            {
                isAmount = true;
                try
                {
                    withDrawBLL.updateBalance(InfoUser.CARD.AccountID, amount + 1000);
                    isSuccess = true;
                }
                catch {
                    isSuccess = false;
                }
            }
        }

        public void creatLog(int amount)
        {
            DateTime logDate = DateTime.Now;
            int atmID = ConfigATM.ATMID;
            int logTypeID = 1;
            string details = "";
            string cardNo = InfoUser.CARD.CardNo;

            Log log = new Log(logTypeID, atmID, cardNo, logDate, amount, details, "");
            logBLL.createLog(log);
        }
    }
}

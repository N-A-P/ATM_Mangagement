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
namespace GUI
{
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void Success_Load(object sender, EventArgs e)
        {
            Form1.currentfunction = CurrentForm.success;            
        }

        // 0: Chuyen
        // 1: Rut
        public void updateBalance(int status) {
            AccountBLL accBLL = new AccountBLL();
            string moneyStr = accBLL.getBalance(InfoUser.CARD.AccountID).ToString();
            Decimal money = Convert.ToDecimal(moneyStr);
            string value = String.Format("{0:0,0 VNĐ}", money);
            lblBalance.Text = value;
            if (status == 0)
            {
                lblPhi.Text = "Phí giao dịch: 3.000 VNĐ";
            }
            else {
                lblPhi.Text = "Phí giao dịch: 1.000 VNĐ";
            }
        }
    }
}

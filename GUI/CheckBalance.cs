using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class CheckBalance : Form
    {
        public CheckBalance()
        {
            InitializeComponent();
        }

        private void CheckBalance_Load(object sender, EventArgs e)
        {
            addLayout();
            lblBalance.Text = getBalance().ToString() + " VND";
        }

        public void addLayout() {
            lblBalance.AutoSize = true;
            lblBalance.Left = (this.ClientSize.Width - lblBalance.Width) / 2;
            lblBalance.Top = (this.ClientSize.Height - lblBalance.Height) / 2;
            lblDesc.Left = (this.ClientSize.Width - lblDesc.Width) / 2 - 50;
            lblDesc.Top = (this.ClientSize.Height - lblDesc.Height) / 2 - 50;
        }

        public int getBalance() {
            AccountBLL accBLL = new AccountBLL();
            LogBLL logBLL = new LogBLL();
            Form1 fr1 = new Form1();
            return accBLL.getBalance(fr1.accID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Validationfrm : Form
    {
        public Validationfrm()
        {
            InitializeComponent();
        }
        BLL.BLL bus = new BLL.BLL();
        Form1 f1 = new Form1();

        private void Validationfrm_Load(object sender, EventArgs e)
        {
            pnfailure.Height = this.Height;
            pnfailure.Width = this.Width;
            pnPIN.Width = this.Width;
            pnPIN.Height = this.Height;
            pnfailure.Visible = false;
            bool check = bus.checkPIN(f1.cardnumb, txtPIN.Text);
            
            int atemps = 0;
            if (!check)
            {
                atemps++;
                label1.Text = "Bạn đã nhập sai mã Pin, hãy nhập lại";
            }            
        }
    }
}

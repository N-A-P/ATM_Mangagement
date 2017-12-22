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
    public partial class ChangePINfrm : Form
    {
        public ChangePINfrm()
        {
            InitializeComponent();
        }
        int currentfeild = 1;

        public string getoldPIN() { return txtoldPIN.Text; }
        public string getnewPIN() { return txtnewPIN.Text; }
        public string getconfirm() { return txtconfirm.Text; }
        public bool checknewPIN()
        {
            if (txtconfirm.Text == txtnewPIN.Text && txtnewPIN.Text.Length == 6)
                return true;
            return false;
        }
        public void resetField() { txtconfirm.Text = ""; txtoldPIN.Text = ""; txtnewPIN.Text = ""; }
        private void ChangePINfrm_Load(object sender, EventArgs e)
        {
            txtoldPIN.Focus();
            txtoldPIN.Location = new Point(this.Size.Width / 2 - txtoldPIN.Width / 2, this.Size.Height / 2 - 50);
            txtnewPIN.Location = new Point(this.Size.Width / 2 - txtnewPIN.Width / 2, this.Size.Height / 2);
            txtconfirm.Location = new Point(this.Size.Width / 2 - txtconfirm.Width / 2, this.Size.Height / 2 + 50);
            label1.Location = new Point(this.Size.Width / 2 - txtoldPIN.Width, this.Size.Height / 2 - 45);
            label2.Location = new Point(this.Size.Width / 2 - txtoldPIN.Width , this.Size.Height / 2 + 5);
            label3.Location = new Point(this.Size.Width / 2 - txtoldPIN.Width, this.Size.Height / 2 + 55);
            label4.Location = new Point(this.Size.Width / 2 - txtoldPIN.Width / 2, txtconfirm.Location.Y + 50);
            lblcp.Location = new Point(txtoldPIN.Location.X + txtnewPIN.Width + 10, this.Size.Height / 2 - 50);
        }

        public void settxtb(string str)
        {
            if (currentfeild == 1)
                txtoldPIN.Text = str;
            if (currentfeild == 2)
                txtnewPIN.Text = str;
            if (currentfeild == 3)
                txtconfirm.Text = str;

        }
        public void setfocus(int i)
        {
            if (i == 1)
            {
                txtoldPIN.Focus();
                currentfeild = 1;
                lblcp.Location = new Point(txtoldPIN.Location.X + txtnewPIN.Width + 10, this.Size.Height / 2 - 55);
            }
            if (i == 2)
            {
                txtnewPIN.Focus();
                currentfeild = 2;
                lblcp.Location = new Point(txtnewPIN.Location.X + txtnewPIN.Width + 10, this.Size.Height / 2 - 5);
            }
            if (i == 3)
            {
                txtconfirm.Focus();
                currentfeild = 3;
                lblcp.Location = new Point(txtconfirm.Location.X + txtnewPIN.Width + 10, this.Size.Height / 2 + 45);
            }
        }
        public int getCurrentfield()
        {
            return currentfeild;
        }
        void checkfield()
        {
            if (txtoldPIN.Focus() == true)
            {
                currentfeild = 1;
            }

            if (txtnewPIN.Focus() == true)
            {
                currentfeild = 2;
            }
            if (txtconfirm.Focus() == true)
            {
                currentfeild = 3;
            }
        }

        private void lblcp_Click(object sender, EventArgs e)
        {

        }
    }
}

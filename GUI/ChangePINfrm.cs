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
                lblcp.Location = new Point(571, 158);
            }
            if (i == 2)
            {
                txtnewPIN.Focus();
                currentfeild = 2;
                lblcp.Location = new Point(571, 194);
            }
            if (i == 3)
            {
                txtconfirm.Focus();
                currentfeild = 3;
                lblcp.Location = new Point(571, 231);
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

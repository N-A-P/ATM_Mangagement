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
        public static int currentfeild = 1;
        public static bool confirm;
        public static string oldPIN,newPIN;
        private void ChangePINfrm_Load(object sender, EventArgs e)
        {
            Form1.currentfunction = CurrentForm.changePIN;
            txtoldPIN.Focus();
        }
        bool cfirm()
        {
            if (txtoldPIN.Text == txtnewPIN.Text)
                return true;
            return false;
        }

        private void txtoldPIN_TextChanged(object sender, EventArgs e)
        {
            checkfield();
        }

        private void txtnewPIN_TextChanged(object sender, EventArgs e)
        {
            checkfield();
        }

        private void txtconfirm_TextChanged(object sender, EventArgs e)
        {
                ChangePINfrm.confirm = cfirm();
                if (ChangePINfrm.confirm)
                {
                    ChangePINfrm.oldPIN = txtoldPIN.Text;
                    ChangePINfrm.newPIN = txtnewPIN.Text;
                }
            checkfield();
        }
        public void  setfocus(int i)
        {
            if (i == 1)
            {
                txtoldPIN.Focus();
            }
            if(i == 2)
            {
                txtnewPIN.Focus();
            }
            if (i == 3)
            {
                txtconfirm.Focus();
            }
        }
        void checkfield()
        {
            if (txtoldPIN.Focus() == true)
            {
                ChangePINfrm.currentfeild = 1;
            }

            if (txtnewPIN.Focus() == true)
            {
                ChangePINfrm.currentfeild = 2;
            }
            if (txtconfirm.Focus() == true)
            {
                ChangePINfrm.currentfeild = 3;
            }
        }
    }
}

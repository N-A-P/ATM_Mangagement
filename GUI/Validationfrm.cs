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
        public static string PIN;
       
        private void Validationfrm_Load(object sender, EventArgs e)
        {
            Form1.currentfunction = CurrentForm.validation;
        }
        public string getPIN()
        {
            return txtPIN.Text;
        }
        public void setPIN(string str)
        {
            txtPIN.Text = str;
        }
        public void setlbl(string str)
        {
            label2.Text = str;
        }
        public void InvalidCard()
        {
            pnPIN.Visible = false;
            pnfailure.Visible = true;      
        }
    }
}

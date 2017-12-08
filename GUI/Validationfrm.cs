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

        private void Validationfrm_Load(object sender, EventArgs e)
        {
            pnfailure.Height = this.Height;
            pnfailure.Width = this.Width;
            pnPIN.Width = this.Width;
            pnPIN.Height = this.Height;
            pnfailure.Visible = false;
            bool isCardValid = bus.checkCard("234");
        }
    }
}

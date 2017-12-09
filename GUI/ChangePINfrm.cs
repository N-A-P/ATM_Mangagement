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

        private void ChangePINfrm_Load(object sender, EventArgs e)
        {
            Form1.currentfunction = CurrentForm.changePIN;
            
        }
    }
}

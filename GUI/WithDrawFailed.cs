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
    public partial class WithDrawFailed : Form
    {
        public WithDrawFailed()
        {
            InitializeComponent();
        }

        private void WithDrawFailed_Load(object sender, EventArgs e)
        {
            Form1.currentfunction = CurrentForm.failed;
            
        }
        //1: Vuot muc thau chi
        //2: Vuot muc toi da rut trong ngay
        //3: Vuot muc toi da 1 lan rut
        //4: So tien rut nho hon toi thieu
        //5: So tien trong cay khong du
        public void updateStatus(int status) {
            switch (status)
            {
                case 1: lblAlert.Text = "Vượt mức thấu chi";
                    break;
                case 2: lblAlert.Text = "Vượt mức tối đa rút trong ngày";
                    break;
                case 3: lblAlert.Text = "Vượt mức tối đa một lần rút";
                    break;
                case 4: lblAlert.Text = "Số tiền rút nhỏ hơn tối thiểu";
                    break;
                case 5: lblAlert.Text = "Số tiền trong cây không đủ";
                    break;
                case 6: lblAlert.Text = "Số tiền không đủ để thực hiện giao dịch";
                    break;
                default:
                    lblAlert.Text = "Đã xảy ra lỗi";
                    break;
               lblAlert.Left = (this.ClientSize.Width - lblAlert.Width) / 2;
               lblAlert.Top = (this.ClientSize.Height - lblAlert.Height) / 2;     
            }
            
        }
    }
}

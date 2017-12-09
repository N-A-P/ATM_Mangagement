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
    public partial class ViewHistory : Form
    {
        public ViewHistory()
        {
            InitializeComponent();
        }

        private void ViewHistory_Load(object sender, EventArgs e)
        {
            
            LogBLL logBLL = new LogBLL();
            Form1 fr1 = new Form1();
            dgvLichSu.DataSource = logBLL.getLog(fr1.cardNo);
            configHienThi();
        }

        public void configHienThi() {
            dgvLichSu.Columns[0].Width = 100;
            dgvLichSu.Columns[0].HeaderText = "ID";
            dgvLichSu.Columns[1].Width = 200;
            dgvLichSu.Columns[1].HeaderText = "Ngày";
            dgvLichSu.Columns[2].Width = 100;
            dgvLichSu.Columns[2].HeaderText = "Số Tiền";
            dgvLichSu.Columns[3].Width = 100;
            dgvLichSu.Columns[3].HeaderText = "Chi Tiết";
            //dgvLichSu.Columns[4].Width = 100;
            //dgvLichSu.Columns[4].HeaderText = "loại";
            dgvLichSu.Columns[4].Width = 100;
            dgvLichSu.Columns[4].HeaderText = "ATM";
            dgvLichSu.Columns[5].Width = 100;
            dgvLichSu.Columns[5].HeaderText = "Số Thẻ";
            dgvLichSu.Columns[6].Width = 100;
            dgvLichSu.Columns[6].HeaderText = "Tới Số Thẻ";
        }
    }
}

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
        LogBLL logBLL = new LogBLL();
        Form1 fr1 = new Form1();
        private void ViewHistory_Load(object sender, EventArgs e)
        {
            Form1.currentfunction = CurrentForm.viewHistory;
            dgvLichSu.DataSource = logBLL.getLog(Form1.cardNumber);
            configHienThi();
        }
        
        public void configHienThi() {
            dgvLichSu.RowHeadersVisible = false;
            dgvLichSu.Columns[0].HeaderText = "ID";
            dgvLichSu.Columns[1].HeaderText = "Ngày";
            dgvLichSu.Columns[2].HeaderText = "Số Tiền";
            dgvLichSu.Columns[3].HeaderText = "Chi Tiết";
            dgvLichSu.Columns[4].HeaderText = "Chi Nhánh";
            dgvLichSu.Columns[5].HeaderText = "Địa Chỉ";
            dgvLichSu.Columns[6].HeaderText = "Số Thẻ";
            dgvLichSu.Columns[7].HeaderText = "Số Thẻ Nhận Tiền";
            //set autosize mode
            dgvLichSu.Columns[0].Width = 50;
            dgvLichSu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLichSu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLichSu.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLichSu.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvLichSu.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLichSu.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLichSu.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

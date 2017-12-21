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
using DAO;
namespace GUI
{
    public partial class CashTransferFrm : Form
    {
        BLL.BLL bus = new BLL.BLL();
        TransferBLL transf = new TransferBLL();
        AccountBLL accBLL = new AccountBLL();
        CustomerBLL custBLL = new CustomerBLL();
        LogBLL logBLL = new LogBLL();
        public bool success = false;
        public bool isInput = true;
        private TextBox focusedTextbox = null;

        public CashTransferFrm()
        {
            InitializeComponent();
        }

        private void CashTransferFrm_Load(object sender, EventArgs e)
        {
            lblAlert.Text = "";
            Form1.currentfunction = CurrentForm.transfer;
            txtSoTaiKhoan.Focus();
            focusedTextbox = txtSoTaiKhoan;
        }
        
        public void focusTextbox() {
            txtSoTienChuyen.Focus();
            focusedTextbox = txtSoTienChuyen;
        }

        private bool checkAcc() {
            bool result = false;
            if (txtSoTaiKhoan.Text != "") {
                try
                {
                   // int accID = int.Parse(txtSoTaiKhoan.Text);
                    result = bus.checkCard(txtSoTaiKhoan.Text);
                    //result = accBLL.checkAcc(accID);
                }
                catch {
                    lblAlert.Text = "Số thẻ không chính xác";
                }          
            }
            return result;
        }

        public bool checkAmout() {
            bool result = false;
            if (txtSoTienChuyen.Text == "") {
                lblAlert.Text = "Số tiền không hợp lệ!!!";
                focusTextbox();
                return false;
            }
            int accID = InfoUser.CARD.AccountID;
            
            try
            {
                int amount = int.Parse(txtSoTienChuyen.Text);
                if (amount == 0) {
                    lblAlert.Text = "Số tiền không hợp lệ!!!";
                    focusTextbox();
                    return false;               
                }
                result = transf.checkAmount(accID, amount);
            }
            catch
            {
                lblAlert.Text = "Số tiền không hợp lệ!!!";
            }
            return result;
        }

        public void doTransf() {
            int amount = int.Parse(txtSoTienChuyen.Text);
            int accID = getAccID();

            try
            {
                // Nhận tiền
                transf.updateBalance(accID, amount, 1);

                // Trừ tiền
                transf.updateBalance(InfoUser.CARD.AccountID, amount, 0);

                success = true;
            }
            catch {
                lblAlert.Text = "Chuyển Tiền Thất Bại. Vui lòng thử lại!!!";
            }
        }

        private int getAccID() {
            int accID = bus.getAccID(txtSoTaiKhoan.Text);
            return accID;
        }

        private int getCustID() { 
            int custID = 0;
            custID = accBLL.getCustID(getAccID());
            return custID;
        }


        public void checkInfo()
        {
            if (checkAcc())
            {
                string name = custBLL.getName(getCustID());
                txtTenNguoiHuong.Text = name;
                focusTextbox();
                isInput = false;
            }
            else {
                lblAlert.Text = "Số tài khoản không chính xác";
                txtSoTaiKhoan.Focus();
                focusedTextbox = txtSoTaiKhoan;
            }
        }

        public void creatLog() {
            DateTime logDate = DateTime.Now;
            int amount = int.Parse(txtSoTienChuyen.Text);
            string toCardNo = txtSoTaiKhoan.Text;
            int atmID = ConfigATM.ATMID;
            int logTypeID = 2;
            string details = "";
            string cardNo = InfoUser.CARD.CardNo;

            Log log = new Log(4, logTypeID, atmID, cardNo, logDate, amount, details, toCardNo);
            logBLL.createLog(log);
        }

        public void clearText() {
            focusedTextbox.Text = "";
        }

        private void txtSoTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            lblAlert.Text = "";
        }

        private void txtSoTienChuyen_TextChanged(object sender, EventArgs e)
        {
            lblAlert.Text = "";
        }

        public void number0DidTouched() {
            focusedTextbox.Text += "0";
        }
        public void number1DidTouched()
        {
            focusedTextbox.Text += "1";
        }
        public void number2DidTouched()
        {
            focusedTextbox.Text += "2";
        }
        public void number3DidTouched()
        {
            focusedTextbox.Text += "3";
        }
        public void number4DidTouched()
        {
            focusedTextbox.Text += "4";
        }
        public void number5DidTouched()
        {
            focusedTextbox.Text += "5";
        }
        public void number6DidTouched()
        {
            focusedTextbox.Text += "6";
        }
        public void number7DidTouched()
        {
            focusedTextbox.Text += "7";
        }
        public void number8DidTouched()
        {
            focusedTextbox.Text += "8";
        }
        public void number9DidTouched()
        {
            focusedTextbox.Text += "9";
        }

    }
}

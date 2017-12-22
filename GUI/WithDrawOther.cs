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
    public partial class WithDrawOther : Form
    {
        public WithDrawOther()
        {
            InitializeComponent();
        }

        WithDrawBLL withDrawBLL = new WithDrawBLL();
        public bool isSuccess = false;
        public bool isAmount = false;
        public int result = -1;
        public bool didWithDraw = false;
        LogBLL logBLL = new LogBLL();

        private void WithDrawOther_Load(object sender, EventArgs e)
        {            
            txtAlert.Text = "";
        }

        public bool checkAmount() {
            int amount = 0;
            if (txtSoTien.Text == "")
            {
                return false;
            }
            else {
                amount = int.Parse(txtSoTien.Text);
                if (amount < 50000)
                {
                    return false;
                }
                else {
                    return true;
                }
            }               
        }

        public void withDraw() {                    
            isSuccess = false;
            isAmount = false;
            didWithDraw = false;
            if (checkAmount())
            {
                int amount = int.Parse(txtSoTien.Text);
                result = withDrawBLL.checkAmount(InfoUser.CARD.CardNo, InfoUser.CARD.AccountID, amount);
                if (result == 0)
                {
                    isAmount = true;
                    try
                    {
                        withDrawBLL.updateBalance(InfoUser.CARD.AccountID, amount + 1000);
                        isSuccess = true;
                    }
                    catch
                    {
                        isSuccess = false;
                    }
                }
                didWithDraw = true;
            }
            else {
                txtAlert.Text = "Số tiền không hợp lệ";
            }            
        }

        public void creatLog()
        {
            DateTime logDate = DateTime.Now;
            int amount = int.Parse(txtSoTien.Text);
            int atmID = ConfigATM.ATMID;
            int logTypeID = 1;
            string details = "";
            string cardNo = InfoUser.CARD.CardNo;

            Log log = new Log(logTypeID, atmID, cardNo, logDate, amount, details, "");
            logBLL.createLog(log);
        }

        public void clearText() {
            txtSoTien.Text = "";
        }

        public void number0DidTouched()
        {
            txtSoTien.Text += "0";
        }
        public void number1DidTouched()
        {
            txtSoTien.Text += "1";
        }
        public void number2DidTouched()
        {
            txtSoTien.Text += "2";
        }
        public void number3DidTouched()
        {
            txtSoTien.Text += "3";
        }
        public void number4DidTouched()
        {
            txtSoTien.Text += "4";
        }
        public void number5DidTouched()
        {
            txtSoTien.Text += "5";
        }
        public void number6DidTouched()
        {
            txtSoTien.Text += "6";
        }
        public void number7DidTouched()
        {
            txtSoTien.Text += "7";
        }
        public void number8DidTouched()
        {
            txtSoTien.Text += "8";
        }
        public void number9DidTouched()
        {
            txtSoTien.Text += "9";
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            txtAlert.Text = "";
        }
    }
}

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
using System.Threading;


namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;           
        }
        AccountBLL accbll = new AccountBLL();
        public static string currentfunction;
        public static string cardnumb;
        
        BLL.BLL bus = new BLL.BLL();     
        public int accID = 1;
        int atemps = 0;
        public static string cardNumber;
        public string cardNo;

        CashTransferFrm cashTransFm = new CashTransferFrm();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            GoFullscreen(false);
            WelcomeScreen welcomescr = new WelcomeScreen();
            welcomescr.MdiParent = this;
            welcomescr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            welcomescr.Dock = DockStyle.Fill;
            screen.Controls.Add(welcomescr);
            welcomescr.Show();
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        Validationfrm validfrm = new Validationfrm();
        ChangePINfrm changePINfrm = new ChangePINfrm();
        CashTransferFrm transf = new CashTransferFrm();
        Functionfrm functionfrm = new Functionfrm();
        WelcomeScreen welcomescr = new WelcomeScreen();


        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '1');
            }

            if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                    changePINfrm.settxtb(changePINfrm.getoldPIN() + '1');
                 else if (changePINfrm.getCurrentfield() == 2)
                    changePINfrm.settxtb(changePINfrm.getnewPIN() + '1');
                 else if (changePINfrm.getCurrentfield() == 3)
                    changePINfrm.settxtb(changePINfrm.getconfirm() + '1');
            }

            if (Form1.currentfunction == CurrentForm.transfer) {
                transf.number1DidTouched();
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '2');
            }

            if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                    changePINfrm.settxtb(changePINfrm.getoldPIN() + '2');
                 else if (changePINfrm.getCurrentfield() == 2)
                    changePINfrm.settxtb(changePINfrm.getnewPIN() + '2');
                 else if (changePINfrm.getCurrentfield() == 3)
                    changePINfrm.settxtb(changePINfrm.getconfirm() + '2');
            }
            if (Form1.currentfunction == CurrentForm.transfer)
            {
                transf.number2DidTouched();
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                    changePINfrm.settxtb(changePINfrm.getoldPIN() + '3');
                 else if (changePINfrm.getCurrentfield() == 2)
                    changePINfrm.settxtb(changePINfrm.getnewPIN() + '3');
                 else if (changePINfrm.getCurrentfield() == 3)
                    changePINfrm.settxtb(changePINfrm.getconfirm() + '3');
            }

            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '3');
            }
            if (Form1.currentfunction == CurrentForm.transfer)
            {
                transf.number3DidTouched();
            }

        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                    changePINfrm.settxtb(changePINfrm.getoldPIN() + '4');
                 else if (changePINfrm.getCurrentfield() == 2)
                    changePINfrm.settxtb(changePINfrm.getnewPIN() + '4');
                 else if (changePINfrm.getCurrentfield() == 3)
                    changePINfrm.settxtb(changePINfrm.getconfirm() + '4');
            }

            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '4');
            }

            if (Form1.currentfunction == CurrentForm.transfer)
            {
                transf.number4DidTouched();
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '5');
            }

            if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                    changePINfrm.settxtb(changePINfrm.getoldPIN() + '5');
                 else if (changePINfrm.getCurrentfield() == 2)
                    changePINfrm.settxtb(changePINfrm.getnewPIN() + '5');
                 else if (changePINfrm.getCurrentfield() == 3)
                    changePINfrm.settxtb(changePINfrm.getconfirm() + '5');
            }

            if (Form1.currentfunction == CurrentForm.transfer)
            {
                transf.number5DidTouched();
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '6');
            }

            else if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                    changePINfrm.settxtb(changePINfrm.getoldPIN() + '6');
                 else if (changePINfrm.getCurrentfield() == 2)
                    changePINfrm.settxtb(changePINfrm.getnewPIN() + '6');
                 else if (changePINfrm.getCurrentfield() == 3)
                    changePINfrm.settxtb(changePINfrm.getconfirm() + '6');
            }

            if (Form1.currentfunction == CurrentForm.transfer)
            {
                transf.number6DidTouched();
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '7');
            }

            if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                    changePINfrm.settxtb(changePINfrm.getoldPIN() + '7');
                 else if (changePINfrm.getCurrentfield() == 2)
                    changePINfrm.settxtb(changePINfrm.getnewPIN() + '7');
                 else if (changePINfrm.getCurrentfield() == 3)
                    changePINfrm.settxtb(changePINfrm.getconfirm() + '7');
            }

            if (Form1.currentfunction == CurrentForm.transfer)
            {
                transf.number7DidTouched();
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '8');
            }

            if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                    changePINfrm.settxtb(changePINfrm.getoldPIN() + '8');
                 else if (changePINfrm.getCurrentfield() == 2)
                    changePINfrm.settxtb(changePINfrm.getnewPIN() + '8');
                 else if (changePINfrm.getCurrentfield() == 3)
                    changePINfrm.settxtb(changePINfrm.getconfirm() + '8');
            }
            if (Form1.currentfunction == CurrentForm.transfer)
            {
                transf.number8DidTouched();
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '9');
            }

            if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                    changePINfrm.settxtb(changePINfrm.getoldPIN() + '9');
                 else if (changePINfrm.getCurrentfield() == 2)
                    changePINfrm.settxtb(changePINfrm.getnewPIN() + '9');
                 else if (changePINfrm.getCurrentfield() == 3)
                    changePINfrm.settxtb(changePINfrm.getconfirm() + '9');
            }
            if (Form1.currentfunction == CurrentForm.transfer)
            {
                transf.number9DidTouched();
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '0');
            }

            if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                    changePINfrm.settxtb(changePINfrm.getoldPIN() + '0');
                else if (changePINfrm.getCurrentfield() == 2)
                    changePINfrm.settxtb(changePINfrm.getnewPIN() + '0');
                else if (changePINfrm.getCurrentfield() == 3)
                    changePINfrm.settxtb(changePINfrm.getconfirm() + '0');
            }
            if (Form1.currentfunction == CurrentForm.transfer)
            {
                transf.number0DidTouched();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            
            if(Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN("");
            }

            if (Form1.currentfunction == CurrentForm.transfer) {
                transf.clearText();
            }

            if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                    changePINfrm.settxtb("");
                 else if (changePINfrm.getCurrentfield() == 2)
                    changePINfrm.settxtb("");
                 else if (changePINfrm.getCurrentfield() == 3)
                    changePINfrm.settxtb("");
            }
        }

        private void btnInsertCard_Click(object sender, EventArgs e)
        {
            cardNo = null;
            cardNo = ShowDialog("Mã thẻ", "Nhập mã thẻ");
            Form1.cardnumb = cardNo;
            if (bus.checkCard(cardNo))
            {
                SwitchScreen(validfrm);
                btnInsertCard.Enabled = false;
                Form1.cardNumber = cardNo;
                ConfigATM.ATMID = 122;
                ConfigATM.ConfigID = 1;
                InfoUser.CARD = bus.getCardInfo(cardNo);

            }
            else
            {
                validfrm.InvalidCard();
                SwitchScreen(validfrm);
            }
            
        }
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }


        private void btnenter_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                atemps++;
                bool check = bus.checkPIN(cardNo, validfrm.getPIN(),atemps);
                if (!check)
                {
                    validfrm.setlbl("Bạn đã nhập sai mã PIN "+atemps+" lần, nhập sai 3 lần sẽ bị khóa thẻ");
                    validfrm.setPIN("");
                }
                else
                {
                    SwitchScreen(functionfrm);
                    atemps = 0;
                }
                if (atemps > 2)
                { 
                    MessageBox.Show("Thẻ của bạn bị khóa do nhập sai PIN quá nhiều lần. Hãy tới chi nhánh ngân hàng gần nhất để được giúp đỡ!");
                    SwitchScreen(welcomescr);
                    btnInsertCard.Enabled = true;
                }
            }

            if(Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                {
                    changePINfrm.setfocus(2);
                }
                else if (changePINfrm.getCurrentfield() == 2)
                {
                    changePINfrm.setfocus(3);
                }
            }

            if (Form1.currentfunction == CurrentForm.transfer) {
                cashTransFunc();
            }
        }

        private void cashTransFunc() {

            if (transf.isInput)
            {
                transf.checkInfo();
            }
            else {
                if (transf.checkAmout())
                {
                    transf.doTransf();
                    if (transf.success)
                    {
                        transf.creatLog();
                        Success successFr = new Success();
                        SwitchScreen(successFr);
                    }
                }
            }
        }

        void SwitchScreen(Form form)
        {
            screen.Controls.Clear();
            form.MdiParent = this;
            screen.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            // switch checkpoint
            #region
            if (form is ChangePINfrm)
            {
                currentfunction = CurrentForm.changePIN;
            }
            else if (form is Functionfrm)
            {
                currentfunction = CurrentForm.function;
            }
            else if (form is ViewHistory)
            {
                currentfunction = CurrentForm.viewHistory;
            }
            else if (form is Validationfrm)
            {
                currentfunction = CurrentForm.validation;
            }
            else if (form is WelcomeScreen)
            {
                currentfunction = CurrentForm.welcomscr;
            }
            else if (form is CheckBalance)
            {
                currentfunction = CurrentForm.checkBalance;
            }
            else if (form is WithDraw)
            {
                currentfunction = CurrentForm.withdraw;
            }
            else if (form is CashTransferFrm)
            {
                currentfunction = CurrentForm.transfer;
            }
            #endregion
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                WelcomeScreen welcomescr = new WelcomeScreen();
                SwitchScreen(welcomescr);
                btnInsertCard.Enabled = true;
            }

            if (Form1.currentfunction == CurrentForm.transfer)
            {
                SwitchScreen(welcomescr);
            }
            if (Form1.currentfunction == CurrentForm.changePIN)
            {
                if (changePINfrm.getCurrentfield() == 1)
                {
                    SwitchScreen(functionfrm);
                }
                else if (changePINfrm.getCurrentfield() == 2)
                {
                    changePINfrm.settxtb("");
                    changePINfrm.setfocus(1);
                }

                else if (changePINfrm.getCurrentfield() == 3)
                {
                    changePINfrm.settxtb("");
                    changePINfrm.setfocus(2);
                }
            }      
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            if(Form1.currentfunction == CurrentForm.function)
            {
                changePINfrm.setfocus(1);
                changePINfrm.resetField();
                SwitchScreen(changePINfrm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.function) {
                SwitchScreen(transf);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.function)
            {
                CheckBalance frCheckBalance = new CheckBalance();
                SwitchScreen(frCheckBalance);
            }

        }

        public void button5_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.function)
            {
                ViewHistory viewHis = new ViewHistory();
                SwitchScreen(viewHis);
            }
            
            else if(Form1.currentfunction == CurrentForm.changePIN)
            {
                Form form = new Form();
                Label lblaounce = new Label();
                form.Controls.Add(lblaounce);
                lblaounce.Location = new Point(screen.Width / 2 - lblaounce.Width, screen.Height / 2);
                lblaounce.AutoSize = true;
                Label lbl = new Label();
                lbl.Text = "OK";
                lbl.Location = new Point(805,364);
                form.Controls.Add(lbl);
                if (changePINfrm.checknewPIN())
                {                  
                    if( bus.checkPIN(cardNo,changePINfrm.getoldPIN(), 0))
                    {
                        bus.ChangePIN(cardNo, changePINfrm.getnewPIN());
                        lblaounce.Text = "Đổi PIN thành công";
                        SwitchScreen(form);
                        currentfunction = "#1";
                    }
                    else
                    {
                        lblaounce.Text = "Sai mã PIN cũ";
                        SwitchScreen(form);
                        currentfunction = "#2";
                    }
                    
                }
                else {
                    lblaounce.Text = "Mã PIN mới phải có 6 ký tự số và phải trùng nhau!";
                    SwitchScreen(form);
                    currentfunction = "#3";
                }
            }
            else if (Form1.currentfunction == CurrentForm.validation)
            {
                atemps++;
                bool check = bus.checkPIN(cardNo, validfrm.getPIN(), atemps);
                if (!check)
                {
                    validfrm.setlbl("Bạn đã nhập sai mã PIN " + atemps + " lần, nhập sai 3 lần sẽ bị khóa thẻ");
                    validfrm.setPIN("");
                }
            }else
                {
                    validfrm.setPIN("");
                    SwitchScreen(functionfrm);
                    atemps = 0;
                }
                if (atemps > 2)
                {
                    MessageBox.Show("Thẻ của bạn bị khóa do nhập sai PIN quá nhiều lần. Hãy tới chi nhánh ngân hàng gần nhất để được giúp đỡ!");
                    SwitchScreen(welcomescr);
                    btnInsertCard.Enabled = true;

                }
            if (Form1.currentfunction == CurrentForm.success) {
                Functionfrm fuctionfrm = new Functionfrm();
                SwitchScreen(fuctionfrm);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation || Form1.currentfunction == CurrentForm.success || Form1.currentfunction == CurrentForm.function)
            {
                WelcomeScreen welcomescr = new WelcomeScreen();
                SwitchScreen(welcomescr);
                btnInsertCard.Enabled = true;
                validfrm = new Validationfrm(); 
            }
            else if (Form1.currentfunction == CurrentForm.checkBalance|| Form1.currentfunction == CurrentForm.viewHistory || Form1.currentfunction == CurrentForm.changePIN || Form1.currentfunction == CurrentForm.transfer)
            {
                SwitchScreen(functionfrm);
            }
            else if(Form1.currentfunction == "#1")
            {
                SwitchScreen(functionfrm);
            }
            else if (Form1.currentfunction == "#2")
            {
                SwitchScreen(welcomescr);
            }
            else if (Form1.currentfunction == "#3")
            {
                SwitchScreen(functionfrm);
            }
        }
    }
}

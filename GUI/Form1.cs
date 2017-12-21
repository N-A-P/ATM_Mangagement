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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;           
        }
        AccountBLL accbll = new AccountBLL();
        public static string currentfunction;
        
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


        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '1');
            }

            if (Form1.currentfunction == CurrentForm.changePIN)
            {

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

            if (Form1.currentfunction == CurrentForm.changePIN)
            {

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
        }

        private void btnInsertCard_Click(object sender, EventArgs e)
        {
            
            cardNo = ShowDialog("Nhập mã thẻ", "Input form");
            
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
                    Functionfrm fuctionfrm = new Functionfrm();
                    SwitchScreen(fuctionfrm);
                    atemps = 0;
                }
                if (atemps > 2)
                { 
                    MessageBox.Show("Thẻ của bạn bị khóa do nhập sai PIN quá nhiều lần. Hãy tới chi nhánh ngân hàng gần nhất để được giúp đỡ!");
                    WelcomeScreen welcomescr = new WelcomeScreen();
                    SwitchScreen(welcomescr);
                    btnInsertCard.Enabled = true;
                }
            }

            if(Form1.currentfunction == CurrentForm.changePIN)
            {
                if (ChangePINfrm.currentfeild == 1)
                {
                    changePINfrm.setfocus(2);
                }

                if (ChangePINfrm.currentfeild == 2)
                {
                    changePINfrm.setfocus(3);
                }

                if (ChangePINfrm.currentfeild == 3)
                {
                    //
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
            if (screen.Controls.Count > 0) {
                screen.Controls.RemoveAt(0);
                form.MdiParent = this;
                screen.Controls.Add(form);
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();    
            }
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
                WelcomeScreen welcomescr = new WelcomeScreen();
                SwitchScreen(welcomescr);
            }
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            if(Form1.currentfunction == CurrentForm.function)
            {
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
            if(Form1.currentfunction == CurrentForm.changePIN)
            {
               
                if (ChangePINfrm.confirm)
                {
                    // exe change PIN
                    // goto function screen
                }
            }
            if (Form1.currentfunction == CurrentForm.success) {
                Functionfrm fuctionfrm = new Functionfrm();
                SwitchScreen(fuctionfrm);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Functionfrm fuctionfrm = new Functionfrm();
            if (Form1.currentfunction == CurrentForm.validation || Form1.currentfunction == CurrentForm.success || Form1.currentfunction == CurrentForm.function)
            {
                WelcomeScreen welcomescr = new WelcomeScreen();
                SwitchScreen(welcomescr);
                btnInsertCard.Enabled = true;
            }
            if (Form1.currentfunction == CurrentForm.checkBalance|| Form1.currentfunction == CurrentForm.viewHistory || Form1.currentfunction == CurrentForm.changePIN || Form1.currentfunction == CurrentForm.transfer)
            {
                SwitchScreen(fuctionfrm);
            }
        }
    }
}

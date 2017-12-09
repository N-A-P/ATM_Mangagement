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
        public int accID = 97041;
        int atemps = 0;
        public string cardNo;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            WelcomeScreen welcomescr = new WelcomeScreen();
            welcomescr.MdiParent = this;
            welcomescr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            welcomescr.Dock = DockStyle.Fill;
            screen.Controls.Add(welcomescr);
            welcomescr.Show();
        }


        Validationfrm validfrm = new Validationfrm();
        ChangePINfrm changePINfrm = new ChangePINfrm();



        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN(validfrm.getPIN() + '1');
            }

            if (Form1.currentfunction == CurrentForm.changePIN)
            {

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
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            
            if(Form1.currentfunction == CurrentForm.validation)
            {
                validfrm.setPIN("");
            }
        }

        private void btnInsertCard_Click(object sender, EventArgs e)
        {
            
            cardNo = ShowDialog("Nhập mã thẻ", "Input form");
            if (bus.checkCard(cardNo))
            {
                SwitchScreen(validfrm);
                btnInsertCard.Enabled = false;
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

        }

        void SwitchScreen(Form form)
        {
            screen.Controls.RemoveAt(0);
            form.MdiParent = this;
            screen.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();          
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            if (Form1.currentfunction == CurrentForm.validation)
            {
                WelcomeScreen welcomescr = new WelcomeScreen();
                SwitchScreen(welcomescr);
                btnInsertCard.Enabled = true;
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
           



        }

        private void button6_Click(object sender, EventArgs e)
        {
            Functionfrm fuctionfrm = new Functionfrm();
            if (Form1.currentfunction == CurrentForm.validation)
            {
                WelcomeScreen welcomescr = new WelcomeScreen();
                SwitchScreen(welcomescr);
                btnInsertCard.Enabled = true;
            }
            if (Form1.currentfunction == CurrentForm.checkBalance|| Form1.currentfunction == CurrentForm.viewHistory || Form1.currentfunction == CurrentForm.changePIN)
            {
                
                SwitchScreen(fuctionfrm);
            }
          
            
        }
    }
}

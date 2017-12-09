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

        BLL.BLL bus = new BLL.BLL();
        public string cardnumb;
        //Functionfrm fuctionfrm = new Functionfrm();
       
        
        Validationfrm validfrm = new Validationfrm();
        private void Form1_Load(object sender, EventArgs e)
        {
            Form welcomescr = new Form();

            welcomescr.MdiParent = this;
            welcomescr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            welcomescr.Dock = DockStyle.Fill;
            Label lbl = new Label();
            lbl.Text = "Welcome to our bank's ATM system, please insert your ATM card";
            lbl.AutoSize = true;
            lbl.Location = new Point((screen.Width / 2) - 158, screen.Height / 2);
            welcomescr.Controls.Add(lbl);
            screen.Controls.Add(welcomescr);
            welcomescr.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            cardpanel.Visible = !cardpanel.Visible;
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
          
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnInsertCard_Click(object sender, EventArgs e)
        {
            cardnumb = ShowDialog("Nhập mã thẻ", "Input form");
            if (bus.checkCard(cardnumb))
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
           

            bool check = bus.checkPIN(cardnumb, validfrm.getPIN(), atemps);
            if (!check)
            {
                atemps++;
                validfrm.setlbl("Bạn đã nhập sai mã Pin, hãy nhập lại");
            }
            else
            {

                //SwitchScreen(fuctionfrm);
            }
            if (atemps > 2)
            {
                MessageBox.Show("Thẻ của bạn bị khóa do nhập sai PIN quá nhiều lần. Hãy tới chi nhánh ngân hàng gần nhất để được giúp đỡ!");
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
        int atemps = 0;
        private void btncancel_Click(object sender, EventArgs e)
        {
           

        }
      
    }
}

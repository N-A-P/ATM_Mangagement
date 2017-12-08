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
        }

        BLL.BLL bus = new BLL.BLL();
        string cardnumb;
        public int accID = 97041;
        public string cardNo = "1234567890123";
        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Form welcomescr = new Form();
            welcomescr.MdiParent = this;
            welcomescr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            welcomescr.Dock = DockStyle.Fill;
            Label lbl = new Label();
            lbl.Text = "Welcome to our bank's ATM system, please insert your ATM card";
            lbl.AutoSize = true;
            lbl.Location = new Point((screen.Width / 2) - 158 ,screen.Height/2);
            label1.Text = (screen.Width / 2).ToString();
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
            txtCardNo.Text = txtCardNo.Text + '1';
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtCardNo.Text = txtCardNo.Text + '2';
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtCardNo.Text = txtCardNo.Text + '3';
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtCardNo.Text = txtCardNo.Text + '4';
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtCardNo.Text = txtCardNo.Text + '5';
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtCardNo.Text = txtCardNo.Text + '6';
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtCardNo.Text = txtCardNo.Text + '7';
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtCardNo.Text = txtCardNo.Text + '8';
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtCardNo.Text = txtCardNo.Text + '9';
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtCardNo.Text = txtCardNo.Text + '0';
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtCardNo.Text = "";
        }

        private void btnInsertCard_Click(object sender, EventArgs e)
        {
            if (bus.checkCard(txtCardNo.Text) == true)
            {
                label1.Text = "nhap ma pin";
                cardnumb = txtCardNo.Text;
            }
            else
                label1.Text = "the khong hop le:";               
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if (bus.checkPIN(cardnumb, txtCardNo.Text))
            {
                label1.Text = "Đăng nhập thành công!";
            }
            else
                label1.Text = "failed";
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

        private void button4_Click(object sender, EventArgs e)
        {
            CheckBalance frCheckBalance = new CheckBalance();
            SwitchScreen(frCheckBalance);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewHistory viewHis = new ViewHistory();
            SwitchScreen(viewHis);
        }
    }
}

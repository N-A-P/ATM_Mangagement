namespace GUI
{
    partial class ChangePINfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePINfrm));
            this.txtoldPIN = new System.Windows.Forms.TextBox();
            this.txtnewPIN = new System.Windows.Forms.TextBox();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtoldPIN
            // 
            this.txtoldPIN.Enabled = false;
            this.txtoldPIN.Location = new System.Drawing.Point(397, 155);
            this.txtoldPIN.Name = "txtoldPIN";
            this.txtoldPIN.Size = new System.Drawing.Size(147, 20);
            this.txtoldPIN.TabIndex = 0;
            // 
            // txtnewPIN
            // 
            this.txtnewPIN.Enabled = false;
            this.txtnewPIN.Location = new System.Drawing.Point(397, 191);
            this.txtnewPIN.Name = "txtnewPIN";
            this.txtnewPIN.Size = new System.Drawing.Size(147, 20);
            this.txtnewPIN.TabIndex = 0;
            // 
            // txtconfirm
            // 
            this.txtconfirm.Enabled = false;
            this.txtconfirm.Location = new System.Drawing.Point(397, 228);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(147, 20);
            this.txtconfirm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã PIN cũ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã PIN mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xác nhận PIN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(805, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đồng ý";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(805, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hủy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "(Mã PIN gồm 6 chữ số)";
            // 
            // lblcp
            // 
            this.lblcp.AutoSize = true;
            this.lblcp.Location = new System.Drawing.Point(571, 158);
            this.lblcp.Name = "lblcp";
            this.lblcp.Size = new System.Drawing.Size(16, 13);
            this.lblcp.TabIndex = 5;
            this.lblcp.Text = "<-";
            this.lblcp.Click += new System.EventHandler(this.lblcp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(935, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // ChangePINfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 427);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblcp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtnewPIN);
            this.Controls.Add(this.txtoldPIN);
            this.Name = "ChangePINfrm";
            this.Text = "ChangePINfrm";
            this.Load += new System.EventHandler(this.ChangePINfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtoldPIN;
        private System.Windows.Forms.TextBox txtnewPIN;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcp;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
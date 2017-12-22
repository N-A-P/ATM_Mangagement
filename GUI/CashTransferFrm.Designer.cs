namespace GUI
{
    partial class CashTransferFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashTransferFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSoTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTienChuyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNguoiHuong = new System.Windows.Forms.TextBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.imgST = new System.Windows.Forms.PictureBox();
            this.imgT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(704, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Thẻ nhận tiền";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-21, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1865, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTaiKhoan.Enabled = false;
            this.txtSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(714, 327);
            this.txtSoTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(504, 44);
            this.txtSoTaiKhoan.TabIndex = 2;
            this.txtSoTaiKhoan.TextChanged += new System.EventHandler(this.txtSoTaiKhoan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 544);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số tiền chuyển";
            // 
            // txtSoTienChuyen
            // 
            this.txtSoTienChuyen.Enabled = false;
            this.txtSoTienChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienChuyen.Location = new System.Drawing.Point(714, 629);
            this.txtSoTienChuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTienChuyen.Name = "txtSoTienChuyen";
            this.txtSoTienChuyen.Size = new System.Drawing.Size(504, 44);
            this.txtSoTienChuyen.TabIndex = 4;
            this.txtSoTienChuyen.TextChanged += new System.EventHandler(this.txtSoTienChuyen_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1708, 679);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1630, 795);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 51);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cancel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 51);
            this.label5.TabIndex = 7;
            this.label5.Text = "Người Hưởng";
            // 
            // txtTenNguoiHuong
            // 
            this.txtTenNguoiHuong.Enabled = false;
            this.txtTenNguoiHuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiHuong.Location = new System.Drawing.Point(714, 469);
            this.txtTenNguoiHuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNguoiHuong.Name = "txtTenNguoiHuong";
            this.txtTenNguoiHuong.Size = new System.Drawing.Size(504, 44);
            this.txtTenNguoiHuong.TabIndex = 8;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.Crimson;
            this.lblAlert.Location = new System.Drawing.Point(1252, 327);
            this.lblAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(437, 37);
            this.lblAlert.TabIndex = 10;
            this.lblAlert.Text = "Số tài khoản không chính xác";
            this.lblAlert.UseWaitCursor = true;
            // 
            // imgST
            // 
            this.imgST.Image = global::GUI.Properties.Resources.pad;
            this.imgST.Location = new System.Drawing.Point(657, 321);
            this.imgST.Name = "imgST";
            this.imgST.Size = new System.Drawing.Size(50, 50);
            this.imgST.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgST.TabIndex = 11;
            this.imgST.TabStop = false;
            // 
            // imgT
            // 
            this.imgT.Image = global::GUI.Properties.Resources.pad;
            this.imgT.Location = new System.Drawing.Point(657, 623);
            this.imgT.Name = "imgT";
            this.imgT.Size = new System.Drawing.Size(50, 50);
            this.imgT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgT.TabIndex = 12;
            this.imgT.TabStop = false;
            // 
            // CashTransferFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 883);
            this.Controls.Add(this.imgT);
            this.Controls.Add(this.imgST);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.txtTenNguoiHuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoTienChuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoTaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashTransferFrm";
            this.Text = "CashTransferFrm";
            this.Load += new System.EventHandler(this.CashTransferFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSoTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoTienChuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNguoiHuong;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.PictureBox imgST;
        private System.Windows.Forms.PictureBox imgT;
    }
}
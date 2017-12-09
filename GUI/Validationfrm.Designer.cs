namespace GUI
{
    partial class Validationfrm
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
            this.pnPIN = new System.Windows.Forms.Panel();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnfailure = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPIN.SuspendLayout();
            this.pnfailure.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPIN
            // 
            this.pnPIN.Controls.Add(this.txtPIN);
            this.pnPIN.Controls.Add(this.label2);
            this.pnPIN.Location = new System.Drawing.Point(182, 95);
            this.pnPIN.Name = "pnPIN";
            this.pnPIN.Size = new System.Drawing.Size(335, 145);
            this.pnPIN.TabIndex = 0;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(179, 57);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(129, 20);
            this.txtPIN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mã PIN:";
            // 
            // pnfailure
            // 
            this.pnfailure.Controls.Add(this.label1);
            this.pnfailure.Location = new System.Drawing.Point(579, 128);
            this.pnfailure.Name = "pnfailure";
            this.pnfailure.Size = new System.Drawing.Size(202, 112);
            this.pnfailure.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thẻ không hợp lệ!";
            // 
            // Validationfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 390);
            this.Controls.Add(this.pnfailure);
            this.Controls.Add(this.pnPIN);
            this.Name = "Validationfrm";
            this.Text = "Validation";
            this.Load += new System.EventHandler(this.Validationfrm_Load);
            this.pnPIN.ResumeLayout(false);
            this.pnPIN.PerformLayout();
            this.pnfailure.ResumeLayout(false);
            this.pnfailure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPIN;
        private System.Windows.Forms.Panel pnfailure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPIN;
    }
}
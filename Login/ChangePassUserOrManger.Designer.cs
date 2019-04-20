namespace Login
{
    partial class ChangePassUserOrManger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassUserOrManger));
            this.btnSavePass = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSavePass
            // 
            this.btnSavePass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSavePass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSavePass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSavePass.Location = new System.Drawing.Point(138, 185);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(125, 29);
            this.btnSavePass.TabIndex = 75;
            this.btnSavePass.Text = "עדכן סיסמה";
            this.btnSavePass.UseVisualStyleBackColor = false;
            this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(121, 96);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPass.Size = new System.Drawing.Size(92, 26);
            this.txtPass.TabIndex = 76;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(25, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 79;
            this.label4.Text = "אשר סיסמה:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label11.Location = new System.Drawing.Point(55, 99);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 78;
            this.label11.Text = "סיסמה:";
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(121, 132);
            this.txtPassConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.PasswordChar = '*';
            this.txtPassConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassConfirm.Size = new System.Drawing.Size(92, 26);
            this.txtPassConfirm.TabIndex = 77;
            this.txtPassConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(12, 185);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 29);
            this.btnClose.TabIndex = 75;
            this.btnClose.Text = "ביטול";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 78;
            this.label1.Text = "הגדר סיסמה חדשה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 78;
            this.label2.Text = "הגדר סיסמה ל:";
            // 
            // maskedID
            // 
            this.maskedID.Enabled = false;
            this.maskedID.Location = new System.Drawing.Point(121, 43);
            this.maskedID.Margin = new System.Windows.Forms.Padding(2);
            this.maskedID.Name = "maskedID";
            this.maskedID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedID.Size = new System.Drawing.Size(98, 26);
            this.maskedID.TabIndex = 76;
            // 
            // ChangePassUserOrManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(296, 224);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSavePass);
            this.Controls.Add(this.maskedID);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPassConfirm);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassUserOrManger";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "שינוי סיסמה";
            this.Load += new System.EventHandler(this.ChangePassUserOrManger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSavePass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maskedID;
    }
}
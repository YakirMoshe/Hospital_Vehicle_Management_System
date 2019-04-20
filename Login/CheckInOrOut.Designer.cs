namespace Login
{
    partial class CheckInOrOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInOrOut));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCheckInOut = new System.Windows.Forms.TextBox();
            this.txtcome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesCheck = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "מספר רכב:";
            // 
            // txtCheckInOut
            // 
            this.txtCheckInOut.Location = new System.Drawing.Point(95, 49);
            this.txtCheckInOut.Name = "txtCheckInOut";
            this.txtCheckInOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCheckInOut.Size = new System.Drawing.Size(122, 26);
            this.txtCheckInOut.TabIndex = 1;
            this.txtCheckInOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCheckInOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyIntNum_KeyPress);
            // 
            // txtcome
            // 
            this.txtcome.AutoSize = true;
            this.txtcome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.txtcome.Location = new System.Drawing.Point(107, 9);
            this.txtcome.Name = "txtcome";
            this.txtcome.Size = new System.Drawing.Size(189, 25);
            this.txtcome.TabIndex = 2;
            this.txtcome.Text = "מבקר נכנס לבית חולים";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(37, 84);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "הערה:";
            // 
            // txtDesCheck
            // 
            this.txtDesCheck.Location = new System.Drawing.Point(95, 81);
            this.txtDesCheck.Multiline = true;
            this.txtDesCheck.Name = "txtDesCheck";
            this.txtDesCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDesCheck.Size = new System.Drawing.Size(271, 63);
            this.txtDesCheck.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(107, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "ביטול";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheckIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckIn.Location = new System.Drawing.Point(221, 160);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 32);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "כניסה";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckOut.Location = new System.Drawing.Point(221, 160);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 32);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "יציאה";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtout
            // 
            this.txtout.AutoSize = true;
            this.txtout.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.txtout.Location = new System.Drawing.Point(96, 9);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(200, 25);
            this.txtout.TabIndex = 2;
            this.txtout.Text = "מבקר יוצא מבית החולים";
            // 
            // CheckInOrOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(395, 204);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtout);
            this.Controls.Add(this.txtcome);
            this.Controls.Add(this.txtDesCheck);
            this.Controls.Add(this.txtCheckInOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckInOrOut";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "n";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCheckInOut;
        private System.Windows.Forms.Label txtcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesCheck;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label txtout;
    }
}
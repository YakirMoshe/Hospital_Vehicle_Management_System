namespace Login
{
    partial class CardGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneNump = new System.Windows.Forms.TextBox();
            this.txtStatusvis = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.radioParkingWork = new System.Windows.Forms.RadioButton();
            this.radioParking = new System.Windows.Forms.RadioButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "פרטי מבקר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(36, 10);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "הרשאות נתיב:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "שם פרטי:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "שם משפחה:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(278, 102);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "מחלקה:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(281, 141);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "סטטוס:";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.close.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.close.Location = new System.Drawing.Point(133, 280);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 35);
            this.close.TabIndex = 10;
            this.close.Text = "סגירה";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(111, 102);
            this.txtFname.Name = "txtFname";
            this.txtFname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFname.Size = new System.Drawing.Size(108, 20);
            this.txtFname.TabIndex = 2;
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters_KeyPress);
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(110, 142);
            this.txtLname.Name = "txtLname";
            this.txtLname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLname.Size = new System.Drawing.Size(109, 20);
            this.txtLname.TabIndex = 3;
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters_KeyPress);
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveCar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveCar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveCar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveCar.Location = new System.Drawing.Point(275, 280);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(116, 35);
            this.btnSaveCar.TabIndex = 9;
            this.btnSaveCar.Text = "שמירה שינויים";
            this.btnSaveCar.UseVisualStyleBackColor = false;
            this.btnSaveCar.Click += new System.EventHandler(this.btnSaveCar_Click);
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "כללית",
            "משטרה",
            "בטחון",
            "נכה",
            "חריג"});
            this.cmbGroup.Location = new System.Drawing.Point(346, 103);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbGroup.TabIndex = 5;
            this.cmbGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(282, 61);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "פלאפון:";
            // 
            // phoneNump
            // 
            this.phoneNump.Location = new System.Drawing.Point(346, 62);
            this.phoneNump.Name = "phoneNump";
            this.phoneNump.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phoneNump.Size = new System.Drawing.Size(121, 20);
            this.phoneNump.TabIndex = 4;
            this.phoneNump.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyIntNum_KeyPress);
            // 
            // txtStatusvis
            // 
            this.txtStatusvis.FormattingEnabled = true;
            this.txtStatusvis.Items.AddRange(new object[] {
            "פעיל",
            "לא פעיל"});
            this.txtStatusvis.Location = new System.Drawing.Point(346, 139);
            this.txtStatusvis.Name = "txtStatusvis";
            this.txtStatusvis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStatusvis.Size = new System.Drawing.Size(121, 21);
            this.txtStatusvis.TabIndex = 6;
            this.txtStatusvis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label8.Location = new System.Drawing.Point(9, 63);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "תעודת זהות:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(111, 63);
            this.txtid.Name = "txtid";
            this.txtid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtid.Size = new System.Drawing.Size(108, 20);
            this.txtid.TabIndex = 35;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyIntNum_KeyPress);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.radioParkingWork);
            this.panel.Controls.Add(this.radioParking);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(162, 174);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(163, 100);
            this.panel.TabIndex = 36;
            // 
            // radioParkingWork
            // 
            this.radioParkingWork.AutoSize = true;
            this.radioParkingWork.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioParkingWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.radioParkingWork.Location = new System.Drawing.Point(17, 64);
            this.radioParkingWork.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioParkingWork.Name = "radioParkingWork";
            this.radioParkingWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioParkingWork.Size = new System.Drawing.Size(123, 23);
            this.radioParkingWork.TabIndex = 35;
            this.radioParkingWork.TabStop = true;
            this.radioParkingWork.Text = "חניון בית חולים";
            this.radioParkingWork.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.radioParkingWork.UseVisualStyleBackColor = true;
            // 
            // radioParking
            // 
            this.radioParking.AutoSize = true;
            this.radioParking.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioParking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.radioParking.Location = new System.Drawing.Point(56, 35);
            this.radioParking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioParking.Name = "radioParking";
            this.radioParking.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioParking.Size = new System.Drawing.Size(84, 23);
            this.radioParking.TabIndex = 34;
            this.radioParking.TabStop = true;
            this.radioParking.Text = "חניון סגל";
            this.radioParking.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.radioParking.UseVisualStyleBackColor = true;
            // 
            // CardGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(476, 320);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.txtStatusvis);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.btnSaveCar);
            this.Controls.Add(this.phoneNump);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "פרטי מבקר";
            this.Load += new System.EventHandler(this.CardGUI_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneNump;
        private System.Windows.Forms.ComboBox txtStatusvis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RadioButton radioParkingWork;
        private System.Windows.Forms.RadioButton radioParking;
    }
}
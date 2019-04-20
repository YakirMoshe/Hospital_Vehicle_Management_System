namespace Login
{
    partial class CarCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarCard));
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtcarid = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.car = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveCar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveCar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveCar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveCar.Location = new System.Drawing.Point(270, 180);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(116, 35);
            this.btnSaveCar.TabIndex = 3;
            this.btnSaveCar.Text = "שמירה שינויים";
            this.btnSaveCar.UseVisualStyleBackColor = false;
            this.btnSaveCar.Click += new System.EventHandler(this.btnSaveCar_Click);
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(338, 63);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcolor.Size = new System.Drawing.Size(120, 20);
            this.txtcolor.TabIndex = 0;
            this.txtcolor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters_KeyPress);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(338, 102);
            this.txtyear.Name = "txtyear";
            this.txtyear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtyear.Size = new System.Drawing.Size(120, 20);
            this.txtyear.TabIndex = 1;
            this.txtyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyIntNum_KeyPress);
            // 
            // txtcarid
            // 
            this.txtcarid.Location = new System.Drawing.Point(113, 118);
            this.txtcarid.Name = "txtcarid";
            this.txtcarid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcarid.Size = new System.Drawing.Size(108, 20);
            this.txtcarid.TabIndex = 50;
            this.txtcarid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyIntNum_KeyPress);
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(339, 139);
            this.txttype.Name = "txttype";
            this.txttype.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttype.Size = new System.Drawing.Size(119, 20);
            this.txttype.TabIndex = 2;
            this.txttype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters_KeyPress);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.close.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.close.Location = new System.Drawing.Point(153, 180);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 35);
            this.close.TabIndex = 4;
            this.close.Text = "סגירה";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(262, 62);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "צבע רכב:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(260, 100);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "שנת יצור:";
            // 
            // car
            // 
            this.car.AutoSize = true;
            this.car.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.car.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.car.Location = new System.Drawing.Point(26, 118);
            this.car.Name = "car";
            this.car.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.car.Size = new System.Drawing.Size(81, 19);
            this.car.TabIndex = 43;
            this.car.Text = "מספר רכב:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(267, 139);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "סוג רכב:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = "פרטי רכב של מבקר";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "תעודת זהות:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(113, 77);
            this.txtid.Name = "txtid";
            this.txtid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtid.Size = new System.Drawing.Size(108, 20);
            this.txtid.TabIndex = 50;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyIntNum_KeyPress);
            // 
            // CarCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(468, 227);
            this.Controls.Add(this.btnSaveCar);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtcarid);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.car);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarCard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מידע רכב";
            this.Load += new System.EventHandler(this.CarCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtcarid;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label car;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
    }
}
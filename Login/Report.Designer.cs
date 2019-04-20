namespace Login
{
    partial class Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Allr = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.appr = new System.Windows.Forms.RadioButton();
            this.rejr = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textSave1 = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.buckM = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(685, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = ":בחירת דוח";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "הפקת דוחות";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox1.Location = new System.Drawing.Point(635, 281);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(172, 29);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "חיפוש לפי תאריך:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = ":מ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = ":עד";
            // 
            // Allr
            // 
            this.Allr.AutoSize = true;
            this.Allr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Allr.Location = new System.Drawing.Point(317, 79);
            this.Allr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Allr.Name = "Allr";
            this.Allr.Size = new System.Drawing.Size(54, 22);
            this.Allr.TabIndex = 5;
            this.Allr.TabStop = true;
            this.Allr.Text = "הכל";
            this.Allr.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.pdf;
            this.pictureBox1.Location = new System.Drawing.Point(25, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "הכל",
            "דוח הרשאות לנתיבים",
            "דוח נכנסים",
            "דוח מבקרים",
            "דוח חריגים"});
            this.comboBox1.Location = new System.Drawing.Point(557, 90);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // appr
            // 
            this.appr.AutoSize = true;
            this.appr.Location = new System.Drawing.Point(317, 108);
            this.appr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appr.Name = "appr";
            this.appr.Size = new System.Drawing.Size(96, 21);
            this.appr.TabIndex = 13;
            this.appr.TabStop = true;
            this.appr.Text = "רק מאושרים";
            this.appr.UseVisualStyleBackColor = true;
            // 
            // rejr
            // 
            this.rejr.AutoSize = true;
            this.rejr.Location = new System.Drawing.Point(317, 135);
            this.rejr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rejr.Name = "rejr";
            this.rejr.Size = new System.Drawing.Size(88, 21);
            this.rejr.TabIndex = 14;
            this.rejr.TabStop = true;
            this.rejr.Text = "רק חסומים";
            this.rejr.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(448, 324);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(91, 322);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(649, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = ":שמור את הקובץ ב";
            // 
            // textSave1
            // 
            this.textSave1.Location = new System.Drawing.Point(264, 400);
            this.textSave1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSave1.Name = "textSave1";
            this.textSave1.Size = new System.Drawing.Size(377, 22);
            this.textSave1.TabIndex = 18;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(140, 396);
            this.browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(100, 28);
            this.browse.TabIndex = 19;
            this.browse.Text = "שמור ב";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // buckM
            // 
            this.buckM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buckM.Location = new System.Drawing.Point(799, 14);
            this.buckM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buckM.Name = "buckM";
            this.buckM.Size = new System.Drawing.Size(129, 28);
            this.buckM.TabIndex = 31;
            this.buckM.Text = "חזרה לתפריט";
            this.buckM.UseVisualStyleBackColor = true;
            this.buckM.Click += new System.EventHandler(this.buckM_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "יצירת קובץ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buckM);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.textSave1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rejr);
            this.Controls.Add(this.appr);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Allr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Allr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton appr;
        private System.Windows.Forms.RadioButton rejr;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSave1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button buckM;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}
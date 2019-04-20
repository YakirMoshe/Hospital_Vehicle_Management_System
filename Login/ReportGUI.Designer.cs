namespace Login
{
    partial class reportGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPdfByDeate = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdTypeReport = new System.Windows.Forms.ComboBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.buckM = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupStatusPdf = new System.Windows.Forms.GroupBox();
            this.radioWorkers = new System.Windows.Forms.RadioButton();
            this.radioALL = new System.Windows.Forms.RadioButton();
            this.groupDate = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupStatusPdf.SuspendLayout();
            this.groupDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(226, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "בחירת דוח:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(330, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "הפקת דוחות";
            // 
            // chkPdfByDeate
            // 
            this.chkPdfByDeate.AutoSize = true;
            this.chkPdfByDeate.BackColor = System.Drawing.Color.Transparent;
            this.chkPdfByDeate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chkPdfByDeate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.chkPdfByDeate.Location = new System.Drawing.Point(239, 18);
            this.chkPdfByDeate.Margin = new System.Windows.Forms.Padding(2);
            this.chkPdfByDeate.Name = "chkPdfByDeate";
            this.chkPdfByDeate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPdfByDeate.Size = new System.Drawing.Size(142, 23);
            this.chkPdfByDeate.TabIndex = 2;
            this.chkPdfByDeate.Text = "חיפוש לפי תאריך:";
            this.chkPdfByDeate.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(348, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "מ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(142, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "עד:";
            // 
            // cmdTypeReport
            // 
            this.cmdTypeReport.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdTypeReport.FormattingEnabled = true;
            this.cmdTypeReport.Items.AddRange(new object[] {
            "",
            "מבקרים",
            "רכבים",
            "חניון סגל",
            "חניון בית חולים",
            "משתמשי מערכת"});
            this.cmdTypeReport.Location = new System.Drawing.Point(330, 84);
            this.cmdTypeReport.Margin = new System.Windows.Forms.Padding(2);
            this.cmdTypeReport.Name = "cmdTypeReport";
            this.cmdTypeReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdTypeReport.Size = new System.Drawing.Size(125, 26);
            this.cmdTypeReport.TabIndex = 12;
            this.cmdTypeReport.Text = "נא לבחור ערך";
            this.cmdTypeReport.SelectedValueChanged += new System.EventHandler(this.cmdTypeReport_SelectedValueChanged);
            this.cmdTypeReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(242, 58);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateFrom.RightToLeftLayout = true;
            this.dateFrom.Size = new System.Drawing.Size(102, 22);
            this.dateFrom.TabIndex = 15;
            this.dateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(35, 58);
            this.dateTo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTo.Name = "dateTo";
            this.dateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTo.RightToLeftLayout = true;
            this.dateTo.Size = new System.Drawing.Size(103, 22);
            this.dateTo.TabIndex = 16;
            this.dateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(92, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "שמור את הקובץ ב:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(227, 374);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(323, 20);
            this.txtPath.TabIndex = 18;
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.browse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.browse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.browse.Location = new System.Drawing.Point(556, 369);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(100, 31);
            this.browse.TabIndex = 19;
            this.browse.Text = "שמור ב";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // buckM
            // 
            this.buckM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buckM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buckM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buckM.Location = new System.Drawing.Point(571, 11);
            this.buckM.Margin = new System.Windows.Forms.Padding(2);
            this.buckM.Name = "buckM";
            this.buckM.Size = new System.Drawing.Size(117, 31);
            this.buckM.TabIndex = 31;
            this.buckM.Text = "חזרה לתפריט";
            this.buckM.UseVisualStyleBackColor = false;
            this.buckM.Click += new System.EventHandler(this.buckM_Click_1);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGenerate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerate.Location = new System.Drawing.Point(354, 407);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 48);
            this.btnGenerate.TabIndex = 32;
            this.btnGenerate.Text = "יצירת קובץ";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupStatusPdf
            // 
            this.groupStatusPdf.Controls.Add(this.radioWorkers);
            this.groupStatusPdf.Controls.Add(this.radioALL);
            this.groupStatusPdf.Location = new System.Drawing.Point(468, 84);
            this.groupStatusPdf.Name = "groupStatusPdf";
            this.groupStatusPdf.Size = new System.Drawing.Size(145, 91);
            this.groupStatusPdf.TabIndex = 34;
            this.groupStatusPdf.TabStop = false;
            // 
            // radioWorkers
            // 
            this.radioWorkers.AutoSize = true;
            this.radioWorkers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.radioWorkers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.radioWorkers.Location = new System.Drawing.Point(59, 48);
            this.radioWorkers.Name = "radioWorkers";
            this.radioWorkers.Size = new System.Drawing.Size(81, 26);
            this.radioWorkers.TabIndex = 1;
            this.radioWorkers.TabStop = true;
            this.radioWorkers.Text = "עובדים";
            this.radioWorkers.UseVisualStyleBackColor = true;
            // 
            // radioALL
            // 
            this.radioALL.AutoSize = true;
            this.radioALL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.radioALL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.radioALL.Location = new System.Drawing.Point(82, 16);
            this.radioALL.Name = "radioALL";
            this.radioALL.Size = new System.Drawing.Size(58, 26);
            this.radioALL.TabIndex = 0;
            this.radioALL.TabStop = true;
            this.radioALL.Text = "הכל";
            this.radioALL.UseVisualStyleBackColor = true;
            // 
            // groupDate
            // 
            this.groupDate.Controls.Add(this.chkPdfByDeate);
            this.groupDate.Controls.Add(this.label3);
            this.groupDate.Controls.Add(this.dateFrom);
            this.groupDate.Controls.Add(this.label4);
            this.groupDate.Controls.Add(this.dateTo);
            this.groupDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupDate.Location = new System.Drawing.Point(227, 231);
            this.groupDate.Name = "groupDate";
            this.groupDate.Size = new System.Drawing.Size(386, 100);
            this.groupDate.TabIndex = 35;
            this.groupDate.TabStop = false;
            this.groupDate.Text = "בחירת תאריך";
            // 
            // reportGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(699, 466);
            this.Controls.Add(this.groupDate);
            this.Controls.Add(this.groupStatusPdf);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.buckM);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdTypeReport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reportGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "דוחות מערכת";
            this.Load += new System.EventHandler(this.reportGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupStatusPdf.ResumeLayout(false);
            this.groupStatusPdf.PerformLayout();
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPdfByDeate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmdTypeReport;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button buckM;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupStatusPdf;
        private System.Windows.Forms.RadioButton radioWorkers;
        private System.Windows.Forms.RadioButton radioALL;
        private System.Windows.Forms.GroupBox groupDate;
    }
}
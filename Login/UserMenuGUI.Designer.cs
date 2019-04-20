namespace Login
{
    partial class UserMenuGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenuGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVisitorToday = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.כניסהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.יציאהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.פרטימבקרToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCardVis = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSearchCar = new System.Windows.Forms.PictureBox();
            this.txtNumCar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buckM = new System.Windows.Forms.Button();
            this.lbltimeTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCheckOut = new System.Windows.Forms.PictureBox();
            this.btnCheckIn = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitorToday)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckIn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(565, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ניהול מבקרים";
            // 
            // dgvVisitorToday
            // 
            this.dgvVisitorToday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisitorToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitorToday.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvVisitorToday.Location = new System.Drawing.Point(244, 203);
            this.dgvVisitorToday.Name = "dgvVisitorToday";
            this.dgvVisitorToday.ReadOnly = true;
            this.dgvVisitorToday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvVisitorToday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitorToday.Size = new System.Drawing.Size(966, 446);
            this.dgvVisitorToday.TabIndex = 4;
            this.dgvVisitorToday.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitorToday_CellContentClick);
            this.dgvVisitorToday.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvVisitorToday_RowPostPaint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.כניסהToolStripMenuItem,
            this.יציאהToolStripMenuItem,
            this.toolStripMenuItem2,
            this.פרטימבקרToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 76);
            // 
            // כניסהToolStripMenuItem
            // 
            this.כניסהToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("כניסהToolStripMenuItem.Image")));
            this.כניסהToolStripMenuItem.Name = "כניסהToolStripMenuItem";
            this.כניסהToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.כניסהToolStripMenuItem.Text = "כניסה";
            this.כניסהToolStripMenuItem.Click += new System.EventHandler(this.כניסהToolStripMenuItem_Click);
            // 
            // יציאהToolStripMenuItem
            // 
            this.יציאהToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("יציאהToolStripMenuItem.Image")));
            this.יציאהToolStripMenuItem.Name = "יציאהToolStripMenuItem";
            this.יציאהToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.יציאהToolStripMenuItem.Text = "יציאה";
            this.יציאהToolStripMenuItem.Click += new System.EventHandler(this.יציאהToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 6);
            // 
            // פרטימבקרToolStripMenuItem
            // 
            this.פרטימבקרToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("פרטימבקרToolStripMenuItem.Image")));
            this.פרטימבקרToolStripMenuItem.Name = "פרטימבקרToolStripMenuItem";
            this.פרטימבקרToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.פרטימבקרToolStripMenuItem.Text = "פרטי מבקר";
            this.פרטימבקרToolStripMenuItem.Click += new System.EventHandler(this.פרטימבקרToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCardVis);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(1, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 446);
            this.panel2.TabIndex = 6;
            // 
            // btnCardVis
            // 
            this.btnCardVis.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCardVis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCardVis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCardVis.Location = new System.Drawing.Point(21, 338);
            this.btnCardVis.Name = "btnCardVis";
            this.btnCardVis.Size = new System.Drawing.Size(195, 91);
            this.btnCardVis.TabIndex = 33;
            this.btnCardVis.Text = "הצג מידע בעל רכב";
            this.btnCardVis.UseVisualStyleBackColor = false;
            this.btnCardVis.Visible = false;
            this.btnCardVis.Click += new System.EventHandler(this.btnCardVis_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(4, 4);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picSearchCar);
            this.panel1.Controls.Add(this.txtNumCar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 110);
            this.panel1.TabIndex = 1;
            // 
            // picSearchCar
            // 
            this.picSearchCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearchCar.Image = ((System.Drawing.Image)(resources.GetObject("picSearchCar.Image")));
            this.picSearchCar.Location = new System.Drawing.Point(16, 43);
            this.picSearchCar.Name = "picSearchCar";
            this.picSearchCar.Size = new System.Drawing.Size(52, 41);
            this.picSearchCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchCar.TabIndex = 2;
            this.picSearchCar.TabStop = false;
            this.picSearchCar.Click += new System.EventHandler(this.picSearchCar_Click);
            // 
            // txtNumCar
            // 
            this.txtNumCar.Location = new System.Drawing.Point(74, 58);
            this.txtNumCar.Name = "txtNumCar";
            this.txtNumCar.Size = new System.Drawing.Size(145, 26);
            this.txtNumCar.TabIndex = 1;
            this.txtNumCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumCar.TextChanged += new System.EventHandler(this.txtNumCar_TextChanged);
            this.txtNumCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyIntNum_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(74, 15);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "חיפוש לפי מספר רכב:";
            // 
            // buckM
            // 
            this.buckM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buckM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buckM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buckM.Location = new System.Drawing.Point(11, 11);
            this.buckM.Margin = new System.Windows.Forms.Padding(2);
            this.buckM.Name = "buckM";
            this.buckM.Size = new System.Drawing.Size(128, 30);
            this.buckM.TabIndex = 31;
            this.buckM.Text = "חזרה לתפריט";
            this.buckM.UseVisualStyleBackColor = false;
            this.buckM.Click += new System.EventHandler(this.buckM_Click);
            // 
            // lbltimeTitle
            // 
            this.lbltimeTitle.AutoSize = true;
            this.lbltimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.lbltimeTitle.Location = new System.Drawing.Point(42, 61);
            this.lbltimeTitle.Name = "lbltimeTitle";
            this.lbltimeTitle.Size = new System.Drawing.Size(56, 25);
            this.lbltimeTitle.TabIndex = 32;
            this.lbltimeTitle.Text = "time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(204, 63);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = ":שעה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(190, 22);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = ":תאריך";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.lblDateTitle.Location = new System.Drawing.Point(41, 20);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(58, 25);
            this.lblDateTitle.TabIndex = 32;
            this.lblDateTitle.Text = "date";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.Location = new System.Drawing.Point(362, 78);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(100, 119);
            this.btnCheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.TabStop = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckIn.Image")));
            this.btnCheckIn.Location = new System.Drawing.Point(244, 78);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(100, 119);
            this.btnCheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.TabStop = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbltimeTitle);
            this.groupBox1.Controls.Add(this.lblDateTitle);
            this.groupBox1.Location = new System.Drawing.Point(910, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 100);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // UserMenuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1222, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buckM);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvVisitorToday);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMenuGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "פאנל כניסות ויציאות";
            this.Load += new System.EventHandler(this.UserMenuGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitorToday)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckIn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCheckIn;
        private System.Windows.Forms.PictureBox btnCheckOut;
        private System.Windows.Forms.DataGridView dgvVisitorToday;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCardVis;
        private System.Windows.Forms.PictureBox picSearchCar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem כניסהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem יציאהToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem פרטימבקרToolStripMenuItem;
        private System.Windows.Forms.Button buckM;
        private System.Windows.Forms.Label lbltimeTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
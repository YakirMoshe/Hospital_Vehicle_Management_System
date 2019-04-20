namespace Login
{
    partial class mainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGUI));
            this.PanelMain = new System.Windows.Forms.Panel();
            this.rtbInfo11 = new System.Windows.Forms.RichTextBox();
            this.EditVisitorDetails = new System.Windows.Forms.Button();
            this.VehicleApproval = new System.Windows.Forms.Button();
            this.InformationVisitors = new System.Windows.Forms.Button();
            this.GenerateReports = new System.Windows.Forms.Button();
            this.AddingVisitor = new System.Windows.Forms.Button();
            this.systemPermissions = new System.Windows.Forms.Button();
            this.HistoryLogins = new System.Windows.Forms.Button();
            this.ManageVisitors = new System.Windows.Forms.Button();
            this.VehicleLnformation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PanelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMain.Controls.Add(this.rtbInfo11);
            this.PanelMain.Controls.Add(this.EditVisitorDetails);
            this.PanelMain.Controls.Add(this.VehicleApproval);
            this.PanelMain.Controls.Add(this.InformationVisitors);
            this.PanelMain.Controls.Add(this.GenerateReports);
            this.PanelMain.Controls.Add(this.AddingVisitor);
            this.PanelMain.Controls.Add(this.systemPermissions);
            this.PanelMain.Controls.Add(this.HistoryLogins);
            this.PanelMain.Controls.Add(this.ManageVisitors);
            this.PanelMain.Controls.Add(this.VehicleLnformation);
            this.PanelMain.Controls.Add(this.pictureBox1);
            this.PanelMain.ForeColor = System.Drawing.Color.Transparent;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelMain.Size = new System.Drawing.Size(901, 540);
            this.PanelMain.TabIndex = 0;
            this.PanelMain.MouseHover += new System.EventHandler(this.PanelMain_MouseHover);
            // 
            // rtbInfo11
            // 
            this.rtbInfo11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbInfo11.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbInfo11.Location = new System.Drawing.Point(188, 216);
            this.rtbInfo11.Name = "rtbInfo11";
            this.rtbInfo11.ReadOnly = true;
            this.rtbInfo11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbInfo11.Size = new System.Drawing.Size(535, 137);
            this.rtbInfo11.TabIndex = 14;
            this.rtbInfo11.Text = "";
            // 
            // EditVisitorDetails
            // 
            this.EditVisitorDetails.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditVisitorDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.EditVisitorDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditVisitorDetails.Location = new System.Drawing.Point(188, 404);
            this.EditVisitorDetails.Name = "EditVisitorDetails";
            this.EditVisitorDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EditVisitorDetails.Size = new System.Drawing.Size(174, 39);
            this.EditVisitorDetails.TabIndex = 11;
            this.EditVisitorDetails.Text = "עריכת פרטי מבקר";
            this.EditVisitorDetails.UseVisualStyleBackColor = false;
            this.EditVisitorDetails.Click += new System.EventHandler(this.EditVisitorDetails_Click);
            this.EditVisitorDetails.MouseHover += new System.EventHandler(this.EditVisitorDetails_MouseHover);
            // 
            // VehicleApproval
            // 
            this.VehicleApproval.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.VehicleApproval.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.VehicleApproval.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VehicleApproval.Location = new System.Drawing.Point(369, 403);
            this.VehicleApproval.Name = "VehicleApproval";
            this.VehicleApproval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VehicleApproval.Size = new System.Drawing.Size(174, 39);
            this.VehicleApproval.TabIndex = 10;
            this.VehicleApproval.Text = "אישור זמני לרכב";
            this.VehicleApproval.UseVisualStyleBackColor = false;
            this.VehicleApproval.Click += new System.EventHandler(this.Approval_Click);
            this.VehicleApproval.MouseHover += new System.EventHandler(this.VehicleApproval_MouseHover);
            // 
            // InformationVisitors
            // 
            this.InformationVisitors.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.InformationVisitors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.InformationVisitors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InformationVisitors.Location = new System.Drawing.Point(368, 359);
            this.InformationVisitors.Name = "InformationVisitors";
            this.InformationVisitors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InformationVisitors.Size = new System.Drawing.Size(174, 39);
            this.InformationVisitors.TabIndex = 9;
            this.InformationVisitors.Text = "מידע מבקרים";
            this.InformationVisitors.UseVisualStyleBackColor = false;
            this.InformationVisitors.Click += new System.EventHandler(this.Manage_visitors_Click);
            this.InformationVisitors.MouseHover += new System.EventHandler(this.InformationVisitors_MouseHover);
            // 
            // GenerateReports
            // 
            this.GenerateReports.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GenerateReports.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GenerateReports.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GenerateReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GenerateReports.Location = new System.Drawing.Point(188, 450);
            this.GenerateReports.Name = "GenerateReports";
            this.GenerateReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenerateReports.Size = new System.Drawing.Size(174, 39);
            this.GenerateReports.TabIndex = 8;
            this.GenerateReports.Text = "הפקת דוחות";
            this.GenerateReports.UseVisualStyleBackColor = false;
            this.GenerateReports.Click += new System.EventHandler(this.reportss_Click);
            this.GenerateReports.MouseHover += new System.EventHandler(this.GenerateReports_MouseHover);
            // 
            // AddingVisitor
            // 
            this.AddingVisitor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddingVisitor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.AddingVisitor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddingVisitor.Location = new System.Drawing.Point(549, 404);
            this.AddingVisitor.Name = "AddingVisitor";
            this.AddingVisitor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddingVisitor.Size = new System.Drawing.Size(174, 39);
            this.AddingVisitor.TabIndex = 7;
            this.AddingVisitor.Text = "הוספת מבקר";
            this.AddingVisitor.UseVisualStyleBackColor = false;
            this.AddingVisitor.Click += new System.EventHandler(this.add_car_Click);
            this.AddingVisitor.MouseHover += new System.EventHandler(this.AddingVisitor_MouseHover);
            // 
            // systemPermissions
            // 
            this.systemPermissions.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.systemPermissions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.systemPermissions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.systemPermissions.Location = new System.Drawing.Point(549, 450);
            this.systemPermissions.Name = "systemPermissions";
            this.systemPermissions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.systemPermissions.Size = new System.Drawing.Size(174, 39);
            this.systemPermissions.TabIndex = 6;
            this.systemPermissions.Text = "הרשאות מערכת";
            this.systemPermissions.UseVisualStyleBackColor = false;
            this.systemPermissions.Click += new System.EventHandler(this.system_permissions_Click);
            this.systemPermissions.MouseHover += new System.EventHandler(this.systemPermissions_MouseHover);
            // 
            // HistoryLogins
            // 
            this.HistoryLogins.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.HistoryLogins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.HistoryLogins.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HistoryLogins.Location = new System.Drawing.Point(368, 450);
            this.HistoryLogins.Name = "HistoryLogins";
            this.HistoryLogins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HistoryLogins.Size = new System.Drawing.Size(174, 39);
            this.HistoryLogins.TabIndex = 5;
            this.HistoryLogins.Text = "היסטוריה";
            this.HistoryLogins.UseVisualStyleBackColor = false;
            this.HistoryLogins.Click += new System.EventHandler(this.History_logins_Click);
            this.HistoryLogins.MouseHover += new System.EventHandler(this.HistoryLogins_MouseHover);
            // 
            // ManageVisitors
            // 
            this.ManageVisitors.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ManageVisitors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ManageVisitors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ManageVisitors.Location = new System.Drawing.Point(549, 360);
            this.ManageVisitors.Name = "ManageVisitors";
            this.ManageVisitors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ManageVisitors.Size = new System.Drawing.Size(174, 39);
            this.ManageVisitors.TabIndex = 4;
            this.ManageVisitors.Text = "ניהול מבקרים";
            this.ManageVisitors.UseVisualStyleBackColor = false;
            this.ManageVisitors.Click += new System.EventHandler(this.Editing_paths_Click);
            this.ManageVisitors.MouseHover += new System.EventHandler(this.ManageVisitors_MouseHover);
            // 
            // VehicleLnformation
            // 
            this.VehicleLnformation.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.VehicleLnformation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.VehicleLnformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VehicleLnformation.Location = new System.Drawing.Point(188, 359);
            this.VehicleLnformation.Name = "VehicleLnformation";
            this.VehicleLnformation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VehicleLnformation.Size = new System.Drawing.Size(174, 39);
            this.VehicleLnformation.TabIndex = 3;
            this.VehicleLnformation.Text = "מידע רכבים";
            this.VehicleLnformation.UseVisualStyleBackColor = false;
            this.VehicleLnformation.Click += new System.EventHandler(this.Car_management_Click);
            this.VehicleLnformation.MouseHover += new System.EventHandler(this.VehicleLnformation_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(894, 528);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "פאנל מנהל";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.mainGUI_Load);
            this.PanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GenerateReports;
        private System.Windows.Forms.Button AddingVisitor;
        private System.Windows.Forms.Button systemPermissions;
        private System.Windows.Forms.Button HistoryLogins;
        private System.Windows.Forms.Button ManageVisitors;
        private System.Windows.Forms.Button VehicleLnformation;
        private System.Windows.Forms.Button VehicleApproval;
        private System.Windows.Forms.Button EditVisitorDetails;
        private System.Windows.Forms.Button InformationVisitors;
        private System.Windows.Forms.RichTextBox rtbInfo11;
    }
}
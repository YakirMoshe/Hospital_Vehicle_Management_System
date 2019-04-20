namespace Login
{
    partial class systemPermGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(systemPermGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dellUser = new System.Windows.Forms.Button();
            this.dellManeg = new System.Windows.Forms.Button();
            this.buckM = new System.Windows.Forms.Button();
            this.rightToManag = new System.Windows.Forms.Button();
            this.leftToUser = new System.Windows.Forms.Button();
            this.Usersbox = new System.Windows.Forms.ListBox();
            this.adminbox = new System.Windows.Forms.ListBox();
            this.RadioUser = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textB_name = new System.Windows.Forms.TextBox();
            this.textB_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TabControl();
            this.TpSearch = new System.Windows.Forms.TabPage();
            this.RadioAdmin = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.textB_pass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textB_user = new System.Windows.Forms.TextBox();
            this.tabP_Upd = new System.Windows.Forms.TabPage();
            this.btnchangePass = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.comboIdType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.updateUser = new System.Windows.Forms.Button();
            this.RadioAdminUP = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.UserUP = new System.Windows.Forms.TextBox();
            this.RadioUserUP = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.UserNameUP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UserIdUP = new System.Windows.Forms.TextBox();
            this.search.SuspendLayout();
            this.TpSearch.SuspendLayout();
            this.tabP_Upd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(310, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "הרשאות מערכת";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(452, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "מנהלים:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(110, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "משתמשים:";
            // 
            // dellUser
            // 
            this.dellUser.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dellUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dellUser.Location = new System.Drawing.Point(169, 397);
            this.dellUser.Margin = new System.Windows.Forms.Padding(2);
            this.dellUser.Name = "dellUser";
            this.dellUser.Size = new System.Drawing.Size(122, 33);
            this.dellUser.TabIndex = 3;
            this.dellUser.Text = "מחיקת משתמש";
            this.dellUser.UseVisualStyleBackColor = false;
            this.dellUser.Click += new System.EventHandler(this.dellUser_Click_1);
            // 
            // dellManeg
            // 
            this.dellManeg.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dellManeg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dellManeg.Location = new System.Drawing.Point(529, 397);
            this.dellManeg.Margin = new System.Windows.Forms.Padding(2);
            this.dellManeg.Name = "dellManeg";
            this.dellManeg.Size = new System.Drawing.Size(122, 32);
            this.dellManeg.TabIndex = 2;
            this.dellManeg.Text = "מחיקת מנהל";
            this.dellManeg.UseVisualStyleBackColor = false;
            this.dellManeg.Click += new System.EventHandler(this.dellManeg_Click_1);
            // 
            // buckM
            // 
            this.buckM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buckM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buckM.Location = new System.Drawing.Point(703, 11);
            this.buckM.Margin = new System.Windows.Forms.Padding(2);
            this.buckM.Name = "buckM";
            this.buckM.Size = new System.Drawing.Size(112, 31);
            this.buckM.TabIndex = 30;
            this.buckM.Text = "חזרה לתפריט";
            this.buckM.UseVisualStyleBackColor = false;
            this.buckM.Click += new System.EventHandler(this.buckM_Click);
            // 
            // rightToManag
            // 
            this.rightToManag.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rightToManag.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.rightToManag.Location = new System.Drawing.Point(373, 220);
            this.rightToManag.Margin = new System.Windows.Forms.Padding(2);
            this.rightToManag.Name = "rightToManag";
            this.rightToManag.Size = new System.Drawing.Size(78, 27);
            this.rightToManag.TabIndex = 0;
            this.rightToManag.Text = ">>";
            this.rightToManag.UseVisualStyleBackColor = false;
            this.rightToManag.Click += new System.EventHandler(this.rightToManag_Click);
            // 
            // leftToUser
            // 
            this.leftToUser.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.leftToUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.leftToUser.Location = new System.Drawing.Point(373, 251);
            this.leftToUser.Margin = new System.Windows.Forms.Padding(2);
            this.leftToUser.Name = "leftToUser";
            this.leftToUser.Size = new System.Drawing.Size(78, 26);
            this.leftToUser.TabIndex = 1;
            this.leftToUser.Text = "<<";
            this.leftToUser.UseVisualStyleBackColor = false;
            this.leftToUser.Click += new System.EventHandler(this.leftToUser_Click);
            // 
            // Usersbox
            // 
            this.Usersbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Usersbox.FormattingEnabled = true;
            this.Usersbox.ItemHeight = 16;
            this.Usersbox.Location = new System.Drawing.Point(114, 100);
            this.Usersbox.Name = "Usersbox";
            this.Usersbox.Size = new System.Drawing.Size(254, 292);
            this.Usersbox.TabIndex = 33;
            // 
            // adminbox
            // 
            this.adminbox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.adminbox.FormattingEnabled = true;
            this.adminbox.ItemHeight = 16;
            this.adminbox.Location = new System.Drawing.Point(456, 100);
            this.adminbox.Name = "adminbox";
            this.adminbox.Size = new System.Drawing.Size(253, 292);
            this.adminbox.TabIndex = 34;
            // 
            // RadioUser
            // 
            this.RadioUser.AutoSize = true;
            this.RadioUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.RadioUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.RadioUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.RadioUser.Location = new System.Drawing.Point(210, 59);
            this.RadioUser.Name = "RadioUser";
            this.RadioUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RadioUser.Size = new System.Drawing.Size(82, 23);
            this.RadioUser.TabIndex = 4;
            this.RadioUser.TabStop = true;
            this.RadioUser.Text = "משתמש";
            this.RadioUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioUser.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSave.Location = new System.Drawing.Point(27, 53);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(124, 41);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "הוסף עובד";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textB_name
            // 
            this.textB_name.Location = new System.Drawing.Point(580, 79);
            this.textB_name.Margin = new System.Windows.Forms.Padding(2);
            this.textB_name.Name = "textB_name";
            this.textB_name.Size = new System.Drawing.Size(100, 26);
            this.textB_name.TabIndex = 1;
            this.textB_name.TextChanged += new System.EventHandler(this.textB_name_TextChanged);
            // 
            // textB_id
            // 
            this.textB_id.Location = new System.Drawing.Point(580, 41);
            this.textB_id.Margin = new System.Windows.Forms.Padding(2);
            this.textB_id.Name = "textB_id";
            this.textB_id.Size = new System.Drawing.Size(100, 26);
            this.textB_id.TabIndex = 0;
            this.textB_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textB_id.TextChanged += new System.EventHandler(this.textB_id_TextChanged);
            this.textB_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyIntNum_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(684, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 54;
            this.label5.Text = "שם ומשפחה:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(685, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "תעודת זהות:";
            // 
            // search
            // 
            this.search.Controls.Add(this.TpSearch);
            this.search.Controls.Add(this.tabP_Upd);
            this.search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.search.Location = new System.Drawing.Point(11, 450);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search.RightToLeftLayout = true;
            this.search.SelectedIndex = 0;
            this.search.Size = new System.Drawing.Size(804, 175);
            this.search.TabIndex = 36;
            // 
            // TpSearch
            // 
            this.TpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.TpSearch.Controls.Add(this.RadioAdmin);
            this.TpSearch.Controls.Add(this.label9);
            this.TpSearch.Controls.Add(this.textB_pass);
            this.TpSearch.Controls.Add(this.label8);
            this.TpSearch.Controls.Add(this.label7);
            this.TpSearch.Controls.Add(this.textB_user);
            this.TpSearch.Controls.Add(this.buttonSave);
            this.TpSearch.Controls.Add(this.label6);
            this.TpSearch.Controls.Add(this.RadioUser);
            this.TpSearch.Controls.Add(this.label5);
            this.TpSearch.Controls.Add(this.textB_id);
            this.TpSearch.Controls.Add(this.textB_name);
            this.TpSearch.Location = new System.Drawing.Point(4, 28);
            this.TpSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TpSearch.Name = "TpSearch";
            this.TpSearch.Padding = new System.Windows.Forms.Padding(2);
            this.TpSearch.Size = new System.Drawing.Size(796, 143);
            this.TpSearch.TabIndex = 1;
            this.TpSearch.Text = "יצירת חשבון חדש";
            // 
            // RadioAdmin
            // 
            this.RadioAdmin.AutoSize = true;
            this.RadioAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.RadioAdmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.RadioAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.RadioAdmin.Location = new System.Drawing.Point(231, 88);
            this.RadioAdmin.Name = "RadioAdmin";
            this.RadioAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RadioAdmin.Size = new System.Drawing.Size(61, 23);
            this.RadioAdmin.TabIndex = 5;
            this.RadioAdmin.TabStop = true;
            this.RadioAdmin.Text = "מנהל";
            this.RadioAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioAdmin.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label9.Location = new System.Drawing.Point(459, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 63;
            this.label9.Text = "סיסמא:";
            // 
            // textB_pass
            // 
            this.textB_pass.Location = new System.Drawing.Point(354, 81);
            this.textB_pass.Margin = new System.Windows.Forms.Padding(2);
            this.textB_pass.Name = "textB_pass";
            this.textB_pass.PasswordChar = '*';
            this.textB_pass.Size = new System.Drawing.Size(100, 26);
            this.textB_pass.TabIndex = 3;
            this.textB_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textB_pass.TextChanged += new System.EventHandler(this.textB_pass_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label8.Location = new System.Drawing.Point(217, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 61;
            this.label8.Text = "הרשאות:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(459, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 60;
            this.label7.Text = "שם משתמש:";
            // 
            // textB_user
            // 
            this.textB_user.Location = new System.Drawing.Point(354, 41);
            this.textB_user.Margin = new System.Windows.Forms.Padding(2);
            this.textB_user.Name = "textB_user";
            this.textB_user.Size = new System.Drawing.Size(100, 26);
            this.textB_user.TabIndex = 2;
            this.textB_user.TextChanged += new System.EventHandler(this.textB_user_TextChanged);
            // 
            // tabP_Upd
            // 
            this.tabP_Upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.tabP_Upd.Controls.Add(this.btnchangePass);
            this.tabP_Upd.Controls.Add(this.btnSearchUser);
            this.tabP_Upd.Controls.Add(this.comboIdType);
            this.tabP_Upd.Controls.Add(this.label14);
            this.tabP_Upd.Controls.Add(this.updateUser);
            this.tabP_Upd.Controls.Add(this.RadioAdminUP);
            this.tabP_Upd.Controls.Add(this.label12);
            this.tabP_Upd.Controls.Add(this.UserUP);
            this.tabP_Upd.Controls.Add(this.RadioUserUP);
            this.tabP_Upd.Controls.Add(this.label11);
            this.tabP_Upd.Controls.Add(this.label13);
            this.tabP_Upd.Controls.Add(this.UserNameUP);
            this.tabP_Upd.Controls.Add(this.label10);
            this.tabP_Upd.Controls.Add(this.UserIdUP);
            this.tabP_Upd.Location = new System.Drawing.Point(4, 28);
            this.tabP_Upd.Name = "tabP_Upd";
            this.tabP_Upd.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Upd.Size = new System.Drawing.Size(796, 143);
            this.tabP_Upd.TabIndex = 2;
            this.tabP_Upd.Text = "עדכון עובד";
            // 
            // btnchangePass
            // 
            this.btnchangePass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnchangePass.Location = new System.Drawing.Point(540, 84);
            this.btnchangePass.Name = "btnchangePass";
            this.btnchangePass.Size = new System.Drawing.Size(129, 31);
            this.btnchangePass.TabIndex = 78;
            this.btnchangePass.Text = "שינוי סיסמה";
            this.btnchangePass.UseVisualStyleBackColor = false;
            this.btnchangePass.Visible = false;
            this.btnchangePass.Click += new System.EventHandler(this.btnchangePass_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchUser.Location = new System.Drawing.Point(662, 48);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(125, 29);
            this.btnSearchUser.TabIndex = 0;
            this.btnSearchUser.Text = "הצג נתונים";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // comboIdType
            // 
            this.comboIdType.FormattingEnabled = true;
            this.comboIdType.Location = new System.Drawing.Point(545, 8);
            this.comboIdType.Margin = new System.Windows.Forms.Padding(2);
            this.comboIdType.Name = "comboIdType";
            this.comboIdType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboIdType.Size = new System.Drawing.Size(112, 27);
            this.comboIdType.TabIndex = 2;
            this.comboIdType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label14.Location = new System.Drawing.Point(665, 8);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(132, 19);
            this.label14.TabIndex = 77;
            this.label14.Text = "חפש עובד לפי ת.ז:";
            // 
            // updateUser
            // 
            this.updateUser.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updateUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.updateUser.Location = new System.Drawing.Point(30, 45);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(116, 47);
            this.updateUser.TabIndex = 9;
            this.updateUser.Text = "עדכון עובד";
            this.updateUser.UseVisualStyleBackColor = false;
            this.updateUser.Visible = false;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // RadioAdminUP
            // 
            this.RadioAdminUP.AutoSize = true;
            this.RadioAdminUP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.RadioAdminUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.RadioAdminUP.Location = new System.Drawing.Point(198, 69);
            this.RadioAdminUP.Name = "RadioAdminUP";
            this.RadioAdminUP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RadioAdminUP.Size = new System.Drawing.Size(61, 23);
            this.RadioAdminUP.TabIndex = 8;
            this.RadioAdminUP.TabStop = true;
            this.RadioAdminUP.Text = "מנהל";
            this.RadioAdminUP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioAdminUP.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label12.Location = new System.Drawing.Point(412, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(95, 19);
            this.label12.TabIndex = 67;
            this.label12.Text = "תעודת זהות:";
            // 
            // UserUP
            // 
            this.UserUP.Location = new System.Drawing.Point(315, 49);
            this.UserUP.Margin = new System.Windows.Forms.Padding(2);
            this.UserUP.Name = "UserUP";
            this.UserUP.Size = new System.Drawing.Size(92, 26);
            this.UserUP.TabIndex = 5;
            this.UserUP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters_KeyPress);
            // 
            // RadioUserUP
            // 
            this.RadioUserUP.AutoSize = true;
            this.RadioUserUP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.RadioUserUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.RadioUserUP.Location = new System.Drawing.Point(177, 45);
            this.RadioUserUP.Name = "RadioUserUP";
            this.RadioUserUP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RadioUserUP.Size = new System.Drawing.Size(82, 23);
            this.RadioUserUP.TabIndex = 7;
            this.RadioUserUP.TabStop = true;
            this.RadioUserUP.Text = "משתמש";
            this.RadioUserUP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioUserUP.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label11.Location = new System.Drawing.Point(411, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(96, 19);
            this.label11.TabIndex = 71;
            this.label11.Text = "שם משתמש:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label13.Location = new System.Drawing.Point(411, 90);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 19);
            this.label13.TabIndex = 68;
            this.label13.Text = "שם ומשפחה:";
            // 
            // UserNameUP
            // 
            this.UserNameUP.Location = new System.Drawing.Point(315, 87);
            this.UserNameUP.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameUP.Name = "UserNameUP";
            this.UserNameUP.Size = new System.Drawing.Size(92, 26);
            this.UserNameUP.TabIndex = 4;
            this.UserNameUP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label10.Location = new System.Drawing.Point(194, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 72;
            this.label10.Text = "הרשאות:";
            // 
            // UserIdUP
            // 
            this.UserIdUP.Location = new System.Drawing.Point(315, 12);
            this.UserIdUP.Margin = new System.Windows.Forms.Padding(2);
            this.UserIdUP.Name = "UserIdUP";
            this.UserIdUP.Size = new System.Drawing.Size(92, 26);
            this.UserIdUP.TabIndex = 3;
            this.UserIdUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UserIdUP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyIntNum_KeyPress);
            // 
            // systemPermGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(824, 636);
            this.Controls.Add(this.search);
            this.Controls.Add(this.adminbox);
            this.Controls.Add(this.Usersbox);
            this.Controls.Add(this.leftToUser);
            this.Controls.Add(this.rightToManag);
            this.Controls.Add(this.buckM);
            this.Controls.Add(this.dellManeg);
            this.Controls.Add(this.dellUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "systemPermGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הרשאות משתמשים";
            this.Load += new System.EventHandler(this.systemPermGUI_Load);
            this.search.ResumeLayout(false);
            this.TpSearch.ResumeLayout(false);
            this.TpSearch.PerformLayout();
            this.tabP_Upd.ResumeLayout(false);
            this.tabP_Upd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dellUser;
        private System.Windows.Forms.Button dellManeg;
        private System.Windows.Forms.Button buckM;
        private System.Windows.Forms.Button rightToManag;
        private System.Windows.Forms.Button leftToUser;
        private System.Windows.Forms.ListBox Usersbox;
        private System.Windows.Forms.ListBox adminbox;
        private System.Windows.Forms.RadioButton RadioUser;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textB_name;
        private System.Windows.Forms.TextBox textB_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl search;
        private System.Windows.Forms.TabPage TpSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textB_pass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textB_user;
        private System.Windows.Forms.RadioButton RadioAdmin;
        private System.Windows.Forms.TabPage tabP_Upd;
        private System.Windows.Forms.Button btnchangePass;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.ComboBox comboIdType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.RadioButton RadioAdminUP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox UserUP;
        private System.Windows.Forms.RadioButton RadioUserUP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox UserNameUP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UserIdUP;
    }
}
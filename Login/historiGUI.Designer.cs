namespace Login
{
    partial class historiGUI
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("מבקרים");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("כל הכניסות", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("מבקרים");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("כל היציאות", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("אירועים היסטוריים", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("קיימים בתוך בית החולים");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("סיכום שוטף", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historiGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.HistoriTree = new System.Windows.Forms.TreeView();
            this.imgEvents = new System.Windows.Forms.ImageList(this.components);
            this.buckM = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.datahistoryAll = new System.Windows.Forms.DataGridView();
            this.pnlCardVisit = new System.Windows.Forms.Panel();
            this.radioParkingWork = new System.Windows.Forms.RadioButton();
            this.panelEvent = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.txtLogged = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.radioParking = new System.Windows.Forms.RadioButton();
            this.txtWorkerID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtcarID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datahistoryAll)).BeginInit();
            this.pnlCardVisit.SuspendLayout();
            this.panelEvent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(360, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "היסטוריית כניסות/יציאות מהבית חולים";
            // 
            // HistoriTree
            // 
            this.HistoriTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(210)))));
            this.HistoriTree.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoriTree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.HistoriTree.FullRowSelect = true;
            this.HistoriTree.ImageIndex = 5;
            this.HistoriTree.ImageList = this.imgEvents;
            this.HistoriTree.Location = new System.Drawing.Point(7, 121);
            this.HistoriTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HistoriTree.Name = "HistoriTree";
            treeNode1.ImageKey = "worker.png";
            treeNode1.Name = "InVisitors";
            treeNode1.SelectedImageKey = "worker.png";
            treeNode1.Tag = "AllCheckin";
            treeNode1.Text = "מבקרים";
            treeNode2.ImageKey = "cheknin.png";
            treeNode2.Name = "AllCheckin";
            treeNode2.SelectedImageKey = "cheknin.png";
            treeNode2.Tag = "history";
            treeNode2.Text = "כל הכניסות";
            treeNode3.ImageKey = "worker.png";
            treeNode3.Name = "OutVisitors";
            treeNode3.Tag = "AllChekout";
            treeNode3.Text = "מבקרים";
            treeNode4.ImageKey = "chekout.png";
            treeNode4.Name = "AllChekout";
            treeNode4.SelectedImageKey = "chekout.png";
            treeNode4.Tag = "history";
            treeNode4.Text = "כל היציאות";
            treeNode5.ImageKey = "histori.png";
            treeNode5.Name = "history";
            treeNode5.SelectedImageKey = "histori.png";
            treeNode5.Tag = "history";
            treeNode5.Text = "אירועים היסטוריים";
            treeNode6.ImageKey = "default_large.png";
            treeNode6.Name = "checkin";
            treeNode6.SelectedImageKey = "default_large.png";
            treeNode6.Tag = "current";
            treeNode6.Text = "קיימים בתוך בית החולים";
            treeNode7.ImageKey = "General.png";
            treeNode7.Name = "current";
            treeNode7.SelectedImageKey = "General.png";
            treeNode7.Tag = "history";
            treeNode7.Text = "סיכום שוטף";
            this.HistoriTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7});
            this.HistoriTree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HistoriTree.RightToLeftLayout = true;
            this.HistoriTree.SelectedImageIndex = 5;
            this.HistoriTree.Size = new System.Drawing.Size(236, 531);
            this.HistoriTree.TabIndex = 2;
            this.HistoriTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HistoriTree_MouseUp);
            // 
            // imgEvents
            // 
            this.imgEvents.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgEvents.ImageStream")));
            this.imgEvents.TransparentColor = System.Drawing.Color.Transparent;
            this.imgEvents.Images.SetKeyName(0, "chekout.png");
            this.imgEvents.Images.SetKeyName(1, "cheknin.png");
            this.imgEvents.Images.SetKeyName(2, "General.png");
            this.imgEvents.Images.SetKeyName(3, "histori.png");
            this.imgEvents.Images.SetKeyName(4, "default_large.png");
            this.imgEvents.Images.SetKeyName(5, "worker.png");
            // 
            // buckM
            // 
            this.buckM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buckM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buckM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buckM.Location = new System.Drawing.Point(995, 11);
            this.buckM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buckM.Name = "buckM";
            this.buckM.Size = new System.Drawing.Size(147, 32);
            this.buckM.TabIndex = 31;
            this.buckM.Text = "חזרה לתפריט";
            this.buckM.UseVisualStyleBackColor = false;
            this.buckM.Click += new System.EventHandler(this.buckM_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.MainPanel.Controls.Add(this.datahistoryAll);
            this.MainPanel.Controls.Add(this.pnlCardVisit);
            this.MainPanel.Location = new System.Drawing.Point(250, 121);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(888, 531);
            this.MainPanel.TabIndex = 32;
            // 
            // datahistoryAll
            // 
            this.datahistoryAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datahistoryAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datahistoryAll.Location = new System.Drawing.Point(4, 4);
            this.datahistoryAll.Margin = new System.Windows.Forms.Padding(4);
            this.datahistoryAll.Name = "datahistoryAll";
            this.datahistoryAll.ReadOnly = true;
            this.datahistoryAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datahistoryAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datahistoryAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datahistoryAll.Size = new System.Drawing.Size(880, 314);
            this.datahistoryAll.TabIndex = 0;
            this.datahistoryAll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datahistoryAll_CellClick);
            this.datahistoryAll.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.datahistoryAll_RowPostPaint);
            // 
            // pnlCardVisit
            // 
            this.pnlCardVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardVisit.Controls.Add(this.radioParkingWork);
            this.pnlCardVisit.Controls.Add(this.panelEvent);
            this.pnlCardVisit.Controls.Add(this.radioParking);
            this.pnlCardVisit.Controls.Add(this.txtWorkerID);
            this.pnlCardVisit.Controls.Add(this.label8);
            this.pnlCardVisit.Controls.Add(this.txtPhoneNumber);
            this.pnlCardVisit.Controls.Add(this.txtLastName);
            this.pnlCardVisit.Controls.Add(this.txtFirstName);
            this.pnlCardVisit.Controls.Add(this.txtcarID);
            this.pnlCardVisit.Controls.Add(this.label7);
            this.pnlCardVisit.Controls.Add(this.label3);
            this.pnlCardVisit.Controls.Add(this.label6);
            this.pnlCardVisit.Controls.Add(this.label5);
            this.pnlCardVisit.Controls.Add(this.label4);
            this.pnlCardVisit.Controls.Add(this.label2);
            this.pnlCardVisit.Location = new System.Drawing.Point(4, 326);
            this.pnlCardVisit.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCardVisit.Name = "pnlCardVisit";
            this.pnlCardVisit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlCardVisit.Size = new System.Drawing.Size(880, 201);
            this.pnlCardVisit.TabIndex = 34;
            // 
            // radioParkingWork
            // 
            this.radioParkingWork.AutoSize = true;
            this.radioParkingWork.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioParkingWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.radioParkingWork.Location = new System.Drawing.Point(482, 154);
            this.radioParkingWork.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioParkingWork.Name = "radioParkingWork";
            this.radioParkingWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioParkingWork.Size = new System.Drawing.Size(75, 20);
            this.radioParkingWork.TabIndex = 33;
            this.radioParkingWork.TabStop = true;
            this.radioParkingWork.Text = "חניון סגל";
            this.radioParkingWork.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.radioParkingWork.UseVisualStyleBackColor = true;
            // 
            // panelEvent
            // 
            this.panelEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEvent.Controls.Add(this.label12);
            this.panelEvent.Controls.Add(this.label11);
            this.panelEvent.Controls.Add(this.label10);
            this.panelEvent.Controls.Add(this.txtEventType);
            this.panelEvent.Controls.Add(this.txtLogged);
            this.panelEvent.Controls.Add(this.txtComment);
            this.panelEvent.Location = new System.Drawing.Point(-1, -1);
            this.panelEvent.Margin = new System.Windows.Forms.Padding(4);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(377, 205);
            this.panelEvent.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label12.Location = new System.Drawing.Point(306, 54);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "אירוע:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label11.Location = new System.Drawing.Point(282, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "זמן פעולה:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label10.Location = new System.Drawing.Point(274, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "הערת משתמש:";
            // 
            // txtEventType
            // 
            this.txtEventType.Location = new System.Drawing.Point(98, 48);
            this.txtEventType.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.ReadOnly = true;
            this.txtEventType.Size = new System.Drawing.Size(175, 22);
            this.txtEventType.TabIndex = 1;
            // 
            // txtLogged
            // 
            this.txtLogged.Location = new System.Drawing.Point(98, 14);
            this.txtLogged.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogged.Name = "txtLogged";
            this.txtLogged.ReadOnly = true;
            this.txtLogged.Size = new System.Drawing.Size(175, 22);
            this.txtLogged.TabIndex = 1;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(13, 94);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtComment.Size = new System.Drawing.Size(260, 55);
            this.txtComment.TabIndex = 1;
            // 
            // radioParking
            // 
            this.radioParking.AutoSize = true;
            this.radioParking.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioParking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.radioParking.Location = new System.Drawing.Point(448, 130);
            this.radioParking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioParking.Name = "radioParking";
            this.radioParking.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioParking.Size = new System.Drawing.Size(109, 20);
            this.radioParking.TabIndex = 32;
            this.radioParking.TabStop = true;
            this.radioParking.Text = "חניון בית חולים";
            this.radioParking.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.radioParking.UseVisualStyleBackColor = true;
            // 
            // txtWorkerID
            // 
            this.txtWorkerID.Location = new System.Drawing.Point(393, 40);
            this.txtWorkerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkerID.Name = "txtWorkerID";
            this.txtWorkerID.ReadOnly = true;
            this.txtWorkerID.Size = new System.Drawing.Size(140, 22);
            this.txtWorkerID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label8.Location = new System.Drawing.Point(488, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "נתיב כניסה:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(393, 70);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(140, 22);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(646, 122);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(127, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(646, 80);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(127, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtcarID
            // 
            this.txtcarID.Location = new System.Drawing.Point(646, 39);
            this.txtcarID.Margin = new System.Windows.Forms.Padding(4);
            this.txtcarID.Name = "txtcarID";
            this.txtcarID.ReadOnly = true;
            this.txtcarID.Size = new System.Drawing.Size(127, 22);
            this.txtcarID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(542, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "מספר עובד:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(380, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "מידע מבקר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(564, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "פלאפון:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(782, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "שם משפחה:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(828, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "שם:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(791, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "מספר רכב:";
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.AutoSize = true;
            this.txtEventTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtEventTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.txtEventTitle.Location = new System.Drawing.Point(431, 20);
            this.txtEventTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(0, 19);
            this.txtEventTitle.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEventTitle);
            this.groupBox1.Location = new System.Drawing.Point(254, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(880, 55);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // historiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1154, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HistoriTree);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.buckM);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "historiGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "היסטוריה";
            this.Load += new System.EventHandler(this.historiGUI_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datahistoryAll)).EndInit();
            this.pnlCardVisit.ResumeLayout(false);
            this.pnlCardVisit.PerformLayout();
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imgEvents;
        private System.Windows.Forms.Button buckM;
        private System.Windows.Forms.TreeView HistoriTree;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView datahistoryAll;
        private System.Windows.Forms.Label txtEventTitle;
        private System.Windows.Forms.Panel pnlCardVisit;
        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogged;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtWorkerID;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtcarID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioParkingWork;
        private System.Windows.Forms.RadioButton radioParking;
        private System.Windows.Forms.Label label8;
    }
}
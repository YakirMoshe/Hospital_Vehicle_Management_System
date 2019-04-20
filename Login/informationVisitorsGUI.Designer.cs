namespace Login
{
    partial class informationVisitorsGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informationVisitorsGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TabControl();
            this.TpSearch = new System.Windows.Forms.TabPage();
            this.btnHips = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buckM = new System.Windows.Forms.Button();
            this.dataListVisitors = new System.Windows.Forms.DataGridView();
            this.search.SuspendLayout();
            this.TpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListVisitors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(383, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(252, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "מידע וחיפוש מבקרים";
            // 
            // search
            // 
            this.search.Controls.Add(this.TpSearch);
            this.search.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.search.Location = new System.Drawing.Point(284, 53);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search.RightToLeftLayout = true;
            this.search.SelectedIndex = 0;
            this.search.Size = new System.Drawing.Size(463, 205);
            this.search.TabIndex = 1;
            // 
            // TpSearch
            // 
            this.TpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.TpSearch.Controls.Add(this.btnHips);
            this.TpSearch.Controls.Add(this.buttonSearch);
            this.TpSearch.Controls.Add(this.searchid);
            this.TpSearch.Controls.Add(this.label2);
            this.TpSearch.Location = new System.Drawing.Point(4, 24);
            this.TpSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TpSearch.Name = "TpSearch";
            this.TpSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TpSearch.Size = new System.Drawing.Size(455, 177);
            this.TpSearch.TabIndex = 1;
            this.TpSearch.Text = "חיפוש";
            // 
            // btnHips
            // 
            this.btnHips.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHips.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnHips.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHips.Location = new System.Drawing.Point(54, 52);
            this.btnHips.Name = "btnHips";
            this.btnHips.Size = new System.Drawing.Size(150, 33);
            this.btnHips.TabIndex = 33;
            this.btnHips.Text = "הצג פרטי רכב";
            this.btnHips.UseVisualStyleBackColor = false;
            this.btnHips.Click += new System.EventHandler(this.btnHips_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.Location = new System.Drawing.Point(163, 106);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(148, 50);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "חיפוש";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // searchid
            // 
            this.searchid.Location = new System.Drawing.Point(254, 59);
            this.searchid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchid.Name = "searchid";
            this.searchid.Size = new System.Drawing.Size(127, 21);
            this.searchid.TabIndex = 4;
            this.searchid.TextChanged += new System.EventHandler(this.searchid_TextChanged);
            this.searchid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchid_KeyDown);
            this.searchid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyIntNum_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(242, 38);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "חיפוש לפי תעודת זהות:";
            // 
            // buckM
            // 
            this.buckM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buckM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buckM.Location = new System.Drawing.Point(852, 11);
            this.buckM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buckM.Name = "buckM";
            this.buckM.Size = new System.Drawing.Size(151, 33);
            this.buckM.TabIndex = 32;
            this.buckM.Text = "חזרה לתפריט";
            this.buckM.UseVisualStyleBackColor = false;
            this.buckM.Click += new System.EventHandler(this.buckM_Click);
            // 
            // dataListVisitors
            // 
            this.dataListVisitors.AllowUserToOrderColumns = true;
            this.dataListVisitors.AllowUserToResizeColumns = false;
            this.dataListVisitors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataListVisitors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListVisitors.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataListVisitors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataListVisitors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListVisitors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataListVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListVisitors.GridColor = System.Drawing.Color.DimGray;
            this.dataListVisitors.Location = new System.Drawing.Point(13, 260);
            this.dataListVisitors.Margin = new System.Windows.Forms.Padding(4);
            this.dataListVisitors.Name = "dataListVisitors";
            this.dataListVisitors.ReadOnly = true;
            this.dataListVisitors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListVisitors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataListVisitors.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataListVisitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListVisitors.Size = new System.Drawing.Size(989, 349);
            this.dataListVisitors.TabIndex = 33;
            this.dataListVisitors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchAndInfVisitors_CellContentClick);
            this.dataListVisitors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchAndInfVisitors_CellDoubleClick);
            this.dataListVisitors.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataListVisitors_RowPostPaint);
            // 
            // informationVisitorsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1015, 613);
            this.Controls.Add(this.dataListVisitors);
            this.Controls.Add(this.buckM);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "informationVisitorsGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מידע מבקרים";
            this.Load += new System.EventHandler(this.informationVisitorsGUI_Load);
            this.search.ResumeLayout(false);
            this.TpSearch.ResumeLayout(false);
            this.TpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListVisitors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl search;
        private System.Windows.Forms.TabPage TpSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox searchid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buckM;
        private System.Windows.Forms.DataGridView dataListVisitors;
        private System.Windows.Forms.Button btnHips;
    }
}
namespace Login
{
    partial class informationCarGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informationCarGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.searchcar = new System.Windows.Forms.TextBox();
            this.buckM = new System.Windows.Forms.Button();
            this.DGcars = new System.Windows.Forms.DataGridView();
            this.btnHips = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGcars)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(376, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "מידע וחיפוש רכבים";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "הכנס מס\' רכב או ת.ז:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(631, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "הערת רכב:";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNote.Location = new System.Drawing.Point(721, 102);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNote.Size = new System.Drawing.Size(258, 93);
            this.txtNote.TabIndex = 11;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // searchcar
            // 
            this.searchcar.Location = new System.Drawing.Point(170, 91);
            this.searchcar.Margin = new System.Windows.Forms.Padding(4);
            this.searchcar.Name = "searchcar";
            this.searchcar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchcar.Size = new System.Drawing.Size(181, 22);
            this.searchcar.TabIndex = 12;
            this.searchcar.TextChanged += new System.EventHandler(this.searchcar_TextChanged);
            this.searchcar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchcar_KeyDown);
            this.searchcar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyIntNum_KeyPress);
            // 
            // buckM
            // 
            this.buckM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buckM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buckM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buckM.Location = new System.Drawing.Point(832, 11);
            this.buckM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buckM.Name = "buckM";
            this.buckM.Size = new System.Drawing.Size(171, 37);
            this.buckM.TabIndex = 30;
            this.buckM.Text = "חזרה לתפריט";
            this.buckM.UseVisualStyleBackColor = false;
            this.buckM.Click += new System.EventHandler(this.buckM_Click);
            // 
            // DGcars
            // 
            this.DGcars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGcars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGcars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DGcars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGcars.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGcars.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGcars.Location = new System.Drawing.Point(17, 270);
            this.DGcars.Margin = new System.Windows.Forms.Padding(4);
            this.DGcars.Name = "DGcars";
            this.DGcars.ReadOnly = true;
            this.DGcars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGcars.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGcars.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGcars.Size = new System.Drawing.Size(985, 310);
            this.DGcars.TabIndex = 31;
            this.DGcars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGcars_CellContentClick);
            this.DGcars.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGcars_CellContentDoubleClick);
            this.DGcars.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGcars_RowPostPaint);
            // 
            // btnHips
            // 
            this.btnHips.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHips.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnHips.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHips.Location = new System.Drawing.Point(409, 91);
            this.btnHips.Margin = new System.Windows.Forms.Padding(4);
            this.btnHips.Name = "btnHips";
            this.btnHips.Size = new System.Drawing.Size(200, 41);
            this.btnHips.TabIndex = 32;
            this.btnHips.Text = "הצג מידע בעל רכב";
            this.btnHips.UseVisualStyleBackColor = false;
            this.btnHips.Click += new System.EventHandler(this.btnHips_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearch.Location = new System.Drawing.Point(181, 119);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(149, 50);
            this.buttonSearch.TabIndex = 33;
            this.buttonSearch.Text = "חיפוש";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // btnNote
            // 
            this.btnNote.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNote.Location = new System.Drawing.Point(809, 203);
            this.btnNote.Margin = new System.Windows.Forms.Padding(4);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(80, 36);
            this.btnNote.TabIndex = 32;
            this.btnNote.Text = "שמור";
            this.btnNote.UseVisualStyleBackColor = false;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // informationCarGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1015, 613);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.btnHips);
            this.Controls.Add(this.DGcars);
            this.Controls.Add(this.buckM);
            this.Controls.Add(this.searchcar);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "informationCarGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מידע רכבים";
            this.Load += new System.EventHandler(this.informationCarGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGcars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox searchcar;
        private System.Windows.Forms.Button buckM;
        private System.Windows.Forms.DataGridView DGcars;
        private System.Windows.Forms.Button btnHips;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button btnNote;
    }
}
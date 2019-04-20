using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class UserMenuGUI : Form
    {
        private DBSQL dataB;
        private int rowIndex = 0;
        private bool isTrue;

        public UserMenuGUI(DBSQL db) 
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.dataB = db;
        }

        //=======================
        // כפתור הצגת מידע מבקר
        //======================
        private void btnCardVis_Click(object sender, EventArgs e)
        {
            if (txtNumCar.Text != "")
            {
                CardForUser cardvis = new CardForUser(dataB, false, int.Parse(txtNumCar.Text.ToString()));
                cardvis.ShowDialog();
            }
        }

        //===========
        //טבלה להצגה
        //===========
        private void UserMenuGUI_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }
       
        // ================================================
        // פונקציה שמציגה את התוצאה מתוך חיפוש לפי מזהה
        // ================================================
        private void showResult(int carid)
        {
            dgvVisitorToday.Rows.Clear();
            Visitors visitor;
            timer1.Start();
            lblDateTitle.Text = DateTime.Today.ToShortDateString();
            lbltimeTitle.Text = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            visitor = dataB.searchEventBycarId(carid);
            if (visitor.CrId != null)
            {
                addVisitorToListView(visitor);
            }
            else
            {
                MessageBox.Show("לא נמצא", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ==================
        // חיפוש על ידי מזהה
        // ==================
        private void addVisitorToListView(Visitors visitor)
        {
            timer1.Start();
            lblDateTitle.Text = DateTime.Today.ToShortDateString();
            lbltimeTitle.Text = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            Visitors[] vs; // מערך של המבקרים
            vs = dataB.GetEventData(); // מכיל את כל המערך
            dgvVisitorToday.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvVisitorToday.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitorToday.SelectionMode = isTrue == true ? DataGridViewSelectionMode.FullRowSelect : DataGridViewSelectionMode.RowHeaderSelect;
            dgvVisitorToday.AutoResizeColumns();
            dgvVisitorToday.ColumnCount = 8;
            dgvVisitorToday.RowCount = vs.Length; // כמות שורות מהטבלה באקסס
            dgvVisitorToday.Columns[0].HeaderText = "תאריך"; // להציג בעמודות
            dgvVisitorToday.Columns[1].HeaderText = "מספר רכב";
            dgvVisitorToday.Columns[2].HeaderText = "שם פרטי";
            dgvVisitorToday.Columns[3].HeaderText = "שם משפחה";
            dgvVisitorToday.Columns[4].HeaderText = "קבוצה";
            dgvVisitorToday.Columns[5].HeaderText = "הרשאות נתיב";
            dgvVisitorToday.Columns[6].HeaderText = "סטטוס";
            dgvVisitorToday.Columns[7].HeaderText = "הערה";
            dgvVisitorToday.Rows.Add();
            dgvVisitorToday.Rows[rowIndex].Cells[0].Value = visitor.DateChek.ToString();
            dgvVisitorToday.Rows[rowIndex].Cells[1].Value = visitor.CrId.ToString();
            dgvVisitorToday.Rows[rowIndex].Cells[2].Value = visitor.FirstName.ToString();
            dgvVisitorToday.Rows[rowIndex].Cells[3].Value = visitor.LastName.ToString();
            dgvVisitorToday.Rows[rowIndex].Cells[4].Value = visitor.Group.ToString();
            dgvVisitorToday.Rows[rowIndex].Cells[5].Value = visitor.PermissionPaths.ToString();
            dgvVisitorToday.Rows[rowIndex].Cells[6].Value = visitor.StatusVisitor.ToString();
            dgvVisitorToday.Rows[rowIndex].Cells[7].Value = visitor.AdminComment.ToString();
        }

        //====================
        //חיפוש לפי מספר רכב
        //====================
        private void picSearchCar_Click(object sender, EventArgs e)
        {
            btnCardVis.Visible = false;
            if (txtNumCar.Text != "") // בדיקה שהשדה לא ריק
                if (valid.checkcarId(txtNumCar.Text) == true) //  תקינות מספר רכב 7 או 8 ספרות 
                {
                    int search;
                    int flag1 = 0;
                    search = int.Parse(txtNumCar.Text);
                    flag1 = dataB.CheckCarEvenExist(search); // בדיקה אם מספר רכב קיים במערכת
                    if (flag1 == 1) // אם לא קיים
                    {
                        int idcar;
                        if (int.TryParse(txtNumCar.Text, out idcar))
                        {
                            idcar = int.Parse(txtNumCar.Text);
                            showResult(idcar); // קריאה לפונקציה להוצאת נתונים
                        }                       
                        btnCardVis.Visible = true;

                        }                   
                    else
                    {
                        txtNumCar.BackColor = Color.Red;
                        MessageBox.Show("רכב לא קיים במערכת");
                        txtNumCar.BackColor = Color.White;
                        txtNumCar.Clear();
                        txtNumCar.Focus();
                    }
                }
                else
                {
                    txtNumCar.BackColor = Color.Red;
                    MessageBox.Show("מספר רכב לא תקין");
                    txtNumCar.BackColor = Color.White;
                    txtNumCar.Clear();
                    txtNumCar.Focus();
                }
            else
            {
                txtNumCar.BackColor = Color.Red;
                MessageBox.Show("נא להקליד מספר זיהוי");
                txtNumCar.BackColor = Color.White;
                txtNumCar.Focus();
            }
        }

        //===========================================================================
        //לחיצה על מבקר יוסיף מספר רכב לשדה חיפוש לצורך לחיצה על כפתור פרטי מבקר
        //===========================================================================
        private void dgvVisitorToday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = 0;
            if (txtNumCar.Text != null)
            {
                try
            {
                if (e.ColumnIndex == 1)
                {
                    item = int.Parse(dgvVisitorToday.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                else if (e.ColumnIndex == -1)
                {
                    btnCardVis.Visible = false;
                    item = int.Parse(dgvVisitorToday.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                Visitors vis = new Visitors();
                vis = dataB.searchEvenById(item);
                txtNumCar.Text = vis.CrId;
                btnCardVis.Visible = true;
            }
            catch (Exception)
            {       
            }
        }
            else
            {
                if (e.ColumnIndex == -1)
                {
                    btnCardVis.Visible = false;
                    item = int.Parse(dgvVisitorToday.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
            }
        }

        //=========================
        //כפתור חזרה לתפריט הראשי
        //=========================
        private void buckM_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            mainGUI m = new mainGUI(dataB);
            loginGUI l = new loginGUI();
            if (!l.IsManager)
            {
                m.HideMangerButtons();
            }
            m.Show(); // להציג את המסך 
        }

        //=============
        //ריענון לטבלה
        //=============
        public void RefreshLoad()
        {
            timer1.Start();
            lblDateTitle.Text = DateTime.Today.ToShortDateString();
            lbltimeTitle.Text = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            Visitors[] vs; // מערך של המבקרים
            vs = dataB.GetEventData(); // מכיל את כל המערך

            dgvVisitorToday.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvVisitorToday.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitorToday.SelectionMode = isTrue == true ? DataGridViewSelectionMode.FullRowSelect : DataGridViewSelectionMode.RowHeaderSelect;
            dgvVisitorToday.AutoResizeColumns();

            dgvVisitorToday.ColumnCount = 8; // כמות עמודות
            dgvVisitorToday.RowCount = vs.Length; // כמות שורות מהטבלה באקסס
            dgvVisitorToday.Columns[0].HeaderText = "תאריך"; // להציג בעמודות
            dgvVisitorToday.Columns[1].HeaderText = "מספר רכב";
            dgvVisitorToday.Columns[2].HeaderText = "שם פרטי";
            dgvVisitorToday.Columns[3].HeaderText = "שם משפחה";
            dgvVisitorToday.Columns[4].HeaderText = "קבוצה";
            dgvVisitorToday.Columns[5].HeaderText = "הרשאות נתיב";
            dgvVisitorToday.Columns[6].HeaderText = "סטטוס";
            dgvVisitorToday.Columns[7].HeaderText = "הערה";

            int k;
            for (k = 0; k < vs.Length; k++)
            {
                dgvVisitorToday[0, k].Value = vs[k].DateChek;
                dgvVisitorToday[1, k].Value = vs[k].CrId;
               dgvVisitorToday[2, k].Value = vs[k].FirstName;
                dgvVisitorToday[3, k].Value = vs[k].LastName;
              dgvVisitorToday[4, k].Value = vs[k].Group;
                dgvVisitorToday[5, k].Value = vs[k].PermissionPaths;
               dgvVisitorToday[6, k].Value = vs[k].StatusVisitor;
                dgvVisitorToday[7, k].Value = vs[k].AdminComment;
            }
        }

        //=========================
        //אפשרות להקליד רק מספרים
        //=========================
        private void OnlyIntNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //=============================================
        //לאחר לחיצה על כפתור ימני פתיחת כרטיס מבקר
        //=============================================
        private void פרטימבקרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNumCar.Text != "")
            {
                if (valid.checkcarId(txtNumCar.Text) == true) // תקינות מספר רכב 7 או 8 ספרות
                {
                    int search;
                    int flag1 = 0;
                    search = int.Parse(txtNumCar.Text);
                    flag1 = dataB.CheckCarEvenExist(search);
                    if (flag1 == 1) // אם לא קיים
                    {
                        CardForUser cardvis = new CardForUser(dataB, false, int.Parse(txtNumCar.Text.ToString()));
                        cardvis.ShowDialog();
                        btnCardVis.Visible = false;
                        txtNumCar.Clear();
                        return;
                    }
                    else
                    {
                        txtNumCar.BackColor = Color.Red;
                        MessageBox.Show("רכב לא קיים במערכת");
                        txtNumCar.BackColor = Color.White;
                        txtNumCar.Clear();
                        txtNumCar.Focus();
                        return;
                    }
                }
                else
                    txtNumCar.BackColor = Color.Red;
                    MessageBox.Show("מספר רכב לא תקין");
                    txtNumCar.Clear();
                    txtNumCar.BackColor = Color.White;
                    return;
                }
            else
            {
                txtNumCar.BackColor = Color.Red;
                MessageBox.Show("נא להקליד מספר רכב לחיפוש");
                txtNumCar.Clear();
                txtNumCar.BackColor = Color.White;
            }
        }

        //========================
        //כפתור כניסה לבית חולים
        //========================
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInOrOut checkIn = new CheckInOrOut(dataB, true, null);
            checkIn.ShowDialog();
            RefreshLoad();
        }

        //========================
        //כפתור יציאה לבית חולים
        //========================
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckInOrOut checkOut = new CheckInOrOut(dataB, false, null);
            checkOut.ShowDialog();
            RefreshLoad(); // עדכון הטבלה
        }

        //====================================
        //לחיצה על לחצן ימני -->כניסה
        //עידכון מבקר למצב כניסה לבית חולים
        //====================================
        private void כניסהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNumCar.Text != "")
            {
                if (valid.checkcarId(txtNumCar.Text) == true) // בדיקת תקינות מספר רכב 
                {
                    int search;
                    int flag1 = 0;
                    search = int.Parse(txtNumCar.Text);
                    flag1 = dataB.CheckCarEvenExist(search); // בדיקה  שמס רכב קיים
                    if (flag1 == 1) // אם לא קיים
                    {
                        CheckInOrOut checkIn = new CheckInOrOut(dataB, true, txtNumCar.Text.ToString());
                        checkIn.ShowDialog();
                        btnCardVis.Visible = false;
                        txtNumCar.Clear();
                        RefreshLoad();
                        return;
                    }
                    else
                    {
                        txtNumCar.BackColor = Color.Red;
                        MessageBox.Show("רכב לא קיים במערכת");
                        txtNumCar.BackColor = Color.White;
                        txtNumCar.Clear();
                        txtNumCar.Focus();
                        return;
                    }
                }            
            else
                txtNumCar.BackColor = Color.Red;
                MessageBox.Show("מספר רכב לא תקין");
                txtNumCar.Clear();
                txtNumCar.BackColor = Color.White;
                return;
            }
            else
            {
                txtNumCar.BackColor = Color.Red;
                MessageBox.Show("נא להקליד מספר רכב לביצוע הפעולה");
                txtNumCar.Clear();
                txtNumCar.BackColor = Color.White;
            }
        }

        //====================================
        //לחיצה על לחצן ימני -->יציאה
        //עידכון מבקר למצב כניסה לבית חולים
        //====================================
        private void יציאהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNumCar.Text != "")
            {
                if (valid.checkcarId(txtNumCar.Text) == true) // תקינות מספר רכב 7 או 8 ספרות
                {
                    int search;
                    int flag1 = 0;
                    search = int.Parse(txtNumCar.Text);
                    flag1 = dataB.CheckCarEvenExist(search); // בדיקה  שמס רכב קיים
                    if (flag1 == 1) // אם לא קיים
                    {
                        CheckInOrOut checkOut = new CheckInOrOut(dataB, false, txtNumCar.Text.ToString());
                        checkOut.ShowDialog();
                        btnCardVis.Visible = false;
                        txtNumCar.Clear();
                        RefreshLoad();
                        return;
                    }
                    else
                    {
                        txtNumCar.BackColor = Color.Red;
                        MessageBox.Show("רכב לא קיים במערכת");
                        txtNumCar.BackColor = Color.White;
                        txtNumCar.Clear();
                        txtNumCar.Focus();
                        return;
                    }
                }
                else
                    txtNumCar.BackColor = Color.Red;
                MessageBox.Show("מספר רכב לא תקין");
                txtNumCar.Clear();
                txtNumCar.BackColor = Color.White;
                return;
            }

            else
            {
                txtNumCar.BackColor = Color.Red;
                MessageBox.Show("נא להקליד מספר רכב לביצוע הפעולה");
                txtNumCar.Clear();
                txtNumCar.BackColor = Color.White;
            }
        }

       private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbltimeTitle.Text = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        //============================
        // פונקציה שממספרת את השורות
        //============================
        private void dgvVisitorToday_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvVisitorToday.RowHeadersDefaultCellStyle.ForeColor))
            {
                if (dgvVisitorToday.RightToLeft == RightToLeft.No) // בדיקה האם הטבלה מימין לשמאל
                {
                    e.Graphics.DrawString(e.RowIndex.ToString(), e.InheritedRowStyle.Font, b,
                        e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
                }
                else
                {

                    string index = e.RowIndex.ToString();
                    var size = e.Graphics.MeasureString(index, e.InheritedRowStyle.Font);
                    e.Graphics.DrawString(index, e.InheritedRowStyle.Font, b, e.RowBounds.Right - 20 - size.Width,
                        e.RowBounds.Location.Y + 4);
                }
            }
        }

        //=========================================
        //כאשר שדה החיפוש ריק לעשות ריענון לטבלה
        //=========================================
        private void txtNumCar_TextChanged(object sender, EventArgs e)
        {
            if (txtNumCar.Text == "")
            {
                btnCardVis.Visible = false;
                RefreshLoad(); // ריענון
          }
        }
    }
  }
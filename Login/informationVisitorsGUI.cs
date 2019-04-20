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
    public partial class informationVisitorsGUI : Form
    {
        private DBSQL dataB;
        public static string userName;
        private int rowIndex = 0;

        //=====
        //בנאי
        //=====
        public informationVisitorsGUI(DBSQL db)
        {
            InitializeComponent();
            this.dataB = db;
        }

        //==========================
        //יצירת כותרות ושדות לטבלה
        //==========================
        private void informationVisitorsGUI_Load(object sender, EventArgs e)
        {
            Visitors[] vs; // מערך של המבקרים
            vs = dataB.GetVisitorsData(); // מכיל את כל המערך
            dataListVisitors.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataListVisitors.AutoResizeColumns();

            if (vs.Length == 0) //אם אין מבקרים במערכת
            {
                dataListVisitors.DataSource = null;
                this.Close();
                MessageBox.Show("אין רשומים במערכת", "Error");
            }
            else
            {
                dataListVisitors.ColumnCount = 13; // כמות עמודות
                dataListVisitors.RowCount = vs.Length; // כמות שורות מהטבלה באקסס
                dataListVisitors.Columns[0].HeaderText = "תעודת זהות"; // להציג בעמודות
                dataListVisitors.Columns[1].HeaderText = "שם פרטי";
                dataListVisitors.Columns[2].HeaderText = "שם משפחה";
                dataListVisitors.Columns[3].HeaderText = "עיר";
                dataListVisitors.Columns[4].HeaderText = "רחוב";
                dataListVisitors.Columns[5].HeaderText = "מס' טלפון";
                dataListVisitors.Columns[6].HeaderText = "מס' עובד";
                dataListVisitors.Columns[7].HeaderText = "תאריך יצירה";
                dataListVisitors.Columns[8].HeaderText = "סטטוס";
                dataListVisitors.Columns[9].HeaderText = "סוג נתיב";
                dataListVisitors.Columns[10].HeaderText = "בקבוצה";
                dataListVisitors.Columns[11].HeaderText = "הערת מנהל";
                dataListVisitors.Columns[12].HeaderText = "ארגון";

                int k;
                for (k = 0; k < vs.Length; k++)
                {
                    dataListVisitors[0, k].Value = vs[k].ID;
                    dataListVisitors[1, k].Value = vs[k].FirstName;
                    dataListVisitors[2, k].Value = vs[k].LastName;
                    dataListVisitors[3, k].Value = vs[k].City;
                    dataListVisitors[4, k].Value = vs[k].Street;
                    dataListVisitors[5, k].Value = vs[k].PhoneNum;
                    dataListVisitors[6, k].Value = vs[k].WorkerID;
                    dataListVisitors[7, k].Value = vs[k].CreateDate;
                    dataListVisitors[8, k].Value = vs[k].StatusVisitor;
                    dataListVisitors[9, k].Value = vs[k].PermissionPaths;
                    dataListVisitors[10, k].Value = vs[k].Group;
                    dataListVisitors[11, k].Value = vs[k].AdminComment;
                    dataListVisitors[12, k].Value = vs[k].OrganizationBox;
                }
            }
        }

        //===================
        //כפתור חזרה לתפריט
        //==================
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

        //=================================================================================
        //לחיצה אחת על תעודת זהות יוסיף תעודת זהות לשדה חיפוש לצורך כפתור מידע רכב
        //=================================================================================
        private void SearchAndInfVisitors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = 0;
            if (searchid.Text != "")
            {
                try
                {
                    if (e.ColumnIndex == 1)
                    {
                        item = int.Parse(dataListVisitors.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    }
                    else if (e.ColumnIndex == 0)
                    {
                        item = int.Parse(dataListVisitors.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    }
                    Visitors vis = new Visitors();
                    vis = dataB.searchById(item);
                    searchid.Text = vis.ID;
                }
                catch (Exception)
                { }
            }
            else
            {
                if (e.ColumnIndex == 0)
                {
                    item = int.Parse(dataListVisitors.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    Visitors vis = new Visitors();
                    vis = dataB.searchById(item);
                    searchid.Text = vis.ID;

                }
              
            }
        }    

        // ==========================
        //רענון רשימה לאחר עידכונים
        // ==========================
        public void refreshListView()
        {
            Visitors[] vs; // מערך של המבקרים
            vs = dataB.GetVisitorsData(); // מכיל את כל המערך
            dataListVisitors.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataListVisitors.AutoResizeColumns();

            if (vs.Length == 0) //אם אין מבקרים במערכת
            {
                dataListVisitors.DataSource = null;
                this.Close();
                MessageBox.Show("אין רשומים במערכת", "Error");
            }
            else
            {
                dataListVisitors.ColumnCount = 13; // כמות עמודות
                dataListVisitors.RowCount = vs.Length; // כמות שורות מהטבלה באקסס
                dataListVisitors.Columns[0].HeaderText = "תעודת זהות"; // להציג בעמודות
                dataListVisitors.Columns[1].HeaderText = "שם פרטי";
                dataListVisitors.Columns[2].HeaderText = "שם משפחה";
                dataListVisitors.Columns[3].HeaderText = "עיר";
                dataListVisitors.Columns[4].HeaderText = "רחוב";
                dataListVisitors.Columns[5].HeaderText = "מס' טלפון";
                dataListVisitors.Columns[6].HeaderText = "מס' עובד";
                dataListVisitors.Columns[7].HeaderText = "תאריך יצירה";
                dataListVisitors.Columns[8].HeaderText = "סטטוס";
                dataListVisitors.Columns[9].HeaderText = "סוג נתיב";
                dataListVisitors.Columns[10].HeaderText = "בקבוצה";
                dataListVisitors.Columns[11].HeaderText = "הערת מנהל";
                dataListVisitors.Columns[12].HeaderText = "ארגון";

                int k;
                for (k = 0; k < vs.Length; k++)
                {
                    dataListVisitors[0, k].Value = vs[k].ID;
                    dataListVisitors[1, k].Value = vs[k].FirstName;
                    dataListVisitors[2, k].Value = vs[k].LastName;
                    dataListVisitors[3, k].Value = vs[k].City;
                    dataListVisitors[4, k].Value = vs[k].Street;
                    dataListVisitors[5, k].Value = vs[k].PhoneNum;
                    dataListVisitors[6, k].Value = vs[k].WorkerID;
                    dataListVisitors[7, k].Value = vs[k].CreateDate;
                    dataListVisitors[8, k].Value = vs[k].StatusVisitor;
                    dataListVisitors[9, k].Value = vs[k].PermissionPaths;
                    dataListVisitors[10, k].Value = vs[k].Group;
                    dataListVisitors[11, k].Value = vs[k].AdminComment;
                    dataListVisitors[12, k].Value = vs[k].OrganizationBox;
                }
            }
        }

        // ================================================
        // פונקציה שמציגה את התוצאה מתוך חיפוש לפי מזהה
        // ================================================
        private void showResult(int ID)
        {
            dataListVisitors.Rows.Clear();
            Visitors visitor;
            visitor = dataB.search(ID);
            if (visitor.ID != null)
            {
                addVisitorToListView(visitor);
            }
            else
            {
                MessageBox.Show("לא נמצא", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //============================
        // פונקציה שממספרת את השורות
        //============================
        private void dataListVisitors_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataListVisitors.RowHeadersDefaultCellStyle.ForeColor))
            {
                if (dataListVisitors.RightToLeft == RightToLeft.No) // בדיקה האם הטבלה מימין לשמאל
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

        // ==================
        // חיפוש על ידי מזהה
        // ==================
        private void addVisitorToListView(Visitors visitor)
        {
            Visitors[] vs; // מערך של המבקרים
            vs = dataB.GetVisitorsData(); // מכיל את כל המערך
            dataListVisitors.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataListVisitors.AutoResizeColumns();
            dataListVisitors.ColumnCount = 13; // כמות עמודות
            dataListVisitors.RowCount = vs.Length; // כמות שורות מהטבלה באקסס
            dataListVisitors.Columns[0].HeaderText = "תעודת זהות"; // להציג בעמודות
            dataListVisitors.Columns[1].HeaderText = "שם פרטי";
            dataListVisitors.Columns[2].HeaderText = "שם משפחה";
            dataListVisitors.Columns[3].HeaderText = "עיר";
            dataListVisitors.Columns[4].HeaderText = "רחוב";
            dataListVisitors.Columns[5].HeaderText = "מס' טלפון";
            dataListVisitors.Columns[6].HeaderText = "מס' עובד";
            dataListVisitors.Columns[7].HeaderText = "תאריך יצירה";
            dataListVisitors.Columns[8].HeaderText = "סטטוס";
            dataListVisitors.Columns[9].HeaderText = "סוג נתיב";
            dataListVisitors.Columns[10].HeaderText = "בקבוצה";
            dataListVisitors.Columns[11].HeaderText = "הערת מנהל";
            dataListVisitors.Columns[12].HeaderText = "ארגון";
            dataListVisitors.Rows.Add();
            dataListVisitors.Rows[rowIndex].Cells[0].Value = visitor.ID.ToString();
            dataListVisitors.Rows[rowIndex].Cells[1].Value = visitor.FirstName.ToString();
            dataListVisitors.Rows[rowIndex].Cells[2].Value = visitor.LastName.ToString();
            dataListVisitors.Rows[rowIndex].Cells[3].Value = visitor.City.ToString();
            dataListVisitors.Rows[rowIndex].Cells[4].Value = visitor.Street.ToString();
            dataListVisitors.Rows[rowIndex].Cells[5].Value = visitor.PhoneNum.ToString();
            dataListVisitors.Rows[rowIndex].Cells[6].Value = visitor.WorkerID.ToString();
            dataListVisitors.Rows[rowIndex].Cells[7].Value = visitor.CreateDate.ToShortDateString();
            dataListVisitors.Rows[rowIndex].Cells[8].Value = visitor.StatusVisitor.ToString();
            dataListVisitors.Rows[rowIndex].Cells[9].Value = visitor.PermissionPaths.ToString();
            dataListVisitors.Rows[rowIndex].Cells[10].Value = visitor.Group.ToString();
            dataListVisitors.Rows[rowIndex].Cells[11].Value = visitor.AdminComment.ToString();
            dataListVisitors.Rows[rowIndex].Cells[12].Value = visitor.OrganizationBox.ToString();
        }

        //==============================
        //כפתור חיפוש מבקר על ידי מזהה
        //==============================
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (searchid.Text != "")
                if (valid.checkId(searchid.Text) == true) // בדיקת תקינות ת.ז
                {
                    dataListVisitors.Rows.Clear();
                    rowIndex = 0;
                    int search;
                    int flag1 = 0;

                    search = int.Parse(searchid.Text);
                    flag1 = dataB.CheckVisitorExist(search); // בדיקה אם משתמש קיים במערכת
                    if (flag1 == 1)
                    {
                        int idOrVis;
                        if (int.TryParse(searchid.Text, out idOrVis))
                        {
                            idOrVis = int.Parse(searchid.Text);
                            showResult(idOrVis); // קריאה לפונקציה להוצאת נתונים
                        }
                    }
                    else
                    {
                        searchid.BackColor = Color.Red;
                        MessageBox.Show("מבקר לא קיים במערכת");
                        searchid.BackColor = Color.White;
                        searchid.Clear();
                    }
                }
                else
                {
                    searchid.BackColor = Color.Red;
                    MessageBox.Show("תעודת זהות לא תקינה");
                    searchid.BackColor = Color.White;
                    searchid.Clear();
                }
            else
            {
                searchid.BackColor = Color.Red;
                MessageBox.Show("נא להקליד ת.ז לחיפוש");
                searchid.BackColor = Color.White;
                searchid.Focus();
            }
        }

        //=================================================
        //כאשר נלחץ על תעודת זהות פעמיים יפתח פרטי הרכב
        //=================================================
        private void SearchAndInfVisitors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (searchid.Text != "")
            {
                CarCard CarInfo = new CarCard(dataB, false, int.Parse(dataListVisitors.Rows[e.RowIndex].Cells[0].Value.ToString()));
                loginGUI l = new loginGUI();
                if (!l.IsManager) // בדיקת התחברות מנהל או משתמש
                {
                    CarInfo.HideMangerButtonsUpdate();
                    CarInfo.ShowDialog();
                    return;
                }
                CarInfo.ShowDialog();//מצב מנהל
            }
            else
            {
                searchid.BackColor = Color.Red;
                MessageBox.Show("נא להקליד ת.ז לחיפוש");
                searchid.BackColor = Color.White;
                searchid.Focus();
            }
        }

        //======================
        //כפתור הצגת מידע הרכב
        //======================
        private void btnHips_Click(object sender, EventArgs e)
        {
            int search;
            int flag1 = 0;
            if (searchid.Text != "" && valid.checkId(searchid.Text) == true) // בדיקה ששדה לא ריק ותעודת זהות תקין
            {
                search = int.Parse(searchid.Text);
                flag1 = dataB.CheckVisitorExist(search); // בדיקה אם משתמש קיים במערכת
                if (flag1 == 1)
                {
                    CarCard c = new CarCard(dataB, false, int.Parse(searchid.Text.ToString()));
                    loginGUI l = new loginGUI();
                    if (!l.IsManager) // בדיקת התחברות מנהל או משתמש
                    {
                        c.HideMangerButtonsUpdate();
                        c.ShowDialog();
                        return;
                    }
                    c.ShowDialog(); //מצב מנהל
                }
                else
                {
                    searchid.BackColor = Color.Red;
                    MessageBox.Show("מבקר לא קיים במערכת");
                    searchid.BackColor = Color.White;
                    searchid.Clear();
                    searchid.Focus();
                }
            }
            else
            {
                searchid.BackColor = Color.Red;
                MessageBox.Show("נא להקליד ת.ז שקיים במערכת");
                searchid.BackColor = Color.White;
                searchid.Clear();
                searchid.Focus();
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

        //=========================================================
        //כאשר שדה חיפוש ריק ריענון הטבלה מחדש להצגת כל המבקרים
        //=========================================================
        private void searchid_TextChanged(object sender, EventArgs e)
        {
            if (searchid.Text == "")
            {
                refreshListView(); // ריענון
            }
        }

        //=============================================
        //הפעל כפתור חיפוש בעת לחיצה על אינטר במקלדת
        //=============================================
        private void searchid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch.PerformClick();
            }
        }
    }
}



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
    public partial class informationCarGUI : Form
    {
        private DBSQL dataB;
        private int item = 0;
        private int rowIndex = 0;

        //=====
        //בנאי
        //=====
        public informationCarGUI(DBSQL db)
        {
            InitializeComponent();
            this.dataB = db;
        }

        //==========================
        //יצירת כותרות ושדות לטבלה
        //==========================
        private void informationCarGUI_Load(object sender, EventArgs e)
        {
            Cars[] cs; // מערך של רכבים
            cs = dataB.GetCarsData(); // מכיל את כל המערך

            if (cs.Length == 0) //אם אין מבקרים במערכת
            {
                DGcars.DataSource = null;
                this.Close();
                MessageBox.Show("אין רשומים במערכת", "Error");
            }
            else
            {
                DGcars.ColumnCount = 5; // כמות עמודות
                DGcars.RowCount = dataB.GetCarsNumber(); // כמות שורות מהטבלה באקסס
                DGcars.Columns[0].HeaderText = "ת.ז בעל רכב";
                DGcars.Columns[1].HeaderText = "מספר רכב";
                DGcars.Columns[2].HeaderText = "סוג הרכב";
                DGcars.Columns[3].HeaderText = "שנת יצור";
                DGcars.Columns[4].HeaderText = "צבע";
                int k;
                for (k = 0; k < cs.Length; k++)
                {
                    DGcars[0, k].Value = cs[k].IDVis;
                    DGcars[1, k].Value = cs[k].CarId;
                    DGcars[2, k].Value = cs[k].TypeCar;
                    DGcars[3, k].Value = cs[k].YearCar;
                    DGcars[4, k].Value = cs[k].ColorCar;
                }
            }
        }

        //==================================
        //כפתור חזרה אחורה לתפריט
        //==================================
        private void buckM_Click(object sender, EventArgs e)
        {
            this.Hide(); // כאשר נלחץ על כפתור כניסה נכנס למסך ראשי
            mainGUI m = new mainGUI(dataB);
            loginGUI l = new loginGUI();
            if (!l.IsManager)
            {
                m.HideMangerButtons();
            }
            m.Show(); // להציג את המסך 
        }

        // ==================
        // חיפוש על ידי מזהה
        // ==================
        private void addCarToListView(Cars car)
        {
            Cars[] cs; // מערך של רכבים
            cs = dataB.GetCarsData(); // מכיל את כל המערך
            DGcars.ColumnCount = 5; // כמות עמודות
            DGcars.RowCount = dataB.GetCarsNumber(); // כמות שורות מהטבלה באקסס
            DGcars.Columns[0].HeaderText = "ת.ז בעל רכב";
            DGcars.Columns[1].HeaderText = "מספר רכב";
            DGcars.Columns[2].HeaderText = "סוג הרכב";
            DGcars.Columns[3].HeaderText = "שנת יצור";
            DGcars.Columns[4].HeaderText = "צבע";
            DGcars.Rows.Add();
            DGcars.Rows[rowIndex].Cells[0].Value = car.IDVis.ToString();
            DGcars.Rows[rowIndex].Cells[1].Value = car.CarId.ToString();
            DGcars.Rows[rowIndex].Cells[2].Value = car.TypeCar.ToString();
            DGcars.Rows[rowIndex].Cells[3].Value = car.YearCar.ToString();
            DGcars.Rows[rowIndex].Cells[4].Value = car.ColorCar.ToString();
        }

        // ====================================================
        // פונקציה שמציגה את התוצאה מתוך חיפוש לפי מזהה רכב
        // ====================================================
        private void showResult(int idcar)
        {
            DGcars.Rows.Clear();
            Cars car;
            car = dataB.searchCar(idcar);
            if (car.CarId != null)
            {
                addCarToListView(car);
            }
            else
            {
                MessageBox.Show("לא נמצא", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ====================================================
        // פונקציה שמציגה את התוצאה מתוך חיפוש לפי מזהה ת.ז
        // ====================================================
        private void showResultid(int idvis)
        {
            DGcars.Rows.Clear();
            Cars car;
            car = dataB.searchCarvis(idvis);
            if (car.IDVis != null)
            {
                addCarToListView(car);
            }
            else
            {
                MessageBox.Show("לא נמצא", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //=====================================================================
        //כפתור לחיפוש רכבים בטבלה או על ידי תעודת זהות או על ידי מספר רכב
        //=====================================================================
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            txtNote.Text = null;
            if (searchcar.Text != "")
                if (valid.checkcarId(searchcar.Text) == true) //בידקת תקינות מספר רכב
                {
                    DGcars.Rows.Clear();
                    rowIndex = 0;

                    int search;
                    int flag1 = 0;

                    search = int.Parse(searchcar.Text);
                    flag1 = dataB.CheckCarExist(search);
                    if (flag1 == 1)
                    {
                        int idcar;
                        if (int.TryParse(searchcar.Text, out idcar))
                        {
                            idcar = int.Parse(searchcar.Text);
                            showResult(idcar); // קריאה לפונקציה להוצאת נתונים
                        }
                    }
                    else
                    {
                        searchcar.BackColor = Color.Red;
                        MessageBox.Show("רכב לא קיים במערכת");
                        searchcar.BackColor = Color.White;
                        searchcar.Clear();
                        searchcar.Focus();
                        return;
                    }
                    return;
                }

            //=========================
            //חיפוש על ידי תעודת זהות
            //=========================
            if (searchcar.Text != "")
            {
                if (valid.checkId(searchcar.Text) == true) // בדיקת תקינות על ידי תעודת זהות
                {
                    int search;
                    int numRow;
                    int flag1 = 0;

                    search = int.Parse(searchcar.Text);
                    flag1 = dataB.CheckCarExistbyid(search);
                    if (flag1 == 1)
                    {
                        int idcarvis;
                        if (int.TryParse(searchcar.Text, out idcarvis))
                        {
                            idcarvis = int.Parse(searchcar.Text);
                            showResultid(idcarvis); // קריאה לפונקציה להוצאת נתונים
                        }
                    }                                 
                    else
                    {
                        searchcar.BackColor = Color.Red;
                        MessageBox.Show("רכב לא קיים במערכת");
                        searchcar.BackColor = Color.White;
                        searchcar.Clear();
                        searchcar.Focus();
                    }

                }
                else
                {
                    searchcar.BackColor = Color.Red;
                    MessageBox.Show("מספר זיהוי לא תקין");
                    searchcar.BackColor = Color.White;
                    searchcar.Clear();
                    searchcar.Focus();
                }
            }
            else
            {
                searchcar.BackColor = Color.Red;
                MessageBox.Show("נא להקליד מספר זיהוי");
                searchcar.BackColor = Color.White;
                searchcar.Focus();
            }
        }


        //===================================================
        //כאשר נלחץ על תעודת זהות פעמיים יפתח פרטי בעל הרכב
        //===================================================
        private void DGcars_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CardGUI visInfo = new CardGUI(dataB, false, int.Parse(DGcars.Rows[e.RowIndex].Cells[0].Value.ToString()));
            loginGUI l = new loginGUI();
            if (!l.IsManager) // בדיקת התחברות מנהל או משתמש
            {
                visInfo.HideMangerButtonsUpdate();
                visInfo.ShowDialog();
                return;
            }
            visInfo.ShowDialog();//מצב מנהל

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

        //=======================
        //כפתור שמירת הערה לרכב
        //=======================
        private void btnNote_Click(object sender, EventArgs e)
        {
            int search;
            int flag1 = 0;
            if (searchcar.Text != "" && valid.checkId(searchcar.Text) == true) // בדיקה ששדה לא ריק ותעודת זהות תקין
            {
                search = int.Parse(searchcar.Text);
                flag1 = dataB.CheckVisitorExist(search); // בדיקה אם משתמש קיים במערכת
                if (flag1 == 1)
                {

                UpdatNote(searchcar.Text);
            }
            else
            {
                searchcar.BackColor = Color.Red;
                MessageBox.Show("מבקר לא קיים במערכת");
                searchcar.BackColor = Color.White;
                searchcar.Clear();
            }
        }    
            else
            {
                searchcar.BackColor = Color.Red;
                MessageBox.Show("נא להקליד מספר שקיים במערכת");
                searchcar.BackColor = Color.White;
                searchcar.Clear();
            }
        }

        //===================================
        //פונקציה לשמירת הערה בבסיס נתונים
        //===================================
        private void UpdatNote(string uv)
        {
            string ID = searchcar.Text;
            string AdminComment = txtNote.Text;

            Visitors visitor = new Visitors();
            visitor.ID = searchcar.Text;
            if (visitor.AdminComment == "")
                visitor.AdminComment = txtNote.Text;
            else
                visitor.AdminComment = txtNote.Text;
            dataB.UpdatNote(visitor, true);

            MessageBox.Show("הערה נשמרה");
        }

        //==================================================================================
        //לחיצה אחת על תעודת זהות יוסיף תעודת זהות לשדה חיפוש לצורך רשימת הערה על הרכב
        //==================================================================================
        private void DGcars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = 0;
            if (searchcar.Text != "")
            {
                try
                {


                    if (e.ColumnIndex == 1)
                    {
                        item = int.Parse(DGcars.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    }
                    else if (e.ColumnIndex == 0)
                    {
                        item = int.Parse(DGcars.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    }
                    Visitors vis = new Visitors();
                    vis = dataB.searchById(item);
                    searchcar.Text = vis.ID;
                    txtNote.Text = vis.AdminComment;
                }
                catch (Exception)
                { }
            }
            else
            {
                if (e.ColumnIndex == 0)
                {
                    item = int.Parse(DGcars.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    Visitors vis = new Visitors();
                    vis = dataB.searchById(item);
                    searchcar.Text = vis.ID;
                    txtNote.Text = vis.AdminComment;
                }
            }
        }


        //==========================
        //כפתור הצגת מידע בעל הרכב
        //==========================
        private void btnHips_Click(object sender, EventArgs e)
        {
            int search;
            int flag1 = 0;
            if (searchcar.Text != "" && valid.checkId(searchcar.Text) == true) // בדיקה ששדה לא ריק ותעודת זהות תקין
            {
                search = int.Parse(searchcar.Text);
                flag1 = dataB.CheckVisitorExist(search); // בדיקה אם משתמש קיים במערכת
                if (flag1 == 1)
                {
                    CardGUI CarInfo = new CardGUI(dataB, false, int.Parse(searchcar.Text.ToString()));
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
                    searchcar.BackColor = Color.Red;
                    MessageBox.Show("מבקר לא קיים במערכת");
                    searchcar.BackColor = Color.White;
                    searchcar.Clear();
                }
            }
            else
            {
                searchcar.BackColor = Color.Red;
                MessageBox.Show("נא להקליד מספר תעודת זהות תקין להצגת כרטיסיית מבקר");
                searchcar.BackColor = Color.White;
                searchcar.Clear();
            }
        }

        //=============
        //ריענון לטבלה
        //=============
        private void RefreshLoad()
        {
            DGcars.Rows.Clear();
            Cars[] cs; // מערך של רכבים
            cs = dataB.GetCarsData(); // מכיל את כל המערך

            if (cs.Length == 0) //אם אין מבקרים במערכת
            {
                DGcars.DataSource = null;
                this.Close();
                MessageBox.Show("אין רשומים במערכת", "Error");
            }
            else
            {
                DGcars.ColumnCount = 5; // כמות עמודות
                DGcars.RowCount = dataB.GetVisitorsNumber(); // כמות שורות מהטבלה באקסס
                DGcars.Columns[0].HeaderText = "ת.ז בעל רכב"; // להציג בעמודות
                DGcars.Columns[1].HeaderText = "מספר רכב";
                DGcars.Columns[2].HeaderText = "סוג הרכב";
                DGcars.Columns[3].HeaderText = "שנת יצור";
                DGcars.Columns[4].HeaderText = "צבע";
                int k;
                for (k = 0; k < cs.Length; k++)
                {
                    DGcars[0, k].Value = cs[k].IDVis;
                    DGcars[1, k].Value = cs[k].CarId;
                    DGcars[2, k].Value = cs[k].TypeCar;
                    DGcars[3, k].Value = cs[k].YearCar;
                    DGcars[4, k].Value = cs[k].ColorCar;
                }
            }
        }

        //=========================================
        //כאשר שדה החיפוש ריק לעשות ריענון לטבלה
        //=========================================
        private void searchcar_TextChanged(object sender, EventArgs e)
        {
            if (searchcar.Text == "")
            {
                txtNote.Text = null;
                RefreshLoad(); // ריענון
            }
        }

        //============================
        // פונקציה שממספרת את השורות
        //============================
        private void DGcars_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(DGcars.RowHeadersDefaultCellStyle.ForeColor))
            {
                if (DGcars.RightToLeft == RightToLeft.No) // בדיקה האם הטבלה מימין לשמאל
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

        //=============================================
        //הפעל כפתור חיפוש בעת לחיצה על אינטר במקלדת
        //=============================================
        private void searchcar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch.PerformClick();
            }
        }
    }
 }

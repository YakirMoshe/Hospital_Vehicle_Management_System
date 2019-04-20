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
    public partial class editVisitCar : Form
    {
        private DBSQL dataB;

        public editVisitCar(DBSQL db)
        {
            InitializeComponent();
            this.dataB = db;
        }

        //============
        //יצירת הטבלה
        //============
        private void editVisitCar_Load(object sender, EventArgs e)
        {
            txtsearchVis.Focus();
            Visitors[] vs; // מערך של המבקרים
            vs = dataB.GetVisitorsData(); // מכיל את כל המערך

            dataEdit.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataEdit.AutoResizeColumns();

            if (vs.Length == 0) //אם אין מבקרים במערכת
            {
                dataEdit.DataSource = null;
                this.Close();
                MessageBox.Show("אין רשומים במערכת", "Error");
            }
            else
            {
                dataEdit.ColumnCount = 13; // כמות עמודות
                dataEdit.RowCount = vs.Length; // כמות שורות מהטבלה באקסס
                dataEdit.Columns[0].HeaderText = "תעודת זהות"; // להציג בעמודות
                dataEdit.Columns[1].HeaderText = "שם פרטי";
                dataEdit.Columns[2].HeaderText = "שם משפחה";
                dataEdit.Columns[3].HeaderText = "עיר";
                dataEdit.Columns[4].HeaderText = "רחוב";
                dataEdit.Columns[5].HeaderText = "מס' טלפון";
                dataEdit.Columns[6].HeaderText = "מס' עובד";
                dataEdit.Columns[7].HeaderText = "תאריך יצירה";
                dataEdit.Columns[8].HeaderText = "סטטוס";
                dataEdit.Columns[9].HeaderText = "סוג נתיב";
                dataEdit.Columns[10].HeaderText = "בקבוצה";
                dataEdit.Columns[11].HeaderText = "הערת מנהל";
                dataEdit.Columns[12].HeaderText = "ארגון";

                int k;
                for (k = 0; k < vs.Length; k++)
                {
                    dataEdit[0, k].Value = vs[k].ID;
                    dataEdit[1, k].Value = vs[k].FirstName;
                    dataEdit[2, k].Value = vs[k].LastName;
                    dataEdit[3, k].Value = vs[k].City;
                    dataEdit[4, k].Value = vs[k].Street;
                    dataEdit[5, k].Value = vs[k].PhoneNum;
                    dataEdit[6, k].Value = vs[k].WorkerID;
                    dataEdit[7, k].Value = vs[k].CreateDate;
                    dataEdit[8, k].Value = vs[k].StatusVisitor;
                    dataEdit[9, k].Value = vs[k].PermissionPaths;
                    dataEdit[10, k].Value = vs[k].Group;
                    dataEdit[11, k].Value = vs[k].AdminComment;
                    dataEdit[12, k].Value = vs[k].OrganizationBox;
                }
            }
        }

        //========================================
        //כפתור יציאה  ניקוי השדות ונעילת הפאנל
        //========================================
        private void exitp_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(panel1);
            panel1.Enabled = false;
        }

        //=======================
        //לחיצה על כפתור עריכה
        //=======================
        private void editp_Click(object sender, EventArgs e)
        {
            if (iDp.Text != "")
            {
                panel1.Enabled = true;
                UpdateVisitors("עריכה");
                RefreshLoad(); // ריענון
            }
            else
            {
                panel1.Enabled = false;
                MessageBox.Show("נא ללחוץ לחיצה כפולה על תעודת זהות לעריכת פרטים או על ידי חיפוש", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsearchVis.Focus();
            }
        }

        //======================
        //לחיצה על כפתור מחיקה
        //======================
        private void delp_Click(object sender, EventArgs e)
        {
            if (iDp.Text != "")
            {
                if (MessageBox.Show("אתה בטוח שאתה רוצה למחוק את המבקר ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    UpdateVisitors("מחיקה");
                panel1.Enabled = false;
                RefreshLoad(); // ריענון
            }
            else
            {
                txtsearchVis.BackColor = Color.Red;
                MessageBox.Show("לא נבחר מבקר למחיקה", "Error");
                txtsearchVis.BackColor = Color.White;
                txtsearchVis.Focus();
            }
        }

        //=====================================================================
        //כפתור חיפוש כאשר נלחץ יפתח כרטיס המבקר לעידכון פרטים או למחיקה .
        //=====================================================================
        private void btnsearcVis_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            if (txtsearchVis.Text != "")
            {
                if (valid.checkId(txtsearchVis.Text) == true) // בדיקת תקינות ת.ז
                { // פרטי מבקר
                    Visitors visitors = new Visitors();
                    visitors = dataB.searchVisitById(txtsearchVis.Text); // בדיקה שת.ז קיים
                    if (visitors != null)
                    {
                        groupp.Text = visitors.Group;
                        iDp.Text = visitors.ID;
                        firstNamep.Text = visitors.FirstName;
                        lastNamep.Text = visitors.LastName;
                        phoneNump.Text = visitors.PhoneNum;
                        cityp.Text = visitors.City;
                        streetp.Text = visitors.Street;
                        workIDp.Text = visitors.WorkerID;
                        statusVisitorp.Text = visitors.StatusVisitor;
                        organizationBoxp.Text = visitors.OrganizationBox;
                        adminCommentp.Text = visitors.AdminComment;
                        carIDp.Text = visitors.CrId;
                    }
                    //פרטי רכב
                    Cars carvis = new Cars();
                    carvis = dataB.searchCarById(txtsearchVis.Text);
                    if (carvis != null)
                    {
                        iDp.Text = carvis.IDVis;
                        carIDp.Text = carvis.CarId;
                        typeCarp.Text = carvis.TypeCar;
                        yearCarp.Text = carvis.YearCar;
                        colorCarp.Text = carvis.ColorCar;
                        //נתיבי כניסה
                        if (visitors.PermissionPaths == "חניון בית חולים")
                        {
                            radioParking.Checked = true;
                            radioParkingWork.Checked = false;
                        }

                        else
                        {
                            radioParking.Checked = false;
                            radioParkingWork.Checked = true;
                        }
                        btnsearcVis.Enabled = true;
                    }
                    else
                    {
                        txtsearchVis.BackColor = Color.Red;
                        MessageBox.Show("מבקר לא קיים במערכת");
                        txtsearchVis.BackColor = Color.White;
                        panel1.Enabled = false;
                        txtsearchVis.Clear();
                        txtsearchVis.Focus();
                    }
                }           
            else
            {
                    txtsearchVis.BackColor = Color.Red;
                    MessageBox.Show("תעודת זהות לא תקינה");
                    txtsearchVis.BackColor = Color.White;
                    txtsearchVis.Clear();
                    txtsearchVis.Focus();
                }
        }
              else
            {
                txtsearchVis.BackColor = Color.Red;
                MessageBox.Show("לא הוקלד מספר תעודת זהות");
                txtsearchVis.BackColor = Color.White;
                txtsearchVis.Focus();
            }
        }

        //======================
        //עדכון פרטי מבקר
        //======================
        private void UpdateVisitors(string uv)
        {
            //בדיקה שכל השדות חובה מולאו בהצלחה
            bool flagState = true;
            if (String.IsNullOrEmpty(groupp.Text))
            {
                groupp.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(iDp.Text))
            {
                iDp.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(firstNamep.Text))
            {
                firstNamep.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(lastNamep.Text))
            {
                lastNamep.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(phoneNump.Text))
            {
                phoneNump.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(cityp.Text))
            {
                cityp.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(streetp.Text))
            {
                streetp.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(statusVisitorp.Text))
            {
                statusVisitorp.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(carIDp.Text))
            {
                carIDp.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(typeCarp.Text))
            {
                typeCarp.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(yearCarp.Text))
            {
                yearCarp.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(colorCarp.Text))
            {
                colorCarp.BackColor = Color.Red;
                flagState = false;
            }
            if (flagState == true)
            {
                string Group = groupp.Text;
                string ID = iDp.Text;
                string FirstName = firstNamep.Text;
                string LastName = lastNamep.Text;
                string PhoneNum = phoneNump.Text;
                string City = cityp.Text;
                string Street = streetp.Text;
                string WorkerID = workIDp.Text;
                string StatusForName = statusVisitorp.Text;
                string OrganizationBox = organizationBoxp.Text;
                string AdminComment = adminCommentp.Text;
                string vispw = "";
                string CrId = carIDp.Text;
                string IDVis = iDp.Text;
                string CarId = carIDp.Text;
                string TypeCar = typeCarp.Text;
                string YearCar = yearCarp.Text;
                string ColorCar = colorCarp.Text;

                bool[] err = new bool[11];
                for (int i = 0; i < err.Length; i++)
                    err[i] = true;
                if (radioParking.Checked || radioParkingWork.Checked)
                {
                    if (radioParkingWork.Checked)
                        vispw = "חניון בית חולים";
                    else
                        vispw = "חניון סגל";
                }
                //בדיקת תקינות קלט פלט של הנתונים
                err[0] = valid.checkId(ID);
                err[1] = valid.checkfirstName(FirstName);
                err[2] = valid.checklastName(LastName);
                err[3] = valid.checkcity(City);
                err[4] = valid.checkstreet(Street);
                err[5] = valid.checkPhone(PhoneNum);
                err[6] = valid.checkworkerID(WorkerID);
                err[7] = valid.checkcarId(CrId);
                err[8] = valid.checktypeCar(TypeCar);
                err[9] = valid.checkyearCar(YearCar);
                err[10] = valid.checkcolorCar(ColorCar);
                bool flg = true;
                for (int i = 0; i < err.Length; i++)
                {
                    if (err[i] == false) // אם הנתונים לא תקינים הצג שגיאות מתאימות
                    {
                        switch (i)
                        {
                            case 0:
                                iDp.BackColor = Color.Red;
                                MessageBox.Show("תעודת זהות לא תקינה");
                                iDp.BackColor = Color.White;
                                break;
                            case 1:
                                firstNamep.BackColor = Color.Red;
                                MessageBox.Show("שם פרטי שגוי");
                                firstNamep.BackColor = Color.White;
                                break;
                            case 2:
                                lastNamep.BackColor = Color.Red;
                                MessageBox.Show("שם משפחה שגוי");
                                lastNamep.BackColor = Color.White;
                                break;
                            case 3:
                                cityp.BackColor = Color.Red;
                                MessageBox.Show("רשום עיר מחדש");
                                cityp.BackColor = Color.White;
                                break;
                            case 4:
                                streetp.BackColor = Color.Red;
                                MessageBox.Show("רשום רחוב מחדש");
                                streetp.BackColor = Color.White;
                                break;
                            case 5:
                                phoneNump.BackColor = Color.Red;
                                MessageBox.Show("מספר טלפון חייב להכיל 10 ספרות");
                                phoneNump.BackColor = Color.White;
                                break;
                            case 6:
                                workIDp.BackColor = Color.Red;
                                MessageBox.Show("מספר עובד חייב להכיל 5 ספרות");
                                workIDp.BackColor = Color.White;
                                break;
                            case 7:
                                carIDp.BackColor = Color.Red;
                                MessageBox.Show("מס רכב חייב להכיל 7 או 8 ספרות");
                                carIDp.BackColor = Color.White;
                                break;
                            case 8:
                                typeCarp.BackColor = Color.Red;
                                MessageBox.Show("סוג רכב לא תקין");
                                typeCarp.BackColor = Color.White;
                                break;
                            case 9:
                                yearCarp.BackColor = Color.Red;
                                MessageBox.Show("שנת יצור חייב להכיל 4 ספרות");
                                yearCarp.BackColor = Color.White;
                                break;
                            case 10:
                                colorCarp.BackColor = Color.Red;
                                MessageBox.Show("צבע שגוי");
                                colorCarp.BackColor = Color.White;
                                break;
                        }
                        flg = false;
                    }
                }
                if (flg == true)
                { 
                    Visitors visitor = new Visitors();
                    visitor.ID = iDp.Text;
                    visitor.FirstName = firstNamep.Text;
                    visitor.LastName = lastNamep.Text;
                    visitor.City = cityp.Text;
                    visitor.Street = streetp.Text;
                    visitor.PhoneNum = phoneNump.Text;
                    visitor.WorkerID = workIDp.Text;
                    visitor.StatusVisitor = statusVisitorp.Text;

                    if (radioParking.Checked) // הרשאות נתיב חניון רגיל/סגל
                        visitor.PermissionPaths = radioParking.Text;
                    else
                        visitor.PermissionPaths = radioParkingWork.Text;

                    visitor.Group = groupp.Text;
                    visitor.OrganizationBox = organizationBoxp.Text;
                    if (visitor.AdminComment == "")
                        visitor.AdminComment = adminCommentp.Text;
                    else
                        visitor.AdminComment = adminCommentp.Text;

                    visitor.CrId = carIDp.Text;

                    // הכנסת נתונים של הרכב
                    Cars car = new Cars();
                    car.IDVis = iDp.Text; //תעודת זהות של בעל הרכב
                    car.CarId = carIDp.Text;
                    car.TypeCar = typeCarp.Text;
                    car.YearCar = yearCarp.Text;
                    car.ColorCar = colorCarp.Text;
                    if (radioParking.Checked) // הרשאות נתיב חניון רגיל/סגל
                        car.PermissionPaths = radioParking.Text;
                    else
                        car.PermissionPaths = radioParkingWork.Text;
                    car.Group = groupp.Text;

                    if (uv.Equals("עריכה"))
                    {
                        dataB.updatevisitors(visitor, true);
                        dataB.updateCars(car, true);
                        MessageBox.Show("פרטי מבקר ורכב עודכנו בהצלחה");
                    }
                    if (uv.Equals("מחיקה"))
                    {
                        visitor.StatusVisitor = "לא פעיל";
                        dataB.updatevisitors(visitor, false);
                        dataB.updateCars(car, false);
                        MessageBox.Show("המבקר נמחק מהמערכת");
                    }
                }
                    else
                    {
                        MessageBox.Show("לא בוצע עידכון,מלא שדות");
                    }
                }
                else
                {
                    MessageBox.Show("נא מלא את השדות האדומים להוספת אישור זמני למבקר", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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

        //=================================================
        //לחיצה כפולה על תעודת זהות מילוי כל השדות להצגה
        //=================================================
        private void dataEdit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Enabled = true;
            try
                {
                    string item = null;
                    string txtsearchVis = null;
                    if (e.ColumnIndex == 1)
                    {
                        item = dataEdit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    txtsearchVis = item;
                }
                    else if (e.ColumnIndex == 0)
                    {
                        item = dataEdit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    txtsearchVis = item;
                }
                Visitors visitors = new Visitors();
                    visitors = dataB.searchVisitById(txtsearchVis);
                if (visitors != null) 

                {
                    groupp.Text = visitors.Group;
                        iDp.Text = visitors.ID;
                        firstNamep.Text = visitors.FirstName;
                        lastNamep.Text = visitors.LastName;
                        phoneNump.Text = visitors.PhoneNum;
                        cityp.Text = visitors.City;
                        streetp.Text = visitors.Street;
                        workIDp.Text = visitors.WorkerID;
                        statusVisitorp.Text = visitors.StatusVisitor;
                        organizationBoxp.Text = visitors.OrganizationBox;
                        adminCommentp.Text = visitors.AdminComment;
                    }
                    //פרטי רכב
                    Cars carvis = new Cars();
                    carvis = dataB.searchCarById(txtsearchVis);
                    if (carvis != null)
                    {
                        iDp.Text = carvis.IDVis;
                        carIDp.Text = carvis.CarId;
                        typeCarp.Text = carvis.TypeCar;
                        yearCarp.Text = carvis.YearCar;
                        colorCarp.Text = carvis.ColorCar;
                        //נתיבי כניסה
                        if (visitors.PermissionPaths == "חניון בית חולים")
                        {
                            radioParking.Checked = true;
                            radioParkingWork.Checked = false;
                        }
                        else
                        {
                            radioParking.Checked = false;
                            radioParkingWork.Checked = true;
                        }
                        btnsearcVis.Enabled = true;
                    }
                }
                catch (Exception)
                { }
        }

        //=====================================
        //פונקציה לניקוי כל התאים לאחר פעולה
        //=====================================
        public void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }
        }


        //======================================
        //פונקציה לריענון הטבלה לאחר פעולות
        //======================================
        public void RefreshLoad()
        {
            txtsearchVis.Focus();
            Visitors[] vs; // מערך של המבקרים
            vs = dataB.GetVisitorsData(); // מכיל את כל המערך

            dataEdit.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataEdit.AutoResizeColumns();

            if (vs.Length == 0) //אם אין מבקרים במערכת
            {
                dataEdit.DataSource = null;
                this.Close();
                MessageBox.Show("אין רשומים במערכת", "Error");
            }
            else
            {
                dataEdit.ColumnCount = 13; // כמות עמודות
                dataEdit.RowCount = vs.Length; // כמות שורות מהטבלה באקסס
                dataEdit.Columns[0].HeaderText = "תעודת זהות"; // להציג בעמודות
                dataEdit.Columns[1].HeaderText = "שם פרטי";
                dataEdit.Columns[2].HeaderText = "שם משפחה";
                dataEdit.Columns[3].HeaderText = "עיר";
                dataEdit.Columns[4].HeaderText = "רחוב";
                dataEdit.Columns[5].HeaderText = "מס' טלפון";
                dataEdit.Columns[6].HeaderText = "מס' עובד";
                dataEdit.Columns[7].HeaderText = "תאריך יצירה";
                dataEdit.Columns[8].HeaderText = "סטטוס";
                dataEdit.Columns[9].HeaderText = "סוג נתיב";
                dataEdit.Columns[10].HeaderText = "בקבוצה";
                dataEdit.Columns[11].HeaderText = "הערת מנהל";
                dataEdit.Columns[12].HeaderText = "ארגון";

                int k;
                for (k = 0; k < vs.Length; k++)
                {
                    dataEdit[0, k].Value = vs[k].ID;
                    dataEdit[1, k].Value = vs[k].FirstName;
                    dataEdit[2, k].Value = vs[k].LastName;
                    dataEdit[3, k].Value = vs[k].City;
                    dataEdit[4, k].Value = vs[k].Street;
                    dataEdit[5, k].Value = vs[k].PhoneNum;
                    dataEdit[6, k].Value = vs[k].WorkerID;
                    dataEdit[7, k].Value = vs[k].CreateDate;
                    dataEdit[8, k].Value = vs[k].StatusVisitor;
                    dataEdit[9, k].Value = vs[k].PermissionPaths;
                    dataEdit[10, k].Value = vs[k].Group;
                    dataEdit[11, k].Value = vs[k].AdminComment;
                    dataEdit[12, k].Value = vs[k].OrganizationBox;
                }
            }
          }

        //====================
        //combobox קריאה בלבד
        //====================
        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        //===============================
        //פונקציה להחזרת שדה לצבע לבן
        //===============================
        private void textWhite()
        {
            if (!String.IsNullOrEmpty(groupp.Text))
            {
                groupp.BackColor = Color.White;             
            }
            if (!String.IsNullOrEmpty(iDp.Text))
            {
                iDp.BackColor = Color.White;     
            }
            if (!String.IsNullOrEmpty(firstNamep.Text))
            {
                firstNamep.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(lastNamep.Text))
            {
               lastNamep.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(phoneNump.Text))
            {
                phoneNump.BackColor = Color.White; 
            }
            if (!String.IsNullOrEmpty(cityp.Text))
            {
                cityp.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(streetp.Text))
            {
                streetp.BackColor = Color.White; 
            }
            if (!String.IsNullOrEmpty(workIDp.Text))
            {
                workIDp.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(statusVisitorp.Text))
            {
                statusVisitorp.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(carIDp.Text))
            {
                carIDp.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(typeCarp.Text))
            {
                typeCarp.BackColor = Color.White;
            }
            if (String.IsNullOrEmpty(yearCarp.Text))
            {
                yearCarp.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(colorCarp.Text))
            {
                colorCarp.BackColor = Color.White;
            }
        }

        //=======================
        // בדיקת מצב שדות בפאנל
        //=======================
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            textWhite();
        }

        //============================
        // פונקציה שממספרת את השורות
        //============================
        private void dataEdit_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataEdit.RowHeadersDefaultCellStyle.ForeColor))
            {
                if (dataEdit.RightToLeft == RightToLeft.No) // בדיקה האם הטבלה מימין לשמאל
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

        //=========================
        //כפתור חזרה אחורה לתפריט
        //=========================
        private void buckM_Click_1(object sender, EventArgs e)
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

        //=============================================
        //הפעל כפתור חיפוש בעת לחיצה על אינטר במקלדת
        //=============================================
        private void txtsearchVis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsearcVis.PerformClick();
            }
        }

    }
 }
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class add_CarVisitorGUI : Form
    {
        private DBSQL dataB;

        //=====
        //בנאי
        //=====
        public add_CarVisitorGUI(DBSQL db)
        {
            this.dataB = db;
            InitializeComponent();
        }

        //==========================
        //כפתןר חזרה לתפריט הראשי
        //==========================
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

        //=====================
        //כפתור הוספה למערכת
        //=====================
        private void addVBT_Click(object sender, EventArgs e)
        {
            //בדיקה שכל השדות חובה מולאו בהצלחה
            bool flagState = true; 
            if (String.IsNullOrEmpty(organizationBox.Text))
            {
                organizationBox.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(iD.Text))
            {
                iD.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(firstName.Text))
            {
                firstName.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(lastName.Text))
            {
                lastName.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(phoneNum.Text))
            {
                phoneNum.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(city.Text))
            {
                city.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(street.Text))
            {
                street.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(group.Text))
            {
                group.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(statusVisitor.Text))
            {
                statusVisitor.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(carID.Text))
            {
                carID.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(yearCar.Text))
            {
                yearCar.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(typeCar.Text))
            {
                typeCar.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(ColorCar.Text))
            {
                ColorCar.BackColor = Color.Red;
                flagState = false;
            }
            if (flagState == true)
            {
            Visitors visitor = new Visitors();
                //הכנסת נתונים של מבקר חדש
                    if (valid.checkId(iD.Text) == true) // בדיקת תקינות ת.ז
                    {
                        if (!dataB.checkIfVisExist(int.Parse(iD.Text))) // בדיקה אם תעודת זהות קיימת במערכת
                        {
                            iD.BackColor = Color.Red;
                            MessageBox.Show(visitor.ID + "מבקר כבר קיים במערכת", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            iD.BackColor = Color.White;
                            return;
                        }
                        visitor.ID = iD.Text;
                        visitor.FirstName = firstName.Text;
                        visitor.LastName = lastName.Text;
                        visitor.City = city.Text;
                        visitor.Street = street.Text;
                        visitor.PhoneNum = phoneNum.Text;
                        if (workerID.Text != "" && (!dataB.checkIfWorkExist(int.Parse(workerID.Text)))) // בדיקה שהמספר עובד לא קיים במערכת
                        {
                            visitor.WorkerID = workerID.Text;
                            workerID.BackColor = Color.Red;
                            MessageBox.Show(visitor.WorkerID + "מס עובד כבר קיים במערכת", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            workerID.BackColor = Color.White;
                            return;
                        }
                        else
                            visitor.WorkerID = workerID.Text;
                        visitor.CreateDate = Convert.ToDateTime(createdDate.Text);
                        visitor.StatusVisitor = statusVisitor.Text;
                        if (radioParking.Checked) // הרשאות נתיב חניון רגיל/סגל
                            visitor.PermissionPaths = radioParking.Text;
                        else
                            visitor.PermissionPaths = radioParkingWork.Text;

                        visitor.Group = group.Text;

                        if (visitor.AdminComment == "")
                            visitor.AdminComment = adminComment.Text;
                        else
                            visitor.AdminComment = adminComment.Text;

                        visitor.OrganizationBox = organizationBox.Text;
                        visitor.CrId = carID.Text;
                        // הכנסת נתונים של הרכב
                        Cars car = new Cars();

                        if (carID.Text != "" && (!dataB.checkIfCarExist(int.Parse(carID.Text))))// בדיקה אם מספר רכב קיים במערכת
                        {
                            car.CarId = carID.Text;
                            carID.BackColor = Color.Red;
                            MessageBox.Show(car.CarId + " מס רכב כבר קיים במערכת", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            carID.BackColor = Color.White;
                        }
                        else
                        car.CarId = carID.Text;
                        car.IDVis = iD.Text; //תעודת זהות של בעל הרכב
                        car.TypeCar = typeCar.Text; // סוג הרכב
                        car.YearCar = yearCar.Text; // שנת יצור
                        car.ColorCar = ColorCar.Text; // צבע רכב
                        if (radioParking.Checked) // הרשאות נתיב חניון רגיל/סגל
                            car.PermissionPaths = radioParking.Text;
                        else
                            car.PermissionPaths = radioParkingWork.Text;

                        car.Group = group.Text;
                        car.StatusVisitor = statusVisitor.Text;

                        //בדיקת תקינות קלט פלט של הנתונים
                        bool[] err = new bool[12];
                        err[0] = valid.checkId(visitor.ID);
                        err[1] = valid.checkfirstName(visitor.FirstName);
                        err[2] = valid.checklastName(visitor.LastName);
                        err[3] = valid.checkcity(visitor.City);
                        err[4] = valid.checkstreet(visitor.Street);
                        err[5] = valid.checkPhone(visitor.PhoneNum);
                        err[6] = valid.checkworkerID(visitor.WorkerID);
                        err[7] = valid.checkcarId(car.CarId);
                        err[8] = valid.checktypeCar(car.TypeCar);
                        err[9] = valid.checkyearCar(car.YearCar);
                        err[10] = valid.checkcolorCar(car.ColorCar);
                        err[11] = valid.checkIDVis(car.IDVis);
                        bool flg = true;
                        for (int i = 0; i < err.Length; i++)
                        {
                            if (err[i] == false) // אם הנתונים לא תקינים הצג שגיאות מתאימות
                            {
                                switch (i)
                                {
                                    case 0:
                                        iD.BackColor = Color.White;
                                        MessageBox.Show("תעודת זהות לא תקינה");
                                        iD.BackColor = Color.White;
                                        break;
                                    case 1:
                                        firstName.BackColor = Color.Red;
                                        MessageBox.Show("שם פרטי שגוי");
                                        firstName.BackColor = Color.White;
                                        break;
                                    case 2:
                                        lastName.BackColor = Color.Red;
                                        MessageBox.Show("שם משפחה שגוי");
                                        lastName.BackColor = Color.White;
                                        break;
                                    case 3:
                                        city.BackColor = Color.Red;
                                        MessageBox.Show("רשום עיר מחדש");
                                        city.BackColor = Color.White;
                                        break;
                                    case 4:
                                        street.BackColor = Color.Red;
                                        MessageBox.Show("רשום רחוב מחדש");
                                        street.BackColor = Color.White;
                                        break;
                                    case 5:
                                        phoneNum.BackColor = Color.Red;
                                        MessageBox.Show("מספר טלפון חייב להכיל 10 ספרות");
                                        phoneNum.BackColor = Color.White;
                                        break;
                                    case 6:
                                        workerID.BackColor = Color.Red;
                                        MessageBox.Show("מספר עובד חייב להכיל 5 ספרות");
                                        workerID.BackColor = Color.White;
                                        break;
                                    case 7:
                                        carID.BackColor = Color.Red;
                                        MessageBox.Show("מס רכב חייב להכיל 7 או 8 ספרות");
                                        carID.BackColor = Color.White;
                                        break;
                                    case 8:
                                        typeCar.BackColor = Color.Red;
                                        MessageBox.Show("סוג רכב לא תקין");
                                        typeCar.BackColor = Color.White;
                                        break;
                                    case 9:
                                        yearCar.BackColor = Color.Red;
                                        MessageBox.Show("שנת יצור חייב להכיל 4 ספרות");
                                        yearCar.BackColor = Color.White;
                                        break;
                                    case 10:
                                        ColorCar.BackColor = Color.Red;
                                        MessageBox.Show("צבע שגוי");
                                        ColorCar.BackColor = Color.White;
                                        break;
                                }
                                flg = false;
                            }
                        }
                        if (flg == true) // אם הנתונים תקינים ללא שגיאות הכנס אותם לבסיס נתונים
                        {
                            dataB.InsertVisitors(visitor);
                            dataB.InsertCars(car);
                            MessageBox.Show("מבקר חדש צורף בהצלחה", "OK");
                            ClearTextBoxes(infoVis);
                            ClearTextBoxes(infoCar);
                    }

                        return;
                    }
                MessageBox.Show("תעודת זהות לא תקינה");
                iD.BackColor = Color.Red;
                iD.Clear();
                iD.Focus();
            }
            else
            {
                MessageBox.Show("אנא מלא את השדות האדומים להוספת מבקר חדש למערכת", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        //=========================================
        //אפשרות להקליד רק אותיות ורווחים בלבד
        //=========================================
        private void OnlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                (e.KeyChar != ' '))
            {
                e.Handled = true;
                IsNullOrEmpty();
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
                IsNullOrEmpty();
            }
        }

        //====================
        //combobox קריאה בלבד
        //====================
        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        ////==========================================================
        ////פונקציה החזרת צבע לבן בזמן הקלדה על השדות פרטי מבקר
        ////==========================================================
        private void IsNullOrEmpty()
        {
            if (!String.IsNullOrEmpty(organizationBox.Text))
            {
                organizationBox.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(iD.Text))
            {
                iD.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(firstName.Text))
            {
                firstName.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(lastName.Text))
            {
                lastName.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(phoneNum.Text))
            {
                phoneNum.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(city.Text))
            {
                city.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(street.Text))
            {
                street.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(group.Text))
            {
                group.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(statusVisitor.Text))
            {
                statusVisitor.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(carID.Text))
            {
                carID.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(yearCar.Text))
            {
                yearCar.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(typeCar.Text))
            {
                typeCar.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(ColorCar.Text))
            {
                ColorCar.BackColor = Color.White;
            }
        }

        //=========================================
        //בדיקה אם שדות לא ריקות הפוך ללבן
        //=========================================
        #region WhiteText
        private void organizationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void iD_TextChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void firstName_TextChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void lastName_TextChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void phoneNum_TextChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void city_TextChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void street_TextChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void statusVisitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void group_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void carID_TextChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void typeCar_TextChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void yearCar_TextChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
        private void ColorCar_TextChanged(object sender, EventArgs e)
        {
            IsNullOrEmpty();
        }
    }
}
#endregion WhiteText
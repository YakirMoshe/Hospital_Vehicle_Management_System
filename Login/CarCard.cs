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
    public partial class CarCard : Form
    {
        private DBSQL dataB;
        private bool p;
        private int item = 0;

        //======
        //בנאי
        //======
        public CarCard(DBSQL dataB, bool newcar, int item)
        {
            InitializeComponent();
            this.dataB = dataB;
            this.item = item;
            if (!newcar) txtid.ReadOnly = true; //הגנה על תעודת זהות
            if (!newcar) txtcarid.ReadOnly = true; 
        }

        public CarCard(DBSQL dataB)
        {
            this.dataB = dataB;
        }

        //=================
        //כפתור סגירת חלון
        //=================
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //======================================================================
        //לאחר לחיצה על תעודת זהות במסך מידע מבקרים נפתח פרטי הרכב של המבקר
        //======================================================================
        private void CarCard_Load(object sender, EventArgs e)
        {
            Cars car;
            car = dataB.GetCarCardDetails(item);
            txtid.Text = car.IDVis;
            txtcarid.Text = car.CarId;
            txttype.Text = car.TypeCar;
            txtcolor.Text = car.ColorCar;
            txtyear.Text = car.YearCar;
        }

        //=====================
        //כפתור הפעלת שינויים
        //====================
        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            updateCarCard("עריכה");
        }

        //================================
        //פונקציה עריכת פריטים בכרטייסיה
        //================================
        private void updateCarCard(string uv)
        {
            string IDVis = txtid.Text;
            string CarId = txtcarid.Text;
            string TypeCar = txttype.Text;
            string ColorCar = txtcolor.Text;
            string YearCar = txtyear.Text;

            Cars car = new Cars();
            car.IDVis = txtid.Text;
            car.CarId = txtcarid.Text;
            car.TypeCar = txttype.Text;
            car.ColorCar = txtcolor.Text;
            car.YearCar = txtyear.Text;
          
                bool[] err = new bool[3];
                err[0] = valid.checktypeCar(car.TypeCar);
                err[1] = valid.checkcolorCar(car.ColorCar);
                err[2] = valid.checkyearCar(car.YearCar);

                bool flg = true;
                for (int i = 0; i < err.Length; i++)
                {
                    if (err[i] == false) // אם הנתונים לא תקינים הצג שגיאות מתאימות
                    {
                        switch (i)
                        {
                            case 0:
                                txttype.BackColor = Color.Red;
                                MessageBox.Show("סוג רכב לא תקין");
                                txttype.BackColor = Color.White;
                                break;
                            case 1:
                                txtcolor.BackColor = Color.Red;
                                MessageBox.Show("צבע שגוי");
                                txtcolor.BackColor = Color.White;
                                break;
                            case 2:
                                txtyear.BackColor = Color.Red;
                                MessageBox.Show("שנת יצור חייב להכיל 4 ספרות");
                                txtyear.BackColor = Color.White;
                                break;
                        }
                        flg = false;
                    }
                }
                if (flg == true) // אם הנתונים תקינים ללא שגיאות הכנס אותם לבסיס נתונים
                {
                    dataB.updateCarCard(car, true);
                txtid.BackColor = Color.Green;
                txtcarid.BackColor = Color.Green;
                txttype.BackColor = Color.Green;
                txtcolor.BackColor = Color.Green;
                txtyear.BackColor = Color.Green;
                MessageBox.Show("פרטי הרכב שערכת נשמרו בהצלחה", "OK");
                    this.Close();
                }
            }
            
        //=======================================
        //אפשרות להקליד רק אותיות ורווחים בלבד
        //=======================================
        private void OnlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                (e.KeyChar != ' '))
            {
                e.Handled = true;
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

        //==================
        //מסך משתמש
        //ניעלת שדות עידכון
        //===================
        public void HideMangerButtonsUpdate()
        {
            btnSaveCar.Enabled = false; 
            txtcolor.Enabled = false; 
            txtyear.Enabled = false;
            txttype.Enabled = false;
            this.Text = "פאנל משתמש - פרטי רכב של מבקר";
        }
    }
}
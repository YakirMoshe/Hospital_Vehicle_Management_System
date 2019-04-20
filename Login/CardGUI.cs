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
    //===============================================
    //כרטייסית פרטי מבקר  לתצוגה לאחר לחיצת כפתור
    //==============================================
    public partial class CardGUI : Form
    {
        private DBSQL dataB;
        private int item = 0;
 
        //=====
        //בנאי
        //=====
        public CardGUI(DBSQL dataB, bool newcar, int item)
        {
            InitializeComponent();
            this.dataB = dataB;
            this.item = item;
            if (!newcar) txtid.ReadOnly = true; // תעודת זהות לא ניתן לשינוי
        }

        //===============
        //כפתור סגירה
        //===============
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //=============================================================================
        //לאחר לחיצה על תעודת זהות במסך מידע רכבים נפתח פרטי בעל הרכב+הרשאות נתיב
        //=============================================================================
        public void CardGUI_Load(object sender, EventArgs e)
        {
            Visitors visitor;
             visitor = dataB.GetCardDetails(item);
              txtid.Text = visitor.ID;
              txtFname.Text = visitor.FirstName;
              txtLname.Text = visitor.LastName;
              cmbGroup.Text = visitor.Group;
              txtStatusvis.Text = visitor.StatusVisitor;
               phoneNump.Text = visitor.PhoneNum;
              //נתיבי כניסה
              if (visitor.PermissionPaths == "חניון בית חולים")
              {
                  radioParkingWork.Checked = true;
                  radioParking.Checked = false;
              }

              else
              {
                  radioParkingWork.Checked = false;
                  radioParking.Checked = true;
              }
        }

        //=====================
        //כפתור הפעלת שינויים
        //====================
        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            updateCard("עריכה");
        }

        //================================
        //פונקציה עריכת פריטים בכרטייסיה
        //================================
        private void updateCard(string uv)
        {
            string ID = txtid.Text;
            string FirstName = txtFname.Text;
            string LastName = txtLname.Text;
            string Group = cmbGroup.Text;
            string StatusVisitor = txtStatusvis.Text;
            string PhoneNum = phoneNump.Text;
            string vispw="";

            bool[] err = new bool[3];
            for (int i = 0; i < err.Length; i++)
                err[i] = true;
            if (radioParkingWork.Checked || radioParking.Checked)
            {
                if (radioParking.Checked)
                    vispw = "חניון בית חולים";
                else
                    vispw = "חניון סגל";
            }
            //בדיקת תקינות קלט פלט של הנתונים
            err[0] = valid.checkfirstName(FirstName);
            err[1] = valid.checklastName(LastName);
            err[2] = valid.checkPhone(PhoneNum);
            bool flg = true;
            for (int i = 0; i < err.Length; i++)
            {
                if (err[i] == false) // אם הנתונים לא תקינים הצג שגיאות מתאימות
                {
                    switch (i)
                    {
                        case 0:
                            txtFname.BackColor = Color.Red;
                            MessageBox.Show("שם פרטי שגוי");
                            txtFname.BackColor = Color.White;
                            break;
                        case 1:
                            txtLname.BackColor = Color.Red;
                            MessageBox.Show("שם משפחה שגוי");
                            txtLname.BackColor = Color.White;
                            break;
                        case 2:
                            phoneNump.BackColor = Color.Red;
                            MessageBox.Show("מספר טלפון חייב להכיל 10 ספרות");
                            phoneNump.BackColor = Color.White;
                            break;
                    }

                    flg = false;
                }
            }
            if (flg == true) // אם הנתונים תקינים ללא שגיאות הכנס אותם לבסיס נתונים
            {
                Visitors visitor = new Visitors();
                visitor.ID = txtid.Text;
                visitor.FirstName = txtFname.Text;
                visitor.LastName = txtLname.Text;
                visitor.Group = cmbGroup.Text;
                visitor.StatusVisitor = txtStatusvis.Text;
                visitor.PhoneNum = phoneNump.Text;

                if (radioParkingWork.Checked) // הרשאות נתיב חניון רגיל/סגל
                    visitor.PermissionPaths = radioParkingWork.Text;
                else
                    visitor.PermissionPaths = radioParking.Text;
                if (uv.Equals("עריכה"))
                {
                    dataB.updateCard(visitor, true);
                    MessageBox.Show("פרטי המבקר שערכת נשמרו בהצלחה");
                    this.Close();
                }
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
            txtFname.Enabled = false;
            txtLname.Enabled = false;
            cmbGroup.Enabled = false;
            txtStatusvis.Enabled = false;
            panel.Enabled = false;
            this.Text = "פאנל משתמש - פרטי מבקר";
        }

        //====================
        //combobox קריאה בלבד
        //====================
        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
  }
 

    

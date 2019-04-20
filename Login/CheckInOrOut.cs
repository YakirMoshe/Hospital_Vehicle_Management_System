using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//================================
//פאנל כניסה ויציאה מהבית חולים
//================================
namespace Login
{
    public partial class CheckInOrOut : Form
    {
        private DBSQL dataB;
        private Visitors[] visit;
        private string carid = "";

        public CheckInOrOut(DBSQL db, bool visibal, string carid)
        {
            InitializeComponent();
            this.dataB = db;
            this.carid = carid;

            txtCheckInOut.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // השלמת מספרי רכב אוטומטי
            txtCheckInOut.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            visit = dataB.autoCompleteVisitorsCheckInOrOut(); // נכנס לבסיס נתונים לזיהוי אם מספר רכב קיים
            //=====================================
            //השלמה אוטומטית על ידי כניסה ויציאה
            //=====================================
            if (visibal) //בדיקה מה משתמש רוצה לעשות כניסה או יציאה
            { //לאחר לחיצה על כפתור כניסה הפעלת מסך לכניסה
                this.Text = "כניסה לבית החולים";
                txtCheckInOut.Focus();
                btnCheckOut.Visible = false;
                txtout.Visible = false;
                txtCheckInOut.Focus();
                for (int i = 0; i < visit.Length; i++)
                    if (visit[i].CheckInOrCheckOut != true)
                        data.Add(visit[i].CrId.ToString()); // מוסיף את מספר הרכב
                txtCheckInOut.AutoCompleteCustomSource = data; // מקבל את מספר הרכב להשלמה אוטומטית
            }
            else
            { // לאחר לחיצה על כפתור יציאה הפעלת מסך ליציאה
                txtCheckInOut.Focus();
                btnCheckIn.Visible = false;
                txtcome.Visible = false;
                txtCheckInOut.Focus();
                for (int i = 0; i < visit.Length; i++)
                    if (visit[i].CheckInOrCheckOut != false)
                        data.Add(visit[i].CrId.ToString());
                txtCheckInOut.AutoCompleteCustomSource = data;
            }
            if (carid != null)
            {
                txtCheckInOut.Text = carid;
            }
        }

        //============================================
        // פונקציה שרושמת את כל הכניסות מהבית חולים 
        // ושומר את המידע
        //============================================
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            txtCheckInOut.Focus();
            bool flagcarID = false; // דגל כבוי
            string crId = string.Empty;
            int index = -1;
            crId = txtCheckInOut.Text;
            if (txtCheckInOut.Text.Length == 7 || txtCheckInOut.Text.Length == 8 && crId != string.Empty) // תקינות מספר רכב 7 או 8 ספרות
            {
                int search;
                int flag1 = 0;

                search = int.Parse(txtCheckInOut.Text);
                flag1 = dataB.CheckCarExist(search); // בדיקה אם הרכב קיים במערכת
                if (flag1 == 1)
                {
                    for (int i = 0; i < visit.Length; i++)
                {
                    if (visit[i].CheckInOrCheckOut == false && visit[i].CrId.Equals(crId)) // בדיקה שהרכב לא בתוך הבית חולים וזיהוי המספר בבסיס נתונים
                    {
                        flagcarID = true;
                        index = i;
                    }
                }
   
                if (flagcarID)
                {
                    txtCheckInOut.Focus();
                    if (txtDesCheck.Text == string.Empty)
                        txtDesCheck.Text = "המבקר נכנס";
                    dataB.updateInsertEntery(visit[index], true, txtDesCheck.Text); // הוספה ועדכון של מבקר הנכנס לבית חולים
                    dataB.insertEvent(visit[index], true, txtDesCheck.Text); // עדכון טבלת היסטוריה על כניסה חדשה והערה של מבקר 
                        txtCheckInOut.BackColor = Color.Green;
                        var confirmResult = MessageBox.Show(" המבקר [" + txtCheckInOut.Text + "] נכנס לבית חולים", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCheckInOut.BackColor = Color.White;
                        if (confirmResult == DialogResult.OK)
                        this.Close();
                        return;
                    }
                else
                        txtCheckInOut.BackColor = Color.Red;
                    MessageBox.Show("המבקר [" + txtCheckInOut.Text + "] כבר בפנים", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCheckInOut.BackColor = Color.White;
                }
                else
                {
                    txtCheckInOut.BackColor = Color.Red;
                    MessageBox.Show("רכב לא קיים במערכת", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCheckInOut.BackColor = Color.White;
                    txtCheckInOut.Clear();
                    txtCheckInOut.Focus();
                }
            }
            else
            {
                txtCheckInOut.BackColor = Color.Red;
                MessageBox.Show("הכנס 7 או 8 ספרות של הרכב ונסה שנית", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCheckInOut.BackColor = Color.White;
                txtCheckInOut.Clear();
                txtCheckInOut.Focus();
            }
        }

        //============================================
        // פונקציה שרושמת את כל היציאות מהבית חולים
        //ושומרת את המידע
        //============================================
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            txtCheckInOut.Focus();
            bool flagcarID = false;
            int search;
            int numRow;
            int flag1 = 0;
            string crId = string.Empty;
            int index = -1;
            crId = txtCheckInOut.Text;
            if (txtCheckInOut.Text.Length == 7 || txtCheckInOut.Text.Length == 8 && crId != string.Empty) // תקינות מספר רכב 7 או 8 ספרות
            {
                search = int.Parse(txtCheckInOut.Text); // מקבל מספר רכב לבדיקה
            flag1 = dataB.CheckCarExist(search); // בודק עם מספר רכב קיים במערכת
            if (flag1 == 1)
            {
                    for (int i = 0; i < visit.Length; i++)
                        if (visit[i].CheckInOrCheckOut != false && visit[i].CrId.Equals(crId))
                        {
                            flagcarID = true;
                            index = i;
                        }
                    if (flagcarID)
                    {
                        if (txtDesCheck.Text == string.Empty)
                            txtDesCheck.Text = "המבקר יצא";
                        dataB.updateInsertEntery(visit[index], false, txtDesCheck.Text); // הוספה ועדכון של מבקר היוצא לבית חולים
                        dataB.insertEvent(visit[index], false, txtDesCheck.Text); // עדכון טבלת היסטוריה על יציאה חדשה והערה של מבקר 
                        txtCheckInOut.BackColor = Color.Green;
                        var confirmResult = MessageBox.Show("המבקר [" + txtCheckInOut.Text + "] יצא מהבית חולים", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCheckInOut.BackColor = Color.White;
                        if (confirmResult == DialogResult.OK) // לאחר שהמבקר יצא סגור מסך
                            this.Close();
                        return;
                    }
                    else // אחרת מספר רכב לא נכנס לבית החולים
                        txtCheckInOut.BackColor = Color.Red;
                    MessageBox.Show("המבקר [" + txtCheckInOut.Text + "] לא נכנס לבית חולים", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCheckInOut.BackColor = Color.White;
                }
                else // כאשר הוקלד מספר רכב שלא קיים במערכת
                {
                    txtCheckInOut.BackColor = Color.Red;
                    MessageBox.Show("רכב לא קיים במערכת", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCheckInOut.BackColor = Color.White;
                    txtCheckInOut.Clear();
                    txtCheckInOut.Focus();
                }
            }
            else // כאשר הוקלד מספר רכב לא תקין
            {
                txtCheckInOut.BackColor = Color.Red;
                MessageBox.Show("הכנס 7 או 8 ספרות של הרכב ונסה שנית", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCheckInOut.BackColor = Color.White;
                txtCheckInOut.Clear();
                txtCheckInOut.Focus();
            }
          }
        
        //=============
        // סגירת חלון
        //============
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}

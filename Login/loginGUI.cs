using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class loginGUI : Form
    {
        private DBSQL dataB;
        static public bool isManager = false;
        private string userName = null;

        //=====
        //בנאי
        //=====
        public loginGUI()
        {
            InitializeComponent();
        }

        ////======================
        ////התחברות לבסיס נתונים
        ////======================
        private void Form1_Load(object sender, EventArgs e)
        {
            string dbPath = Application.StartupPath + @"\tables-Hemk.accdb"; // מוצא את הקובץ של האקסס
            if (File.Exists(dbPath)) // פונקציה סטטית שבודקת אם קיים קובץ שהגדרנו
            {
                dataB = new DBSQL(@"Provider= Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath + ";Persist Security Info=False;");
            }
            else // אם לא מוצא את הקובץ רשום הודעה 
            {
                MessageBox.Show("DataBase" + dbPath + " not found");
                Application.Exit();
            }
        }

        //==============================
        // בדיקת התחברות מנהל או משתמש
        //==============================
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                string perm = dataB.loginToSystem(txtUsername.Text, txtPassword.Text);
                switch (perm)
                {
                    case "מנהל":
                        {
                            this.Hide();
                            mainGUI m = new mainGUI(dataB);
                            loginGUI l = new loginGUI();
                            isManager = true;
                            m.Show();
                            break;
                        }
                         case "משתמש":
                        {
                            this.Hide();
                            mainGUI m = new mainGUI(dataB);
                            loginGUI l = new loginGUI();
                             m.HideMangerButtons(); // להסתיר כפתורי מנהל
                              m.Show(); // להציג את המסך 
                            break;
                        }
                    case "נכשל":
                        {
                            if (string.IsNullOrEmpty(txtUsername.Text)) // במקרה שהוקלד רק שם משתמש
                            {
                                txtUsername.BackColor = Color.Yellow;
                                MessageBox.Show("הכנס בבקשה שם משתמש", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtUsername.BackColor = Color.White;
                                txtUsername.Focus(); 
                                return;
                            }
                            else if (string.IsNullOrEmpty(txtPassword.Text)) // במקרה שהוקלד רק סיסמה
                            {
                                txtPassword.BackColor = Color.Yellow;
                                MessageBox.Show("הכנס בבקשה סיסמה", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtPassword.BackColor = Color.White;
                                txtPassword.Focus();
                                return;
                            }
                            txtUsername.BackColor = Color.Red;
                            txtPassword.BackColor = Color.Red;
                            MessageBox.Show("שם משתמש או סיסמה לא נכונים", "Permission denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.BackColor = Color.White;
                            txtPassword.BackColor = Color.White;
                            break;
                        }
                 }
             }
            catch (Exception)
            {
            }
        }

                 //============
                 //מקבל ומחזיר
                 //============
                 public bool IsManager
                 {
                   get { return isManager; }
                   set { isManager = value; }
                 }

        //=======================
        //שדה ראשון לחיצת אינטר
        //=======================
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        //=============================================
        //הפעל כפתור כניסה בעת לחיצה על אינטר במקלדת
        //=============================================
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.PerformClick();
            }
        }
    }
}                
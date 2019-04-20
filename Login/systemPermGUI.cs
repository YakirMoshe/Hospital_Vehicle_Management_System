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
    public partial class systemPermGUI : Form 
    {
        private DBSQL dataB;

        //=====
        //בנאי
        //=====
        public systemPermGUI(DBSQL db)
        {
            InitializeComponent();
            this.dataB = db;
           UserIdUP.ReadOnly = true; // תעודת זהות לא ניתן לשינוי
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

        //======================
        //כפתור הוספת חשבון חדש
        //=======================
        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool flagState = true; //זיהוי שדות
            Users UserWork = new Users();
            if (textB_id.Text != "") //שדה תעודת זהות
            {
                textB_id.BackColor = Color.White;
            }
            else
            {
                flagState = false; // אחרת לצבוע באדום ולשלוח הודעה מתאימה
                textB_id.BackColor = Color.Red;
            }
            if (textB_user.Text != "") //שם ושם משפחה
            {
                textB_user.BackColor = Color.White;
            }
            else
            {
                flagState = false;
                textB_user.BackColor = Color.Red;
            }
            if (textB_name.Text != "") //שם משתמש 
            {
                textB_name.BackColor = Color.White;
            }
            else
            {
                flagState = false;
                textB_name.BackColor = Color.Red;
            }
            if (textB_pass.Text != "") //סיסמה
            {
                textB_pass.BackColor = Color.White;
            }
            else
            {
                flagState = false;
                textB_pass.BackColor = Color.Red;
            }
            if (RadioUser.Checked) //משתמש
            {
                RadioUser.BackColor = Color.White;
                RadioAdmin.BackColor = Color.White;
            }
            else if (RadioAdmin.Checked)
            {
                RadioAdmin.BackColor = Color.White;
                RadioUser.BackColor = Color.White;
            }
            else
            {
                RadioUser.BackColor = Color.Red;
                RadioAdmin.BackColor = Color.Red;
            }
            if (flagState == false)
            {
                MessageBox.Show("אנא מלא את השדות האדומים ליצירת חשבון ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (valid.checkId(textB_id.Text) == true) // בדיקת תקינות ת.ז
            {
                int search;
                int flag1 = 0;

                search = int.Parse(textB_id.Text);
                if (valid.checkPassworduser(textB_pass.Text) == true)  // בדיקת תקינות סיסמה
                {
                    flag1 = dataB.checkIfUserExist(search); // בדיקה אם משתמש קיים במערכת
                    if (flag1 == 1)
                    {
                        textB_id.BackColor = Color.Red;
                        MessageBox.Show(UserWork.UserId + "מבקר כבר קיים במערכת", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textB_id.BackColor = Color.White;
                        textB_id.Clear();
                        return;
                    }
                    //הכנסת נתונים של משתמש חדש
                    UserWork.UserId = textB_id.Text;
                    UserWork.UserName = textB_user.Text;
                    UserWork.User = textB_name.Text;
                    UserWork.Userpassword = textB_pass.Text;
                    if (RadioUser.Checked)
                        UserWork.PermisionType = RadioUser.Text;
                    else
                        UserWork.PermisionType = RadioAdmin.Text;
                    //בדיקת תקינות קלט פלט של הנתונים
                    bool[] err = new bool[3];
                    err[0] = valid.checkId(UserWork.UserId);
                    err[1] = valid.checkUserName(UserWork.UserName);
                    err[2] = valid.checkUser(UserWork.User);
                    bool flg = true;
                    for (int i = 0; i < err.Length; i++)
                    {
                        if (err[i] == false) // אם הנתונים לא תקינים הצג שגיאות מתאימות
                        {
                            switch (i)
                            {
                                case 0:
                                    textB_id.BackColor = Color.Red;
                                    MessageBox.Show("תעודת זהות לא תקינה");
                                    textB_id.BackColor = Color.White;
                                    break;
                                case 1:
                                    textB_name.BackColor = Color.Red;
                                    MessageBox.Show("שם פרטי ללא מספרים");
                                    textB_name.BackColor = Color.White;
                                    break;
                                case 2:
                                    textB_user.BackColor = Color.Red;
                                    MessageBox.Show("שם משתמש לא חוקי");
                                    textB_user.BackColor = Color.White;
                                    break;

                            }
                            flg = false;
                        }
                    }

                    if (flg == true) // אם הנתונים תקינים ללא שגיאות הכנס אותם לבסיס נתונים
                    {
                        dataB.InsertUser(UserWork);
                        MessageBox.Show("חשבון משתמש נוצר בהצלחה", "OK");
                        //בדיקה לאיזה מסך להוסיף את החשבון שנוצר
                        if (UserWork.PermisionType == "משתמש")
                        {
                            Usersbox.Items.Add(UserWork.UserName);
                        }
                        else
                        {
                            adminbox.Items.Add(UserWork.UserName);
                        }
                    }
                    //ניקוי שדות
                    textB_id.Clear();
                    textB_user.Clear();
                    textB_name.Clear();
                    textB_pass.Clear();
                    RadioUserUP.Checked = false;
                    RadioAdminUP.Checked = false;
                }
                else
                { 
                    textB_pass.BackColor = Color.Red;
                MessageBox.Show("סיסמה חייבת להכיל לפחות 5 תווים");
                textB_pass.BackColor = Color.White;
                textB_pass.Text = ""; // ניקוי שדה סיסמה
                textB_pass.Focus(); // מיקוד מקלדת על שדה סיסמה
            }
           }
            else
                {
                    textB_id.BackColor = Color.Red;
                    MessageBox.Show("תעודת זהות לא תקינה");
                    textB_id.BackColor = Color.White;
                    textB_id.Clear();
                }
            }

        //====================================================
        //הצגת תעודות זהות במסך עידכון על ידי שימוש בקומבו
        //====================================================
        private void systemPermGUI_Load(object sender, EventArgs e)
        {
            comboIdType.Focus();
            FillIdUsers(comboIdType); // להצגת תעודות זהות בעידכון חשבון
            Users[] name;
            name = dataB.GetUserData("משתמש");// מציג במסך את המשתמשים
            Usersbox.Items.Clear();
            for (int i = 0; i < name.Length; i++)
            {
                Usersbox.Items.Add(name[i].UserName);
            }
            name = dataB.GetUserData("מנהל"); // מציג במסך את המנהלים
            adminbox.Items.Clear();
            for (int i = 0; i < name.Length; i++)
            {
                adminbox.Items.Add(name[i].UserName);
            }
        }

        //=====================================
        //פונקציה לחיפוש תעודת זהות של משתמש
        //=====================================
        private void FillIdUsers(ComboBox cmp)
        {
            Users[] st1;
            st1 = dataB.GetidUserData();

            for (int i = 0; i < st1.Length; i++)
            {
                cmp.Items.Add(st1[i].UserId);
            }
        }

        //=========================
        //פונקציה שלוקחת שם משתמש
        //=========================
        private string getIDfromListBox(string str)
        {
            string[] tmp;
            tmp = str.Split(' ');
            return tmp[0];
        }

        //=======================================
        // כפתור הזזה ימינה להעביר משתמש למנהל
        //=======================================
        private void rightToManag_Click(object sender, EventArgs e)
        {
            if (Usersbox.SelectedItem != null)  //בודק שנבחר שם להעברה
            {
                dataB.userToManager(getIDfromListBox(Usersbox.SelectedItem.ToString())); // נכנס לפונקציה בבסיס נתונים לשנות לוח בקרה למשתמש/מנהל
                adminbox.Items.Add(Usersbox.SelectedItem);// מעביר את השם למסך המנהל
                Usersbox.Items.Remove(Usersbox.SelectedItems[0]); // מוחק את השם ממסך המשתמש
            }
        }

        //=======================================
        // כפתור הזזה שמאלה להעביר מנהל למשתמש
        //=======================================
        private void leftToUser_Click(object sender, EventArgs e)
        {
            if (adminbox.SelectedItem != null)
            {
                dataB.ManagerToUser(getIDfromListBox(adminbox.SelectedItem.ToString()));
                Usersbox.Items.Add(adminbox.SelectedItem);
                adminbox.Items.Remove(adminbox.SelectedItems[0]);
            }
        }

        //==============================================
        //פונקציה מחיקה משתמש מבסיס נתונים ומהפאנל 
        //==============================================
        private void delPerm(string userName)
        {
            DialogResult dialogResult = MessageBox.Show("האם אתה בטוח שברצונך למחוק את " + userName + " ", "Delete ID?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);// הודעה האם למחוק את המשתמש
            if (dialogResult == DialogResult.Yes) // אם נבחר כן נמחוק דרך בסיס נתונים את השם
            {
                dataB.deletePermByID(userName); // מעבר לבסיס נתונים למחיקת צמיתות של המשתמש/מנהל
                Usersbox.Items.Remove(Usersbox.SelectedItem.ToString()); // העלמת שם מהמסך לאחר המחיקה
            }
        }

        //==============================================
        //פונקציה מחיקה מנהל מבסיס נתונים ומהפאנל 
        //==============================================
        private void delPermMan(string userName)
        {
            DialogResult dialogResult = MessageBox.Show("האם אתה בטוח שברצונך למחוק את " + userName + " ", "Delete ID?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);// הודעה האם למחוק את המשתמש
            if (dialogResult == DialogResult.Yes) // אם נבחר כן נמחוק דרך בסיס נתונים את השם
            {
                dataB.deletePermByID(userName); // מעבר לבסיס נתונים למחיקת צמיתות של המשתמש/מנהל
                adminbox.Items.Remove(adminbox.SelectedItem.ToString()); // העלמת שם מהמסך לאחר המחיקה
            }
        }

        //===================
        //כפתור מחיקת משתמש
        //===================
        private void dellUser_Click_1(object sender, EventArgs e)
        {
            if (Usersbox.SelectedItem != null) // בדיקה שנבחר שם למחיקה
            {
                delPerm(getIDfromListBox(Usersbox.SelectedItem.ToString())); // הוצאת השם הנבחר למחיקה וקריאה לפונקציה delPerm

            }
        }

        //====================
        // כפתור למחיקת מנהל
        //===================
        private void dellManeg_Click_1(object sender, EventArgs e)
        {
            if (adminbox.SelectedItem != null)
            {
                delPermMan(getIDfromListBox(adminbox.SelectedItem.ToString()));
            }
        }

        //============================
        //מסך שני עידכון חשבון משתמש
        // כפתור עדכון פרטי משתמש
        //============================
        private void updateUser_Click(object sender, EventArgs e)
        {
            if (comboIdType.Text != "")
            {
                search.Enabled = true;
                UpdateUsers("עדכון");
            }
            else
            {
                comboIdType.BackColor = Color.Red;
                MessageBox.Show("נא להכניס מספר זיהוי");
                comboIdType.BackColor = Color.White;
                UserIdUP.Clear();
                UserNameUP.Clear();
                UserUP.Clear();
                RadioUserUP.Checked = false;
                RadioAdminUP.Checked = false;
            }
        }

        //====================================
        //הצגת נתונים של משתמש ועדכון פרטים
        //====================================
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            btnchangePass.Visible = true;
            updateUser.Visible = true;
            Users user = new Users();
            user = dataB.searchusserById(comboIdType.Text);
            if (user != null)
            {
                UserIdUP.Text = user.UserId;
                UserNameUP.Text = user.UserName;
                UserUP.Text = user.User;
                if (user.PermisionType == "משתמש")
                {
                    RadioUserUP.Checked = true;
                    RadioAdminUP.Checked = false;
                }

                else
                {
                    RadioUserUP.Checked = false;
                    RadioAdminUP.Checked = true;
                }
            }
        }

        //=======================
        //עדכון פרטי משתמש קיים
        //=======================
        private void UpdateUsers(string uu)
        {
            bool flagState = true; // בדיקה שכל השדות מלאים
            if (UserNameUP.Text != "") //שם ושם משפחה
            {
                UserNameUP.BackColor = Color.White;
            }
            else
            {
                flagState = false;
                UserNameUP.BackColor = Color.Red;
            }
            if (UserUP.Text != "") //שם משתמש 
            {
                UserUP.BackColor = Color.White;
            }
            else
            {
                flagState = false;
                UserUP.BackColor = Color.Red;
            }
            if (flagState == false)
            {
                MessageBox.Show("אנא מלא את השדות האדומים ליצירת חשבון ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string UserId = UserIdUP.Text;
            string UserName = UserNameUP.Text;
            string User = UserUP.Text;
            string usm = "";

            if (RadioUserUP.Checked || RadioAdminUP.Checked)
            {
                if (RadioAdminUP.Checked)
                    usm = "מנהל";
                else
                    usm = "משתמש";
            }

            Users UserWorkup = new Users();
            UserWorkup.UserId = UserIdUP.Text;
            UserWorkup.UserName = UserNameUP.Text;
            UserWorkup.User = UserUP.Text;
            if (RadioUserUP.Checked)
                UserWorkup.PermisionType = RadioUserUP.Text;
            else
                UserWorkup.PermisionType = RadioAdminUP.Text;

            if (uu.Equals("עדכון"))
            {
                dataB.updateuser(UserWorkup, true);
                MessageBox.Show("פרטי משתמש עודכנו בהצלחה");
                comboIdType.ResetText();
                UserIdUP.Clear();
                UserNameUP.Clear();
                UserUP.Clear();
                RadioUserUP.Checked = false;
                RadioAdminUP.Checked = false;
                btnchangePass.Visible = false;
                updateUser.Visible = false;

                Users[] name;
                // מציג במסך את המשתמשים
                name = dataB.GetUserData("משתמש");
                Usersbox.Items.Clear();
                for (int i = 0; i < name.Length; i++)
                {
                    Usersbox.Items.Add(name[i].UserName);
                }
                // מציג במסך את המנהלים
                name = dataB.GetUserData("מנהל");
                adminbox.Items.Clear();
                for (int i = 0; i < name.Length; i++)
                {
                    adminbox.Items.Add(name[i].UserName);
                }
            }
            else
                MessageBox.Show("לא בוצע עידכון,תקן פרטים");
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

        //====================
        //כפתור לשינוי סיסמה
        //====================
        private void btnchangePass_Click(object sender, EventArgs e)
        {
            if (comboIdType.Text != "")
            {
                ChangePassUserOrManger newpass = new ChangePassUserOrManger(dataB, false, int.Parse(comboIdType.Text.ToString()));
                newpass.ShowDialog();
            }
            else
            {
                comboIdType.BackColor = Color.Red;
                MessageBox.Show("נא לבחור תעודת זהות");
                comboIdType.BackColor = Color.White;
            }
        }

        //==============================================
        //הפיכה שדה ללבן בזמן הקלדת שדות לאחר שגיאות
        //==============================================
        #region WhiteText
        private void textB_id_TextChanged(object sender, EventArgs e)
        {
            if (textB_id.Text != "")
            {
                textB_id.BackColor = Color.White;
            }
        }
        private void textB_name_TextChanged(object sender, EventArgs e)
        {
            if (textB_name.Text != "")
            {
                textB_name.BackColor = Color.White;
            }
        }
        private void textB_user_TextChanged(object sender, EventArgs e)
        {
            if (textB_name.Text != "")
            {
                textB_user.BackColor = Color.White;
            }
        }
        private void textB_pass_TextChanged(object sender, EventArgs e)
        {
            if (textB_pass.Text != "")
            {
                textB_pass.BackColor = Color.White;
            }
        }
        #endregion WhiteText

        //====================
        //combobox קריאה בלבד
        //====================
        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
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
    public partial class ChangePassUserOrManger : Form
    {
        private DBSQL dataB;
        private bool p;
        private int item = 0;

        //======
        //בנאי
        //======
        public ChangePassUserOrManger(DBSQL dataB, bool newcar, int item)
        {
            InitializeComponent();
            this.dataB = dataB;
            this.item = item;
            this.item = item;
            if (!newcar) maskedID.ReadOnly = true; // תעודת זהות לא ניתן לשינוי
        }

        //=================
        //כפתור סגירת חלון
        //=================
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==========================
        //כפתור לשמירת סיסמה חדשה
        //==========================
        private void btnSavePass_Click(object sender, EventArgs e)
        {
            updateNewPass("עריכה");
        }

        //======================
        // פונקציה לניקוי התאים
        //======================
        private void clearFields()
        {
            maskedID.Clear();
            txtPass.Text = "";
            txtPassConfirm.Text = "";
        }

        //===========================================
        //פונקציה לשמירת הסיסמה החדשה בבסיס נתונים
        //===========================================
        private void updateNewPass(string uv)
        {
            if (txtPass.Text != "" && txtPassConfirm.Text != "")
            {
                    if (valid.checkPassworduser(txtPass.Text) == true)  // בדיקת תקינות סיסמה
                    {
                        bool result = txtPass.Text.Equals(txtPassConfirm.Text);
                        if (txtPass.Text != string.Empty && txtPassConfirm.Text != string.Empty)
                        {
                            if (result)
                            {
                                Users user = new Users();
                                user.UserId = maskedID.Text;
                                user.Userpassword = txtPass.Text;
                                dataB.addNewPerm(user, txtPass.Text, result);
                                MessageBox.Show("שינוי סיסמה הצליח!");
                                this.Close();
                            }
                            else // כאשר הסימסאות לא נכונות
                            {
                                txtPass.BackColor = Color.Red;
                                txtPassConfirm.BackColor = Color.Red;
                                MessageBox.Show("סיסמאות אינן נכונות!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPass.BackColor = Color.White;
                                txtPassConfirm.BackColor = Color.White;
                                txtPass.Text = "";
                                txtPassConfirm.Text = "";
                                txtPass.Focus();
                                return;
                            }
                            txtPass.Enabled = false;
                            txtPassConfirm.Enabled = false;
                            return;
                        }
                    }
                    else
                        txtPass.BackColor = Color.Red;
                    txtPassConfirm.BackColor = Color.Red;
                    MessageBox.Show("סיסמה חייבת להכיל לפחות 5 תווים");
                    txtPass.BackColor = Color.White;
                    txtPassConfirm.BackColor = Color.White;
                    txtPass.Text = "";
                    txtPassConfirm.Text = "";
                    txtPass.Focus();
                }
                else // כאשר הסיסמאות לא שוות
                {
                    txtPass.BackColor = Color.Red;
                    txtPassConfirm.BackColor = Color.Red;
                    MessageBox.Show("אנא מלא את 2 השדות בהתאם!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.BackColor = Color.White;
                    txtPassConfirm.BackColor = Color.White;
                    txtPass.Text = "";
                    txtPassConfirm.Text = "";
                    txtPass.Focus();
                }
            }
        
        //================================
        //שליפת תעודת זהות של משתמש למסך 
        //================================
        private void ChangePassUserOrManger_Load(object sender, EventArgs e)
        {
            Users user;
            user = dataB.GetUserDetails(item);
            maskedID.Text = user.UserId;
        }
    }
}

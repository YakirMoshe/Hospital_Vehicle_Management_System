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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // כפתור יציאה
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // כפתור כניסה 
        {
            if(string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("בבקשה הכנס שם משתמש וסיסמה. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            try
            { 
                AppDataTableAdapters.UsersTableAdapter user = new AppDataTableAdapters.UsersTableAdapter(); // מסד נתונים
                AppData.UsersDataTable dt = user.GetDataByUsernamePassword(txtUsername.Text , txtPassword.Text); // לוודא שם משתמש וסיסמה
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("התחברת בהצחלה.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           this.Hide(); // כאשר נלחץ על כפתור כניסה נכנס למסך ראשי
                             mainGUI m = new mainGUI();
                               m.Show(); // להציג את המסך 
                }
                else
                {
                    MessageBox.Show("שם משתמש או סיסמה לא נכונים.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK , MessageBoxIcon.Error);
        }
      }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e) // שורת מילוי של השם משתמש
        {
            if (e.KeyChar == (char)13)
                txtPassword.Focus();

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // לא בשימוש
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e) // שורת מילוי של הסיסמה
        {
            if (e.KeyChar == (char)13)
                login.PerformClick();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) // לא בשימוש
        {

        }
    }
}

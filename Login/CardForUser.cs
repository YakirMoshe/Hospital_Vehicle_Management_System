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
    public partial class CardForUser : Form
    {
        private DBSQL dataB;
        private int item = 0;
        //======
        //בנאי
        //======
        public CardForUser(DBSQL dataB, bool newcar, int item)
        {
            InitializeComponent();
            this.dataB = dataB;
            this.item = item;
            if (!newcar) txtid.ReadOnly = true; // תעודת זהות לא ניתן לשינוי
        }

        //============
        //כפתור סגירה
        //============
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //===============================================================
        //לאחר לחיצה על מספר רכב  במסך ניהול משתמש נפתח פרטי בעל הרכב
        //===============================================================
        private void CardForUser_Load(object sender, EventArgs e)
        {
            Visitors visitor;
            visitor = dataB.GetEventDetails(item);
                txtid.Text = visitor.ID;
                txtCity.Text = visitor.City;
                txtphone.Text = visitor.PhoneNum;
            txtNote.Text = visitor.AdminComment;

            Cars car;
            car = dataB.GetEventDetailscar(item);
            txttype.Text = car.TypeCar;
            txtcolor.Text = car.ColorCar;
            txtyear.Text = car.YearCar;
        }

        //===================
        //עידכון הערה למבקר
        //===================
        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            if (txtNote.Text != "")
            {
                UpdatNote(txtNote.Text);
            }       
        }

        //===================================
        //פונקציה לשמירת הערה בבסיס נתונים
        //===================================
        private void UpdatNote(string uv)
        {
            string crId = txtNote.Text;
            string AdminComment = txtNote.Text;

            Visitors visitor = new Visitors();
            visitor.ID = txtid.Text;
            if (visitor.AdminComment == "")
                visitor.AdminComment = txtNote.Text;
            else
                visitor.AdminComment = txtNote.Text;
            dataB.UpdatNote(visitor, true);
            MessageBox.Show("הערה נשמרה");
        }
    }
}

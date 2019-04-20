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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void add_car_Click(object sender, EventArgs e)// כפתור הוספת רכב
        {
            this.Hide(); // להסתיר את המסך הקודם
            Add_CarGUI car = new Add_CarGUI(); // מסך הוספת רכב
            car.Show(); // להציג את המסך 
        }

        private void system_permissions_Click(object sender, EventArgs e) // כפתור הרשאות מערכת הוספת משתמש ומתן הרשאה
        {
            this.Hide(); // להסתיר את המסך הקודם
            SystemPermGUI per = new SystemPermGUI(); // מסך מתן הרשאות
            per.Show(); // להציג את המסך 
        }

        private void reportss_Click(object sender, EventArgs e) // כפתור הפקת דוחות
        {
            this.Hide(); // להסתיר את המסך הקודם
            ReportGUI rep = new ReportGUI(); // מסך מתן הרשאות
            rep.Show(); // להציג את המסך 
        }

        private void Car_management_Click(object sender, EventArgs e) // כפתור מידע רכבים
        {
            this.Hide(); // להסתיר את המסך הקודם
            informationCarGUI inf = new informationCarGUI(); // מסך מתן הרשאות
            inf.Show(); // להציג את המסך 
        }

        private void Manage_visitors_Click(object sender, EventArgs e) // כפתור מידע מבקרים
        {
            this.Hide(); // להסתיר את המסך הקודם
            InformationVisitorsGUI inv = new InformationVisitorsGUI(); // מסך מתן הרשאות
           inv.Show(); // להציג את המסך 
        }

       /* private void hideAdminButtons(שם משתמש, אדמין)*/
    }
}

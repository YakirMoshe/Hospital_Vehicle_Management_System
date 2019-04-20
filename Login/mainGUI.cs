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
    public partial class mainGUI : Form
    {
        private DBSQL dataB;
        private string loginID;
        public static string userName;
        //=====
        //בנאי
        //=====
        public mainGUI(DBSQL db)
        {
            InitializeComponent();
            this.dataB = db;
        }

        //==========
        //מסך משתמש
        //==========
        public void HideMangerButtons()
        {
            systemPermissions.Visible = false;
            GenerateReports.Visible = false;
            AddingVisitor.Visible = false;
            EditVisitorDetails.Visible = false;
            this.Text = "פאנל משתמש";
        }

        //=============================
        //כפתור הוספת מבקר/רכב למערכת
        //=============================
        private void add_car_Click(object sender, EventArgs e)
        {
            this.Hide(); // להסתיר את המסך הקודם
            add_CarVisitorGUI car = new add_CarVisitorGUI(dataB); 
            car.Show(); // להציג את המסך 
        }

        //===================
        // כפתור מידע מבקרים
        //===================
        private void Manage_visitors_Click(object sender, EventArgs e)
        {
            this.Hide(); // להסתיר את המסך הקודם
            informationVisitorsGUI inv = new informationVisitorsGUI(dataB);
            inv.Show(); // להציג את המסך 
        }

        //===================
        // כפתור מידע רכבים
        //===================
        private void Car_management_Click(object sender, EventArgs e)
        {
            this.Hide(); // להסתיר את המסך הקודם
            informationCarGUI inf = new informationCarGUI(dataB); 
            inf.Show(); // להציג את המסך 
        }

        //=============================================
        // כפתור הרשאות מערכת הוספת משתמש ומתן הרשאה
        //=============================================
        private void system_permissions_Click(object sender, EventArgs e)
        {
            this.Hide(); // להסתיר את המסך הקודם
            systemPermGUI per = new systemPermGUI(dataB); 
            per.Show(); // להציג את המסך 
        }

        //===================
        // כפתור הפקת דוחות
        //===================
        private void reportss_Click(object sender, EventArgs e)
        {
            this.Hide(); // להסתיר את המסך הקודם
            reportGUI rep = new reportGUI(dataB); 
            rep.Show(); // להציג את המסך 
        }

        //========================
        // כפתור אישור זמני לרכב
        //========================
        private void Approval_Click(object sender, EventArgs e)
        {
            this.Hide(); // להסתיר את המסך הקודם
            provisionalApprovalGUI pla = new provisionalApprovalGUI(dataB); 
            pla.Show(); // להציג את המסך 
        }

        //================
        // כפתור היסטוריה
        //================
        private void History_logins_Click(object sender, EventArgs e)
        {
            this.Hide(); // להסתיר את המסך הקודם
            historiGUI hist = new historiGUI(dataB); 
            hist.Show(); // להציג את המסך 
        }

        //===========================
        //כפתור עריכת פרטי מבקר/רכב
        //===========================
        private void EditVisitorDetails_Click(object sender, EventArgs e)
        {
            this.Hide(); // להסתיר את המסך הקודם
            editVisitCar dell = new editVisitCar(dataB);
            dell.Show(); // להציג את המסך 
        }

        //==================
        //מסך ניהול מבקרים
        //==================
        private void Editing_paths_Click(object sender, EventArgs e)
        {
            this.Hide(); // להסתיר את המסך הקודם
            UserMenuGUI Usm = new UserMenuGUI(dataB); 
            Usm.Show(); // להציג את המסך 
        }

        //==============================
        //מידע על לחצני התפריט הראשי
        //בזמן העברת עכבר מעל הכפתורים
        //==============================
        #region Detalis about main menu buttons
        //ראשי
        private void MainMenu()
        {
            rtbInfo11.LoadFile(Application.StartupPath + @"\info\MainMenu.rtf"); //פתיחת קובץ RTF למסך התפריט
        }
        private void PanelMain_MouseHover(object sender, EventArgs e)
        {
            rtbInfo11.LoadFile(Application.StartupPath + @"\info\MainMenu.rtf");
        }
        //ניהול מבקרים
        private void ManageVisitors_MouseHover(object sender, EventArgs e)
        {
            rtbInfo11.LoadFile(Application.StartupPath + @"\info\Manage_visitors.rtf");
        }
        // מידע מבקרים
        private void InformationVisitors_MouseHover(object sender, EventArgs e)
        {
            rtbInfo11.LoadFile(Application.StartupPath + @"\info\Information_Visitors.rtf");
        }
        //מידע רכבים
        private void VehicleLnformation_MouseHover(object sender, EventArgs e)
        {
            rtbInfo11.LoadFile(Application.StartupPath + @"\info\Vehicle_Lnformation.rtf");
        }
        //הוספת מבקר
        private void AddingVisitor_MouseHover(object sender, EventArgs e)
        {
            rtbInfo11.LoadFile(Application.StartupPath + @"\info\Adding_Visitor.rtf");
        }
        //היסטוריה
        private void HistoryLogins_MouseHover(object sender, EventArgs e)
        {
            rtbInfo11.LoadFile(Application.StartupPath + @"\info\History_Logins.rtf");
        }
        //עריכת פרטי מבקר
        private void EditVisitorDetails_MouseHover(object sender, EventArgs e)
        {
            rtbInfo11.LoadFile(Application.StartupPath + @"\info\Edit_VisitorDetails.rtf");
        }
        //הרשאות משתמש
        private void systemPermissions_MouseHover(object sender, EventArgs e)
        {
            rtbInfo11.LoadFile(Application.StartupPath + @"\info\system_Permissions.rtf");
        }
        //אישור זמני
        private void VehicleApproval_MouseHover(object sender, EventArgs e)
        {
            rtbInfo11.LoadFile(Application.StartupPath + @"\info\Vehicle_Approval.rtf");
        }
        //הפקת דוחות
        private void GenerateReports_MouseHover(object sender, EventArgs e)
        {
            rtbInfo11.LoadFile(Application.StartupPath + @"\info\Generate_Reports.rtf");
        }
        //==============
        //הצגת מסך מידע
        //==============
        private void mainGUI_Load(object sender, EventArgs e)
        {
            MainMenu();
        }

    }
}
#endregion Detalis about main menu buttons
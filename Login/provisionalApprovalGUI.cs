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
    public partial class provisionalApprovalGUI : Form
    {
        private DBSQL dataB;

        public provisionalApprovalGUI(DBSQL db)
        {
            InitializeComponent();
            this.dataB = db;
            this.dataGtime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //=========================
        //כפתור חזרה לתפריט הראשי
        //=========================
        private void buckM_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            mainGUI m = new mainGUI(dataB);
            loginGUI l = new loginGUI();
            if (!l.IsManager) // בדיקה אם זה מנהל או משתמש
            {
                m.HideMangerButtons();
            }
            m.Show(); // להציג את המסך 
        }

        //============
        //מסך הנתונים
        //============
        private void dataGtime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProvisionalApproval prov = new ProvisionalApproval();
            dataB.InsertProv(prov); // הכנסת נתונים לבסיס
        }

        //=============
        //טבלת DATAGRID
        //=============
        private void provisionalApprovalGUI_Load(object sender, EventArgs e)
        {
            editp.Enabled = false; //נעילת כפתור עריכה
            ProvisionalApproval prov = new ProvisionalApproval();
            loginGUI l = new loginGUI();
            if (!l.IsManager) // בדיקת התחברות מנהל או משתמש
            {
              HideMangerButtonsUpdate();
            }

            dataGtime.Rows.Clear();
            ProvisionalApproval[] pr; // מערך של רכבים
            pr = dataB.GetProvData(); // מכיל את כל המערך
            chcekProvEndDate(); // בדיקת פג תוקף אישור
             if (pr.Length == 0) //אם אין רכבים במערכת
             {
                 dataGtime.DataSource = null;
                 this.Close();
                 MessageBox.Show("אין רשומים במערכת", "Error");
             }
             else
             {

                dataGtime.ColumnCount = 14; // כמות עמודות
            dataGtime.RowCount = dataB.GetProvsNumber(); // כמות שורות מהטבלה באקסס
            dataGtime.Columns[0].HeaderText = "זמן התרחשות"; // להציג בעמודות
            dataGtime.Columns[1].HeaderText = "תעודת זהות";
            dataGtime.Columns[2].HeaderText = "שם פרטי";
            dataGtime.Columns[3].HeaderText = "שם משפחה";
            dataGtime.Columns[4].HeaderText = "סטטוס תו";
            dataGtime.Columns[5].HeaderText = "אישור כניסה מתאריך";
            dataGtime.Columns[6].HeaderText = "אישור כניסה עד";
            dataGtime.Columns[7].HeaderText = "סטטוס בקשה";
            dataGtime.Columns[8].HeaderText = "טלפון בעל הרכב";
            dataGtime.Columns[9].HeaderText = "מספר רכב";
            dataGtime.Columns[10].HeaderText = "סוג רכב";
            dataGtime.Columns[11].HeaderText = "צבע רכב";
            dataGtime.Columns[12].HeaderText = "מאשר";
            dataGtime.Columns[13].HeaderText = "סטטוס";
            int k;
            for (k = 0; k < pr.Length; k++)
            {
                dataGtime[0, k].Value = pr[k].ActivityTime;
                dataGtime[1, k].Value = pr[k].Idvis;
                dataGtime[2, k].Value = pr[k].FName;
                dataGtime[3, k].Value = pr[k].LName;
                dataGtime[4, k].Value = pr[k].CharacterStatus;
                dataGtime[5, k].Value = pr[k].StartDate;
                dataGtime[6, k].Value = pr[k].EndDate;
                dataGtime[7, k].Value = pr[k].RequestStatus;
                dataGtime[8, k].Value = pr[k].PhoneOwner;
                dataGtime[9, k].Value = pr[k].CId;
                dataGtime[10, k].Value = pr[k].TCar;
                dataGtime[11, k].Value = pr[k].CCar;
                dataGtime[12, k].Value = pr[k].TypeOk;
                dataGtime[13, k].Value = pr[k].StatusProv;
            }
        }
    }

        //=====================================
        //פונקציה לניקוי כל השדות לאחר פעולה
        //=====================================
        public void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
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

        //=================
        //כפתור שמירה מבקר
        //=================
        private void savep_Click(object sender, EventArgs e)
        { //בדיקה שכל השדות חובה מולאו בהצלחה
            bool flagState = true;
            if (String.IsNullOrEmpty(idvis.Text))
            {
                idvis.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(fname.Text))
            {
                fname.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(lname.Text))
            {
                lname.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(txtphone.Text))
            {
                txtphone.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(numcar.Text))
            {
                numcar.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(typecar.Text))
            {
                typecar.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(colorcar.Text))
            {
                colorcar.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(txtmos.Text))
            {
                txtmos.BackColor = Color.Red;
                flagState = false;
            }
            if (String.IsNullOrEmpty(txtunit.Text))
            {
                txtunit.BackColor = Color.Red;
                flagState = false;
            }
            if (flagState == true)
            {
                ProvisionalApproval provs = new ProvisionalApproval();
                if (valid.checkId(idvis.Text) == true) // בדיקת תקינות ת.ז
                {
                    int search;
                    int searchcar;
                    int flag1 = 0;
                    int flag2 = 0;

                    search = int.Parse(idvis.Text);
                    searchcar = int.Parse(numcar.Text);
                    flag1 = dataB.checkIfPorvExist(search); // בדיקה אם מבקר קיים במערכת
                    flag2 = dataB.checkIfPorvCarExist(searchcar); // בדיקה אם רכב כבר קיים במערת
                    if (flag1 == 1)
                    {
                        idvis.BackColor = Color.Red;
                        MessageBox.Show(provs.Idvis + "מבקר כבר קיים במערכת", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        idvis.BackColor = Color.White;
                        idvis.Clear();
                    }
                    if (flag2 == 1)
                    {
                        numcar.BackColor = Color.Red;
                        MessageBox.Show(provs.CId + "רכב כבר קיים במערכת", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        numcar.BackColor = Color.White;
                        numcar.Clear();
                        return;
                    }
                        //הכנסת נתונים של משתמש חדש
                        provs.ActivityTime = Convert.ToDateTime(activityTime.Text);
                            provs.Idvis = idvis.Text;
                            provs.FName = fname.Text;
                            provs.LName = lname.Text;
                            provs.CharacterStatus = charStatus.Text;
                            provs.StartDate = Convert.ToDateTime(dateTimeStart.Text);
                            provs.EndDate = Convert.ToDateTime(dateTimeEnd.Text);
                            provs.RequestStatus = requestStatus.Text;
                            provs.PhoneOwner = txtphone.Text;
                            provs.CId = numcar.Text;
                            provs.TCar = typecar.Text;
                            provs.CCar = colorcar.Text;
                            provs.Typemos = txtmos.Text;
                            provs.Unit = txtunit.Text;
                            provs.TypeOk = txttypeok.Text;
                            provs.StatusProv = cmbStatActiv.Text;

                            //בדיקת תקינות קלט פלט של הנתונים
                            bool[] err = new bool[3];
                            for (int i = 0; i < err.Length; i++)
                                err[i] = true;
                            err[0] = valid.checkId(provs.Idvis); // בדיקת תקינות תעודת זהות
                            err[1] = valid.checkPhone(provs.PhoneOwner); // בדיקת תקינות של מספר טלפון
                            err[2] = valid.checkcarId(provs.CId); // בדיקת תקינות של מספר רכב

                            bool flg = true;
                            for (int i = 0; i < err.Length; i++)
                            {
                                if (err[i] == false) // אם הנתונים לא תקינים הצג שגיאות מתאימות
                                {
                                    switch (i)
                                    {
                                        case 0:
                                            idvis.BackColor = Color.Red;
                                            MessageBox.Show("תעודת זהות לא תקינה");
                                            break;
                                        case 1:
                                            txtphone.BackColor = Color.Red;
                                            MessageBox.Show("מספר טלפון לא תקין");
                                            break;
                                        case 2:
                                            numcar.BackColor = Color.Red;
                                            MessageBox.Show("מספר רכב חייב להיות 7 ספרות");
                                            break;

                                    }
                                    flg = false;
                                }
                            }

                            if (flg == true) // אם הנתונים תקינים ללא שגיאות הכנס אותם לבסיס נתונים
                            {
                                dataB.InsertProv(provs); // חיבור לבסיס להוספה
                                MessageBox.Show("אישור זמני נוצר בהצלחה", "OK");
                                ClearTextBoxes(InfoVisBox);
                                RefreshLoad(); // ריענון
                            }
                        }
                        else
                        {
                           idvis.BackColor = Color.Red;
                          MessageBox.Show("תעודת זהות לא תקינה");
                            idvis.BackColor = Color.Red;
                            idvis.Clear();
                            idvis.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("נא מלא את השדות האדומים להוספת אישור זמני למבקר", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

        //======================
        //לחיצה על כפתור מחיקה
        //======================
        private void delp_Click(object sender, EventArgs e)
        {
            if (idvis.Text != "")
            {
                if (MessageBox.Show("אתה בטוח שאתה רוצה למחוק את המבקר ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Updateprovs("מחיקה");

            }
            else
            {
                txtSearch.BackColor = Color.Red;
                MessageBox.Show("לא נבחר מבקר למחיקה", "Error");
                txtSearch.BackColor = Color.White;
                txtSearch.Focus();
            }
        }

        //======================        
        //לחיצה על כפתור עריכה
        //======================
        private void editp_Click(object sender, EventArgs e)
        {
            if (idvis.Text != "")
            {
                Updateprovs("עריכה");
            ClearTextBoxes(InfoVisBox);
                savep.Enabled = true; // הפעלת כפתור יצירת מבקר
                editp.Enabled = false; // כיבוי כפתור הפעלה
            }
            else
            {
                MessageBox.Show("נא ללחוץ לחיצה כפולה על תעודת זהות לעריכת פרטים או על ידי חיפוש", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
            }
        }

        //=======================================
        //פונקציות של עריכת נתונים/מחיקת חשבון
        //=======================================
        private void Updateprovs(string pr)
        {
            if (idvis.Text != null)
            {
                DateTime ActivityTime = activityTime.Value;
                string Idvis = idvis.Text;
                string FName = fname.Text;
                string LName = lname.Text;
                string CharacterStatus = charStatus.Text;
                DateTime StartDate = dateTimeStart.Value;
                DateTime EndDate = dateTimeEnd.Value;
                string RequestStatus = requestStatus.Text;
                string PhoneOwner = txtphone.Text;
                string CId = numcar.Text;
                string TCar = typecar.Text;
                string CCar = colorcar.Text;
                string Typemos = txtmos.Text;
                string Unit = txtunit.Text;
                string TypeOk = txttypeok.Text;
                string StatusProv = cmbStatActiv.Text;

                //בדיקת תקינות קלט פלט של הנתונים
                bool[] err = new bool[3];
                for (int i = 0; i < err.Length; i++)
                    err[i] = true;
                err[0] = valid.checkId(Idvis); // בדיקת תקינות תעודת זהות
                err[1] = valid.checkPhone(PhoneOwner); // בדיקת תקינות של מספר טלפון
                err[2] = valid.checkcarId(CId); // בדיקת תקינות של מספר רכב

                bool flg = true;
                for (int i = 0; i < err.Length; i++)
                {
                    if (err[i] == false) // אם הנתונים לא תקינים הצג שגיאות מתאימות
                    {
                        switch (i)
                        {
                            case 0:
                                MessageBox.Show("תעודת זהות לא תקינה");
                                break;
                            case 1:
                                MessageBox.Show("מספר טלפון לא תקין");
                                break;
                            case 2:
                                MessageBox.Show("מספר רכב חייב להיות 7 או 8 ספרות");
                                break;
                        }
                        flg = false;
                    }
                }
                if (flg == true)
                {
                    ProvisionalApproval provs = new ProvisionalApproval();
                    provs.ActivityTime = activityTime.Value;
                    provs.Idvis = idvis.Text;
                    provs.FName = fname.Text;
                    provs.LName = lname.Text;
                    provs.CharacterStatus = charStatus.Text;
                    provs.StartDate = dateTimeStart.Value;
                    provs.EndDate = dateTimeEnd.Value;
                    provs.RequestStatus = requestStatus.Text;
                    provs.PhoneOwner = txtphone.Text;
                    provs.CId = numcar.Text;
                    provs.TCar = typecar.Text;
                    provs.CCar = colorcar.Text;
                    provs.Typemos = txtmos.Text;
                    provs.Unit = txtunit.Text;
                    provs.TypeOk = txttypeok.Text;
                    provs.StatusProv = cmbStatActiv.Text;

                    if (pr.Equals("עריכה"))
                    {
                        dataB.updateProvs(provs, true);
                        MessageBox.Show("פרטי מבקר עודכנו בהצלחה");
                        dataGtime.Update();
                        RefreshLoad(); // ריענון
                    }
                    if (pr.Equals("מחיקה"))
                    {

                        provs.StatusProv = "לא פעיל";
                        dataB.updateProvs(provs, false);
                        MessageBox.Show("המבקר נמחק מהמערכת");
                        ClearTextBoxes(InfoVisBox);
                        savep.Enabled = true; // הפעלת כפתור יצירת מבקר
                        editp.Enabled = false; // כיבוי כפתור הפעלה
                        RefreshLoad(); // ריענון
                    }
                }
                else
                    MessageBox.Show("לא בוצע עידכון,תקן פרטים");
            }
        }

        //==================================
        //מחיקה על ידי כפתור DELETE במקלדת
        //==================================
        private void dataGtime_KeyDown(object sender, KeyEventArgs e) 
        {
            ProvisionalApproval prov = new ProvisionalApproval();
            loginGUI l = new loginGUI();
            if (l.IsManager) // בדיקת התחברות מנהל או משתמש
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("אתה בטוח שאתה רוצה למחוק את המבקר ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Updateprovs("מחיקה");
                }
            }
        }

        //======================================
        //שדה חיפוש לאחר לחיצה על כפתור חיפוש
        //======================================
        private void btnsearcVis_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if (valid.checkId(txtSearch.Text) == true) // בדיקת תקינות ת.ז
                { 
                    int search;
                    int numRow;
                    int flag1 = 0;

                    search = int.Parse(txtSearch.Text);
                    flag1 = dataB.CheckprovExist(search);
                    if (flag1 == 1)
                    {
                        savep.Enabled = false; // כיבוי כפתור יצירה
                        editp.Enabled = true; // הפעלת כפתור הפעלה
                        ProvisionalApproval provs = new ProvisionalApproval();
                        provs = dataB.searchprovById(txtSearch.Text);
                        activityTime.Value = provs.ActivityTime;
                        txtmos.Text = provs.Typemos;
                        txtunit.Text = provs.Unit;
                        numcar.Text = provs.CId;
                        typecar.Text = provs.TCar;
                        colorcar.Text = provs.CCar;
                        txttypeok.Text = provs.TypeOk;
                        idvis.Text = provs.Idvis;
                        txtphone.Text = provs.PhoneOwner;
                        fname.Text = provs.FName;
                        lname.Text = provs.LName;
                        charStatus.Text = provs.CharacterStatus;
                        requestStatus.Text = provs.RequestStatus;
                        dateTimeStart.Value = provs.StartDate;
                        dateTimeEnd.Value = provs.EndDate;
                        cmbStatActiv.Text = provs.StatusProv;
                    }

                    else
                    {
                        txtSearch.BackColor = Color.Red;
                        MessageBox.Show("מבקר לא קיים");
                        txtSearch.BackColor = Color.White;
                        txtSearch.Clear();
                        txtSearch.Focus();
                    }
                }
                else
                {
                    txtSearch.BackColor = Color.Red;
                    MessageBox.Show("מספר זיהוי לא תקין");
                    txtSearch.BackColor = Color.White;
                    txtSearch.Clear();
                    txtSearch.Focus();
                }
            }
            else
            {
                txtSearch.BackColor = Color.Red;
                MessageBox.Show("נא להקליד מספר תעודת זהות");
                txtSearch.BackColor = Color.White;
                txtSearch.Focus();
            }
                }

        //===================================
        //פונקציה לבדיקת סיום האישור הזמני
        //===================================
        public void chcekProvEndDate()
        {
            string str = dataB.CheckDate("לא פעיל");
            ProvisionalApproval[] pal;
            pal = dataB.GetProvData();
            for (int i = 0; i < pal.Length; i++)
            {
                if (pal[i].StatusProv.Equals("פעיל")) // לבדוק ברגע שהסטטוס פעיל מתי הוא פג
                {
                    if (pal[i].EndDate < DateTime.Today) //בדיקת סיום תאריך אישור זמני
                    {
                        pal[i].StatusProv = "לא פעיל"; // אם פג תוקף שינוי הסטטוס ללא פעיל

                    }
                }
            }
        }

        //====================================
        //פונקציה לריענון הטבלה לאחר פעולות
        //====================================
        public void RefreshLoad()
        {
            dataGtime.Rows.Clear();
            ProvisionalApproval[] pr; // מערך של רכבים
            pr = dataB.GetProvData(); // מכיל את כל המערך
            chcekProvEndDate(); // בדיקת פג תוקף אישור

            dataGtime.ColumnCount = 14; // כמות עמודות
            dataGtime.RowCount = dataB.GetProvsNumber(); // כמות שורות מהטבלה באקסס
            dataGtime.Columns[0].HeaderText = "זמן התרחשות"; // להציג בעמודות
            dataGtime.Columns[1].HeaderText = "תעודת זהות";
            dataGtime.Columns[2].HeaderText = "שם פרטי";
            dataGtime.Columns[3].HeaderText = "שם משפחה";
            dataGtime.Columns[4].HeaderText = "סטטוס תו";
            dataGtime.Columns[5].HeaderText = "אישור כניסה מתאריך";
            dataGtime.Columns[6].HeaderText = "אישור כניסה עד תאריך";
            dataGtime.Columns[7].HeaderText = "סטטוס בקשה";
            dataGtime.Columns[8].HeaderText = "טלפון בעל הרכב";
            dataGtime.Columns[9].HeaderText = "מספר רכב";
            dataGtime.Columns[10].HeaderText = "סוג רכב";
            dataGtime.Columns[11].HeaderText = "צבע רכב";
            dataGtime.Columns[12].HeaderText = "מאשר";
            dataGtime.Columns[13].HeaderText = "סטטוס";
            int k;
            for (k = 0; k < pr.Length; k++)
            {
                dataGtime[0, k].Value = pr[k].ActivityTime;
                dataGtime[1, k].Value = pr[k].Idvis;
                dataGtime[2, k].Value = pr[k].FName;
                dataGtime[3, k].Value = pr[k].LName;
                dataGtime[4, k].Value = pr[k].CharacterStatus;
                dataGtime[5, k].Value = pr[k].StartDate;
                dataGtime[6, k].Value = pr[k].EndDate;
                dataGtime[7, k].Value = pr[k].RequestStatus;
                dataGtime[8, k].Value = pr[k].PhoneOwner;
                dataGtime[9, k].Value = pr[k].CId;
                dataGtime[10, k].Value = pr[k].TCar;
                dataGtime[11, k].Value = pr[k].CCar;
                dataGtime[12, k].Value = pr[k].TypeOk;
                dataGtime[13, k].Value = pr[k].StatusProv;
            }
        }

        //=========================================================
        //לחיצה כפולה על תעודת זהות ימלא את כל הפרטים של הבן אדם
        //=========================================================
        private void dataGtime_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            savep.Enabled = false; // נעילת כפתור יצירה
            editp.Enabled = true; // הפעלת כפתור עריכה
            try
            {
                int item = 0;
                
                if (e.ColumnIndex == 1)
                {
                    item = int.Parse(dataGtime.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                else if (e.ColumnIndex == 0)
                {
                    item = int.Parse(dataGtime.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                ProvisionalApproval provs = new ProvisionalApproval();
                provs = dataB.searchprovById(item);
                if (provs != null)
                {
                    activityTime.Value = provs.ActivityTime;
                    txtmos.Text = provs.Typemos;
                    txtunit.Text = provs.Unit;
                    numcar.Text = provs.CId;
                    typecar.Text = provs.TCar;
                    colorcar.Text = provs.CCar;
                    txttypeok.Text = provs.TypeOk;
                    idvis.Text = provs.Idvis;
                    txtphone.Text = provs.PhoneOwner;
                    fname.Text = provs.FName;
                    lname.Text = provs.LName;
                    charStatus.Text = provs.CharacterStatus;
                    requestStatus.Text = provs.RequestStatus;
                    dateTimeStart.Value = provs.StartDate;
                    dateTimeEnd.Value = provs.EndDate;
                    cmbStatActiv.Text = provs.StatusProv;
                }
            }
            catch (Exception)
            {
            }
        }

        //==================
        //מסך משתמש
        //ניעלת שדות עידכון
        //===================
        private void HideMangerButtonsUpdate()
        {
            InfoVisBox.Enabled = false;
            savep.Visible = false;
            editp.Visible = false;
            delp.Visible = false;
            buttonRef.Visible = false;
            this.Text = "פאנל משתמש - אישורים זמניים";
        }

        //====================
        //combobox קריאה בלבד
        //====================
        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        //=============================
        //פונקציה להחזרת שדה לצבע לבן
        //=============================
        private void textWhite()
        {
            if (!String.IsNullOrEmpty(idvis.Text))
            {
                idvis.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(fname.Text))
            {
                fname.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(lname.Text))
            {
                lname.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(txtphone.Text))
            {
                txtphone.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(numcar.Text))
            {
                numcar.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(typecar.Text))
            {
                typecar.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(colorcar.Text))
            {
                colorcar.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(txtmos.Text))
            {
                txtmos.BackColor = Color.White;
            }
            if (!String.IsNullOrEmpty(txtunit.Text))
            {
                txtunit.BackColor = Color.White;
            }
        }

        //============================
        // פונקציה שממספרת את השורות
        //============================
        #region WhiteText
        private void dataGtime_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGtime.RowHeadersDefaultCellStyle.ForeColor))
            {
                if (dataGtime.RightToLeft == RightToLeft.No) // בדיקה האם הטבלה מימין לשמאל
                {
                    e.Graphics.DrawString(e.RowIndex.ToString(), e.InheritedRowStyle.Font, b,
                        e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
                }
                else
                {
                    string index = e.RowIndex.ToString();
                    var size = e.Graphics.MeasureString(index, e.InheritedRowStyle.Font);
                    e.Graphics.DrawString(index, e.InheritedRowStyle.Font, b, e.RowBounds.Right - 20 - size.Width,
                        e.RowBounds.Location.Y + 4);
                }
            }
        }

        private void txtmos_SelectedIndexChanged(object sender, EventArgs e)
        {
            textWhite();
        }
        private void txtunit_SelectedIndexChanged(object sender, EventArgs e)
        {
            textWhite();
        }
        private void idvis_TextChanged(object sender, EventArgs e)
        {
            textWhite();
        }
        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            textWhite();
        }
        private void fname_TextChanged(object sender, EventArgs e)
        {
            textWhite();
        }
        private void lname_TextChanged(object sender, EventArgs e)
        {
            textWhite();
        }
        private void numcar_TextChanged(object sender, EventArgs e)
        {
            textWhite();
        }
        private void typecar_TextChanged(object sender, EventArgs e)
        {
            textWhite();
        }
        private void colorcar_TextChanged(object sender, EventArgs e)
        {
            textWhite();
        }
        //=============================================
        //הפעל כפתור חיפוש בעת לחיצה על אינטר במקלדת
        //=============================================
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsearcVis.PerformClick();
            }
        }

        //====================
        //כפתור לניקוי שדות
        //====================
        private void buttonRef_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(InfoVisBox);
            savep.Enabled = true; // הפעלת כפתור יצירת מבקר
            editp.Enabled = false; // כיבוי כפתור הפעלה
        }
    }
 }
#endregion WhiteText
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
    public partial class historiGUI : Form
    {
        private DBSQL dataB;
        private TreeNode rClickedNode;
        public historiGUI(DBSQL db)
        {
            InitializeComponent();
            this.dataB = db;
        }
        //=========================
        //כפתור חזרה לתפריט הראשי
        //=========================
        private void buckM_Click(object sender, EventArgs e)
        {
            this.Hide(); // כאשר נלחץ על כפתור כניסה נכנס למסך ראשי
            mainGUI m = new mainGUI(dataB);
            loginGUI l = new loginGUI();
            if (!l.IsManager)
            {
                m.HideMangerButtons();
            }
            m.Show(); // להציג את המסך 
        }


        //==================================
        // טעינת האפשרויות של העץ וטבלאות
        //==================================
        private void historiGUI_Load(object sender, EventArgs e)
        {
            HistoriTree.ExpandAll();
            datahistoryAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //====================
        //קביעת גודל לכותרות
        //====================
        private void orderColumnsWidth()
        {
            datahistoryAll.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            datahistoryAll.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            datahistoryAll.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            datahistoryAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //====================================================
        // אירוע שמתרחש כאשר משתמש בוחר את הצומת שהוא רוצה
        // הגדרת הנתונים המבוקשים.
        //====================================================
        private void HistoriTree_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClearTextBoxes(pnlCardVisit); //ניקוי שדות לאחר פעולה חדשה
                ClearTextBoxes(panelEvent);
                Point p = new Point(e.X, e.Y);
                rClickedNode = HistoriTree.GetNodeAt(p);
                if (rClickedNode != null)
                {
                    // בחר כותרת ל - txtEventTitle
                    string eventTitleTxt = "";
                    TreeNode tmpNode = rClickedNode;
                    while (tmpNode != null)
                    {
                        eventTitleTxt = tmpNode.Text + " -> " + eventTitleTxt;
                        tmpNode = tmpNode.Parent; // הצגת כותרת מעבר מאבא לילד
                    } //להסיר "->" מסוף הכותרת
                    eventTitleTxt = eventTitleTxt.Remove(eventTitleTxt.Length - 3);
                    txtEventTitle.Text = eventTitleTxt; //  מכניס את הכותרת לשדה
                    datahistoryAll.Columns.Clear();
                    HistoriTree.SelectedNode = rClickedNode;
                    groupBox1.Enabled = true;
                    switch (rClickedNode.Tag.ToString()) // בדיקה מה שהמשתמש בחר בהיסטוריה או בסיכום שוטף
                    {
                        case "AllCheckin":
                            UpdatedatahistoryAllHistoric(rClickedNode.Name); // קריאה לפונקציה לבקשת נתונים היסטוריים
                            break;
                          case "AllChekout":
                              UpdatedatahistoryAllHistoric(rClickedNode.Name); // קריאה לפונקציה לבקשת נתונים היסטוריים
                              break;
                        case "current":
                            UpdatedatahistoryAllCurrent(rClickedNode.Name); // קריאה לפונקציה לקבלת מבקרים הנמצאים או לא
                            break;
                        default:
                            datahistoryAll.DataSource = null;
                            break;
                    }
                }
            }
        }

        //=================================================================================
        // מקבל מחרוזת אירוע לבדוק כניסה או יציאה מהבית חולים
        // בקשת נתונים היסטוריים ממסד הנתונים וממלא את datagridview // עם כל הנתונים.
        //=================================================================================
        private void UpdatedatahistoryAllHistoric(string _event)
        {
            DataTable dt = new DataTable();
            //לקבל מידע מהבסיס נתונים
            dt = dataB.getEvent(_event);//אם נבחר כניסות או יציאות
            datahistoryAll.DataSource = dt; // משיכת טבלה 
            orderColumnsWidth(); // קריאה לפונקציה לסידור הטבלה
            datahistoryAll.Sort(datahistoryAll.Columns[1], ListSortDirection.Descending); // למיין לפי תאריך
        }

        //====================================================================
        // מעדכן אירוע כניסה או יציאה
        // נתונים שוטפים ממסד הנתונים וממלא את datagridview עם כל הנתונים.
        //====================================================================
        private void UpdatedatahistoryAllCurrent(string _event)
        {
            DataTable dt = new DataTable();
            dt = dataB.getCurrentChecked(_event); // בדיקה מי קיים בתוך הבית חולים או יצא
            datahistoryAll.DataSource = dt; // משיכת הטבלה
            SumColumnsWidth(); // סידור גודל כותרות
        }

        //====================
        //קביעת גודל כותרות למסך סיכום
        //====================
        private void SumColumnsWidth()
        {
            datahistoryAll.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            datahistoryAll.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            datahistoryAll.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            datahistoryAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            datahistoryAll.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //=================================================
        // האירוע הזה מתרחש כאשר משתמש בוחר שורה
        // ממלא את חלון התצוגה המקדימה עם הנתונים שנבחרו
        //=================================================
        private void datahistoryAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            { // אין כותרת במקום שנבחר
                try
                {
                    string idcar = "";
                    switch (rClickedNode.Tag.ToString())
                    { 
                        case "AllCheckin": // טבלאת הכניסות
                        idcar = datahistoryAll.Rows[e.RowIndex].Cells[2].Value.ToString(); // לחיצה על שורה שלישית של מספר רכב לקבל פרטי בעל הרכב
                            panelEvent.Visible = true;
                            radioParking.Enabled = false;
                            radioParkingWork.Enabled = false;
                            break;
                        case "AllChekout": // טבלת היציאות
                            idcar = datahistoryAll.Rows[e.RowIndex].Cells[2].Value.ToString(); // לחיצה על שורה שלישית של מספר רכב לקבל פרטי בעל הרכב
                            panelEvent.Visible = true;
                            radioParking.Enabled = false;
                            radioParkingWork.Enabled = false;
                            break;
                        case "current":
                            idcar = datahistoryAll.Rows[e.RowIndex].Cells[1].Value.ToString();
                            loadVisitorCard(idcar); // קריאה לפונקציה להוצאת פרטי בעל הרכב
                            panelEvent.Visible = false;
                            radioParking.Enabled = false;
                            radioParkingWork.Enabled = false;
                            return;
                            break;
                        default:
                            datahistoryAll.DataSource = null;
                            panelEvent.Visible = true;
                            break;
                    }
                    //מילוי שדות מבקר
                    loadVisitorCard(idcar); // קריאה לפונקציה להוצאת פרטי בעל הרכב
                    txtLogged.Text = datahistoryAll.Rows[e.RowIndex].Cells[0].Value.ToString(); // שליפת התאריך כניסה לשדה המתאים
                    txtEventType.Text = datahistoryAll.Rows[e.RowIndex].Cells[1].Value.ToString(); // שליפת האירוע לשדה המתאים
                    txtComment.Text = datahistoryAll.Rows[e.RowIndex].Cells[3].Value.ToString(); // שליפת הערת משתמש לשדה המתאים
                }
                catch (Exception)
                {
                }
            }
        }

        //===============================
        //הצגת כרטיס מבקר ומילוי השדות
        //===============================
        internal void loadVisitorCard(string carID)
           {
               Visitors visitor;
               visitor = dataB.GetVisitorDetailscar(carID);
               txtFirstName.Text = visitor.FirstName;
               txtLastName.Text = visitor.LastName;
               txtcarID.Text = visitor.CrId;
               txtWorkerID.Text = visitor.WorkerID;
               txtPhoneNumber.Text = visitor.PhoneNum;
            if (visitor.PermissionPaths == "חניון בית חולים")
            {
                radioParking.Checked = true;
                radioParkingWork.Checked = false;
            }

            else
            {
                radioParking.Checked = false;
                radioParkingWork.Checked = true;
            }
        }

        //=====================================
        //פונקציה לניקוי כל התאים לאחר פעולה
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

        //============================
        // פונקציה שממספרת את השורות
        //============================
        private void datahistoryAll_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(datahistoryAll.RowHeadersDefaultCellStyle.ForeColor))
            {
                if (datahistoryAll.RightToLeft == RightToLeft.No) // בדיקה האם הטבלה מימין לשמאל
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
    }
 }

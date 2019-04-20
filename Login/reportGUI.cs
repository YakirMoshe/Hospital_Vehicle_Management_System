using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp; 
using iTextSharp.text;
using iTextSharp.text.pdf; 
using System.Collections;

namespace Login
{
    public partial class reportGUI : Form
    {
        private SaveFileDialog savefileDialog;
        private DateTime start = DateTime.Today;
        private DateTime end = DateTime.Today;
        private DBSQL dataB;
        public static int data;

        public reportGUI(DBSQL dataB)
        {
            InitializeComponent();
            this.dataB = dataB;
        }

        //==================================================
        // פונקציה שמקבלים את הנתיב של מיקום לשמירה במחשב
        //==================================================
        private void browse_Click(object sender, EventArgs e)
        {
            savefileDialog = new SaveFileDialog();
            savefileDialog.FileName = string.Empty;
            if (savefileDialog.ShowDialog() == DialogResult.OK)
            {
                if (savefileDialog.FileName != string.Empty)
                    txtPath.Text = savefileDialog.FileName;
            }
        }

        //========================
        //כפתור ליצירת קובץ PDF
        //========================
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool flagState = true;//זיהוי בחירה
            //בדיקה אם נבחר קומבו
            if (cmdTypeReport.SelectedIndex > 0) 
            {
                cmdTypeReport.BackColor = Color.White;
            }
            else
            {
                // אחרת לצבוע באדום ולשלוח הודעה מתאימה
                flagState = false; 
                cmdTypeReport.BackColor = Color.Red;
            }
            //בדיקה אם נבחר אופציה לפי תאריך
            if (!chkPdfByDeate.Checked)
            { // אם לא נבחר לקחת את כולם
                start = DateTime.MinValue;
                end = DateTime.MaxValue;
            }
            else
            {
                DateTime.TryParse(dateFrom.Text, out start);
                DateTime.TryParse(dateTo.Text, out end);
            }

            // בדיקה שהוכנס נתיב להניח את הקובץ
            if (txtPath.Text == string.Empty) 
            {
                //אם לא לצבוע לאדום
                txtPath.BackColor = Color.Red; 
                flagState = false;
            }
            else
                txtPath.BackColor = Color.White;

            //בדוק תאריך התחלה לפני  מ
            //בדיקה אם נבחר כפתור רדיו
            if (flagState) // בדוק שהכל הוכנס
            {
                //אם נבחר מבקרים/רכבים ללא כפתורי רדיו
                if (groupStatusPdf.Enabled == true)
                {
                    if (cmdTypeReport.SelectedIndex == 1 || cmdTypeReport.SelectedIndex == 2) //מבקרים / רכבים
                    {
                        RadioButton rb = groupStatusPdf.Controls.OfType<RadioButton>() // חיפוש בחירת רדיו
                              .FirstOrDefault(r => r.Checked);
                        if (rb == null)  // אם לא נבחר כפתור רדיו
                        {
                            flagState = false; // אחרת לצבוע באדום ולשלוח הודעה מתאימה
                            groupStatusPdf.BackColor = Color.Red;
                            MessageBox.Show("תבחר בבקשה סוג דוח מפורט", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                            groupStatusPdf.BackColor = System.Drawing.ColorTranslator.FromHtml("#CCCCCC");
                        if (DateTime.Compare(start, end) == -1 || DateTime.Compare(start, end) == 0)
                        {
                            createPdf(start, end); // קריאה לפונקציה ליצירת הקובץ
                            txtPath.Clear(); // ניקוי שדה השמירה לאחר היציאה
                            cmdTypeReport.SelectedIndex = 0; // ניקוי הקומבו
                            MessageBox.Show("הקובץ נוצר בהצלחה !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                            MessageBox.Show("הזן תאריך התחלה מוקדם מתאריך הסיום", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }               
                    else
                    {
                        if (DateTime.Compare(start, end) == -1 || DateTime.Compare(start, end) == 0)
                        {
                            createPdf(start, end); // קריאה לפונקציה ליצירת הקובץ
                            txtPath.Clear(); // ניקוי שדה השמירה לאחר היציאה
                            cmdTypeReport.SelectedIndex = 0; // ניקוי הקומבו
                            MessageBox.Show("הקובץ נוצר בהצלחה !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } // אם בחירת תאריך לא תקין
                        else
                            MessageBox.Show("הזן תאריך התחלה מוקדם מתאריך הסיום", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      }
                    } // אם בחירת רדיו כבויה
                if (DateTime.Compare(start, end) == -1 || DateTime.Compare(start, end) == 0)
                {
                    createPdf(start, end); // קריאה לפונקציה ליצירת הקובץ
                    txtPath.Clear(); // ניקוי שדה השמירה לאחר היציראה
                    cmdTypeReport.SelectedIndex = 0; // ניקוי הקומבו
                    MessageBox.Show("הקובץ נוצר בהצלחה !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } // אם בחירת תאריך לא תקין
                else
                    MessageBox.Show("הזן תאריך התחלה מוקדם מתאריך הסיום", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // אם לא הוכנס פרטים
            else
            MessageBox.Show("אנא מלא את השדות האדומים ליצירת דוח ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
            
        //=============================================
        //ליצור את הקובץ על ידי מה שהמשתמש בחר בפאנל
        // למצוא את המבקרים
        //=============================================
        private void createPdf(DateTime start, DateTime end)
        {
            string state = "";
            ArrayList data;
            Visitors[] visitor = dataB.GetpdfVisitorsData();
            Cars[] car = dataB.GetpdfCarsData();
            Users[] use = dataB.GetpdfUsersData();
            PdfPTable myTable;
            PdfPCell myCell = new PdfPCell();
            myCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //פונט מימין לשמאל
            myCell.BackgroundColor = BaseColor.LIGHT_GRAY; //תא צבעוני
            myCell.BorderColor = BaseColor.DARK_GRAY;
            myCell.HorizontalAlignment = Element.ALIGN_CENTER;
            myCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            Document doc = new Document(iTextSharp.text.PageSize.LETTER);

            iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(txtPath.Text + ".pdf", FileMode.Create)); // שמירה
            doc.Open();
            // נתיב מלא לקובץ Gisha
            string ARIALUNI_TFF = Path.Combine(@"C:\Windows\Fonts", "Gisha.ttf");
            //יצירת אובייקט גופן בסיסי
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            //יצירת אובייקט גופן מסוים
            iTextSharp.text.Font hebFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
            Paragraph par = new Paragraph(new Phrase(":טוריפ חוד ", new iTextSharp.text.Font(bf, 10f, iTextSharp.text.Font.UNDERLINE | iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE)));
            par.Alignment = Element.ALIGN_RIGHT; // מימין לשמאל
            Paragraph pr = new Paragraph("img1.jpg");

            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"img1.jpg");
            jpg.Alignment = Element.ALIGN_CENTER;
            doc.Add(jpg);
            par.Add("\n\n");
            doc.Add(par);

            //========================================
            // בדיקה אם נבחר בחירה דרך כפתורי הרדיו
            //========================================           
            RadioButton rb = groupStatusPdf.Controls.OfType<RadioButton>()
            .FirstOrDefault(r => r.Checked);
            if (rb == null) state += "";
           else if (rb.Checked) state += rb.Text.ToString();

            //======================================
            //הצגת הנתונים לפי בחירת משתמש בקומבו
            //======================================
            switch (cmdTypeReport.SelectedIndex)
                {
                    case 1: //בדיקת בחירה רדיו הכל/עובדים
                            // כותרת לקובץ בהתאם                                          
                    PdfPTable table1 = new PdfPTable(1);
                    Paragraph text1 = new Paragraph(new Phrase("המבקרים שרשומים במערכת:", new iTextSharp.text.Font(bf, 16f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.DARK_GRAY)));
                    text1.Add(new Paragraph("\n\n"));
                    PdfPCell cell1 = new PdfPCell(text1);
                    table1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    text1.Alignment = Element.ALIGN_CENTER;
                    table1.AddCell(cell1);
                    doc.Add(table1);
                    visitor = getResultQuery(start, end, cmdTypeReport.SelectedItem.ToString(), state);
                        myTable = createTableWorkVis(visitor, int.Parse(cmdTypeReport.SelectedIndex.ToString()));
                        myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //פונט מימין לשמאל
                        doc.Add(myTable);
                        doc.Add(new Paragraph("\n\n"));
                        doc.Add(new Paragraph(new Phrase("לכה ךס : " + visitor.Length, new iTextSharp.text.Font(bf, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK))));                    
                    break;

                    case 2: // דוח כל הרכבים במערכת
                   // כותרת לקובץ בהתאם                                          
                    PdfPTable table2 = new PdfPTable(1);                  
                    Paragraph text2 = new Paragraph(new Phrase("הרכבים שרשומים במערכת:", new iTextSharp.text.Font(bf, 16f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.DARK_GRAY)));
                    text2.Add(new Paragraph("\n\n"));
                    PdfPCell cell2 = new PdfPCell(text2);
                    table2.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    text2.Alignment = Element.ALIGN_CENTER;
                     table2.AddCell(cell2);
                    doc.Add(table2);
                    data = dataB.GetInformationAboutCars(start, end, cmdTypeReport.SelectedItem.ToString(), state);
                        myTable = tableOfCars(data, int.Parse(cmdTypeReport.SelectedIndex.ToString())); // ליצור את הטבלה
                        myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //פונט מימין לשמאל
                        doc.Add(myTable);
                        doc.Add(new Paragraph("\n\n"));
                        doc.Add(new Paragraph(new Phrase("לכה ךס : " + data.Count, new iTextSharp.text.Font(bf, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK))));             
                    break;

                    case 3: // דוח חניון סגל
                            // כותרת לקובץ בהתאם                                          
                    PdfPTable table3 = new PdfPTable(1);
                    Paragraph text3 = new Paragraph(new Phrase("כל הרכבים המורשים לכנס לחניון סגל:", new iTextSharp.text.Font(bf, 16f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.DARK_GRAY)));
                    text3.Add(new Paragraph("\n\n"));
                    PdfPCell cell3 = new PdfPCell(text3);
                    table3.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    text3.Alignment = Element.ALIGN_CENTER;
                    table3.AddCell(cell3);
                    doc.Add(table3);
                    data = dataB.GetInformationAboutCars(start, end, cmdTypeReport.SelectedItem.ToString(), state);
                        myTable = tableOfCars(data, int.Parse(cmdTypeReport.SelectedIndex.ToString())); // ליצור את הטבלה
                        myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //פונט מימין לשמאל
                        doc.Add(myTable);
                        doc.Add(new Paragraph("\n\n"));
                        doc.Add(new Paragraph(new Phrase("לכה ךס : " + data.Count, new iTextSharp.text.Font(bf, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK))));
                        break;

                    case 4: // דוח חניון בית חולים
                            // כותרת לקובץ בהתאם                                          
                    PdfPTable table4 = new PdfPTable(1);
                    Paragraph text4 = new Paragraph(new Phrase("כל הרכבים הרשומים בכניסת חניון בית החולים:", new iTextSharp.text.Font(bf, 16f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.DARK_GRAY)));
                    text4.Add(new Paragraph("\n\n"));
                    PdfPCell cell4 = new PdfPCell(text4);
                    table4.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    text4.Alignment = Element.ALIGN_CENTER;
                    table4.AddCell(cell4);
                    doc.Add(table4);
                    data = dataB.GetInformationAboutCars(start, end, cmdTypeReport.SelectedItem.ToString(), state);
                        myTable = tableOfCars(data, int.Parse(cmdTypeReport.SelectedIndex.ToString())); // ליצור את הטבלה
                        myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //פונט מימין לשמאל
                        doc.Add(myTable);
                        doc.Add(new Paragraph("\n\n"));
                        doc.Add(new Paragraph(new Phrase("לכה ךס : " + data.Count, new iTextSharp.text.Font(bf, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK))));
                        break;

                    case 5: // דוח משתמשים
                          // כותרת לקובץ בהתאם                                          
                    PdfPTable table5 = new PdfPTable(1);
                    Paragraph text5 = new Paragraph(new Phrase("כל משתמשי המערכת המורשים לחשיפת התוכנה", new iTextSharp.text.Font(bf, 16f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.DARK_GRAY)));
                    text5.Add(new Paragraph("\n\n"));
                    PdfPCell cell5 = new PdfPCell(text5);
                    table5.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    text5.Alignment = Element.ALIGN_CENTER;
                    table5.AddCell(cell5);
                    doc.Add(table5);
                    data = dataB.GetInformationAboutUsers(start, end, cmdTypeReport.SelectedItem.ToString(), state);
                        myTable = tableOfUsers(data, int.Parse(cmdTypeReport.SelectedIndex.ToString())); // ליצור את הטבלה
                        myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //פונט מימין לשמאל
                        doc.Add(myTable);
                        doc.Add(new Paragraph("\n\n"));
                        doc.Add(new Paragraph(new Phrase("לכה ךס : " + data.Count, new iTextSharp.text.Font(bf, 10f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK))));
                        break;
                }
                doc.Close();           
        }

        //=====================
        // קבל את פרטי המבקר
        //=====================
        private Visitors[] getResultQuery(DateTime start, DateTime end, string typeGroup, string state)
        {
            Visitors[] visArr;
            visArr = dataB.GetInformationAboutVisitorsAndWorker(start, end, typeGroup, state);
            return visArr;
        }

        //========================================
        //פונקציה ליצור טבלה עבור מבקרים מקבוצה
        //========================================
        private PdfPTable createTableWorkVis(Visitors[] vis, int group)
        {
            PdfPTable myTable = null;
            Visitors[] visitor = vis;
            if (group == 0 || group == 1 || group == 2 || group == 3)
            {
                myTable = new PdfPTable(11); // גודל טבלה
                string ARIALUNI_TFF = Path.Combine(@"C:\Windows\Fonts", "Arial.ttf");
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font hebFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //פונט מימין לשמאל
                myTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                myTable.TotalWidth = 560f;
                myTable.LockedWidth = true;
                float[] widths = new float[] { 60f, 80f, 60f, 80f, 80f, 70f, 60f, 50f, 70f, 60f, 80f };
                myTable.SetWidths(widths);
                myTable = tableOfWorkerVisitor(visitor, myTable, group);
            }
            return myTable;
        }

        //==============================
        // פונקציה להחזיר מבקר או עובד
        //==============================
        private PdfPTable tableOfWorkerVisitor(Visitors[] visitor, PdfPTable myTable, int group)
        {
            PdfPTable Table = myTable;
            PdfPCell myCell = new PdfPCell();
            string ARIALUNI_TFF = Path.Combine(@"C:\Windows\Fonts", "Gisha.ttf"); // פונט
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            //יצירת אובייקט גופן מסוים
            iTextSharp.text.Font hebFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
            myCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //פונט מימין לשמאל
            Table.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //טבלה מימין לשמאל
            myCell.BackgroundColor = BaseColor.LIGHT_GRAY; //תא צבעוני
            myCell.BorderColor = BaseColor.DARK_GRAY;
            myCell.HorizontalAlignment = Element.ALIGN_CENTER;
            myCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            myCell.FixedHeight = 15;

            if (visitor.Length != 0) /* כותרת + עיצוב */
            {
                var myFont = new iTextSharp.text.Font(bf, 8f, iTextSharp.text.Font.UNDERLINE | iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE);
                myCell.Phrase = new Phrase("תעודת זהות", myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase("שם פרטי", myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase("שם משפחה", myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase("עיר", myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase("רחוב", myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase("פלאפון", myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase("מס עובד", myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase("תאריך יצירה", myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase("סטטוס", myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase("הרשאות", myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase("קבוצה", myFont);
                Table.AddCell(myCell);
            } /* פרטים על המבקרים או העובדים */
            for (int j = 0; j < visitor.Length; j++)
            {
                var myFont = new iTextSharp.text.Font(bf, 8f);
                myCell.BackgroundColor = BaseColor.WHITE;               
                myCell.Phrase = new Phrase(visitor[j].ID, myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase(visitor[j].FirstName, myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase(visitor[j].LastName, myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase(visitor[j].City, myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase(visitor[j].Street, myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase(visitor[j].PhoneNum, myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase(visitor[j].WorkerID, myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase(visitor[j].CreateDate.ToString(), myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase(visitor[j].StatusVisitor, myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase(visitor[j].PermissionPaths, myFont);
                Table.AddCell(myCell);
                myCell.Phrase = new Phrase(visitor[j].Group, myFont);
                Table.AddCell(myCell);
            }
            return Table;
        }

        //=================
        //יצירת הטבלה לרכב
        //=================
        private PdfPTable tableOfCars(ArrayList data, int group)
        {
            PdfPTable Table = getTableCars(); // טבלה
            PdfPCell myCell = new PdfPCell();//תאים
            myCell.BackgroundColor = BaseColor.LIGHT_GRAY; //תא צבעוני
            myCell.FixedHeight = 20;
            myCell.BorderColor = BaseColor.DARK_GRAY;
            myCell.HorizontalAlignment = Element.ALIGN_CENTER;
            myCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            myCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //פונט מימין לשמאל
            Table.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //טבלה מימין לשמאל
            string ARIALUNI_TFF = Path.Combine(@"C:\Windows\Fonts", "Gisha.ttf");
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font hebFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);

            ArrayList list = data; // רשימה
            object[] anArray = list.ToArray();
            int i = 0;
            int j = 0, k = 0;
            int N = 1;
            if (data.Count != 0)
                N = data.Count;
            Cars[] car = new Cars[N];
            var myFont = new iTextSharp.text.Font(bf, 10f, iTextSharp.text.Font.UNDERLINE | iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE);
            myCell.Phrase = new Phrase("תעודת זהות", myFont);
            Table.AddCell(myCell);
            myCell.Phrase = new Phrase("מספר רכב", myFont);
            Table.AddCell(myCell);
            myCell.Phrase = new Phrase("סוג רכב", myFont);
            Table.AddCell(myCell);
            myCell.Phrase = new Phrase("שנת יצור", myFont);
            Table.AddCell(myCell);
            myCell.Phrase = new Phrase("צבע רכב", myFont);
            Table.AddCell(myCell);
            myCell.Phrase = new Phrase("הרשאות", myFont);
            Table.AddCell(myCell);
            myCell.Phrase = new Phrase("קבוצה", myFont);
            Table.AddCell(myCell);
            myCell.Phrase = new Phrase("סטטוס", myFont);
            Table.AddCell(myCell);
            /* אירגון הנתונים למחלקות */
            while (i < anArray.Count() && anArray.Count() != 0)
            {
                if (anArray[i] is Login.Cars)
                {
                    car[k] = ((Login.Cars)anArray[i]);
                    k++;
                }
                i++;
            }
            if (anArray.Count() != 0)
                Table = createCarsTable(Table, car, N, myCell);
            return Table;
        }

        //==========================
        //יצירת הטבלה משתמשי מערכת
        //==========================
        private PdfPTable tableOfUsers(ArrayList data, int group)
        {
            PdfPTable Table = getTableUsers();
            PdfPCell myCell = new PdfPCell();
            myCell.BackgroundColor = BaseColor.LIGHT_GRAY; //תא צבעוני
            myCell.FixedHeight = 15;
            myCell.BorderColor = BaseColor.DARK_GRAY;
            myCell.HorizontalAlignment = Element.ALIGN_CENTER;
            myCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            myCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //פונט מימין לשמאל
            Table.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //טבלה מימין לשמאל
            string ARIALUNI_TFF = Path.Combine(@"C:\Windows\Fonts", "Gisha.ttf");
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font hebFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);

            ArrayList list = data; // רשימה
            object[] anArray = list.ToArray();
            int i = 0;
            int j = 0, k = 0;
            int N = 1;
            if (data.Count != 0)
                N = data.Count;
            Users[] use = new Users[N];

            var myFont = new iTextSharp.text.Font(bf, 10f, iTextSharp.text.Font.UNDERLINE | iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE);
            myCell.Phrase = new Phrase("תעודת זהות", myFont);
            Table.AddCell(myCell);
            myCell.Phrase = new Phrase("שם מלא", myFont);
            Table.AddCell(myCell);
            myCell.Phrase = new Phrase("שם משתמש", myFont);
            Table.AddCell(myCell);
            myCell.Phrase = new Phrase("הרשאות", myFont);
            Table.AddCell(myCell);
            /* אירגון הנתונים למחלקות */
            while (i < anArray.Count() && anArray.Count() != 0)
            {
                if (anArray[i] is Login.Users)
                {
                    use[k] = ((Login.Users)anArray[i]);
                    k++;
                }
                i++;
            }
            if (anArray.Count() != 0)
                Table = createUserssTable(Table, use, N, myCell);
            return Table;
        }

        //===========================================================
        //פונקציה ליצור טבלה ולהגדיר הגדרות עבור הטבלה עבור רכבים
        //===========================================================
        private PdfPTable getTableCars()
        {
            PdfPTable myTable = new PdfPTable(8); // גודל הטבלה
            myTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            string ARIALUNI_TFF = Path.Combine(@"C:\Windows\Fonts", "Gisha.ttf");
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font hebFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
            myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //מימין לשמאל
            myTable.TotalWidth = 570f;
            myTable.LockedWidth = true;
            float[] widths = new float[] { 60f, 80f, 80f, 50f, 50f, 50f, 60f, 80f };
            myTable.SetWidths(widths);
            return myTable;
        }

        //==============================================================
        // פונקציה ליצור טבלה ולהגדיר הגדרות עבור הטבלה עבור משתמשים
        //==============================================================
        private PdfPTable getTableUsers()
        {
            PdfPTable myTable = new PdfPTable(4); // גודל הטבלה
            myTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            string ARIALUNI_TFF = Path.Combine(@"C:\Windows\Fonts", "Gisha.ttf");
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font hebFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
            myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //מימין לשמאל
            myTable.TotalWidth = 570f;
            myTable.LockedWidth = true;
            float[] widths = new float[] { 80f, 80f, 60f, 60f };
            myTable.SetWidths(widths);
            return myTable;
        }

        //==================================
        // פונקציה להחזיר טבלה עם פרטי רכב
        //==================================
        private PdfPTable createCarsTable(PdfPTable Table, Cars[] car, int size, PdfPCell myCell)
        {
            PdfPCell cell = myCell;
            cell.BackgroundColor = BaseColor.WHITE;
            PdfPTable tableTmp = Table;
            string ARIALUNI_TFF = Path.Combine(@"C:\Windows\Fonts", "Gisha.ttf");
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font hebFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
            myCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //מימין לשמאל
            Table.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //טבלה מימין לשמאל
            int i = 0;
            while (i < size && size != 0)
            {
                var myFont = new iTextSharp.text.Font(bf, 8f);
                cell.Phrase = new Phrase(car[i].IDVis.ToString(), myFont);
                Table.AddCell(myCell);
                cell.Phrase = new Phrase(car[i].CarId.ToString(), myFont);
                Table.AddCell(myCell);
                cell.Phrase = new Phrase(car[i].TypeCar.ToString(), myFont);
                Table.AddCell(myCell);
                cell.Phrase = new Phrase(car[i].YearCar.ToString(), myFont);
                Table.AddCell(myCell);
                cell.Phrase = new Phrase(car[i].ColorCar.ToString(), myFont);
                Table.AddCell(myCell);
                cell.Phrase = new Phrase(car[i].PermissionPaths.ToString(), myFont);
                Table.AddCell(myCell);
                cell.Phrase = new Phrase(car[i].Group.ToString(), myFont);
                Table.AddCell(myCell);
                cell.Phrase = new Phrase(car[i].StatusVisitor.ToString(), myFont);
                Table.AddCell(myCell);
                i++;
            }
            return tableTmp;
        }

        //=======================================
        // פונקציה להחזיר טבלה עם פרטי משתמשים
        //======================================
        private PdfPTable createUserssTable(PdfPTable Table, Users[] use, int size, PdfPCell myCell)
        {
            PdfPCell cell = myCell;
            cell.BackgroundColor = BaseColor.WHITE;
            PdfPTable tableTmp = Table;
            string ARIALUNI_TFF = Path.Combine(@"C:\Windows\Fonts", "Gisha.ttf");          
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font hebFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
            myCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //מימין לשמאל
            Table.RunDirection = PdfWriter.RUN_DIRECTION_RTL; //טבלה מימין לשמאל
            int i = 0;
            while (i < size && size != 0)
            {
                var myFont = new iTextSharp.text.Font(bf, 8f);
                cell.Phrase = new Phrase(use[i].UserId.ToString(), myFont);
                Table.AddCell(myCell);
                cell.Phrase = new Phrase(use[i].User.ToString(), myFont);
                Table.AddCell(myCell);
                cell.Phrase = new Phrase(use[i].UserName.ToString(), myFont);
                Table.AddCell(myCell);
                cell.Phrase = new Phrase(use[i].PermisionType.ToString(), myFont);
                Table.AddCell(myCell);
                i++;
            }
            return tableTmp;
        }   

        //=========================
        //כפתור חזרה לתפריט הראשי
        //=========================
        private void buckM_Click_1(object sender, EventArgs e)
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

        //====================
        //combobox קריאה בלבד
        //====================
        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        //==========================================
        //אירוע הפעלת כפתורי רדיו לאחר בחירת נושא
        //==========================================
        private void cmdTypeReport_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmdTypeReport.SelectedIndex == 0 || cmdTypeReport.SelectedIndex == 3 || cmdTypeReport.SelectedIndex == 4 || cmdTypeReport.SelectedIndex == 5)
                groupStatusPdf.Enabled = false;
            else
                groupStatusPdf.Enabled = true;
        }

        //==========================
        //בדיקת הקומבו בכניסה למסך
        //==========================
        private void reportGUI_Load(object sender, EventArgs e)
        {
            cmdTypeReport.SelectedIndex = 0;
        }
    }
  }
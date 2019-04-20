using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Collections; 
using System.Windows.Forms;

namespace Login
{
    public class DBSQL : DbAccess
    {
        //===================================
        //מחלקה זו יורשת מ "DbAccess class"
        //ומקבלת תוצאות מהשאילתות ששולחת
        //===================================
        public DBSQL(string connectionString)
            : base(connectionString)
        {
        }
        //===============================
        //הכנסת נתונים של כניסה למערכת
        //===============================
        public string loginToSystem(string userName, string userPassword)
        {
            DataSet ds = new DataSet();
            string cmdStr = "SELECT permisionType FROM [Users] WHERE userName='" + userName + "'AND userpassword='" + userPassword + "'";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0].ItemArray[0].ToString();
            }
            return "נכשל";
        }

        //=======================================================================
        //פונקציה זו מקבלת שם משתמש ומחזירה את שמו הפרטי מתוך מאגר המשתמשים 
        //=======================================================================
        public string GetFirstNameOfUser(string userName)
        {
            string result = "";
            string cmdStr = "SELECT [user] FROM Users WHERE [userName]='" + userName + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = (base.GetMultipleQuery(command)).ToString(); //פונקציה המחזירה טבלה עם תוצאות השאילתה
            }
            return result;
        }

        //==============================
        //הכנסת מבקר חדש לבסיס נתונים
        //==============================
        public void InsertVisitors(Visitors Item)
        {
            string cmdStr = "INSERT INTO [Visitors] ([ID],[FirstName],[LastName],[City],[Street],[PhoneNum],[WorkerId],[CreationDate],[StatusVisitor],[PermissionPaths],[Group],[AdminComment],[OrganizationBox],[Carid]) VALUES (@id,@firstName,@lastName,@city,@street,@phoneNum,@workerID,@createDate,@statusVisitor,@permissionPaths,@group,@adminComment,@organizationBox,@carId)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", Item.ID);
                command.Parameters.AddWithValue("@FirstName", Item.FirstName);
                command.Parameters.AddWithValue("@LastName", Item.LastName);
                command.Parameters.AddWithValue("@city", Item.City);
                command.Parameters.AddWithValue("@street", Item.Street);
                command.Parameters.AddWithValue("@phoneNum", Item.PhoneNum);
                command.Parameters.AddWithValue("@workerID", Item.WorkerID);
                command.Parameters.AddWithValue("@createDate", Item.CreateDate);
                command.Parameters.AddWithValue("@statusVisitor", Item.StatusVisitor);
                command.Parameters.AddWithValue("@permissionPaths", Item.PermissionPaths);
                command.Parameters.AddWithValue("@group", Item.Group);
                command.Parameters.AddWithValue("@adminComment", Item.AdminComment);
                command.Parameters.AddWithValue("@organizationBox", Item.OrganizationBox);
                command.Parameters.AddWithValue("@carId", Item.CrId);

                base.ExecuteSimpleQuery(command);  //פונקציה המפעילה שאילתא (בארגומנט) ואינה מחזירה דבר
            }
        }

        //============================================
        //פונקציה לעדכון פרטים של מבקר בבסיס נתונים
        //=============================================
        public void updatevisitors(Visitors Item, bool flg)
        {
            if (flg)
            {
                string cmdStr = "UPDATE [Visitors] SET [ID]=@id,[FirstName]=@firstName,[LastName]=@lastName,[City]=@city,[Street]=@street,[PhoneNum]=@phoneNum,[WorkerId]=@workerID,[CreationDate]=@createDate,[StatusVisitor]=@statusVisitor,[PermissionPaths]=@permissionPaths,[Group]=@group,[AdminComment]=@adminComment,[OrganizationBox]=@organizationBox,[Carid]=@carId WHERE ID LIKE @id ";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    command.Parameters.AddWithValue("@id", Item.ID);
                    command.Parameters.AddWithValue("@FirstName", Item.FirstName);
                    command.Parameters.AddWithValue("@LastName", Item.LastName);
                    command.Parameters.AddWithValue("@city", Item.City);
                    command.Parameters.AddWithValue("@street", Item.Street);
                    command.Parameters.AddWithValue("@phoneNum", Item.PhoneNum);
                    command.Parameters.AddWithValue("@workerID", Item.WorkerID);
                    command.Parameters.AddWithValue("@createDate", Item.CreateDate);
                    command.Parameters.AddWithValue("@statusVisitor", Item.StatusVisitor);
                    command.Parameters.AddWithValue("@permissionPaths", Item.PermissionPaths);
                    command.Parameters.AddWithValue("@group", Item.Group);
                    command.Parameters.AddWithValue("@adminComment", Item.AdminComment);
                    command.Parameters.AddWithValue("@organizationBox", Item.OrganizationBox);
                    command.Parameters.AddWithValue("@carId", Item.CrId);

                    base.ExecuteSimpleQuery(command);  //פונקציה המפעילה שאילתא (בארגומנט) ואינה מחזירה דבר
                }
            }
            else // מחיקת מבקר מהמערכת
            {
                string cmdStr = "DELETE [ID],[FirstName],[LastName],[City],[Street],[PhoneNum],[WorkerId],[CreationDate],[StatusVisitor],[PermissionPaths],[Group],[AdminComment],[OrganizationBox],[Carid] FROM Visitors WHERE ID=@id";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    command.Parameters.AddWithValue("@id", Item.ID);
                    command.Parameters.AddWithValue("@FirstName", Item.FirstName);
                    command.Parameters.AddWithValue("@LastName", Item.LastName);
                    command.Parameters.AddWithValue("@city", Item.City);
                    command.Parameters.AddWithValue("@street", Item.Street);
                    command.Parameters.AddWithValue("@phoneNum", Item.PhoneNum);
                    command.Parameters.AddWithValue("@workerID", Item.WorkerID);
                    command.Parameters.AddWithValue("@createDate", Item.CreateDate);
                    command.Parameters.AddWithValue("@statusVisitor", Item.StatusVisitor);
                    command.Parameters.AddWithValue("@permissionPaths", Item.PermissionPaths);
                    command.Parameters.AddWithValue("@group", Item.Group);
                    command.Parameters.AddWithValue("@adminComment", Item.AdminComment);
                    command.Parameters.AddWithValue("@organizationBox", Item.OrganizationBox);
                    command.Parameters.AddWithValue("@carId", Item.CrId);

                    base.ExecuteSimpleQuery(command); //פונקציה המפעילה שאילתא (בארגומנט) ואינה מחזירה דבר
                }

            }
        }

        //=========================       
        //עדכון פרטי רכב של מבקר
        //=========================
        public void updateCars(Cars Item, bool flg)
        {//אם לעדכן שדות מסויימים
            if (flg)
            {
                string cmdStr = "UPDATE [Cars] SET [IDVis]=@IDVis,[CarId]=@carId,[TypeCar]=@typeCar,[YearCar]=@yearCar,[ColorCar]=@colorCar,[PermissionPaths]=@permissionPaths,[Group]=@group,[StatusVisitor]=@statusVisitor WHERE IDVis LIKE @IDVis ";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    command.Parameters.AddWithValue("@IDVis", Item.IDVis);
                    command.Parameters.AddWithValue("@carId", Item.CarId);
                    command.Parameters.AddWithValue("@typeCar", Item.TypeCar);
                    command.Parameters.AddWithValue("@yearCar", Item.YearCar);
                    command.Parameters.AddWithValue("@colorCar", Item.ColorCar);
                    command.Parameters.AddWithValue("@permissionPaths", Item.PermissionPaths);
                    command.Parameters.AddWithValue("@group", Item.Group);
                    command.Parameters.AddWithValue("@statusVisitor", Item.StatusVisitor);

                    base.ExecuteSimpleQuery(command); //פונקציה המפעילה שאילתא (בארגומנט) ומחזירה שלם
                }
            }
            else
            { // מחיקת רכב מהמרכת

                string cmdStr = "DELETE [IDVis],[CarId],[TypeCar],[YearCar],[ColorCar],[PermissionPaths],[Group],[StatusVisitor] FROM Cars WHERE IDVis=@IDVis";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    command.Parameters.AddWithValue("@IDVis", Item.IDVis);
                    command.Parameters.AddWithValue("@carId", Item.CarId);
                    command.Parameters.AddWithValue("@typeCar", Item.TypeCar);
                    command.Parameters.AddWithValue("@yearCar", Item.YearCar);
                    command.Parameters.AddWithValue("@colorCar", Item.ColorCar);
                    command.Parameters.AddWithValue("@permissionPaths", Item.PermissionPaths);
                    command.Parameters.AddWithValue("@group", Item.Group);
                    command.Parameters.AddWithValue("@statusVisitor", Item.StatusVisitor);

                    base.ExecuteSimpleQuery(command); //פונקציה המפעילה שאילתא (בארגומנט) ומחזירה שלם
                }
            }
        }

        //=================================
        //בדיקה אם המבקר כבר קיים במערכת
        //=================================
        public bool checkIfVisExist(int newID)
        {
            int num = -1;
            string cmdStr = "SELECT COUNT(ID) FROM  [Visitors] WHERE ID LIKE '" + newID + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                num = ExecuteScalarIntQuery(command); //פונקציה המפעילה שאילתא (בארגומנט) ומחזירה שלם
                if (num != 1 && num != 1)
                    return true;
                else
                    return false;
            }
        }

        //==============================
        //בדיקה אם רכב כבר קיים במערכת
        //==============================
        public bool checkIfCarExist(int newcar)
        {
            int num = -1;
            string cmdStr = "SELECT COUNT(CarId) FROM  [Cars] WHERE CarId LIKE '" + newcar + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                num = ExecuteScalarIntQuery(command);
                if (num != 1 && num != 2)
                    return true;
                else
                    return false;
            }
        }

        //========================================
        //בדיקה אם מס עובד קיים כבר קיים במערכת
        //========================================
        public bool checkIfWorkExist(int newwork)
        {
            int num = -1;
            string cmdStr = "SELECT COUNT(WorkerID) FROM  [Visitors] WHERE WorkerID LIKE '" + newwork + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                num = ExecuteScalarIntQuery(command);
                if (num != 1 && num != 1)
                    return true;
                else
                    return false;
            }
        }

        //==================================================
        //פונקציה שמחזירה את מספר המבקרים שנמצאים בטבלה
        //==================================================
        public int GetVisitorsNumber()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM [Visitors]";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        //===========================================
        //פונקציה להצגת כל המבקרים שרשומים במערכת
        //===========================================
        public Visitors[] GetVisitorsData()
        {
            DataSet ds = new DataSet();
            ArrayList Visitors = new ArrayList();

            string cmdStr = "SELECT * FROM [Visitors]"; // הצגת כל המבקרים
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Visitors vst = new Visitors();

                vst.ID = tType[0].ToString();
                vst.FirstName = tType[1].ToString();
                vst.LastName = tType[2].ToString();
                vst.City = tType[3].ToString();
                vst.Street = tType[4].ToString();
                vst.PhoneNum = tType[5].ToString();
                vst.WorkerID = tType[6].ToString();
                vst.CreateDate = DateTime.Parse(tType[7].ToString());
                vst.StatusVisitor = tType[8].ToString();
                vst.PermissionPaths = tType[9].ToString();
                vst.Group = tType[10].ToString();
                vst.AdminComment = tType[11].ToString();
                vst.OrganizationBox = tType[12].ToString();
                vst.CrId = tType[13].ToString();
                Visitors.Add(vst);
            }
            return (Visitors[])Visitors.ToArray(typeof(Visitors));
        }

        //=============================
        // פונקציה להכנסת רכבים לטבלה
        //=============================
        public void InsertCars(Cars Item)
        {
            string cmdStr = "INSERT INTO [Cars] ([IDVis],[CarId],[TypeCar],[YearCar],[ColorCar],[PermissionPaths],[Group],[StatusVisitor]) VALUES (@IDVis,@carId,@typeCar,@yearCar,@colorCar,@permissionPaths,@group,@statusVisitor)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@IDVis", Item.IDVis);
                command.Parameters.AddWithValue("@carId", Item.CarId);
                command.Parameters.AddWithValue("@typeCar", Item.TypeCar);
                command.Parameters.AddWithValue("@yearCar", Item.YearCar);
                command.Parameters.AddWithValue("@colorCar", Item.ColorCar);
                command.Parameters.AddWithValue("@permissionPaths", Item.PermissionPaths);
                command.Parameters.AddWithValue("@group", Item.Group);
                command.Parameters.AddWithValue("@statusVisitor", Item.StatusVisitor);

                base.ExecuteSimpleQuery(command);
            }
        }

        //======================
        //פונקציה לחיפוש משתמש
        //======================
        public Users searchusserById(string userId)
        {
            string cmdStr = "SELECT * FROM [Users] WHERE userId=@userId";
            DataSet ds = new DataSet();
            ArrayList user = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@userId", userId);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            TextBox tb = new TextBox();
            tb.Text = "Default text";
            Users userr = new Users();
            try
            {
                dt = ds.Tables[0];
            }
            catch
            {
                throw new NotImplementedException();
            }
            if (dt.Rows.Count == 1)
            {
                userr.UserId = ds.Tables[0].Rows[0][0].ToString();
                userr.UserName = ds.Tables[0].Rows[0][1].ToString();
                userr.User = ds.Tables[0].Rows[0][2].ToString();
                userr.Userpassword = ds.Tables[0].Rows[0][3].ToString();
                userr.PermisionType = ds.Tables[0].Rows[0][4].ToString();
                return userr;
            }
            else
            {
                return null;
            }
        }

        //========================================
        //פונקציה שמחזירה את מספר הרכבים במערכת
        //========================================
        public int GetCarsNumber()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Cars";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        //=================================
        //פונקציה להצגת כל הרכבים במערכת
        //=================================
        public Cars[] GetCarsData()
        {
            DataSet ds = new DataSet();
            ArrayList Cars = new ArrayList();
            string cmdStr = "SELECT * FROM [Cars]";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Cars crs = new Cars();
                crs.IDVis = tType[0].ToString();
                crs.CarId = tType[1].ToString();
                crs.TypeCar = tType[2].ToString();
                crs.YearCar = tType[3].ToString();
                crs.ColorCar = tType[4].ToString();
                Cars.Add(crs); // פונקצית הוספה לטבלה
            }
            return (Cars[])Cars.ToArray(typeof(Cars));

        }

        //=======================================================
        //לאחר לחיצה כפולה על תעודת זהות יפתח פרטי מבקר בשדות
        //=======================================================
        internal ProvisionalApproval searchprovById(int item)
        {
            string cmdStr = "SELECT * FROM  [ProvisionalApproval] WHERE Idvis LIKE '" + item + "'";
            DataSet ds = new DataSet();
            ArrayList pro = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            TextBox tb = new TextBox();
            tb.Text = "Default text";
            ProvisionalApproval pra = new ProvisionalApproval();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {
                pra.ActivityTime = (DateTime)ds.Tables[0].Rows[0][0];
                pra.Idvis = ds.Tables[0].Rows[0][1].ToString();
                pra.FName = ds.Tables[0].Rows[0][2].ToString();
                pra.LName = ds.Tables[0].Rows[0][3].ToString();
                pra.CharacterStatus = ds.Tables[0].Rows[0][4].ToString();
                pra.StartDate = (DateTime)ds.Tables[0].Rows[0][5];
                pra.EndDate = (DateTime)ds.Tables[0].Rows[0][6];
                pra.RequestStatus = ds.Tables[0].Rows[0][7].ToString();
                pra.PhoneOwner = ds.Tables[0].Rows[0][8].ToString();
                pra.CId = ds.Tables[0].Rows[0][9].ToString();
                pra.TCar = ds.Tables[0].Rows[0][10].ToString();
                pra.CCar = ds.Tables[0].Rows[0][11].ToString();
                pra.TypeOk = ds.Tables[0].Rows[0][12].ToString();
                pra.StatusProv = ds.Tables[0].Rows[0][13].ToString();
                pra.Unit = ds.Tables[0].Rows[0][14].ToString();
                pra.Typemos = ds.Tables[0].Rows[0][15].ToString();
                return pra;
            }
            else
            {
                return null;
            }
        }

        //==============================================
        //בדיקה אם מבקר קיים במערכת על ידי תעודת זהות
        //==============================================
        public int CheckVisitorExist(int id)
        {
            int res;
            string cmdStr = "SELECT COUNT (*) FROM [Visitors] WHERE ID=@id";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", id);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }

        //===========================
        // פונקציה לחיפוש פרטי מבקר
        //===========================
        public Visitors searchVisitById(string id)
        {
            string cmdStr = "SELECT * FROM  [Visitors] WHERE ID LIKE '" + id + "'";
            DataSet ds = new DataSet();
            ArrayList visit = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            TextBox tb = new TextBox();
            tb.Text = "Default text";
            Visitors visi = new Visitors();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {
                visi.ID = ds.Tables[0].Rows[0][0].ToString();
                visi.FirstName = ds.Tables[0].Rows[0][1].ToString();
                visi.LastName = ds.Tables[0].Rows[0][2].ToString();
                visi.City = ds.Tables[0].Rows[0][3].ToString();
                visi.Street = ds.Tables[0].Rows[0][4].ToString();
                visi.PhoneNum = ds.Tables[0].Rows[0][5].ToString();
                visi.WorkerID = ds.Tables[0].Rows[0][6].ToString();
                visi.CreateDate = (DateTime)ds.Tables[0].Rows[0][7];
                visi.StatusVisitor = ds.Tables[0].Rows[0][8].ToString();
                visi.PermissionPaths = ds.Tables[0].Rows[0][9].ToString();
                visi.Group = ds.Tables[0].Rows[0][10].ToString();
                visi.AdminComment = ds.Tables[0].Rows[0][11].ToString();
                visi.OrganizationBox = ds.Tables[0].Rows[0][12].ToString();
                return visi;
            }
            else
            {
                return null;
            }
        }

        //=====================================
        // פונקציה לחיפוש פרטי מבקר לפי מזהה
        //=====================================
        public Visitors search(int id)
        {
            string cmdStr = "SELECT * FROM  [Visitors] WHERE ID LIKE '" + id + "'";
            DataSet ds = new DataSet();
            ArrayList visit = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            TextBox tb = new TextBox();
            tb.Text = "Default text";
            Visitors visi = new Visitors();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {
                visi.ID = ds.Tables[0].Rows[0][0].ToString();
                visi.FirstName = ds.Tables[0].Rows[0][1].ToString();
                visi.LastName = ds.Tables[0].Rows[0][2].ToString();
                visi.City = ds.Tables[0].Rows[0][3].ToString();
                visi.Street = ds.Tables[0].Rows[0][4].ToString();
                visi.PhoneNum = ds.Tables[0].Rows[0][5].ToString();
                visi.WorkerID = ds.Tables[0].Rows[0][6].ToString();
                visi.CreateDate = (DateTime)ds.Tables[0].Rows[0][7];
                visi.StatusVisitor = ds.Tables[0].Rows[0][8].ToString();
                visi.PermissionPaths = ds.Tables[0].Rows[0][9].ToString();
                visi.Group = ds.Tables[0].Rows[0][10].ToString();
                visi.AdminComment = ds.Tables[0].Rows[0][11].ToString();
                visi.OrganizationBox = ds.Tables[0].Rows[0][12].ToString();
                return visi;
            }
            else
            {
                return null;
            }
        }
        //******************************************מסך מידע מבקרים*********************************************************
        //=======================================
        //מסך מידע מבקרים
        //פונקציה לשליפת תעודת זהות לשדה חיפוש
        //=======================================
        internal Cars searchId(int item)
        {
            string cmdStr = "SELECT * FROM  [Cars] WHERE IDVis LIKE '" + item + "'";
            DataSet ds = new DataSet();
            ArrayList ca = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            TextBox tb = new TextBox();
            tb.Text = "Default text";
            Cars car = new Cars();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {
                car.IDVis = ds.Tables[0].Rows[0][0].ToString();
                return car;
            }
            else
            {
                return null;
            }
        }

        //=========================================
        //מסך מידע מבקרים
        // כרטיס מידע על רכב מלחיצה על תעודת זהות
        //=========================================
        public Cars GetCarCardDetails(int getID)
        {
            DataSet ds = new DataSet();
            string cmdStr = "SELECT * FROM  [Cars] WHERE IDVis LIKE '" + getID + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            Cars car = new Cars();
            foreach (DataRow tType in dt.Rows)
            {
                car.IDVis = tType[0].ToString();
                car.CarId = tType[1].ToString();
                car.TypeCar = tType[2].ToString();
                car.YearCar = tType[3].ToString();
                car.ColorCar = tType[4].ToString();
            }
            return car;
        }

        //====================================
        //מסך מידע מבקרים
        //פונקציה לעידכון פרטים מהכרטיסייה
        //====================================
        public void updateCarCard(Cars Item, bool flg)
        {
            if (flg)
            {
                string cmdStr = "UPDATE [Cars] SET [IDVis]=@IDVis,[CarId]=@carId,[TypeCar]=@typeCar,[YearCar]=@yearCar,[ColorCar]=@colorCar WHERE IDVis LIKE @IDVis ";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    command.Parameters.AddWithValue("@IDVis", Item.IDVis);
                    command.Parameters.AddWithValue("@carId", Item.CarId);
                    command.Parameters.AddWithValue("@typeCar", Item.TypeCar);
                    command.Parameters.AddWithValue("@yearCar", Item.YearCar);
                    command.Parameters.AddWithValue("@colorCar", Item.ColorCar);

                    base.ExecuteSimpleQuery(command);
                }
            }
            else
            {
                return;
            }
        }

        // =================================================
        // להחזיר את כל הפרטים על מכוניות בין שני תאריכים 
        // =================================================
        public Visitors[] GetVehicleDetailsByDate(DateTime start, DateTime end)
        {
            DataSet ds = new DataSet();
            ArrayList visitorDetails = new ArrayList();
            string cmdStr = "";
            cmdStr += "SELECT Carid,FirstName,LastName,CreationDate, StatusVisitor,Group FROM [Visitors] WHERE CreationDate BETWEEN #" + start.ToShortDateString() + "# And #" + end.ToShortDateString() + "#";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Visitors visitor = new Visitors();
                visitor.CrId = tType[0].ToString();
                visitor.FirstName = tType[1].ToString();
                visitor.LastName = tType[2].ToString();
                visitor.CreateDate = DateTime.Parse(tType[3].ToString());
                visitor.StatusVisitor = tType[4].ToString();
                visitor.Group = tType[6].ToString();
                visitorDetails.Add(visitor);
            }
            return (Visitors[])visitorDetails.ToArray(typeof(Visitors));
        }
        //******************************************מסך מידע רכבים*********************************************************

        //=====================================
        //מסך מידע רכבים
        // חיפוש רכבים על ידי מספר רכב בטבלה 
        //=====================================
        public int CheckCarExist(int idcar)
        {
            int res;
            string cmdStr = "SELECT COUNT (*) FROM [Cars] WHERE carId=@carId";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@carId", idcar);

                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }

        //======================================
        //מסך מידע רכבים
        // חיפוש רכבים על ידי תעודת זהות בטבלה
        //=======================================
        public int CheckCarExistbyid(int idvis)
        {
            int res;
            string cmdStr = "SELECT COUNT (*) FROM [Cars] WHERE IDVis=@IDVis";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@IDVis", idvis);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }

        // ==========================================
        //מסך מידע רכבים
        // כרטיס מידע על מבקר מלחיצה על תעודת זהות
        // ==========================================
        public Visitors GetCardDetails(int getID)
        {
            DataSet ds = new DataSet();
            string cmdStr = "SELECT * FROM  [Visitors] WHERE ID LIKE '" + getID + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            Visitors visitor = new Visitors();
            foreach (DataRow tType in dt.Rows)
            {
                visitor.ID = tType[0].ToString();
                visitor.FirstName = tType[1].ToString();
                visitor.LastName = tType[2].ToString();
                visitor.Group = tType[10].ToString();
                visitor.StatusVisitor = tType[8].ToString();
                visitor.PermissionPaths = tType[9].ToString();
                visitor.PhoneNum = tType[5].ToString();
            }
            return visitor;
        }

        //===================================
        //מסך מידע רכבים
        //פונקציה לעידכון פרטים מהכרטיסייה
        //===================================
        public void updateCard(Visitors Item, bool flg)
        {
            if (flg)
            {
                string cmdStr = "UPDATE [Visitors] SET [ID]=@id,[FirstName]=@firstName,[LastName]=@lastName,[PhoneNum]=@phoneNum,[StatusVisitor]=@statusVisitor,[PermissionPaths]=@permissionPaths,[Group]=@group WHERE ID LIKE @id";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    command.Parameters.AddWithValue("@id", Item.ID);
                    command.Parameters.AddWithValue("@FirstName", Item.FirstName);
                    command.Parameters.AddWithValue("@LastName", Item.LastName);
                    command.Parameters.AddWithValue("@phoneNum", Item.PhoneNum);
                    command.Parameters.AddWithValue("@statusVisitor", Item.StatusVisitor);
                    command.Parameters.AddWithValue("@permissionPaths", Item.PermissionPaths);
                    command.Parameters.AddWithValue("@group", Item.Group);

                    base.ExecuteSimpleQuery(command);
                }
            }
            else
            {
                return;
            }
        }

        //=======================================
        //מסך מידע רכבים
        //פונקציה לשמירת הערת רכב בבסיס נתונים
        //=======================================
        public void UpdatNote(Visitors Item, bool flg)
        {
            if (flg)
            {
                string cmdStr = "UPDATE [Visitors] SET [ID]=@id,[AdminComment]=@adminComment WHERE ID LIKE @id";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    command.Parameters.AddWithValue("@id", Item.ID);
                    command.Parameters.AddWithValue("@adminComment", Item.AdminComment);

                    base.ExecuteSimpleQuery(command);
                }
            }
            else
            {
                return;
            }
        }

        //=============================================
        //מסך מידע רכבים
        //פונקציה לשליפת תעודת זהות לצורך רשימת הערה
        //=============================================
        internal Visitors searchById(int item)
        {
            string cmdStr = "SELECT * FROM  [Visitors] WHERE ID LIKE '" + item + "'";
            DataSet ds = new DataSet();
            ArrayList pro = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            TextBox tb = new TextBox();
            tb.Text = "Default text";
            Visitors vis = new Visitors();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {
                vis.ID = ds.Tables[0].Rows[0][0].ToString();
                vis.AdminComment = ds.Tables[0].Rows[0][11].ToString();
                return vis;
            }
            else
            {
                return null;
            }
        }

        //==============================================================================
        //מסך מידע רכבים
        //פונקציה למילוי שדות במסך כרטייסיה שנפתח על ידי לחיצה כפולה על תעודת זהות
        //==============================================================================
        public Cars searchCarById(string IDVis)
        {
            string cmdStr = "SELECT * FROM  [Cars] WHERE IDVis='" + IDVis + "'";
            DataSet ds = new DataSet();
            ArrayList carvisit = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            TextBox tb = new TextBox();
            tb.Text = "Default text";
            Cars carvis = new Cars();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {
                carvis.IDVis = ds.Tables[0].Rows[0][0].ToString();
                carvis.CarId = ds.Tables[0].Rows[0][1].ToString();
                carvis.TypeCar = ds.Tables[0].Rows[0][2].ToString();
                carvis.YearCar = ds.Tables[0].Rows[0][3].ToString();
                carvis.ColorCar = ds.Tables[0].Rows[0][4].ToString();
            }
            else
            {
                return null;
            }
            return carvis;
        }

        //========================
        //מסך מידע רכבים
        //הוצאת פרטי רכב לפי מזהה
        //=========================
        public Cars searchCar(int carId)
        {
            string cmdStr = "SELECT * FROM  [Cars] WHERE CarId='" + carId + "'";
            DataSet ds = new DataSet();
            ArrayList carvisit = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            TextBox tb = new TextBox();
            tb.Text = "Default text";
            Cars carvis = new Cars();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {
                carvis.IDVis = ds.Tables[0].Rows[0][0].ToString();
                carvis.CarId = ds.Tables[0].Rows[0][1].ToString();
                carvis.TypeCar = ds.Tables[0].Rows[0][2].ToString();
                carvis.YearCar = ds.Tables[0].Rows[0][3].ToString();
                carvis.ColorCar = ds.Tables[0].Rows[0][4].ToString();
            }
            else
            {
                return null;
            }
            return carvis;
        }
        //========================
        //מסך מידע רכבים
        //הוצאת פרטי רכב לפי מזהה
        //=========================
        public Cars searchCarvis(int viscar)
        {
            string cmdStr = "SELECT * FROM  [Cars] WHERE IDVis='" + viscar + "'";
            DataSet ds = new DataSet();
            ArrayList carvisit = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            TextBox tb = new TextBox();
            tb.Text = "Default text";
            Cars carvis = new Cars();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {
                carvis.IDVis = ds.Tables[0].Rows[0][0].ToString();
                carvis.CarId = ds.Tables[0].Rows[0][1].ToString();
                carvis.TypeCar = ds.Tables[0].Rows[0][2].ToString();
                carvis.YearCar = ds.Tables[0].Rows[0][3].ToString();
                carvis.ColorCar = ds.Tables[0].Rows[0][4].ToString();
            }
            else
            {
                return null;
            }
            return carvis;
        }
        //**********************************************מסך ניהול הרשאות משתמשים******************************
        //========================
        //מסך ניהול הרשאות
        //הוספת חשבון משתמש חדש
        //========================
        public void InsertUser(Users Item)
        {
            string cmdStr = "INSERT INTO [Users] (UserId,[User],[UserName],[Userpassword],[PermisionType] ) VALUES (@userId,@user,@userName,@userpassword,@permisionType)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@userId", Item.UserId);
                command.Parameters.AddWithValue("@user", Item.User);
                command.Parameters.AddWithValue("@userName", Item.UserName);
                command.Parameters.AddWithValue("@userpassword", Item.Userpassword);
                command.Parameters.AddWithValue("@permisionType", Item.PermisionType);
                base.ExecuteSimpleQuery(command);
            }
        }

        //==============================================
        //בדיקה אם משתמש קיים במערכת על ידי תעודת זהות
        //==============================================
        public int checkIfUserExist(int id)
        {
            int res;
            string cmdStr = "SELECT COUNT (*) FROM [Users] WHERE userId=@id";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", id);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }

        // ==================================
        // פונקציה לעדכן סיסמה חדשה למשתמש
        // ==================================
        public void addNewPerm(Users Item, string password, bool flg)
        {
            if (flg)
            {
                string cmdStr = "UPDATE [Users] SET [userId]=@userId,[userpassword]=@userpassword WHERE userId LIKE @userId ";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    command.Parameters.AddWithValue("@userId", Item.UserId);
                    command.Parameters.AddWithValue("@userpassword", Item.Userpassword);
                    base.ExecuteSimpleQuery(command);
                }
            }
            else
            {
                return;
            }
        }

        // ===========================================
        //מסך ניהול הרשאות
        //לאחר פתיחת שינוי סיסמה להציג את הת.ז בשדה
        // ===========================================
        public Users GetUserDetails(int getID)
        {
            DataSet ds = new DataSet();
            string cmdStr = "SELECT * FROM  [Users] WHERE userId LIKE '" + getID + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            Users user = new Users();
            foreach (DataRow tType in dt.Rows)
            {
                user.UserId = tType[0].ToString();
            }
            return user;
        }

        //===============================
        //להציג את המשתמשים במסך תצוגה
        // מקבל סטטוס "מנהל/משתמש"
        //===============================
        public Users[] GetUserData(string status)
        {
            DataSet ds = new DataSet();
            ArrayList name = new ArrayList();
            string cmdStr = "SELECT * FROM [Users] WHERE permisionType=@permisionType";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.Add("@permisionType", status);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Users UserWork = new Users();
                UserWork.UserName = tType[2].ToString();
                name.Add(UserWork);
            }
            return (Users[])name.ToArray(typeof(Users));
        }

        //===============================================
        //להציג את התעודות זהות מהטבלה לעידכון פרטים
        //===============================================
        public Users[] GetidUserData()
        {
            DataSet ds = new DataSet();
            ArrayList names = new ArrayList();
            string cmdStr = "SELECT userId FROM [Users]"; // להציג את התעודות זהות בקומבובוקס
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Users iU = new Users();

                iU.UserId = tType[0].ToString();
                names.Add(iU);
            }
            return (Users[])names.ToArray(typeof(Users));
        }

        //==============================================
        //פונקציה לעדכון פרטים של משתמש בבסיס נתונים
        //==============================================
        public void updateUsers(Users Item)
        {
            string cmdStr = "UPDATE [Users] SET user=@user UserName=@userNam,PermisionType=@permisionType ) VALUES (@userId,@user,@userName,@permisionType LIKE @userId ";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@user", Item.User);
                command.Parameters.AddWithValue("@userName", Item.UserName);
                command.Parameters.AddWithValue("@permisionType", Item.PermisionType);

                base.ExecuteSimpleQuery(command);
            }
        }

        //========================================
        //פונקציה לעדכן הרשאות משתמש רגיל למנהל
        //========================================
        public void userToManager(string userName)
        {
            string cmdStr = "UPDATE [Users] SET permisionType='מנהל' WHERE userName=@userName ";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.Add("@userName", userName);

                base.ExecuteSimpleQuery(command);
            }
        }

        //=========================================
        //פונקציה לעדכן הרשאות ממנהל למשתמש רגיל
        //=========================================
        public void ManagerToUser(string userName)
        {
            string cmdStr = "UPDATE [Users] SET permisionType='משתמש' WHERE userName=@userName ";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.Add("@userName", userName);
                base.ExecuteSimpleQuery(command);
            }
        }

        //=====================================================
        //פונקציית מחיקה משתמש או מנהל מפאנל הרשאות מערכת
        //=====================================================
        public void deletePermByID(string userName)
        {
            string cmdStr = "DELETE [userId],[user],[userName], [userpassword], [permisionType] FROM Users WHERE userName=@userName";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.Add("@userName", userName);
                base.ExecuteSimpleQuery(command);
            }
        }

        //==========================
        //פונקציה לעדכן פרטי משתמש
        //==========================
        public void updateuser(Users Item, bool flg)
        {
            if (flg)
            {
                string cmdStr = "UPDATE [Users] SET [userId]=@userId,[user]=@userName,[userName]=@user,[permisionType]=@permisionType WHERE userId LIKE @userId";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    command.Parameters.AddWithValue("@userId", Item.UserId);
                    command.Parameters.AddWithValue("@userName", Item.UserName);
                    command.Parameters.AddWithValue("@user", Item.User);
                    command.Parameters.AddWithValue("@permisionType", Item.PermisionType);

                    base.ExecuteSimpleQuery(command);
                }
            }
        }
        //**************************************************************אישור זמני***************************************************
        //=================================
        //בדיקה אם מבקר זמני כבר קיים במערכת
        //=================================
        public int checkIfPorvExist(int id)
        {
            int res;
            string cmdStr = "SELECT COUNT (*) FROM [ProvisionalApproval] WHERE Idvis=@idvis";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@idvis", id);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }

        //===================================
        //בדיקה אם רכב זמני כבר קיים במערכת
        //===================================
        public int checkIfPorvCarExist(int car)
        {
            int res;
            string cmdStr = "SELECT COUNT (*) FROM [ProvisionalApproval] WHERE CId=@cId";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@cId", car);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }

        //================================================
        //פונקציה שמחזירה את מספר המבקרים שנמצאים בטבלה
        //=================================================
        public int GetProvsNumber()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM [ProvisionalApproval]";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        //=================================
        //פונקציה להצגת כל הרכבים במערכת
        //=================================
        public ProvisionalApproval[] GetProvData()
        {
            DataSet ds = new DataSet();
            ArrayList Cars = new ArrayList();
            string cmdStr = "SELECT * FROM [ProvisionalApproval]"; //הצגת כל הנתונים
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            ArrayList Provs = new ArrayList();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                ProvisionalApproval pra = new ProvisionalApproval();
                pra.ActivityTime = DateTime.Parse(tType[0].ToString());
                pra.Idvis = tType[1].ToString();
                pra.FName = tType[2].ToString();
                pra.LName = tType[3].ToString();
                pra.CharacterStatus = tType[4].ToString();
                pra.StartDate = DateTime.Parse(tType[5].ToString());
                pra.EndDate = DateTime.Parse(tType[6].ToString());
                pra.RequestStatus = tType[7].ToString();
                pra.PhoneOwner = tType[8].ToString();
                pra.CId = tType[9].ToString();
                pra.TCar = tType[10].ToString();
                pra.CCar = tType[11].ToString();
                pra.TypeOk = tType[12].ToString();
                pra.StatusProv = tType[13].ToString();
                pra.Unit = tType[14].ToString();
                pra.Typemos = tType[15].ToString();

                Provs.Add(pra); // פונקצית הוספה לטבלה
            }
            return (ProvisionalApproval[])Provs.ToArray(typeof(ProvisionalApproval));
        }

        //============================
        //פונקציה הוספת נתונים לבסיס
        //============================
        public void InsertProv(ProvisionalApproval Item)
        {
            string cmdStr = "INSERT INTO [ProvisionalApproval] ([ActivityTime], [Idvis], [FName], [LName], [CharacterStatus], [StartDate], [EndDate], [RequestStatus], [PhoneOwner], [CId], [TCar], [CCar], [TypeOk], [Typemos], [Unit], [StatusProv]) VALUES (@activityTime,@idvis,@fName,@lName,@characterStatus,@startDate,@endDate,@requestStatus,@phoneOwner,@cId,@tCar,@cCar,@typeOk,@typemos,@unit,@statusProv)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@activityTime", Item.ActivityTime);
                command.Parameters.AddWithValue("@idvis", Item.Idvis);
                command.Parameters.AddWithValue("@fName", Item.FName);
                command.Parameters.AddWithValue("@lName", Item.LName);
                command.Parameters.AddWithValue("@characterStatus", Item.CharacterStatus);
                command.Parameters.AddWithValue("@startDate", Item.StartDate);
                command.Parameters.AddWithValue("@endDate", Item.EndDate);
                command.Parameters.AddWithValue("@requestStatus", Item.RequestStatus);
                command.Parameters.AddWithValue("@phoneOwner", Item.PhoneOwner);
                command.Parameters.AddWithValue("@cId", Item.CId);
                command.Parameters.AddWithValue("@tCar", Item.TCar);
                command.Parameters.AddWithValue("@cCar", Item.CCar);
                command.Parameters.AddWithValue("@typeOk", Item.TypeOk);
                command.Parameters.AddWithValue("@typemos", Item.Typemos);
                command.Parameters.AddWithValue("@unit", Item.Unit);
                command.Parameters.AddWithValue("@statusProv", Item.StatusProv);

                base.ExecuteSimpleQuery(command);
            }
        }

        //============================================
        //פונקציה לעדכון פרטים של מבקר בבסיס נתונים
        //============================================
        public void updateProvs(ProvisionalApproval Item, bool flg)
        {
            if (flg)
            {
                string cmdStr = "UPDATE [ProvisionalApproval] SET [ActivityTime]=@activityTime,[Idvis]=@idvis,[FName]=@fName,[LName]=@lName,[CharacterStatus]=@characterStatus,[StartDate]=@startDate,[EndDate]=@endDate,[RequestStatus]=@requestStatus,[PhoneOwner]=@phoneOwner,[CId]=@cId,[TCar]=@tCar,[CCar]=@cCar,[TypeOk]=@typeOk,[Typemos]=@typemos,[Unit]=@unit,[StatusProv]=@statusProv WHERE Idvis LIKE @idvis ";

                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    command.Parameters.AddWithValue("@activityTime", Item.ActivityTime);
                    command.Parameters.AddWithValue("@idvis", Item.Idvis);
                    command.Parameters.AddWithValue("@fName", Item.FName);
                    command.Parameters.AddWithValue("@lName", Item.LName);
                    command.Parameters.AddWithValue("@characterStatus", Item.CharacterStatus);
                    command.Parameters.AddWithValue("@startDate", Item.StartDate);
                    command.Parameters.AddWithValue("@endDate", Item.EndDate);
                    command.Parameters.AddWithValue("@requestStatus", Item.RequestStatus);
                    command.Parameters.AddWithValue("@phoneOwner", Item.PhoneOwner);
                    command.Parameters.AddWithValue("@cId", Item.CId);
                    command.Parameters.AddWithValue("@tCar", Item.TCar);
                    command.Parameters.AddWithValue("@cCar", Item.CCar);
                    command.Parameters.AddWithValue("@typeOk", Item.TypeOk);
                    command.Parameters.AddWithValue("@typemos", Item.Typemos);
                    command.Parameters.AddWithValue("@unit", Item.Unit);
                    command.Parameters.AddWithValue("@statusProv", Item.StatusProv);

                    base.ExecuteSimpleQuery(command);
                }
            }
            else
            { // מחיקת מבקר מהמערכת
                string cmdStr = "DELETE FROM ProvisionalApproval WHERE [Idvis]=@idvis";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    command.Parameters.AddWithValue("@idvis", Item.Idvis);

                    base.ExecuteSimpleQuery(command);
                }
            }
        }

        //================================
        // פונקציה לחיפוש פרטי מבקר זמני
        //================================
        public ProvisionalApproval searchprovById(string id)
        {
            string cmdStr = "SELECT * FROM  [ProvisionalApproval] WHERE Idvis LIKE '" + id + "'";
            DataSet ds = new DataSet();
            ArrayList pro = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            TextBox tb = new TextBox();
            tb.Text = "Default text";
            ProvisionalApproval pra = new ProvisionalApproval();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {
                pra.ActivityTime = (DateTime)ds.Tables[0].Rows[0][0];
                pra.Idvis = ds.Tables[0].Rows[0][1].ToString();
                pra.FName = ds.Tables[0].Rows[0][2].ToString();
                pra.LName = ds.Tables[0].Rows[0][3].ToString();
                pra.CharacterStatus = ds.Tables[0].Rows[0][4].ToString();
                pra.StartDate = (DateTime)ds.Tables[0].Rows[0][5];
                pra.EndDate = (DateTime)ds.Tables[0].Rows[0][6];
                pra.RequestStatus = ds.Tables[0].Rows[0][7].ToString();
                pra.PhoneOwner = ds.Tables[0].Rows[0][8].ToString();
                pra.CId = ds.Tables[0].Rows[0][9].ToString();
                pra.TCar = ds.Tables[0].Rows[0][10].ToString();
                pra.CCar = ds.Tables[0].Rows[0][11].ToString();
                pra.TypeOk = ds.Tables[0].Rows[0][12].ToString();
                pra.StatusProv = ds.Tables[0].Rows[0][13].ToString();
                pra.Unit = ds.Tables[0].Rows[0][14].ToString();
                pra.Typemos = ds.Tables[0].Rows[0][15].ToString();
                return pra;
            }
            else
            {
                return null;
            }
        }

        //==========================
        //לבדוק אם מבקר זמני קיים
        //==========================
        public int CheckprovExist(int id)
        {
            int res;
            string cmdStr = "SELECT COUNT (*) FROM [ProvisionalApproval] WHERE Idvis=@idvis";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@idvis", id);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }

        //==================================
        //פונקציה לבדיקת פג תוקף של סטטוס
        //==================================
        public string CheckDate(string status)
        {
            string cmdStr = "UPDATE [ProvisionalApproval] SET StatusProv='לא פעיל' WHERE endDate<Date()";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
            return string.Empty;
        }
        //******************************************PDF******************************************
        //=========================================
        //הצגת כל הרשומים במערכת לפי תאריך יצירה
        //=========================================
        public DataTable GetBestSellers()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string cmdStr = "select * from Visitors order by CreationDate";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            return dt;
        }

        // ================================
        // פונקציה  שאילתה ליצור קובץ PDF
        // ================================
        private string getQueryVisitorsAndWorker(DateTime start, DateTime end, string group, string state)
        {
            string cmdStr = "";
            switch (group) //סוג קבוצה
            {
                case "מבקרים":
                    if (state == "הכל")
                    {                    
                        cmdStr = "SELECT ID,FirstName,LastName,City,Street,PhoneNum,WorkerId,CreationDate,StatusVisitor,PermissionPaths,Group FROM [Visitors] WHERE ";
                        cmdStr += "CreationDate BETWEEN #" + start.ToShortDateString() + "# And #" + end.ToShortDateString() + "#";
                    }
                    else
                    { // עובדי כללית
                        cmdStr = "SELECT Visitors.ID, Visitors.FirstName, Visitors.LastName, Visitors.City, Visitors.Street, Visitors.PhoneNum, Visitors.WorkerId, Visitors.CreationDate, Visitors.StatusVisitor, Visitors.PermissionPaths, Visitors.Group FROM [Visitors] WHERE (((Visitors.Group) = 'כללית'))";                        
                    }
                    break;
                case "רכבים":
                    if (state == "הכל")
                    {
                        cmdStr = "SELECT Cars.IDVis, Cars.CarId, Cars.TypeCar, Cars.YearCar, Cars.ColorCar, Cars.PermissionPaths, Cars.Group, Cars.StatusVisitor FROM [Cars]";                      
                    }
                    else
                    { // רכבים של עובדי כללית
                        cmdStr = "SELECT Cars.IDVis, Cars.CarId, Cars.TypeCar, Cars.YearCar, Cars.ColorCar, Cars.PermissionPaths, Cars.Group, Cars.StatusVisitor FROM Cars WHERE(((Cars.Group) = 'כללית'))";                      
                    }
                    break;
                case "חניון סגל":
                    if (state != "הכל")
                    {
                        cmdStr = "SELECT Cars.IDVis, Cars.CarId, Cars.TypeCar, Cars.YearCar, Cars.ColorCar, Cars.PermissionPaths, Cars.Group, Cars.StatusVisitor FROM [Cars] WHERE (((Cars.PermissionPaths) = 'חניון סגל'))";                       
                    }
                    break;
                case "חניון בית חולים":
                    if (state != "הכל")
                    {
                        cmdStr = "SELECT Cars.IDVis, Cars.CarId, Cars.TypeCar, Cars.YearCar, Cars.ColorCar, Cars.PermissionPaths, Cars.Group, Cars.StatusVisitor FROM [Cars] WHERE (((Cars.PermissionPaths) = 'חניון בית חולים'))";                      
                    }
                    break;
                case "משתמשי מערכת":
                    if (state != "All")
                    {
                        cmdStr = "SELECT Users.userId, Users.user, Users.userName, Users.permisionType FROM [Users]";                      
                    }
                    break;
            }
            return cmdStr;
        }

        // =========================================
        // פונקציה להוציא פרטים על מבקרים ועובדים
        // =========================================
        public Visitors[] GetInformationAboutVisitorsAndWorker(DateTime start, DateTime end, string group, string state)
        {
            DataSet ds = new DataSet();
            ArrayList visitorDetails = new ArrayList();
            string cmdStr = getQueryVisitorsAndWorker(start, end, group, state);

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (state == "עובדים")
            {
                foreach (DataRow tType in dt.Rows)
                {
                    Visitors visitor = new Visitors();
                    visitor.ID = tType[0].ToString();
                    visitor.FirstName = tType[1].ToString();
                    visitor.LastName = tType[2].ToString();
                    visitor.City = tType[3].ToString();
                    visitor.Street = tType[4].ToString();
                    visitor.PhoneNum = tType[5].ToString();
                    visitor.WorkerID = tType[6].ToString();
                    visitor.CreateDate = (DateTime)tType[7];
                    visitor.StatusVisitor = tType[8].ToString();
                    visitor.PermissionPaths = tType[9].ToString();
                    visitor.Group = tType[10].ToString();

                    visitorDetails.Add(visitor);
                }
            }
            else if (group == "מבקרים")
            { 
                foreach (DataRow tType in dt.Rows)
                {
                    Visitors visitor = new Visitors();
                    visitor.ID = tType[0].ToString();
                    visitor.FirstName = tType[1].ToString();
                    visitor.LastName = tType[2].ToString();
                    visitor.City = tType[3].ToString();
                    visitor.Street = tType[4].ToString();
                    visitor.PhoneNum = tType[5].ToString();
                    visitor.WorkerID = tType[6].ToString();
                    visitor.CreateDate = (DateTime)tType[7];
                    visitor.StatusVisitor = tType[8].ToString();
                    visitor.PermissionPaths = tType[9].ToString();
                    visitor.Group = tType[10].ToString();

                    visitorDetails.Add(visitor);
                }
        }
               
                return (Visitors[])visitorDetails.ToArray(typeof(Visitors));
        }


        // ===============================
        // פונקציה להוציא פרטים על רכבים
        // ===============================
        public ArrayList GetInformationAboutCars(DateTime start, DateTime end, string group, string state)
        {
            DataSet ds = new DataSet();
            ArrayList CarsDetails = new ArrayList();
            string cmdStr = getQueryVisitorsAndWorker(start, end, group, state);
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Cars crs = new Cars();

                crs.IDVis = tType[0].ToString();
                crs.CarId = tType[1].ToString();
                crs.TypeCar = tType[2].ToString();
                crs.YearCar = tType[3].ToString();
                crs.ColorCar = tType[4].ToString();
                crs.PermissionPaths = tType[5].ToString();
                crs.Group = tType[6].ToString();
                crs.StatusVisitor = tType[7].ToString();
                CarsDetails.Add(crs); // פונקצית הוספה לטבלה
            }
            return CarsDetails;

        }

        // ==================================
        // פונקציה להוציא פרטים על משתמשים
        // ==================================
        public ArrayList GetInformationAboutUsers(DateTime start, DateTime end, string group, string state)
        {
            DataSet ds = new DataSet();
            ArrayList UsersDetails = new ArrayList();
            string cmdStr = getQueryVisitorsAndWorker(start, end, group, state);
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Users usr = new Users();

                usr.UserId = tType[0].ToString();
                usr.User = tType[1].ToString();
                usr.UserName = tType[2].ToString();
                usr.PermisionType = tType[3].ToString();
                UsersDetails.Add(usr); // פונקצית הוספה לטבלה
            }
            return UsersDetails;

        }

        // =============================
        // השלמה אוטומטית ליצירת אורח
        // ============================
        public Visitors[] autoCompleteVisitorsGuestCard()
        {
            DataSet ds = new DataSet();
            ArrayList visitor = new ArrayList();
            string cmdStr = "SELECT ID,FirstName,LastName,StatusVisitor,Group FROM [Visitors]";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }

            foreach (DataRow tType in dt.Rows)
            {
                Visitors visitorName = new Visitors();
                visitorName.ID = tType[0].ToString();
                visitorName.FirstName = tType[1].ToString();
                visitorName.LastName = tType[2].ToString();
                visitorName.StatusVisitor = tType[3].ToString();
                visitorName.Group = tType[4].ToString();
                visitor.Add(visitorName);
            }
            return (Visitors[])visitor.ToArray(typeof(Visitors));
        }

        //==================================================
        //פונקציה שמחזירה את מספר המבקרים שנמצאים בטבלה
        //==================================================
        public int GetpdfVisitorsNumber()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM [Visitors]";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        //=============================================
        //פונקציה להצגת כל המבקרים שרשומים במערכת
        //=============================================
        public Visitors[] GetpdfVisitorsData()
        {
            DataSet ds = new DataSet();
            ArrayList Visitors = new ArrayList();

            string cmdStr = "SELECT * FROM [Visitors]"; // הצגת כל המבקרים
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Visitors vst = new Visitors();

                vst.ID = tType[0].ToString();
                vst.FirstName = tType[1].ToString();
                vst.LastName = tType[2].ToString();
                vst.City = tType[3].ToString();
                vst.Street = tType[4].ToString();
                vst.PhoneNum = tType[5].ToString();
                vst.WorkerID = tType[6].ToString();
                vst.CreateDate = DateTime.Parse(tType[7].ToString());
                vst.StatusVisitor = tType[8].ToString();
                vst.PermissionPaths = tType[9].ToString();
                vst.Group = tType[10].ToString();
                Visitors.Add(vst);
            }
            return (Visitors[])Visitors.ToArray(typeof(Visitors));
        }

        //========================================
        //פונקציה שמחזירה את מספר הרכבים במערכת
        //========================================
        public int GetpdfCarsNumber()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Cars";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        //================================
        //פונקציה להצגת כל הרכבים במערכת
        //================================
        public Cars[] GetpdfCarsData()
        {
            DataSet ds = new DataSet();
            ArrayList Cars = new ArrayList();
            string cmdStr = "SELECT * FROM [Cars]"; //הצגת כל הרכבים
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Cars crs = new Cars();

                crs.IDVis = tType[0].ToString();
                crs.CarId = tType[1].ToString();
                crs.TypeCar = tType[2].ToString();
                crs.YearCar = tType[3].ToString();
                crs.ColorCar = tType[4].ToString();
                crs.PermissionPaths = tType[5].ToString();
                crs.Group = tType[6].ToString();
                crs.StatusVisitor = tType[7].ToString();
                Cars.Add(crs); // פונקצית הוספה לטבלה
            }
            return (Cars[])Cars.ToArray(typeof(Cars));
        }

        //==================================
        //פונקציה להצגת כל המשתמשים במערכת
        //==================================
        public Users[] GetpdfUsersData()
        {
            DataSet ds = new DataSet();
            ArrayList users = new ArrayList();
            string cmdStr = "SELECT * FROM [Users]"; //הצגת כל הרכבים
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Users use = new Users();

                use.UserId = tType[0].ToString();
                use.User = tType[1].ToString();
                use.UserName = tType[2].ToString();
                use.PermisionType = tType[3].ToString();
                users.Add(use); // פונקצית הוספה לטבלה
            }
            return (Users[])users.ToArray(typeof(Users));

        }
        //*********************************************************************מסך ניהול משתמש***************************************************************************
        //===========================================
        //מסך ניהול מבקרים
        //פונקציה להצגת כל המבקרים שרשומים במערכת
        //===========================================
        public Visitors[] GetEventData()
        {
            DataSet ds = new DataSet();
            ArrayList Visitors = new ArrayList();
            string cmdStr = "SELECT Visitors.[DateChek], Visitors.[Carid], Visitors.[FirstName], Visitors.[LastName], Visitors.[Group], Visitors.[PermissionPaths], Visitors.[StatusVisitor], Visitors.[AdminComment] FROM [Visitors]";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Visitors vst = new Visitors();

                vst.CrId = tType[1].ToString();
                vst.FirstName = tType[2].ToString();
                vst.LastName = tType[3].ToString();
                vst.Group = tType[4].ToString();
                vst.PermissionPaths = tType[5].ToString();
                vst.StatusVisitor = tType[6].ToString();
                vst.AdminComment = tType[7].ToString();

                Visitors.Add(vst);
            }
            return (Visitors[])Visitors.ToArray(typeof(Visitors));
        }

        //=======================
        //מקבל את כמות האירועים
        //=======================
        public int GetEventsNumber()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM [Visitors]";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        //========================================
        //מסך ניהול משתמש
        //בדיקה מספר רכב שהוקלד האם קיים במערכת
        //========================================
        public int CheckCarEvenExist(int carid)
        {
            int res;
            string cmdStr = "SELECT COUNT (*) FROM [Visitors] WHERE Carid=@crId";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@crId", carid);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }

        //=====================
        //מסך ניהול משתמש
        // פונקציה לחיפוש רכב
        //=====================
        public Visitors searchEventBycarId(int carid)
        {       
            string cmdStr = "SELECT Visitors.DateChek, Visitors.FirstName, Visitors.LastName, Visitors.Carid, Visitors.Group, Visitors.PermissionPaths, Visitors.StatusVisitor, Visitors.AdminComment FROM [Visitors] WHERE Carid LIKE '" + carid + "'";
            DataSet ds = new DataSet();
            ArrayList visit = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            Visitors visi = new Visitors();
            ChekIn_ChekOut cheek = new ChekIn_ChekOut();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {                
                visi.FirstName = ds.Tables[0].Rows[0][1].ToString();
                visi.LastName = ds.Tables[0].Rows[0][2].ToString();
                visi.CrId = ds.Tables[0].Rows[0][3].ToString();
                visi.Group = ds.Tables[0].Rows[0][4].ToString();
                visi.PermissionPaths = ds.Tables[0].Rows[0][5].ToString();
                visi.StatusVisitor = ds.Tables[0].Rows[0][6].ToString();
                visi.AdminComment = ds.Tables[0].Rows[0][7].ToString();
                return visi;
            }
            else
            {
                return null;
            }
        }

        //=============================================
        //מסך ניהול מבקרים
        //פונקציה לשליפת תעודת זהות לצורך כפתור מידע
        //=============================================
        internal Visitors searchEvenById(int idcar)
        {
            string cmdStr = "SELECT * FROM  [Visitors] WHERE Carid LIKE '" + idcar + "'";
            DataSet ds = new DataSet();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            TextBox tb = new TextBox();
            tb.Text = "Default text";
            Visitors vis = new Visitors();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count == 1)
            {
                vis.CrId = ds.Tables[0].Rows[0][13].ToString();
                return vis;
            }
            else
            {
                return null;
            }
        }

        // ========================================
        //מסך ניהול משתמש
        // כרטיס מידע על מבקר מלחיצה על מספר רכב
        //פרטי מבקר
        // ========================================
        public Visitors GetEventDetails(int getcarID)
        {
            DataSet ds = new DataSet();
            string cmdStr = "SELECT * FROM  [Visitors] WHERE Carid LIKE '" + getcarID + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            Visitors visitor = new Visitors();
            foreach (DataRow tType in dt.Rows)
            {
                visitor.ID = tType[0].ToString();
                visitor.City = tType[3].ToString();
                visitor.PhoneNum = tType[5].ToString();
                visitor.AdminComment = tType[11].ToString();
            }
            return visitor;
        }
        // ================
        //מסך ניהול משתמש
        // קבלת מס רכב
        // ===============
        public Visitors GetNumC(int getcarID)
        {
            DataSet ds = new DataSet();
            string cmdStr = "SELECT * FROM  [Visitors] WHERE Carid LIKE '" + getcarID + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            Visitors visitor = new Visitors();
            foreach (DataRow tType in dt.Rows)
            {
                visitor.CrId = tType[13].ToString();
            }
            return visitor;
        }

        // ========================================
        //מסך ניהול משתמש
        // כרטיס מידע על מבקר מלחיצה על מספר רכב
        // ========================================
        public Cars GetEventDetailscar(int getcarID)
        {
            DataSet ds = new DataSet();
            string cmdStr = "SELECT * FROM  [Cars] WHERE Carid LIKE '" + getcarID + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            Cars car = new Cars();

            foreach (DataRow tType in dt.Rows)
            {
                car.TypeCar = tType[2].ToString();
                car.ColorCar = tType[4].ToString();
                car.YearCar = tType[3].ToString();
            }
            return car;
        }

        // ===================================================
        // פונקציה להחזיר את הפרטים של מבקרים שנכנסו ויצאו 
        // השלמה אוטומטית לשדות
        // ==================================================
        public Visitors[] autoCompleteVisitorsCheckInOrOut()
        {
            DataSet ds = new DataSet();
            ArrayList visitor = new ArrayList();
            string cmdStr = "SELECT Carid,FirstName,CheckInOrOut FROM [Visitors]";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Visitors visitorName = new Visitors();

                visitorName.CrId = tType[0].ToString();
                visitorName.FirstName = tType[1].ToString();
                visitorName.CheckInOrCheckOut = bool.Parse(tType[2].ToString());
                visitor.Add(visitorName);
            }
            return (Visitors[])visitor.ToArray(typeof(Visitors));
        }

        // ======================================
        // עדכון הוספה נכנס או יצא מהבית חולים
        // ======================================
        internal void updateInsertEntery(Visitors visitor, bool check, string comment)
        {
            string cmdStr = "UPDATE [Visitors] SET [CheckInOrOut] = @checkInOrOut, [AdminComment] = @adminComment WHERE [Carid] LIKE @carid";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@checkInOrOut", check ? "1" : "0");
                command.Parameters.AddWithValue("@adminComment", comment);
                command.Parameters.AddWithValue("@carid", visitor.CrId);
                base.ExecuteSimpleQuery(command);
            }
        }
        //**********************************************************מסך היסטוריה************************************************************************
        // ===========================================
        // עדכון טבלאות אירועים עם כניסה חדשה והערה
        //מסך היסטוריה
        // ===========================================
        public void insertEvent(Visitors newVisitor, bool check, string comment)
        {
            string cmdStr = "INSERT INTO [HistoryVisitors] ([DateEntry], [EventEntry], [CarID], [Comment]) VALUES ('" + DateTime.Now + "','" + (check ? "כניסה" : "יציאה") + "','" + newVisitor.CrId + "','" + comment + "')";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        //==============
        //מסך היסטוריה 
        //כרטיס מבקר
        //=============
        public Visitors[] GetVisitorDetailsByDate(DateTime start, DateTime end)
        {
            DataSet ds = new DataSet();
            ArrayList Visitors = new ArrayList();
            string cmdStr = "";
            cmdStr += "SELECT * FROM [Visitors] WHERE createdDate BETWEEN #" + start.ToShortDateString() + "# And #" + end.ToShortDateString() + "#";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();

            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Visitors vst = new Visitors();

                vst.ID = tType[0].ToString();
                vst.FirstName = tType[1].ToString();
                vst.LastName = tType[2].ToString();
                vst.City = tType[3].ToString();
                vst.Street = tType[4].ToString();
                vst.PhoneNum = tType[5].ToString();
                vst.WorkerID = tType[6].ToString();
                vst.CreateDate = DateTime.Parse(tType[7].ToString());
                vst.StatusVisitor = tType[8].ToString();
                vst.PermissionPaths = tType[9].ToString();
                vst.Group = tType[10].ToString();
                vst.AdminComment = tType[11].ToString();
                vst.OrganizationBox = tType[12].ToString();
                vst.CrId = tType[13].ToString();
                Visitors.Add(vst);
            }
            return (Visitors[])Visitors.ToArray(typeof(Visitors));
        }

        // ============================================================================
        //מסך היסטוריה
        // פונקציה המחזירה את הכניסות והיציאות (מבקרים / עובדים )
        // ============================================================================
        internal DataTable getEvent(string _event)
        {
            DataSet ds = new DataSet();
            string cmdStr = "SELECT DateEntry AS תאריך, EventEntry AS אירוע, HistoryVisitors.CarID AS מספר_רכב, Comment  AS הערת_משתמש FROM HistoryVisitors INNER JOIN Visitors ON HistoryVisitors.CarID = Visitors.CarID WHERE ";
            if (_event.Contains("AllCheckin")) cmdStr += "EventEntry = 'כניסה'"; // כותרת משנה של כניסות
            if (_event.Contains("AllChekout")) cmdStr += "EventEntry = 'יציאה'"; // כותרת משנה של יציאה
            if (!_event.Contains("Check"))
            {
                switch (_event)
                {
                    case "InVisitors": // כניסות מבקרים
                        cmdStr += "EventEntry = 'כניסה'";
                        break;
                    case "OutVisitors"://יציאות מבקרים
                        cmdStr += "EventEntry = 'יציאה' ";
                        break;
                    default:
                        break;
                }
            }
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            return dt;
        }

        // ==============================================
        //מסך היסטוריה
        // פונקציה שמחזירה טבלה עם כל הכניסות והיציאות
        // מהבית חולים
        // ==============================================
        internal DataTable getCurrentChecked(string _event)
        {
            DataSet ds = new DataSet();
            string cmdStr = "SELECT Group AS מחלקה,Carid AS מספר_רכב,FirstName AS שם,LastName AS משפחה,AdminComment AS הערה FROM [Visitors] WHERE [CheckInOrOut]= ";
            if (_event.Contains("checkin")) cmdStr += "-1";
            if (_event.Contains("checkout")) cmdStr += "0";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            return dt;
        }

        // ================================================================
        //מסך היסטוריה
        // פונקציה המחזירה את כל הפרטים על המבקר באמצעות מזהה מספר רכב
        // ================================================================
        public Visitors GetVisitorDetailscar(string getcarID)
        {
            DataSet ds = new DataSet();
            string cmdStr = "";
            cmdStr += "SELECT * FROM [Visitors] WHERE Carid LIKE '" + getcarID + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            Visitors visitorName = new Visitors();
            foreach (DataRow tType in dt.Rows)
            {
                visitorName.CrId = tType[13].ToString();
                visitorName.FirstName = tType[1].ToString();
                visitorName.LastName = tType[2].ToString();
                visitorName.WorkerID = tType[6].ToString();
                visitorName.PhoneNum = tType[5].ToString();
                visitorName.PermissionPaths = tType[9].ToString();
            }
            return visitorName;
        }
    }
}
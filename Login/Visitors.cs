using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Visitors
    {
        //*********
        // משתנים 
        //*********
        private string id; //ת.ז
        private string firstName; // שם פרטי
        private string lastName; //שם משפחה  
        private string city; // עיר
        private string street; //כתובת
        private string phoneNum; // מס טלפון 
        private string workerID; // מספר עובד
        private DateTime createDate; // תאריך יצירה
        private string statusVisitor; //סטטוס
        private string permissionPaths; // הרשאות נתיבים
        private string group; // קבוצה        
        private string adminComment; // הערת מנהל
        private string organizationBox; //ארגון
        private string crId; //מס רכב
        private bool checkInOrOut; // כניסה/יציאה
        private DateTime dateChek;

        //******************
        // בנאי של המחלקה
        //******************
        public Visitors()
        {
            this.id = string.Empty;
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.city = string.Empty;
            this.street = string.Empty;
            this.phoneNum = string.Empty;
            this.workerID = string.Empty;
            this.createDate = new DateTime(createDate.Year, createDate.Month, createDate.Day);
            this.statusVisitor = string.Empty;
            this.permissionPaths = string.Empty;
            this.group = string.Empty;
            this.organizationBox = string.Empty;
            this.adminComment = string.Empty;
            this.dateChek = DateTime.Now;
            this.crId = string.Empty;
        }

        //***************
        // מקבל ומחזיר    
        //***************
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }
        public string WorkerID
        {
            get { return workerID; }
            set { workerID = value; }
        }
        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        public string StatusVisitor
        {
            get { return statusVisitor; }
            set { statusVisitor = value; }
        }
        public string PermissionPaths
        {
            get { return permissionPaths; }
            set { permissionPaths = value; }
        }
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public string OrganizationBox
        {
            get { return organizationBox; }
            set { organizationBox = value; }
        }
        public string AdminComment
        {
            get { return adminComment; }
            set { adminComment = value; }
        }
         public bool CheckInOrCheckOut
        {
            get { return checkInOrOut; }
            set { checkInOrOut = value; }
        }
        public string CrId
        {
            get { return crId; }
            set { crId = value; }
        }

        public DateTime DateChek
        {
            get { return dateChek; }
            set { dateChek = value; }
        }
    }
}
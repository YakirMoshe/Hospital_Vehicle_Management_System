using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//************************************
//מחלקה ליצירת אישור זמני לרכב
//************************************
namespace Login
{
    public class ProvisionalApproval
    {
        //**********
        // משתנים 
        //**********
        private DateTime activityTime; // זמן התרחשות
        private string idvis; //תעודת זהות בעל הרכב
        private string fName; // שם פרטי
        private string lName; //שם משפחה  
        private string characterStatus; // סטטוס תו
        private DateTime startDate; // אישור כניסה מתאריך
        private DateTime endDate; // אישור כניסה עד תאריך
        private string requestStatus; // סטטוס בקשה
        private string phoneOwner; // טלפון בעל הרכב
        private string cId; // מספר רכב
        private string tCar; // סוג רכב
        private string cCar; // צבע רכב
        private string typeOk; // סוג אישור
        private string statusProv;
        private string unit; //יחידה
        private string typemos; //סוג מוסד
       
        //*****************
        // בנאי של המחלקה
        //*****************
        public ProvisionalApproval()
        {
            this.activityTime = DateTime.Today;
            this.idvis = string.Empty;
            this.fName = string.Empty;
            this.lName = string.Empty;
            this.characterStatus = string.Empty;
            this.startDate = DateTime.Today;
            this.endDate = DateTime.Today;
            this.requestStatus = string.Empty;
            this.phoneOwner = string.Empty;
            this.cId = string.Empty;
            this.tCar = string.Empty;
            this.cCar = string.Empty;
            this.typeOk = string.Empty;
            this.statusProv = string.Empty;
            this.unit = string.Empty;
            this.typemos = string.Empty;
        }
        //****************
        //   מקבל ומחזיר    
        //****************
        public DateTime ActivityTime
        {
            get { return activityTime; }
            set { activityTime = value; }
        }
        public string Idvis
        {
            get { return idvis; }
            set { idvis = value; }
        }
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public string CharacterStatus
        {
            get { return characterStatus; }
            set { characterStatus = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public string RequestStatus
        {
            get { return requestStatus; }
            set { requestStatus = value; }
        }
        public string PhoneOwner
        {
            get { return phoneOwner; }
            set { phoneOwner = value; }
        }
        public string CId
        {
            get { return cId; }
            set { cId = value; }
        }
        public string TCar
        {
            get { return tCar; }
            set { tCar = value; }
        }
        public string CCar
        {
            get { return cCar; }
            set { cCar = value; }
        }
        public string TypeOk
        {
            get { return typeOk; }
            set { typeOk = value; }
        }
        public string StatusProv
        {
            get { return statusProv; }
            set { statusProv = value; }
        }
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
          public string Typemos
        {
            get { return typemos; }
            set { typemos = value; }
        }
    }
}
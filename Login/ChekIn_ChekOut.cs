using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    //**********
    // משתנים 
    //**********
    public class ChekIn_ChekOut
    {
        private string iD; // תעודת זהות
        private DateTime date; // תאריך ושעה
        private string carid; // מס רכב
        private string permissionpaths; // הרשאות
        private string workerId; // מספר עובד אם יש
        private string eventEntry; //תעוד נכנס/יוצא                                   
        private string comment; //הערה

        //*******************
        // בנאי של המחלקה
        //******************
        public ChekIn_ChekOut()
        {
            this.iD = string.Empty;
            this.date = DateTime.Now;
            this.carid = string.Empty;
            this.permissionpaths = string.Empty;
            this.workerId = string.Empty;
            this.eventEntry = string.Empty;
            this.comment = string.Empty;
        }

        //***************
        // מקבל ומחזיר    
        //***************
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string WorkerId
        {
            get { return workerId; }
            set { workerId = value; }
        }
        public string EventEntry
        {
            get { return eventEntry; }
            set { eventEntry = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public string CarID
        {
            get { return carid; }
            set { carid = value; }
        }
        public string Permissionpaths
        {
            get { return permissionpaths; }
            set { permissionpaths = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class VisitorsHistory
    {
        //**********
        // משתנים 
        //**********
        private DateTime date; // תאריך כניסה
        private string eventEntry; // אירוע כניסה או יציאה
        private string carid; // מס רכב
        private string comment;// ת.ז
       
        //******************
        // בנאי של המחלקה
        //******************
         public VisitorsHistory()
         {
            this.date = DateTime.UtcNow;
            this.eventEntry = string.Empty;
            this.carid = string.Empty;
            this.comment = string.Empty;
         }

         //****************
         //   מקבל ומחזיר    
         //****************
            public DateTime Date
            {
                get { return date; }
                set { date = value; }
            }
            public string EventEntry
            {
                get { return eventEntry; }
                set { eventEntry = value; }
            }
            public string Carid
            {
                get { return carid; }
                set { carid = value; }
            }
            public string Comment
            {
                get { return comment; }
                set { comment = value; }
            }
       }
   }

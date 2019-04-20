using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data;

namespace Login
{
    public class DbAccess
    {
        #region Constructor+Members
        //==============================================
        //יכולה לגשת לשדה הזה DbAccess מחלקה שיורשת מ    
        //==============================================
        protected OleDbConnection _conn = null;
        public DbAccess(string connectionString)
        {
            _conn = new OleDbConnection(connectionString);
        }
        #endregion

        #region protected Methods
        //=======================
        //התחבר אל בסיס הנתונים
        //=======================
        protected void Connect()
        {
            //אם לא הוא פתוח
            if (_conn.State != ConnectionState.Open) 
            {
                //מבצעים פתיחה
                _conn.Open(); 
            }
        }
        //=====================
        //התנתק מבסיס הנתונים
        //=====================
        protected void Disconnect()
        {
            _conn.Close();
        }

        //======================================================
        //פונקציה המפעילה שאילתא (בארגומנט) ואינה מחזירה דבר
        //======================================================
        protected void ExecuteSimpleQuery(OleDbCommand command)
        {
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    //DB של ה commnad.text השיטה מפעילה את השאילתה ששמרנו בתוך ה
                    command.ExecuteNonQuery();
                }
                finally
                {
                    //סגירת החיבור ושיחרור הנעילה
                    Disconnect();
                }
            }
        }
        //================================================
        //פונקציה המפעילה שאילתא (בארגומנט) ומחזירה שלם
        //================================================
        protected int ExecuteScalarIntQuery(OleDbCommand command)
        {
            int ret = -1;
            lock (_conn)
            {
                Connect();
                //התחברות שפתחנו
                command.Connection = _conn;
                try
                {
                    //ExecuteScalar-הפעלת שאילתה שמחזירה תוצאה 1
                    ret = (int)command.ExecuteScalar();
                }
                finally
                {
                    Disconnect();
                }
            }
            //הערך שקבלנו מהתוצאה שהשאילתה החזירה
            return ret;
        }
        //=========================================
        //פונקציה המחזירה טבלה עם תוצאות השאילתה
        //=========================================
        protected DataSet GetMultipleQuery(OleDbCommand command)
        {
            DataSet dataset = new DataSet();
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    //אובייקט שממלא את הטבלה מתוצאות השאילתה
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataset);
                }
                finally
                {
                    Disconnect();
                }
            }
            return dataset;
        }
    }
}
#endregion
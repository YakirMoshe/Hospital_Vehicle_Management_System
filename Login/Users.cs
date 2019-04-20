using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{

   public class Users
    {
        //**********
        // משתנים 
        //**********
        private string userId; // ת.ז של העובד
        private string userName;//שם עובד
        private string user; // שם משתמש
        private string userpassword; // סיסמה
        private string permisionType;  //סוג הרשאה מנהל /משתמש

        //*****************
        // בנאי של המחלקה
        //*****************
        public Users()
        {
            this.userId = userId;
            this.userName = userName;
            this.user = user;
            this.userpassword = userpassword;
            this.permisionType = permisionType;
        }

        //***************
        // מקבל ומחזיר    
        //***************
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Userpassword
        {
            get { return userpassword; }
            set { userpassword = value; }
        }
            public string PermisionType
        {
            get { return permisionType; }
           set { permisionType = value; }
        }

    }
}
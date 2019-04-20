using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//מחלקה לתקינות קלט פלט
namespace Login
{
   public class valid
    {
        //****************************
        //בדיקת תקינות לתעודת זהות
        //****************************
        public static bool checkId(string Id)
        {
            bool res = true;
            if (Id.Length == 9)
            {
                for (int i = 0; i < Id.Length && res; i++)
                {
                    res = (Id[i] >= '0' && Id[i] <= '9');
                }
                return res;
            }
            return false;
        }
        //*********************************
        //בדיקה תקינות של שם ללא מספרים
        //*********************************
        public static bool checkfirstName(string firstname)
        {
            bool res = true;
            for (int i = 0; i < firstname.Length && res; i++)
            {
                res = ((firstname[i] >= 'a' && firstname[i] <= 'z') || (firstname[i] >= 'A' && firstname[i] <= 'Z') || (firstname[i] >= 'א' && firstname[i] <= 'ת')||(firstname[i]==' '));
            }
            return res;
        }
        //****************************************
        //בדיקה תקינות של שם משפחה ללא מספרים
        //****************************************
        public static bool checklastName(string lastname)
        {
            bool res = true;
            for (int i = 0; i < lastname.Length && res; i++)
            {
                res = ((lastname[i] >= 'א' && lastname[i] <= 'ת')||(lastname[i]==' '));
            }
            return res;
        }
        //**************************************
        //בדיקת תקינות של שם עיר ללא מספרים
        //**************************************
        public static bool checkcity(string city)
        {
            bool res = true;
            for (int i = 0; i < city.Length && res; i++)
            {
                res = ((city[i] >= 'א' && city[i] <= 'ת') || (city[i] == ' '));
            }
            return res;
        }
        //*********************
        //בדיקת תקינות רחוב
        //*********************
        public static bool checkstreet(string street)
        {
            bool res = true;
            for (int i = 0; i < street.Length && res; i++)
            {
                res = ((street[i] >= 'א' && street[i] <= 'ת')||(street[i]==' '));
            }
            return res;
        }
        //*********************************************************
        //פונקציה לאמת את מספר הטלפון אם יש לו 10 ספרות בדיוק
        //*********************************************************
        public static bool checkPhone(string phone)
        {
            bool res = true;
            if (phone.Length == 10)
            {
                for (int i = 0; i < phone.Length && res; i++)
                {
                    res = (phone[i] >= '0' && phone[i] <= '9');
                }
                return res;
            }
            return false;
        }
        //**************************
        //בדיקת תקינות מספר עובד 
        //**************************
        public static bool checkworkerID(string workerID)
        {
            bool res = true;
            if (workerID.Length == 5 || workerID == "")
            {
                for (int i = 0; i < workerID.Length && res; i++)
                {
                    res = (workerID[i] >= '0' && workerID[i] <= '9' || workerID == "");
                }
                return res;
            }
            return false;
        }
        //****************************
        //בדיקת תקינות עבור פרטי רכב
        // תקינות של מספר הרכב
        //****************************
        public static bool checkcarId(string carId)
        {
            bool res = true;
            if (carId.Length == 7 || carId.Length == 8) // בדיקה שווה ל 7 ספרות או 8 ספרות
            {
                for (int i = 0; i < carId.Length && res; i++)
                {
                    res = (carId[i] >= '0' && carId[i] <= '9');
                }
                return res;
            }
            return false;
        }
        //*****************
        //תקיונת סוג רכב
        //*****************
        public static bool checktypeCar(string typeCar)
        {
            bool res = true;
            for (int i = 0; i < typeCar.Length && res; i++)
            {
                res = ((typeCar[i] >= 'א' && typeCar[i] <= 'ת'));
            }
            return res;
        }
        //******************
        //תקינות שנת הרכב
        //******************
        public static bool checkyearCar(string yearCar)
        {
            bool res = true;
            if (yearCar.Length == 4)
            {
                for (int i = 0; i < yearCar.Length && res; i++)
                {
                    res = (yearCar[i] >= '0' && yearCar[i] <= '9');
                }
                return res;
            }
            return false;
        }
        //********************
        //תקינות שם צבע רכב
        //********************
        public static bool checkcolorCar(string colorCar)
        {
            bool res = true;
            for (int i = 0; i < colorCar.Length && res; i++)
            {
                res = ((colorCar[i] >= 'א' && colorCar[i] <= 'ת'));
            }
            return res;
        }
        //****************************
        //בדיקת תקינות לתעודת זהות
        //****************************
        public static bool checkIDVis(string IDVis)
        {
            bool res = true;
            if (IDVis.Length == 9)
            {
                for (int i = 0; i < IDVis.Length && res; i++)
                {
                    res = (IDVis[i] >= '0' && IDVis[i] <= '9');
                }
                return res;
            }
            return false;
        }

        //*******************************
        //בדיקות תקינות עבור פרטי משתמש
        //בדיקה תקינות של שם ללא מספרים
        //*******************************
        public static bool checkUserName(string userName)
        {
            bool res = true;
            for (int i = 0; i < userName.Length && res; i++)
            {
                res = ((userName[i] >= 'a' && userName[i] <= 'z') || (userName[i] >= 'A' && userName[i] <= 'Z') || (userName[i] >= 'א' && userName[i] <= 'ת') || (userName[i] == ' '));
            }
            return res;
        }
        //****************************************
        //בדיקה תקינות של שם משתמש ללא מספרים
        //****************************************
        public static bool checkUser(string user)
        {
            bool res = true;
            for (int i = 0; i < user.Length && res; i++)
            {
                res = ((user[i] >= 'a' && user[i] <= 'z') || (user[i] >= 'A' && user[i] <= 'Z') || (user[i] >= 'א' && user[i] <= 'ת')||(user[i]==' '));
            }
            return res;
        }
        //************************************
        //בדיקת תקינות סיסמה לפחות 5 תווים
        //************************************
        public static bool checkPassworduser(string passworduser)
        {
            bool res = true;
            if (passworduser.Length >= 5)
            {
                for (int i = 0; i < passworduser.Length && res; i++)
                {
                    res = ((passworduser[i] >= '0' && passworduser[i] <= '9') || (passworduser[i] >= 'a' && passworduser[i] <= 'z') || (passworduser[i] >= 'A' && passworduser[i] <= 'Z') || (passworduser[i] >= 'א' && passworduser[i] <= 'ת'));
                }
                return res;
            }
            return false;
        }
    }
}
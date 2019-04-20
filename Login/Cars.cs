using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Cars
    {
        //**********
        // משתנים 
        //**********
        private string idVis; //ת.ז בעל רכב
        private string carId; // מס רכב
        private string typeCar; // סוג רכב
        private string yearCar; // שנת יצור
        private string colorCar; // צבע רכב
        private string permissionPaths; //הרשאות נתיב
        private string group; //מחלקה
        private string statusVisitor; //סטטוס רכב/מבקר

        //******************
        // בנאי של המחלקה
        //******************
        public Cars()
       {
        this.idVis = string.Empty;
        this.carId = string.Empty;
        this.typeCar = string.Empty;
        this.yearCar = string.Empty;
        this.colorCar = string.Empty;
        this.permissionPaths = string.Empty;
        this.group = string.Empty;
        this.statusVisitor = string.Empty;
        }

        //***************
        // מקבל ומחזיר    
        //***************
        public string IDVis
        {
            get { return idVis; }
            set { idVis = value; }
        }
        public string CarId
        {
            get { return carId; }
            set { carId = value; }
        }
        public string TypeCar
        {
            get { return typeCar; }
            set { typeCar = value; }
        }
        public string YearCar
        {
            get { return yearCar; }
            set { yearCar = value; }
        }
        public string ColorCar
        {
            get { return colorCar; }
            set { colorCar = value; }
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
        public string StatusVisitor
        {
            get { return statusVisitor; }
            set { statusVisitor = value; }
        }
    }
}
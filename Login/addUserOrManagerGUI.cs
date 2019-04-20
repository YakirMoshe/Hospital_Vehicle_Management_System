using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class addUserOrManagerGUI : Form
    {
        public addUserOrManagerGUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // כפתור יציאה וחזרה למסך הקודם
        {
            systemPermGUI sp = new systemPermGUI();
            sp.Show(); // להציג את המסך 
            this.Hide(); // לאחר יציאה להסתיר את המסך
        }
    }
}

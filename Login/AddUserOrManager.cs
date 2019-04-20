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
    public partial class AddUserOrManager : Form
    {
        public AddUserOrManager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // כפתור יציאה וחזרה למסך הקודם
        {
            SystemPermGUI sp = new SystemPermGUI();
            sp.Show(); // להציג את המסך 
            this.Hide(); // לאחר יציאה להסתיר את המסך
        }
    }
}

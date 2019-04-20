using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)// שמירת קובץ
        {
          SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using ( Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(textSave1.Text);
                }
              }
           }

         private void buckM_Click(object sender, EventArgs e)// כפתור חזרה לתפריט
        {
            this.Hide(); // כאשר נלחץ על כפתור כניסה נכנס למסך ראשי
            Main m = new Main();
            m.Show(); // להציג את המסך 
        }

         private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
         {

         }
    }
}

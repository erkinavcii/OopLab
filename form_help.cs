using OOP2Lab1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Lab1
{
    public partial class Form_Help : Form

    {
        private form_AboutUs abouts;
        public Form_Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            abouts = new form_AboutUs();
            abouts.ShowDialog();
            abouts.TopMost = true;
        }
    }
}

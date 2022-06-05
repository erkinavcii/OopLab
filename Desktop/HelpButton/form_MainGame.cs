using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OOP2Lab1
{
    public partial class form_MainGame : Form
    {
        private form_Settings settingsForm;
        private form_Manage manageForm;
        private form_AboutUs about;
        public form_MainGame()
        {
            InitializeComponent();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            
            settingsForm = new form_Settings();
            settingsForm.ShowDialog();
            
        }

        private void button_Manage_Click(object sender, EventArgs e)
        {
            manageForm = new form_Manage();
            manageForm.ShowDialog();
        }

        private void button_About_Us_Click(object sender, EventArgs e)
        {
            about = new form_AboutUs();
            about.ShowDialog();
            about.TopMost=true;
        }
    }
}
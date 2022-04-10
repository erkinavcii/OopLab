using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OOP2Lab1
{
    public partial class form_MainGame : Form
    {
        private form_Settings settingsForm;
        public form_MainGame()
        {
            InitializeComponent();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            
            settingsForm = new form_Settings();
            settingsForm.ShowDialog();
            
        }
       
    }
}
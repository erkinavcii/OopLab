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
    public partial class form_MainGame : Form
    {
        public string difficultyLevel;
        public List<string> chosenRoundShapes = new List<string> {  };
        public int firstNumberCustomSettings, secondNumberCustomSettings;
        public form_MainGame()
        {
            InitializeComponent();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            groupBox_Settings.Visible = true;
            button_Settings.Visible=false;
        }
        private void button_Save_Settings_Click(object sender, EventArgs e)
        {
            if (radioButton_Easy_Settings.Checked)
            {
                difficultyLevel = "Easy";
            }
            else if (radioButton_Normal_Settings.Checked)
            {
                difficultyLevel = "Normal";
            }
            else if (radioButton_Hard_Settings.Checked)
            {
                difficultyLevel = "Hard";
            }
            else if (radioButton_Custom_Settings.Checked)
            {
                difficultyLevel = "Custom";
                try
                {
                    firstNumberCustomSettings = Convert.ToInt32(textBox_FirstNumberCustom_Settings.Text);
                    secondNumberCustomSettings = Convert.ToInt32(textBox_SecondNumberCustom_Settings.Text);
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
            else
            {
                MessageBox.Show("Please select a difficulty level!","Warning");
            }
            chosenRoundShapes.Clear();
            foreach(string s in checkedListBox_RoundShapes.CheckedItems)
            {
                chosenRoundShapes.Add(s);
            }

        }
    }
}

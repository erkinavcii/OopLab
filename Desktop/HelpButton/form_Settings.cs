using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Lab1
{
    public partial class form_Settings : Form
    {
        public string difficultyLevel;
        public List<string> chosenRoundShapes = new List<string> { };
        public List<string> chosenColors = new List<string> { };
        public int firstNumberCustomSettings = 0, secondNumberCustomSettings = 0;
        bool color_flag = false;
        public form_Settings()
        {
            InitializeComponent();
            get_Settings_From_Text_File();
            set_Settings();
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Please select a difficulty level!", "Warning");
            }
            chosenRoundShapes.Clear();
            chosenColors.Clear();
            foreach (string s in checkedListBox_RoundShapes.CheckedItems)
            {
                chosenRoundShapes.Add(s);
            }
            foreach (string s in checkedListBox_Color_Settings.CheckedItems)
            {
                chosenColors.Add(s);
            }
            write_Settings_To_Text_File();
        }
        private void write_Settings_To_Text_File()
        {
            string pathSource = System.IO.Directory.GetCurrentDirectory() + "\\yko.txt";
            StreamWriter writer = new StreamWriter(pathSource);
            writer.WriteLine(difficultyLevel);
            writer.WriteLine(firstNumberCustomSettings);
            writer.WriteLine(secondNumberCustomSettings);

            foreach (string s in chosenRoundShapes)
            {
                writer.WriteLine(s);
            }
            foreach (string s in chosenColors)
            {
                writer.WriteLine(s);
            }
            writer.Close();

        }
        private void get_Settings_From_Text_File()
        {
            string pathSource = System.IO.Directory.GetCurrentDirectory() + "\\yko.txt";
            if (!File.Exists(pathSource))  // If the file doesn't exist, the folder will create in this if statement.
            {
                StreamWriter writer = new StreamWriter(pathSource);
                writer.Close();
            }
            StreamReader reader = new StreamReader(pathSource);
            difficultyLevel = reader.ReadLine();
            firstNumberCustomSettings = Convert.ToInt32(reader.ReadLine());
            secondNumberCustomSettings = Convert.ToInt32(reader.ReadLine());
            chosenRoundShapes.Clear();
            chosenColors.Clear();
            while (!reader.EndOfStream)
            {
                string s = (string)reader.ReadLine();
                if (checkedListBox_Color_Settings.Items.Contains(s))
                {
                    color_flag = true;
                }

                if (color_flag)
                {
                    chosenColors.Add(s);
                }
                else
                {
                    chosenRoundShapes.Add(s);
                }
                Console.WriteLine(s);
            }
            reader.Close();
        }

        private void set_Settings()
        {
            if (difficultyLevel == "Easy")
            {
                radioButton_Easy_Settings.Checked = true;
            }
            else if (difficultyLevel == "Normal")
            {
                radioButton_Normal_Settings.Checked = true;
            }
            else if (difficultyLevel == "Hard")
            {
                radioButton_Hard_Settings.Checked = true;
            }
            else if (difficultyLevel == "Custom")
            {
                radioButton_Custom_Settings.Checked = true;
                textBox_FirstNumberCustom_Settings.Text = firstNumberCustomSettings.ToString();
                textBox_SecondNumberCustom_Settings.Text = secondNumberCustomSettings.ToString();
            }
            foreach (string s in chosenRoundShapes)
            {
                int index = checkedListBox_RoundShapes.FindString(s);
                if (index >= 0)
                {
                    checkedListBox_RoundShapes.SetItemChecked(index, true);
                }
            }
            foreach (string s in chosenColors)
            {
                int index = checkedListBox_Color_Settings.FindString(s);
                if (index >= 0)
                {
                    checkedListBox_Color_Settings.SetItemChecked(index, true);
                }
            }
        }
    }
}

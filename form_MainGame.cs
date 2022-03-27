using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OOP2Lab1
{
    public partial class form_MainGame : Form
    {
        public string difficultyLevel;
        public List<string> chosenRoundShapes = new List<string> { };
        public int firstNumberCustomSettings = 0, secondNumberCustomSettings = 0;
        public form_MainGame()
        {
            InitializeComponent();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            get_Settings_From_Text_File();
            set_Settings(); 
            groupBox_Settings.Visible = true;
            button_Settings.Visible = false;
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
            foreach (string s in checkedListBox_RoundShapes.CheckedItems)
            {
                chosenRoundShapes.Add(s);
            }
            groupBox_Settings.Visible = false; // To back main menu.
            button_Settings.Visible = true; // To back main menu.
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
            writer.Close();

        }
        private void get_Settings_From_Text_File()
        {
            string pathSource = System.IO.Directory.GetCurrentDirectory() + "\\yko.txt";
            StreamReader reader = new StreamReader(pathSource);
            difficultyLevel = reader.ReadLine();
            firstNumberCustomSettings = Convert.ToInt32(reader.ReadLine());
            secondNumberCustomSettings = Convert.ToInt32(reader.ReadLine());
            chosenRoundShapes.Clear();
            while(!reader.EndOfStream)
            {
                chosenRoundShapes.Add((string)reader.ReadLine());   
            }
            reader.Close();
        }
        private void set_Settings()
        {
            if (difficultyLevel=="Easy")
            {
                radioButton_Easy_Settings.Checked = true;
            }
            else if (difficultyLevel == "Normal")
            {
                radioButton_Normal_Settings.Checked = true;
            }
            else if(difficultyLevel == "Hard")
            {
                radioButton_Hard_Settings.Checked = true;
            }
            else if( difficultyLevel == "Custom")
            {
                radioButton_Custom_Settings.Checked= true;
                textBox_FirstNumberCustom_Settings.Text=firstNumberCustomSettings.ToString();
                textBox_SecondNumberCustom_Settings.Text=secondNumberCustomSettings.ToString();
            }
            foreach(string s in chosenRoundShapes)
            {
                int index=checkedListBox_RoundShapes.FindString(s);
                if (index >= 0)
                {
                    checkedListBox_RoundShapes.SetItemChecked(index, true);
                }
            }
        }
    }
}
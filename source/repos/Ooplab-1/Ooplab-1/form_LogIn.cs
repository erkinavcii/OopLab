﻿using System;
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
    public partial class form_LogIn : Form
    {
        private form_MainGame mainGameForm;
        public form_LogIn()
        {
            InitializeComponent();
            this.AcceptButton = button_LogIn;
        }
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            /*if (!textBox_Username.Text.All(c => Char.IsLetter(c)))
            {
                MessageBox.Show("You entered nonletter character.");
            }*/
             if (textBox_Username.Text =="user"&&textBox_Password.Text == "user")
            {
                mainGameForm = new form_MainGame();
                mainGameForm.ShowDialog();
                this.Hide();
            }
            else if(textBox_Username.Text == "admin" && textBox_Password.Text == "admin")
            {
                mainGameForm = new form_MainGame();
                mainGameForm.ShowDialog();
                this.Hide();
            }
            else
            {MessageBox.Show("You entered wrong username or password or both");
            }
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox_Username.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                textBox_Username.Text.Remove(textBox_Username.Text.Length - 1);
            }
        }

        private void textBox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(!char.IsLetter(e.KeyChar)&&!char.IsControl(e.KeyChar)&& !char.IsWhiteSpace(e.KeyChar))
                {
                e.Handled = true;
            }

        }
    }
}
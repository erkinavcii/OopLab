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
using System.Security.Cryptography;

namespace OOP2Lab1
{
    public partial class form_LogIn : Form
    {
        private form_MainGame mainGameForm;
        private form_SignUp SignUpForm;

        public form_LogIn()
        {
            InitializeComponent();
            this.AcceptButton = button_LogIn;
        }
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            if(textBox_Username.Text =="user"&&textBox_Password.Text == "user")
            {
                mainGameForm = new form_MainGame();
                mainGameForm.ShowDialog();
                this.Hide();
                ///////////////////
                string path = System.IO.Directory.GetCurrentDirectory() + "\\lastuser.txt";
                if (!File.Exists(path))  // If the file doesn't exist, the folder will create in this if statement.
                {
                    File.Create(path);
                }
                File.WriteAllText(path, textBox_Username.Text);
                /////////////////////////
            }
            else if(textBox_Username.Text == "admin" && textBox_Password.Text == "admin")
            {
                ////////////////////////
                string path = System.IO.Directory.GetCurrentDirectory() + "\\lastuser.txt";
                if (!File.Exists(path))  // If the file doesn't exist, the folder will create in this if statement.
                {
                    File.Create(path);
                    File.WriteAllText(path, textBox_Username.Text);
                }
                File.WriteAllText(path, textBox_Username.Text);
                //////////////////////
                mainGameForm = new form_MainGame();
                mainGameForm.ShowDialog();
               
                
            }
            else
            {MessageBox.Show("You entered wrong username or password or both");
            }
        }

        private void textBox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))////prevents user to press numbers in username textbox
            {
                e.Handled = true;
            }
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_SıgnIn_Click(object sender, EventArgs e)
        {
            
        }

        private void form_LogIn_Load(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\lastuser.txt";
            var str =File.ReadAllText(path);
            textBox_Username.Text = str;
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            SignUpForm = new form_SignUp();
            SignUpForm.ShowDialog();
        }
    }
}

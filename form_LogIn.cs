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
    
    public partial class form_LogIn : Form
    {
        private form_MainGame mainGameForm=new form_MainGame();
        private form_SignUp signUpForm;
        private List<User> users = new List<User>();
        public static string enteredUsername = "";
        public form_LogIn()
        {
            InitializeComponent();
            this.AcceptButton = button_LogIn;
        }
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            enteredUsername = textBox_Username.Text;
            users = mainGameForm.GetAllUsers();
            bool dbLogInChecker= false;
            for (int i = 0; i < users.Count; i++)
            {
                string username = String.Concat(users[i].Username.Where(c => !Char.IsWhiteSpace(c)));
                string password= String.Concat(users[i].Password.Where(c => !Char.IsWhiteSpace(c)));
                if (username == textBox_Username.Text && password==textBox_Password.Text)
                {
                    mainGameForm = new form_MainGame();
                    mainGameForm.ShowDialog();
                    dbLogInChecker = true;
                    
                }
            }
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
            }
            else if(dbLogInChecker==false)
            {
                MessageBox.Show("You entered wrong username or password or both");
                
            }
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        { 
            mainGameForm = new form_MainGame();
            signUpForm = new form_SignUp(mainGameForm);
            signUpForm.ShowDialog();
        }
    
    }
}

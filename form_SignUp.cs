using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Lab1
{
    public partial class form_SignUp : Form
    {
        private User usedUser=new User() { };
        private form_MainGame form_MainGame = new form_MainGame();
        public form_SignUp(form_MainGame form_MainGame)
        {
            InitializeComponent();
            this.form_MainGame=form_MainGame;
        }

        private void button_CreateUser_Click(object sender, EventArgs e)
        {
            int id =form_MainGame.GetAllUsers().Count+1;
            User user = new User() {Id= id,Username=textBox_Username.Text, Password=textBox_Password.Text, NameSurname=textBox_NameSurname.Text, PhoneNumber=textBox_PhoneNumber.Text, Address=textBox_Adress.Text, City=textBox_City.Text, Country=textBox_Country.Text, Email=textBox_Email.Text};
            form_MainGame.AddNewUser(user);

        }

        private void button_yaradan_Click(object sender, EventArgs e)
        {
            form_MainGame.GetAllUsers();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_NameSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_PhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Country_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_City_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

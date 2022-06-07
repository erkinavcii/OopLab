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
    public partial class form_UserUpdate : Form
    {
        private form_MainGame mainGameForm;
        private User updatedUser,user;
        public form_UserUpdate(User user)
        {
            InitializeComponent();
            textBox_Password.Text = user.Password;
            textBox_Email.Text = user.Email;
            textBox_Adress.Text = user.Address;
            textBox_City.Text = user.City;
            textBox_NameSurname.Text = user.NameSurname;
            textBox_PhoneNumber.Text = user.PhoneNumber;
            textBox_Country.Text = user.Country;
            this.user = user;
        }

        private void button_UpdateUser_Click(object sender, EventArgs e)
        {
            mainGameForm = new form_MainGame();
            updatedUser= new User() {Username= user.Username, Password = textBox_Password.Text, NameSurname = textBox_NameSurname.Text, PhoneNumber = textBox_PhoneNumber.Text, Address = textBox_Adress.Text, City = textBox_City.Text, Country = textBox_Country.Text, Email = textBox_Email.Text };
            mainGameForm.UpdateTheUser(updatedUser);
        }
    }
}

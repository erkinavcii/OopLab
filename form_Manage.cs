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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace OOP2Lab1
{
    public partial class form_Manage :Form
    {
        private List<User> users = new List<User>() { };
        private form_MainGame mainGameForm=new form_MainGame();
        private form_SignUp signUpForm;
        private form_UserUpdate userUpdateForm;
        public string theUsername;
        
        public form_Manage()
        {
            
            InitializeComponent();
            theUsername = form_LogIn.enteredUsername;
            if (theUsername=="admin")
            {
                groupBox_Admin_Manager.Visible = true;
                set_Users_To_ListBox();
            }
            else
            {
                groupBox_Admin_Manager.Visible = false;
                users= mainGameForm.GetAllUsers();
                User user = mainGameForm.getUser(theUsername);
                this.Hide();
                userUpdateForm = new form_UserUpdate(user);
                userUpdateForm.ShowDialog();
            }
            
        }

        private void form_Manage_Load(object sender, EventArgs e)
        {

        }
        private void set_Users_To_ListBox()
        {
            mainGameForm=new form_MainGame();
            users=mainGameForm.GetAllUsers();
            listBox_Usernames.Items.Clear();
            foreach(User user in users)
            {
                listBox_Usernames.Items.Add(user.Username);
            }
        }
        private void update_User_Information()
        {

        }

        private void button_Add_New_User_Click(object sender, EventArgs e)
        {
            signUpForm = new form_SignUp(mainGameForm);
            signUpForm.ShowDialog();
            set_Users_To_ListBox();
        }

        private void button_Delete_User_Click(object sender, EventArgs e)
        {
            users.Clear();
            mainGameForm.RemoveTheUser((string)listBox_Usernames.SelectedItem);
            set_Users_To_ListBox();
        }
        private void button_Update_User_Click(object sender, EventArgs e)
        {
            foreach(User user in users)
            {
                if(user.Username == listBox_Usernames.SelectedItem)
                {
                    userUpdateForm = new form_UserUpdate(user);
                    userUpdateForm.ShowDialog();
                }
            }
            set_Users_To_ListBox();
        }
    }
}

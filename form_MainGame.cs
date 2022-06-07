using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace OOP2Lab1
{
    public partial class form_MainGame : Form
    {
        private form_Settings settingsForm;
        private form_Manage manageForm;
        private form_AboutUs about;
        private List<User> users = new List<User>() { };
        public form_MainGame()
        {
            InitializeComponent();
        }       

        private void button_Settings_Click(object sender, EventArgs e)
        {

            settingsForm = new form_Settings();
            settingsForm.ShowDialog();

        }

        private void button_Manage_Click(object sender, EventArgs e)
        {
            manageForm = new form_Manage();
            manageForm.ShowDialog();
        }

        private void button_About_Us_Click(object sender, EventArgs e)
        {
            about = new form_AboutUs();
            about.ShowDialog();
            about.TopMost = true;
        }
        public void AddNewUser(User user)
        {
            string commandText = "INSERT INTO dbo.Users ([Id],[Username], [Password], [NameSurname],[PhoneNumber], [Address], [City],[Country], [Email] ) VALUES (@id, @username, @password,@nameSurname,@phoneNumber, @address,@city, @country,@email); ";
            //string commandText1 = "CREATE TABLE Users( Id int PRIMARY KEY, Username char(50), Password char(50),NameSurname char(50), PhoneNumber char(50), Address char(50), City char(50), Country char(50), Email char(50))";

            using (SqlConnection connection = new SqlConnection("workstation id=OOP2LABDatabase.mssql.somee.com;packet size=4096;user id=ibrahim1521_SQLLogin_1;pwd=4lcc42568s;data source=OOP2LABDatabase.mssql.somee.com;persist security info=False;initial catalog=OOP2LABDatabase "))
            {
                connection.Open();
                //SqlCommand command1 = new SqlCommand();
                //command1.CommandText = commandText1;
                //command1.Connection = connection;
                //command1.ExecuteNonQuery();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = commandText;
                    command.Connection = connection;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = user.Id;
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = user.Username;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = user.Password;
                    command.Parameters.Add("@nameSurname", SqlDbType.NVarChar).Value = user.NameSurname;
                    command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = user.PhoneNumber;
                    command.Parameters.Add("@address", SqlDbType.NVarChar).Value = user.Address;
                    command.Parameters.Add("@city", SqlDbType.NVarChar).Value = user.City;
                    command.Parameters.Add("@country", SqlDbType.NVarChar).Value = user.Country;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = user.Email;
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<User> GetAllUsers()
        {
            SqlConnection con = new SqlConnection("workstation id=OOP2LABDatabase.mssql.somee.com;packet size=4096;user id=ibrahim1521_SQLLogin_1;pwd=4lcc42568s;data source=OOP2LABDatabase.mssql.somee.com;persist security info=False;initial catalog=OOP2LABDatabase");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM dbo.Users;";
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            users.Clear();
            while (dr.Read())
            {
                User user = new User() { Id = (int)dr["Id"], Username = (string)dr["Username"], Password = (string)dr["Password"], NameSurname = (string)dr["NameSurname"], PhoneNumber = (string)dr["PhoneNumber"], Address = (string)dr["Address"], City = (string)dr["City"], Country = (string)dr["Country"], Email = (string)dr["Email"] };
                users.Add(user);
            }
            dr.Close();
            con.Close();
            return users;
        }
        public void RemoveTheUser(string _username)
        {
            try
            {
                string commandText = "DELETE FROM dbo.Users WHERE Username= @username ";
                using (SqlConnection connection = new SqlConnection("workstation id=OOP2LABDatabase.mssql.somee.com;packet size=4096;user id=ibrahim1521_SQLLogin_1;pwd=4lcc42568s;data source=OOP2LABDatabase.mssql.somee.com;persist security info=False;initial catalog=OOP2LABDatabase "))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandText = commandText;
                        command.Connection = connection;
                        command.Parameters.Add("@username", SqlDbType.NVarChar).Value = _username;
                        command.ExecuteNonQuery();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The username not found!");
            }
            
        }
        public void UpdateTheUser(User user)
        {
            try
            {
                string commandText = "UPDATE dbo.Users SET Password= @password , NameSurname= @nameSurname , PhoneNumber= @phoneNumber , Address= @address ,City= @city , Country= @country , Email= @email WHERE Username= @username ";
                using (SqlConnection connection = new SqlConnection("workstation id=OOP2LABDatabase.mssql.somee.com;packet size=4096;user id=ibrahim1521_SQLLogin_1;pwd=4lcc42568s;data source=OOP2LABDatabase.mssql.somee.com;persist security info=False;initial catalog=OOP2LABDatabase "))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandText = commandText;
                        command.Connection = connection;
                        command.Parameters.Add("@username", SqlDbType.NVarChar).Value = user.Username;
                        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = user.Password;
                        command.Parameters.Add("@nameSurname", SqlDbType.NVarChar).Value = user.NameSurname;
                        command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = user.PhoneNumber;
                        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = user.Address;
                        command.Parameters.Add("@city", SqlDbType.NVarChar).Value = user.City;
                        command.Parameters.Add("@country", SqlDbType.NVarChar).Value = user.Country;
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = user.Email;
                        command.ExecuteNonQuery();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The username not found!");
            }
        }
        public User getUser(string username)
        {
            foreach (User user in users) {
                string usernametemp = String.Concat(user.Username.Where(c => !Char.IsWhiteSpace(c)));
                if (usernametemp == username) { 
                    return user;
                }
            }
            return null;
        }
    }
}
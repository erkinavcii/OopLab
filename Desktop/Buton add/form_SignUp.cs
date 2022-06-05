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
        public form_SignUp()
        {
            InitializeComponent();
        }

        private void button_CreateUser_Click(object sender, EventArgs e)
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
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32("2");
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = textBox_Username.Text;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox_Password.Text;
                    command.Parameters.Add("@nameSurname", SqlDbType.NVarChar).Value = textBox_NameSurname.Text;
                    command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = textBox_PhoneNumber.Text;
                    command.Parameters.Add("@address", SqlDbType.NVarChar).Value = textBox_Adress.Text;
                    command.Parameters.Add("@city", SqlDbType.NVarChar).Value = textBox_City.Text;
                    command.Parameters.Add("@country", SqlDbType.NVarChar).Value = textBox_Country.Text;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBox_Email.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button_yaradan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("workstation id=OOP2LABDatabase.mssql.somee.com;packet size=4096;user id=ibrahim1521_SQLLogin_1;pwd=4lcc42568s;data source=OOP2LABDatabase.mssql.somee.com;persist security info=False;initial catalog=OOP2LABDatabase");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Password FROM dbo.Users;";
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            ArrayList Usernames = new ArrayList();

            while (dr.Read())
            {
                Usernames.Add(dr["Password"]);
            }
            foreach (String username in Usernames)
            {
                MessageBox.Show(username);
            }
            dr.Close();
            con.Close();
        }
    }
}

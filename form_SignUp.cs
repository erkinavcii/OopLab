using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Linq;


namespace OOP2Lab1
{
    
    public partial class form_SignUp : Form
    {

       
        public form_SignUp()
        {
            InitializeComponent();
            
        }

        private void form_SignIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

      
        
        private void button_CreateUser_Click(object sender, EventArgs e)
        {
            
            string path = System.IO.Directory.GetCurrentDirectory() + "\\user.txt";
            if (!File.Exists(path))  // If the file doesn't exist, the folder will create in this if statement.
            {
                StreamWriter writer1 = new StreamWriter(path); 
                writer1.Close();
            }
            
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(textBox_Username.Text);
            writer.WriteLine(textBox_Password.Text);
            writer.WriteLine(textBox_NameSurname.Text);
            writer.WriteLine(textBox_PhoneNumber.Text);
            writer.WriteLine(textBox_Adress.Text);
            writer.WriteLine(textBox_City.Text);
            writer.WriteLine(textBox_Country.Text);
            writer.WriteLine(textBox_Email.Text);
            writer.WriteLine(".");
            writer.Close();
           

        }
    }
}

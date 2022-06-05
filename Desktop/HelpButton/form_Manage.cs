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
    public partial class form_Manage : Form
    {
        private List<string> usernames = new List<string>() { "ali","veli","49","50", "ali" };
        private bool admin=true;
        public form_Manage()
        {
            InitializeComponent();

            if (admin == true)
            {
                groupBox_Admin_Manager.Visible = true;
                set_Users_To_ListBox();
                get_Usernames_From_Xml_File();
            }
            
        }

        private void form_Manage_Load(object sender, EventArgs e)
        {

        }
        private void set_Users_To_ListBox()
        {
            listBox_Usernames.Items.Clear();
            foreach(string user in usernames)
            {
                listBox_Usernames.Items.Add(user);
            }
        }
        private void update_User_Information()
        {

        }

        private void button_Add_New_User_Click(object sender, EventArgs e)
        {
            //Erkinin sign upuna gidecek.
        }

        private void button_Delete_User_Click(object sender, EventArgs e)
        {
            usernames.Remove(listBox_Usernames.SelectedItem.ToString());
            set_Users_To_ListBox();
            // kullanıcı xmlden de silinecek.
        }
        private void button_Update_User_Click(object sender, EventArgs e)
        {
            //Update
        }
        private void get_Usernames_From_Xml_File()
        {
            //string path = System.IO.Directory.GetCurrentDirectory() + "\\users.xml";
            //XmlSerializer serializer=new XmlSerializer(typeof(User));
            //FileStream stream = File.OpenRead(path);
            //var result = (User)(serializer.Deserialize(stream));
            //Console.WriteLine();
        }
    }
}

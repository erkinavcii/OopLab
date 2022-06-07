namespace OOP2Lab1
{
    partial class form_Manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Usernames = new System.Windows.Forms.ListBox();
            this.button_Add_New_User = new System.Windows.Forms.Button();
            this.button_Delete_User = new System.Windows.Forms.Button();
            this.groupBox_Admin_Manager = new System.Windows.Forms.GroupBox();
            this.button_Update_User = new System.Windows.Forms.Button();
            this.groupBox_Admin_Manager.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Usernames
            // 
            this.listBox_Usernames.FormattingEnabled = true;
            this.listBox_Usernames.ItemHeight = 20;
            this.listBox_Usernames.Location = new System.Drawing.Point(254, 49);
            this.listBox_Usernames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_Usernames.Name = "listBox_Usernames";
            this.listBox_Usernames.Size = new System.Drawing.Size(265, 444);
            this.listBox_Usernames.TabIndex = 0;
            // 
            // button_Add_New_User
            // 
            this.button_Add_New_User.Location = new System.Drawing.Point(595, 99);
            this.button_Add_New_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Add_New_User.Name = "button_Add_New_User";
            this.button_Add_New_User.Size = new System.Drawing.Size(112, 54);
            this.button_Add_New_User.TabIndex = 1;
            this.button_Add_New_User.Text = "Add";
            this.button_Add_New_User.UseVisualStyleBackColor = true;
            this.button_Add_New_User.Click += new System.EventHandler(this.button_Add_New_User_Click);
            // 
            // button_Delete_User
            // 
            this.button_Delete_User.Location = new System.Drawing.Point(595, 301);
            this.button_Delete_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Delete_User.Name = "button_Delete_User";
            this.button_Delete_User.Size = new System.Drawing.Size(112, 54);
            this.button_Delete_User.TabIndex = 2;
            this.button_Delete_User.Text = "Delete";
            this.button_Delete_User.UseVisualStyleBackColor = true;
            this.button_Delete_User.Click += new System.EventHandler(this.button_Delete_User_Click);
            // 
            // groupBox_Admin_Manager
            // 
            this.groupBox_Admin_Manager.Controls.Add(this.button_Update_User);
            this.groupBox_Admin_Manager.Controls.Add(this.listBox_Usernames);
            this.groupBox_Admin_Manager.Controls.Add(this.button_Delete_User);
            this.groupBox_Admin_Manager.Controls.Add(this.button_Add_New_User);
            this.groupBox_Admin_Manager.Location = new System.Drawing.Point(0, 15);
            this.groupBox_Admin_Manager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Admin_Manager.Name = "groupBox_Admin_Manager";
            this.groupBox_Admin_Manager.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Admin_Manager.Size = new System.Drawing.Size(788, 519);
            this.groupBox_Admin_Manager.TabIndex = 3;
            this.groupBox_Admin_Manager.TabStop = false;
            this.groupBox_Admin_Manager.Text = "groupBox1";
            this.groupBox_Admin_Manager.Visible = false;
            // 
            // button_Update_User
            // 
            this.button_Update_User.Location = new System.Drawing.Point(595, 196);
            this.button_Update_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Update_User.Name = "button_Update_User";
            this.button_Update_User.Size = new System.Drawing.Size(112, 54);
            this.button_Update_User.TabIndex = 3;
            this.button_Update_User.Text = "Update";
            this.button_Update_User.UseVisualStyleBackColor = true;
            this.button_Update_User.Click += new System.EventHandler(this.button_Update_User_Click);
            // 
            // form_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.groupBox_Admin_Manager);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_Manage";
            this.Text = "form_Manage";
            this.Load += new System.EventHandler(this.form_Manage_Load);
            this.groupBox_Admin_Manager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Usernames;
        private System.Windows.Forms.Button button_Add_New_User;
        private System.Windows.Forms.Button button_Delete_User;
        private System.Windows.Forms.GroupBox groupBox_Admin_Manager;
        private System.Windows.Forms.Button button_Update_User;
    }
}
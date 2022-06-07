namespace OOP2Lab1
{
    partial class form_MainGame
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
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Manage = new System.Windows.Forms.Button();
            this.button_About_Us = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.button_Game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Settings
            // 
            this.button_Settings.Location = new System.Drawing.Point(431, 378);
            this.button_Settings.Margin = new System.Windows.Forms.Padding(4);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(194, 81);
            this.button_Settings.TabIndex = 0;
            this.button_Settings.Text = "Settings";
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // button_Manage
            // 
            this.button_Manage.Location = new System.Drawing.Point(431, 256);
            this.button_Manage.Margin = new System.Windows.Forms.Padding(4);
            this.button_Manage.Name = "button_Manage";
            this.button_Manage.Size = new System.Drawing.Size(194, 81);
            this.button_Manage.TabIndex = 1;
            this.button_Manage.Text = "Manage";
            this.button_Manage.UseVisualStyleBackColor = true;
            this.button_Manage.Click += new System.EventHandler(this.button_Manage_Click);
            // 
            // button_About_Us
            // 
            this.button_About_Us.Location = new System.Drawing.Point(431, 124);
            this.button_About_Us.Margin = new System.Windows.Forms.Padding(4);
            this.button_About_Us.Name = "button_About_Us";
            this.button_About_Us.Size = new System.Drawing.Size(194, 81);
            this.button_About_Us.TabIndex = 2;
            this.button_About_Us.Text = "About Us";
            this.button_About_Us.UseVisualStyleBackColor = true;
            this.button_About_Us.Click += new System.EventHandler(this.button_About_Us_Click);
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(431, 479);
            this.button_help.Margin = new System.Windows.Forms.Padding(4);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(194, 81);
            this.button_help.TabIndex = 3;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // button_Game
            // 
            this.button_Game.Location = new System.Drawing.Point(696, 256);
            this.button_Game.Margin = new System.Windows.Forms.Padding(4);
            this.button_Game.Name = "button_Game";
            this.button_Game.Size = new System.Drawing.Size(194, 81);
            this.button_Game.TabIndex = 4;
            this.button_Game.Text = "Game";
            this.button_Game.UseVisualStyleBackColor = true;
            this.button_Game.Click += new System.EventHandler(this.button_Game_Click);
            // 
            // form_MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.button_Game);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_About_Us);
            this.Controls.Add(this.button_Manage);
            this.Controls.Add(this.button_Settings);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_MainGame";
            this.Text = "Main Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_Manage;
        private System.Windows.Forms.Button button_About_Us;
        private Button button_help;
        private Button button_Game;
    }
}
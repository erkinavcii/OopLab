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
            // form_MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.button_Manage);
            this.Controls.Add(this.button_Settings);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_MainGame";
            this.Text = "Main Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_Manage;
    }
}
namespace OOP2Lab1
{
    partial class form_LogIn
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
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(366, 206);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(213, 27);
            this.textBox_Username.TabIndex = 1;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Username.Location = new System.Drawing.Point(247, 204);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(92, 23);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Password.Location = new System.Drawing.Point(247, 262);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(86, 23);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(366, 262);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(213, 27);
            this.textBox_Password.TabIndex = 3;
            // 
            // button_LogIn
            // 
            this.button_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_LogIn.Location = new System.Drawing.Point(366, 360);
            this.button_LogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(93, 40);
            this.button_LogIn.TabIndex = 4;
            this.button_LogIn.Text = "Log In";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // button_SignUp
            // 
            this.button_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_SignUp.Location = new System.Drawing.Point(501, 360);
            this.button_SignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(113, 40);
            this.button_SignUp.TabIndex = 5;
            this.button_SignUp.Text = "Sign Up";
            this.button_SignUp.UseVisualStyleBackColor = true;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // form_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(154)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.textBox_Username);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_LogIn";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Button button_SignUp;
    }
}


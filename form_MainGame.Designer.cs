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
            this.textBox_FirstNumberCustom_Settings = new System.Windows.Forms.TextBox();
            this.textBox_SecondNumberCustom_Settings = new System.Windows.Forms.TextBox();
            this.radioButton_Easy_Settings = new System.Windows.Forms.RadioButton();
            this.radioButton_Hard_Settings = new System.Windows.Forms.RadioButton();
            this.radioButton_Normal_Settings = new System.Windows.Forms.RadioButton();
            this.radioButton_Custom_Settings = new System.Windows.Forms.RadioButton();
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.checkedListBox_RoundShapes = new System.Windows.Forms.CheckedListBox();
            this.button_Save_Settings = new System.Windows.Forms.Button();
            this.groupBox_Settings.SuspendLayout();
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
            // textBox_FirstNumberCustom_Settings
            // 
            this.textBox_FirstNumberCustom_Settings.Location = new System.Drawing.Point(141, 135);
            this.textBox_FirstNumberCustom_Settings.Name = "textBox_FirstNumberCustom_Settings";
            this.textBox_FirstNumberCustom_Settings.Size = new System.Drawing.Size(39, 29);
            this.textBox_FirstNumberCustom_Settings.TabIndex = 7;
            // 
            // textBox_SecondNumberCustom_Settings
            // 
            this.textBox_SecondNumberCustom_Settings.Location = new System.Drawing.Point(197, 135);
            this.textBox_SecondNumberCustom_Settings.Name = "textBox_SecondNumberCustom_Settings";
            this.textBox_SecondNumberCustom_Settings.Size = new System.Drawing.Size(39, 29);
            this.textBox_SecondNumberCustom_Settings.TabIndex = 8;
            // 
            // radioButton_Easy_Settings
            // 
            this.radioButton_Easy_Settings.AutoSize = true;
            this.radioButton_Easy_Settings.Location = new System.Drawing.Point(39, 32);
            this.radioButton_Easy_Settings.Name = "radioButton_Easy_Settings";
            this.radioButton_Easy_Settings.Size = new System.Drawing.Size(69, 28);
            this.radioButton_Easy_Settings.TabIndex = 11;
            this.radioButton_Easy_Settings.TabStop = true;
            this.radioButton_Easy_Settings.Text = "Easy";
            this.radioButton_Easy_Settings.UseVisualStyleBackColor = true;
            // 
            // radioButton_Hard_Settings
            // 
            this.radioButton_Hard_Settings.AutoSize = true;
            this.radioButton_Hard_Settings.Location = new System.Drawing.Point(39, 101);
            this.radioButton_Hard_Settings.Name = "radioButton_Hard_Settings";
            this.radioButton_Hard_Settings.Size = new System.Drawing.Size(73, 28);
            this.radioButton_Hard_Settings.TabIndex = 12;
            this.radioButton_Hard_Settings.TabStop = true;
            this.radioButton_Hard_Settings.Text = "Hard";
            this.radioButton_Hard_Settings.UseVisualStyleBackColor = true;
            // 
            // radioButton_Normal_Settings
            // 
            this.radioButton_Normal_Settings.AutoSize = true;
            this.radioButton_Normal_Settings.Location = new System.Drawing.Point(39, 66);
            this.radioButton_Normal_Settings.Name = "radioButton_Normal_Settings";
            this.radioButton_Normal_Settings.Size = new System.Drawing.Size(95, 28);
            this.radioButton_Normal_Settings.TabIndex = 13;
            this.radioButton_Normal_Settings.TabStop = true;
            this.radioButton_Normal_Settings.Text = "Normal";
            this.radioButton_Normal_Settings.UseVisualStyleBackColor = true;
            // 
            // radioButton_Custom_Settings
            // 
            this.radioButton_Custom_Settings.AutoSize = true;
            this.radioButton_Custom_Settings.Location = new System.Drawing.Point(39, 135);
            this.radioButton_Custom_Settings.Name = "radioButton_Custom_Settings";
            this.radioButton_Custom_Settings.Size = new System.Drawing.Size(96, 28);
            this.radioButton_Custom_Settings.TabIndex = 14;
            this.radioButton_Custom_Settings.TabStop = true;
            this.radioButton_Custom_Settings.Text = "Custom";
            this.radioButton_Custom_Settings.UseVisualStyleBackColor = true;
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.button_Save_Settings);
            this.groupBox_Settings.Controls.Add(this.checkedListBox_RoundShapes);
            this.groupBox_Settings.Controls.Add(this.radioButton_Normal_Settings);
            this.groupBox_Settings.Controls.Add(this.radioButton_Custom_Settings);
            this.groupBox_Settings.Controls.Add(this.textBox_FirstNumberCustom_Settings);
            this.groupBox_Settings.Controls.Add(this.textBox_SecondNumberCustom_Settings);
            this.groupBox_Settings.Controls.Add(this.radioButton_Hard_Settings);
            this.groupBox_Settings.Controls.Add(this.radioButton_Easy_Settings);
            this.groupBox_Settings.Location = new System.Drawing.Point(290, 83);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Size = new System.Drawing.Size(612, 274);
            this.groupBox_Settings.TabIndex = 15;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
            this.groupBox_Settings.Visible = false;
            // 
            // checkedListBox_RoundShapes
            // 
            this.checkedListBox_RoundShapes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListBox_RoundShapes.FormattingEnabled = true;
            this.checkedListBox_RoundShapes.Items.AddRange(new object[] {
            "Triangle",
            "Square",
            "Circle",
            "Rectangle",
            "Cube",
            "Octagon",
            "Oval",
            "Star",
            "Diamond"});
            this.checkedListBox_RoundShapes.Location = new System.Drawing.Point(405, 32);
            this.checkedListBox_RoundShapes.Name = "checkedListBox_RoundShapes";
            this.checkedListBox_RoundShapes.Size = new System.Drawing.Size(153, 148);
            this.checkedListBox_RoundShapes.TabIndex = 15;
            // 
            // button_Save_Settings
            // 
            this.button_Save_Settings.Location = new System.Drawing.Point(238, 216);
            this.button_Save_Settings.Name = "button_Save_Settings";
            this.button_Save_Settings.Size = new System.Drawing.Size(110, 41);
            this.button_Save_Settings.TabIndex = 16;
            this.button_Save_Settings.Text = "Save";
            this.button_Save_Settings.UseVisualStyleBackColor = true;
            this.button_Save_Settings.Click += new System.EventHandler(this.button_Save_Settings_Click);
            // 
            // form_MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.groupBox_Settings);
            this.Controls.Add(this.button_Settings);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_MainGame";
            this.Text = "Main Game";
            this.groupBox_Settings.ResumeLayout(false);
            this.groupBox_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.TextBox textBox_FirstNumberCustom_Settings;
        private System.Windows.Forms.TextBox textBox_SecondNumberCustom_Settings;
        private System.Windows.Forms.RadioButton radioButton_Easy_Settings;
        private System.Windows.Forms.RadioButton radioButton_Hard_Settings;
        private System.Windows.Forms.RadioButton radioButton_Normal_Settings;
        private System.Windows.Forms.RadioButton radioButton_Custom_Settings;
        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.CheckedListBox checkedListBox_RoundShapes;
        private System.Windows.Forms.Button button_Save_Settings;
    }
}
namespace WindowsFormsApp12345
{
    partial class Setting_password
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
            this.label1 = new System.Windows.Forms.Label();
            this.setting_password_authentic_text = new System.Windows.Forms.TextBox();
            this.setting_password_ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // setting_password_authentic_text
            // 
            this.setting_password_authentic_text.Location = new System.Drawing.Point(66, 94);
            this.setting_password_authentic_text.Multiline = true;
            this.setting_password_authentic_text.Name = "setting_password_authentic_text";
            this.setting_password_authentic_text.Size = new System.Drawing.Size(494, 25);
            this.setting_password_authentic_text.TabIndex = 1;
            // 
            // setting_password_ok_button
            // 
            this.setting_password_ok_button.Location = new System.Drawing.Point(364, 159);
            this.setting_password_ok_button.Name = "setting_password_ok_button";
            this.setting_password_ok_button.Size = new System.Drawing.Size(75, 23);
            this.setting_password_ok_button.TabIndex = 2;
            this.setting_password_ok_button.Text = "ok";
            this.setting_password_ok_button.UseVisualStyleBackColor = true;
            this.setting_password_ok_button.Click += new System.EventHandler(this.setting_password_ok_button_Click);
            // 
            // Setting_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 249);
            this.Controls.Add(this.setting_password_ok_button);
            this.Controls.Add(this.setting_password_authentic_text);
            this.Controls.Add(this.label1);
            this.Name = "Setting_password";
            this.Text = "Settingpassword";
            this.Load += new System.EventHandler(this.Setting_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox setting_password_authentic_text;
        private System.Windows.Forms.Button setting_password_ok_button;
    }
}
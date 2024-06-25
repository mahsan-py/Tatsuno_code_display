namespace WindowsFormsApp12345
{
    partial class SerialportWriteConfigurePage
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
            this.okay_port_status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okay_port_status
            // 
            this.okay_port_status.Location = new System.Drawing.Point(320, 351);
            this.okay_port_status.Name = "okay_port_status";
            this.okay_port_status.Size = new System.Drawing.Size(95, 37);
            this.okay_port_status.TabIndex = 0;
            this.okay_port_status.Text = "Okay";
            this.okay_port_status.UseVisualStyleBackColor = true;
            this.okay_port_status.Click += new System.EventHandler(this.okay_port_status_Click);
            // 
            // SerialportWriteConfigurePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okay_port_status);
            this.Name = "SerialportWriteConfigurePage";
            this.Text = "SerialportWriteConfigurePage";
            this.Load += new System.EventHandler(this.SerialportWriteConfigurePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okay_port_status;
    }
}
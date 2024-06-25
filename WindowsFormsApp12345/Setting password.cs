using System;
using System.Windows.Forms;

namespace WindowsFormsApp12345
{
    public partial class Setting_password : Form
    {
        public static Setting_password instance1;
        public Setting_password()
        {
            instance1 = this;
            InitializeComponent();
           
        }

        private void setting_password_ok_button_Click(object sender, EventArgs e)
        {
            if (setting_password_authentic_text.Text == Setting.setting_safe_password_text)
            {
                Setting settingform = new Setting();
                settingform.Show();
                this.Close();
            }
            else if (setting_password_authentic_text.Text == Setting.dsply)
            {
                SerialportWriteConfigurePage DISPLAY = new SerialportWriteConfigurePage();
                DISPLAY.Show();
                this.Close();
            }
            else if (setting_password_authentic_text.Text == Setting.pricechange)
            {
                NozzelActive nozzelActive = new NozzelActive();
                nozzelActive.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invlid Password!");
                setting_password_authentic_text.Text = "";
            }
        }

        private void Setting_password_Load(object sender, EventArgs e)
        {

        }
    }
}

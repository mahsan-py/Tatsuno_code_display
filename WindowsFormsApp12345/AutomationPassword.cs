using System;
using System.Windows.Forms;

namespace WindowsFormsApp12345
{
    public partial class AutomationPassword : Form
    {
        public static AutomationPassword autopswd;

        public AutomationPassword()
        {
            autopswd = this;
            InitializeComponent();
        }

        private void AutomationPassword_Load(object sender, EventArgs e)
        {

        }

        private void automationpagepasswordokbutton_Click(object sender, EventArgs e)
        {
            if (automationpagetext.Text == Setting.automation_safe_password_text)
            {
                Automation form = new Automation();
                form.Show();

                this.Close();
            }
            else
            {
                automationpagetext.Text = "";
                MessageBox.Show("incorrect password! ");

            }


        }
    }
}

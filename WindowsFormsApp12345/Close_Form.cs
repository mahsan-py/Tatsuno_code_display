using System;
using System.Windows.Forms;

namespace WindowsFormsApp12345
{
    public partial class Close_Form : Form
    {


        public Close_Form()
        {
            InitializeComponent();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {


            if (Closetext.Text == Setting.application_close_password_text)
            {
               for (int i = 0; i<6; i++)
                {
                    Form1.Port[i].Close();
                }


                Environment.Exit(0);
                //Application.Exit();
            }
            else
            {
                Closetext.Text = "";
                MessageBox.Show("Password Incorrect !!");
            }






        }

        private void Close_Form_Load(object sender, EventArgs e)
        {

        }
    }
}

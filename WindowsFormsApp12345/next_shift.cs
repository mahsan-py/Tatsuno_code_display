using System;
using System.Windows.Forms;

namespace WindowsFormsApp12345
{
    public partial class next_shift : Form
    {
        public static bool confirm_data = false;

        public next_shift()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Setting.shift_safe_password_text)
            {
                Form1.shift_id = Form1.shift_id + 1;
                confirm_data = true;
                Form1.liter1 = 0; Form1.liter5 = 0; Form1.liter9 = 0;
                Form1.liter2 = 0; Form1.liter6 = 0; Form1.liter10 = 0;
                Form1.liter3 = 0; Form1.liter7 = 0;
                Form1.liter4 = 0; Form1.liter8 = 0;

                this.Close();

            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Wrong Password!");
            }
        }

        private void next_shift_Load(object sender, EventArgs e)
        {


        }
    }
}

using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{
    public partial class Tank_Page : Form
    {
        MySqlConnection connect;
        bool check_status = false;
        MySqlCommand tank_reader_command;
        public Tank_Page()
        {


            InitializeComponent();




        }

        private void Tank_Page_Load(object sender, EventArgs e)
        {


            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            string tank_losing = "SELECT * FROM `tank_losing_db`Where ID=4;";

            using (connect = new MySqlConnection(connectionString)) ;
            {

                tank_reader_command = new MySqlCommand(tank_losing, connect);
                connect.Open();

            }


            using (MySqlDataReader reader1 = tank_reader_command.ExecuteReader())
            {
                if (reader1.Read())
                {
                    textBox1.Text = reader1["Super_Tank"].ToString();
                    textBox2.Text = reader1["Diesel_Tank"].ToString();
                    textBox3.Text = reader1["Input_Super_Tank"].ToString();
                    textBox4.Text = reader1["Input_Diesel_Tank"].ToString();
                }

            }






        }

        private void ok_tank_value_Click(object sender, EventArgs e)
        {
            MySqlConnection Nozzel_connection = new MySqlConnection(Appsetting.ConnectionString());

            Nozzel_connection.Open();

            MySqlCommand cmd;
            cmd = Nozzel_connection.CreateCommand();
            cmd.CommandText = "UPDATE tank_losing_db SET Super_Tank = @super,Diesel_Tank = @diesel,Input_Super_Tank = @in_super,Input_Diesel_Tank = @in_diesel Where ID=4;";
            if (check_status == false)
            {
                cmd.Parameters.AddWithValue("@super", textBox1.Text);
                cmd.Parameters.AddWithValue("@diesel", textBox2.Text);
                cmd.Parameters.AddWithValue("@in_super", textBox3.Text);
                cmd.Parameters.AddWithValue("@in_diesel", textBox4.Text);
            }
            else
            {
                float.TryParse(textBox1.Text, out float value1);
                float.TryParse(textBox2.Text, out float value2);
                float.TryParse(textBox3.Text, out float value3);
                float.TryParse(textBox4.Text, out float value4);
                value1 += value3;
                value2 += value4;

                cmd.Parameters.AddWithValue("@super", value1.ToString());
                cmd.Parameters.AddWithValue("@diesel", value2.ToString());
                cmd.Parameters.AddWithValue("@in_super", textBox3.Text);
                cmd.Parameters.AddWithValue("@in_diesel", textBox4.Text);


            }

            cmd.ExecuteNonQuery();
            this.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check_status = true;
            float.TryParse(textBox1.Text, out float value1);
            float.TryParse(textBox2.Text, out float value2);
            float.TryParse(textBox3.Text, out float value3);
            float.TryParse(textBox4.Text, out float value4);

        }
    }
}

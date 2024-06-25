using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{
    public partial class CategoryAdd : Form
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }

        private void db_show_data_Click(object sender, EventArgs e)
        {
         
         
            string connect = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            string query = "SELECT * FROM product_category";

            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                MySqlCommand command1 = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "nozzel1");
                dataGridView1.DataSource = ds.Tables["nozzel1"];

            }
            
        }
        public void insertdataintodb()
        {
            MySqlConnection connectiondb = new MySqlConnection(Appsetting.ConnectionString());
            connectiondb.Open();
            MySqlCommand cmd;
            cmd = connectiondb.CreateCommand();
            cmd.CommandText = "INSERT INTO `product_category`( `category_name`, `category_rate`, `category_qty`) VALUES" +
                " (@name,@rate,@qty)";
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@qty", textBox2.Text);
            cmd.Parameters.AddWithValue("@rate", textBox3.Text);
            cmd.ExecuteNonQuery();
            connectiondb.Close();


        }

        private void db_add_data_Click(object sender, EventArgs e)
        {
            insertdataintodb();
        }
    }
}

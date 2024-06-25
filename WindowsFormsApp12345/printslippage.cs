using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{
    public partial class printslippage : Form
    {
        public static string  noz_ctg;
        int slip_id;
        public static int slip_id_no_db;
       public static string cashprint,rateprint,literprint,nozzelprint;

        public printslippage(string cash, string rate, string liter,string nozzel_no)
        {
            InitializeComponent();
            mannualslip.dataGridView1.Rows.Clear();
            mannualslip.dataGridView1.Columns.Clear();
            cashprint = cash;
            rateprint = rate;
            literprint = liter;
            nozzelprint = nozzel_no;
            mannualslip.create_data_grid();
            mannualslip.add_data_grid(nozzel_no, rate, liter, cash);
            

        }

        private void printslippage_Load(object sender, EventArgs e)
        {

        }

        private void Data_add_grid_view_Click(object sender, EventArgs e)
        {
            mannualslip form = new mannualslip(textBox1.Text);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             slip_id=last_id_get(nozzelprint);

            string vehicle_no = textBox1.Text;
            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "UPDATE nozzel1 SET Vehicle_no = @newSection WHERE Slip_Id = @slipid;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@newSection", vehicle_no);
                cmd.Parameters.AddWithValue("@slipid", slip_id);

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            PrintDocument printDocument = new PrintDocument();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            printDocument.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            printDocument.Print();

            this.Close();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            mannualslip.print_data_gridview(e , nozzelprint, textBox1.Text, slip_id.ToString());
            //cashprint, rateprint, literprint,
            mannualslip.add_data_grid(noz_ctg, rateprint, literprint, cashprint);

            
        }



            public static int  last_id_get(string noz_id)
        {
            
            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            string query = "SELECT Slip_ID,Nozzel_Category FROM nozzel1 WHERE Nozzel_ID=@nozzel_id ORDER BY Slip_ID DESC LIMIT 1;"; // Assuming 'id' is the primary key column

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@nozzel_id",noz_id);

            try
            {
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Assuming you have columns named 'column1', 'column2', 'column3', etc.
                        slip_id_no_db = reader.GetInt16("Slip_ID");
                        noz_ctg = reader.GetString("Nozzel_Category");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return slip_id_no_db;
        }
        






    }
}

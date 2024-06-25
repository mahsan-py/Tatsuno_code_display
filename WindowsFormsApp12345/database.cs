using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{
    public partial class database : Form
    {
        MySqlDataAdapter pageadapter;
        DataSet pageds;

        string[] pricequery = new string[17];
        string[] literquery = new string[17];
        MySqlCommand[] pricecommand = new MySqlCommand[17];
        MySqlCommand[] litercommand = new MySqlCommand[17];

        MySqlDataReader[] pricereader = new MySqlDataReader[17];
        MySqlDataReader[] literreader = new MySqlDataReader[17];
        float[] price = new float[17];
        float[] liter = new float[17];
        string[] noz_category = new string[17];

        float diesel_liter = 0;
        float diesel_cash = 0;
        float hobc_liter = 0;
        float hobc_cash = 0;
        float total_database_cash = 0;
        float total_database_liter = 0;
        float super_liter = 0;
        float super_cash = 0;
        long scollVal = 0;
        string slip_vehicle, slip_price, slip_shift_id, slip_liter, slip_fuel_rate, slip_nozzel_id, Slip_ID_slip;

        string slip_datetime;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void left_pagination()
        {
            string xc = shift_data.Text;
            MySqlConnection connection = new MySqlConnection("Server=localhost;" +
               "Database=munir_filling;" +
               "Uid=root;" +
               "pwd=");
            string query = "SELECT * FROM nozzel1 where Shift_ID like '%" + xc + "%' ";
            connection.Open();

            pageadapter = new MySqlDataAdapter(query, connection);
            pageds = new DataSet();



            scollVal = scollVal - 50;

            if (scollVal <= 0)
            {
                scollVal = 0;
            }
            pageds.Clear();
            pageadapter.Fill(pageds, ((int)scollVal), 50, "nozzel1");
            dataGridView1.DataSource = pageds.Tables["nozzel1"];
            connection.Close();
        }
        private void right_pagination()
        {
            string xc = shift_data.Text;
            MySqlConnection connection = new MySqlConnection("Server=localhost;" +
               "Database=munir_filling;" +
               "Uid=root;" +
               "pwd=");
            string query = "SELECT * FROM nozzel1 where Shift_ID like '%" + xc + "%' ";

            connection.Open();




            pageadapter = new MySqlDataAdapter(query, connection);
            pageds = new DataSet();



            scollVal = scollVal + 50;
            label16.Text = scollVal.ToString();
            if (scollVal >= 50)
            {



                //scollVal = 50;
                pageds.Clear();
                pageadapter.Fill(pageds, ((int)scollVal), 50, "nozzel1");
                dataGridView1.DataSource = pageds.Tables["nozzel1"];
            }
            //pageds.Clear();
            //pageadapter.Fill(pageds, scollVal, 50, "nozzel1");

            connection.Close();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            left_pagination();
        }


















        private void btnRight_Click(object sender, EventArgs e)


        {

            right_pagination();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void slip_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        float price1, price2, price3, price4, price5, price6, price7, price8, price9, price10;
        float n1_liter, n2_liter, n3_liter, n4_liter, n5_liter, n6_liter, n7_liter, n8_liter, n9_liter, n10_liter;

        private void date_search_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter;
            DataTable dataTable;

            connection = new MySqlConnection(Appsetting.ConnectionString());

            // Initialize DataTable
            dataTable = new DataTable();

            // Initialize and configure DataGridView
            dataGridView1.DataSource = dataTable;

            // Create MySqlCommand
            command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM nozzel1 WHERE Date_Time >= @startDate AND Date_Time <=@endDate  ORDER BY Slip_ID ASC LIMIT 50;SELECT LAST_INSERT_ID()";



            connection.Open();

            label16.Text = dateTimePicker1.Value.ToString();

            // Add parameters
            command.Parameters.AddWithValue("@startDate", dateTimePicker1.Value.ToString());
            command.Parameters.AddWithValue("@endDate", dateTimePicker2.Value.ToString());

            // Initialize MySqlDataAdapter
            adapter = new MySqlDataAdapter(command);



            scollVal = Convert.ToInt64(command.ExecuteScalar()); ;


            //if (result != null && result != DBNull.Value)
            //{
            //scollVal= Convert.ToInt64(result);
            //}
            //else
            //{
            //    throw new InvalidOperationException("No Slip_ID found.");
            //}






            ///
            //pageds = new DataSet();

            ////adapter.Fill(ds, "nozzel1");

            //adapter.Fill(pageds, ((int)scollVal), 50, "nozzel1");

            //dataGridView1.DataSource = pageds.Tables["nozzel1"];




            //// Fill the DataTable
            adapter.Fill(dataTable);

            // scollVal = GetLastInsertedId(connection);
            label16.Text = scollVal.ToString();
            connection.Close();


        }

        private void DateTimeShiftReport_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            double Liter_Super = 0, Price_Super = 0;
            double Liter_Diesel = 0, Price_Diesel = 0;
            double Liter_Hobc = 0, Price_Hobc = 0;

            string[] categories = { "Super", "Diesel", "Hobc" };

            connection = new MySqlConnection(Appsetting.ConnectionString());
            connection.Open();



            foreach (var category in categories)
            {
                string query = "SELECT SUM(Liter) AS total_liter, SUM(Price) AS total_price,Nozzel_Category FROM nozzel1 WHERE" +
                " Date_Time >= @startDate AND Date_Time <= @endDate AND Nozzel_Category = @category";


                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startDate", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@endDate", dateTimePicker2.Value);
                    command.Parameters.AddWithValue("@category", category);


                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            if (category == "Super")
                            {
                                Liter_Super = Convert.ToDouble(reader["total_liter"]);
                                Price_Super = Convert.ToDouble(reader["total_price"]);

                            }
                            else if (category == "Diesel")
                            {
                                Liter_Diesel = Convert.ToDouble(reader["total_liter"]);
                                Price_Diesel = Convert.ToDouble(reader["total_price"]);

                            }
                            else if (category == "Hobc")
                            {
                                Liter_Hobc = Convert.ToDouble(reader["total_liter"]);
                                Price_Hobc = Convert.ToDouble(reader["total_price"]);

                            }
                        }
                    }
                }





            }



            label7.Text = Liter_Super.ToString("F2");
            label6.Text = Price_Super.ToString("F2");

            label9.Text = Liter_Diesel.ToString("F2");
            label8.Text = Price_Diesel.ToString("F2");

            label11.Text = Liter_Hobc.ToString("F2");
            label10.Text = Price_Hobc.ToString("F2");

            label13.Text = (Liter_Super + Liter_Hobc + Liter_Diesel).ToString("F2");
            label12.Text = (Price_Diesel + Price_Super + Price_Hobc).ToString("F2");






        }


        private void paginationsetup_Click(object sender, EventArgs e)
        {
            scollVal = int.Parse(paginationvalue.Text);
        }












        static long GetLastInsertedId(MySqlConnection connection)
        {
            string query = "SELECT MAX(Slip_ID) FROM nozzel1";

            using (var command = new MySqlCommand(query, connection))
            {
                // ExecuteScalar is used to retrieve a single value (in this case, the maximum ID)
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt64(result);
                }
                else
                {
                    throw new InvalidOperationException("No records found in the table.");
                }
            }
        }







        public database()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            label14.Text = now.ToString();
            //label14.Text = DateTime.UtcNow.ToString("dd'-'MM'-'yyyy'  'HH':'mm':'ss");
        }

        private void database_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;" +
               "Database=munir_filling;" +
               "Uid=root;" +
               "pwd=");
                connection.Open();
                pageadapter = new MySqlDataAdapter("SELECT * FROM nozzel1", connection);



                pageds = new DataSet();

                //adapter.Fill(ds, "nozzel1");
                pageadapter.Fill(pageds, ((int)scollVal), 50, "nozzel1");
                dataGridView1.DataSource = pageds.Tables["nozzel1"];

                connection.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //database_super_ltr.Text = Form1.super_total_ltr;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void serach_database_vehicle(string data_string)
        {
            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            string query = "SELECT * FROM `nozzel1` WHERE Vehicle_no like '%" + data_string + "%' ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "nozzel1");
            dataGridView1.DataSource = ds.Tables["nozzel1"];
            vehicle_data.Text = "";
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            string search_data;




            string nozzel_checked = comboBox1.Text;

            string vehicle_search_no = vehicle_data.Text;
            string shift_search_id = shift_data.Text;
            string slip_search_id = slip_data.Text;



            if (string.IsNullOrWhiteSpace(vehicle_search_no))
            {


            }
            else
            {
                search_data = vehicle_search_no;

                serach_database_vehicle(search_data);
            }




            if (string.IsNullOrWhiteSpace(shift_search_id))
            {

            }
            else
            {
                int.TryParse(shift_search_id, out int number);
                serach_database_shift(number);
            }




            if (string.IsNullOrWhiteSpace(nozzel_checked))
            {

            }
            else
            {
                serach_database_nozzel(nozzel_checked);
            }




            if (string.IsNullOrWhiteSpace(slip_search_id))
            {

            }
            else
            {
                int.TryParse(slip_search_id, out int number);
                serach_database_slip(number);
            }

        }

        private void serach_database_shift(int data_string)
        {
            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            //string query = "SELECT * FROM `nozzel1` WHERE Shift_ID like '%" + data_string + "%' ";
            string query = "SELECT * FROM `nozzel1` WHERE Shift_ID = '%" + data_string + "%'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "nozzel1");
            dataGridView1.DataSource = ds.Tables["nozzel1"];



            shift_data.Text = "";

        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);

            // Load your logo image

            Image logo = Image.FromFile(Form1.logopath);
            // Draw the logo
            int logoWidth = 50; // Adjust the width as needed
            int logoHeight = (int)(((float)logoWidth / (float)logo.Width) * logo.Height); // Maintain aspect ratio
            graphics.DrawImage(logo, 110, -2, logoWidth, logoHeight);

            // Draw other receipt content
            //graphics.DrawString("Receipt", font, Brushes.Black, 100, 100 + logoHeight + 10);
            // Add more drawing/printing code for the receipt content

            font.Dispose();
            logo.Dispose();





            e.Graphics.DrawString("Al_Munir Petroleum", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 70));
            e.Graphics.DrawString("Kachari Road SWL", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(35, 90));
            e.Graphics.DrawString("0322-2229301 ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 120));

            //DateTime now = DateTime.Now;

            //now.ToString()


            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 150));





            //e.Graphics.DrawString("Date       : " + DateTime.Now.ToString("dd'-'MM'-'yyyy'  'HH':'mm':'ss"), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 150));
            e.Graphics.DrawString("Date       : " + slip_datetime, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 170));
            e.Graphics.DrawString("Slip No    : " + Slip_ID_slip, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 190));

            e.Graphics.DrawString("Nozzel No  : " + slip_nozzel_id, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 210));
            e.Graphics.DrawString("Vehicle No : " + slip_vehicle, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 230));
            e.Graphics.DrawString("Liter Qty    : " + slip_liter, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString("Rate          : " + slip_fuel_rate, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 270));
            e.Graphics.DrawString("Total cash  : " + slip_price, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 290));
            e.Graphics.DrawString("============================================================================================", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, 310));
            e.Graphics.DrawString("Powerd by : Power Soft 0300-9698745", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 340));

        }

        private void serach_database_nozzel(string data_string)
        {
            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            string query = "SELECT* FROM `nozzel1` WHERE `Nozzel_ID` like '%" + data_string + "%' ORDER BY `Slip_ID` DESC; ";



            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "nozzel1");
            dataGridView1.DataSource = ds.Tables["nozzel1"];
        }
        private void serach_database_slip(int data_string)

        {
            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";

            string query = "SELECT * FROM `nozzel1` WHERE Slip_ID like '%" + data_string + "%' ";


            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);





            DataSet ds = new DataSet();
            adapter.Fill(ds, "nozzel1");
            dataGridView1.DataSource = ds.Tables["nozzel1"];
            slip_data.Text = "";


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void print_shift_report_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";

            for (int i = 1; i < 17; i++)
            {
                pricequery[i] = "SELECT SUM(Price), Nozzel_ID,Nozzel_Category FROM nozzel1 where Shift_ID=@cashid AND Nozzel_ID=" + i + " GROUP BY Nozzel_ID";

                literquery[i] = "SELECT SUM(Liter), Nozzel_ID,Nozzel_Category FROM nozzel1 where Shift_ID=@id AND Nozzel_ID=" + i + " GROUP BY Nozzel_ID";
            }



            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                for (int j = 1; j < 17; j++)
                {
                    litercommand[j] = new MySqlCommand(literquery[j], connection);
                    pricecommand[j] = new MySqlCommand(pricequery[j], connection);

                    if (shift_data.Text == string.Empty)
                    {
                        MessageBox.Show("Shift_id not available");
                        break;
                    }

                    litercommand[j].Parameters.AddWithValue("@id", shift_data.Text);
                    pricecommand[j].Parameters.AddWithValue("@cashid", shift_data.Text);



                    connection.Close();
                    connection.Open();



                    //cashReader


                    using (pricereader[j] = pricecommand[j].ExecuteReader())
                    {
                        if (pricereader[j].Read())
                        {

                            price[j] = pricereader[j].GetFloat("SUM(Price)");

                            //Form1.noz1_catgory = reader[i]["Nozzel_Category"].ToString();
                            noz_category[j] = pricereader[j]["Nozzel_Category"].ToString();
                        }

                    }

                    using (literreader[j] = litercommand[j].ExecuteReader())
                    {
                        if (literreader[j].Read())
                        {

                            liter[j] = literreader[j].GetFloat("SUM(Liter)");
                        }

                    }










                    if (noz_category[j] == "Super") { database_sum_nozzzel_super(price[j], liter[j]); }
                    else if (noz_category[j] == "Diesel") { database_sum_nozzzel_diesel(price[j], liter[j]); }
                    else if (noz_category[j] == "Hobc") { database_sum_nozzzel_hobc(price[j], liter[j]); }






                }
                connection.Close();


            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);

            // Load your logo image
            Image logo = Image.FromFile(Form1.logopath);
            // Draw the logo
            int logoWidth = 50; // Adjust the width as needed
            int logoHeight = (int)(((float)logoWidth / (float)logo.Width) * logo.Height); // Maintain aspect ratio
            graphics.DrawImage(logo, 110, -2, logoWidth, logoHeight);

            // Draw other receipt content
            //graphics.DrawString("Receipt", font, Brushes.Black, 100, 100 + logoHeight + 10);
            // Add more drawing/printing code for the receipt content

            font.Dispose();
            logo.Dispose();



            //e.Graphics.DrawString("Al Munir Petroleum  ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 70));
            //e.Graphics.DrawString("Kachahry  Road Sahiwal  ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(35, 90));
            //e.Graphics.DrawString("0322-2229301 ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 120));

            e.Graphics.DrawString("Al_Munir Petroleum", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 70));
            e.Graphics.DrawString("Kachari Road SWL", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(35, 90));
            e.Graphics.DrawString("0322-2229301", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 120));



            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 130));





            e.Graphics.DrawString("Date       : " + DateTime.Now.ToString("dd'-'MM'-'yyyy'  'HH':'mm':'ss"), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 150));

            e.Graphics.DrawString("Shift_id    : " + Form1.shift_id, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 170));

            e.Graphics.DrawString("Nozzel No  :     1", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 190));
            e.Graphics.DrawString("Total_liter  : " + n1_liter.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 210));
            e.Graphics.DrawString("Total_Cash   : " + price1.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 230));

            e.Graphics.DrawString("Nozzel No  : 2", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString("Total_Liter  : " + n2_liter.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 270));
            e.Graphics.DrawString("Total_Cash   : " + price2.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 290));

            e.Graphics.DrawString("Nozzel No  : 3", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 310));
            e.Graphics.DrawString("Total_Liter  : " + n3_liter.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 330));
            e.Graphics.DrawString("Total_Cash   : " + price3.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 350));

            e.Graphics.DrawString("Nozzel No  : 4", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 370));
            e.Graphics.DrawString("Total_Liter  : " + n4_liter.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 390));
            e.Graphics.DrawString("Total_Cash   : " + price4.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 410));

            e.Graphics.DrawString("Nozzel No  : 5", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 430));
            e.Graphics.DrawString("Total_Liter  : " + n5_liter.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 450));
            e.Graphics.DrawString("Total_Cash   : " + price5.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 470));

            e.Graphics.DrawString("Nozzel No  : 6", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 490));
            e.Graphics.DrawString("Total_Liter  : " + n6_liter.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 510));
            e.Graphics.DrawString("Total_Cash   : " + price6.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 530));

            e.Graphics.DrawString("Nozzel No  : 7", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 550));
            e.Graphics.DrawString("Total_Liter  : " + n7_liter.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 570));
            e.Graphics.DrawString("Total_Cash   : " + price7.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 590));

            e.Graphics.DrawString("Nozzel No  : 8", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 610));
            e.Graphics.DrawString("Total_liter  : " + n8_liter.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 630));
            e.Graphics.DrawString("Total_Cash   :" + price8.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 650));

            e.Graphics.DrawString("Nozzel No  : 9", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 670));
            e.Graphics.DrawString("Total_Liter  :" + n9_liter.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 690));
            e.Graphics.DrawString("Total_Cash   :" + price9.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 710));

            e.Graphics.DrawString("Nozzel No  : 10", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 730));
            e.Graphics.DrawString("Total_Liter  : " + n10_liter.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 750));
            e.Graphics.DrawString("Total_Cash   : " + price10.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 770));

            e.Graphics.DrawString("Super Sale", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 790));
            e.Graphics.DrawString("Total_Liter  : " + label7.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 810));
            e.Graphics.DrawString("Total_Cash   : " + label6.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 830));

            e.Graphics.DrawString("Diesele SALE", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 850));
            e.Graphics.DrawString("Total_Liter  : " + label9.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 870));
            e.Graphics.DrawString("Total_Cash   : " + label8.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 890));

            e.Graphics.DrawString("Hobc Sale", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 910));
            e.Graphics.DrawString("Total_Liter  : " + label11.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 930));
            e.Graphics.DrawString("Total_Cash   : " + label10.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 950));


            e.Graphics.DrawString("Total_Amount", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 970));
            e.Graphics.DrawString("Total_Liter  : " + label13.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 990));
            e.Graphics.DrawString("Total_Cash  : " + label12.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 1010));




            e.Graphics.DrawString("============================================================================================", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, 1040));
            e.Graphics.DrawString("Powerd by : Power Soft 0300-9698745", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 1070));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            string query = "Select *From `nozzel1`WHERE Slip_ID=@id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", slip_data.Text);

                connection.Open();

                using (MySqlDataReader reader1 = command.ExecuteReader())
                {
                    if (reader1.Read())
                    {
                        slip_shift_id = reader1["Shift_ID"].ToString();
                        slip_vehicle = reader1["Vehicle_no"].ToString();
                        slip_price = reader1["Price"].ToString();
                        slip_liter = reader1["liter"].ToString();
                        Slip_ID_slip = reader1["Slip_ID"].ToString();
                        slip_nozzel_id = reader1["Nozzel_ID"].ToString();
                        slip_datetime = reader1["Date_Time"].ToString();
                        slip_fuel_rate = reader1["Rate"].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                    }
                }
                connection.Close();
            }

            PrintDocument printDocument2 = new PrintDocument();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 800);
            printDocument2.PrintPage += new PrintPageEventHandler(this.printDocument2_PrintPage);
            printDocument2.Print();




        }

        private void database_sum_nozzzel_super(float cash, float liter)
        {

            super_cash += cash;
            super_liter += liter;
            label6.Text = super_cash.ToString();
            label7.Text = super_liter.ToString();
            total_database(cash, liter);

        }
        private void database_sum_nozzzel_diesel(float cash, float liter)
        {


            diesel_cash += cash;
            diesel_liter += liter;
            label8.Text = diesel_cash.ToString();
            label9.Text = diesel_liter.ToString();

            total_database(cash, liter);

        }
        private void database_sum_nozzzel_hobc(float cash, float liter)
        {


            hobc_cash += cash;
            hobc_liter += liter;
            label10.Text = hobc_cash.ToString();
            label11.Text = hobc_liter.ToString();

            total_database(cash, liter);
        }

        private void total_database(float tc, float tl)
        {

            total_database_liter += tl;
            total_database_cash += tc;
            label12.Text = total_database_cash.ToString();
            label13.Text = total_database_liter.ToString();



        }

        /// <summary>
        ///  Select last Row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            string Query = "select *from nozzel1 ORDER BY Slip_ID DESC LIMIT 10;";
            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(Query, connection);



            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "nozzel1");
            dataGridView1.DataSource = ds.Tables["nozzel1"];


            connection.Open();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Assuming you have columns named 'column1', 'column2', 'column3', etc.

                    scollVal = (int)reader.GetInt64("Slip_ID");

                    label16.Text = scollVal.ToString();

                }
            }






            connection.Close();









        }

        private void Shift_slip_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            printDocument1.Print();
        }

    }

}

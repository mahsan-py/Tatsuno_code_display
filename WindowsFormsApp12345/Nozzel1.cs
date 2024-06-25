using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{

    public partial class Nozzel1 : Form
    {
        Graphics ev;
        Graphics graphics;
        public static string vehicle_no_1 = "0";
        Image logo = Image.FromFile(Form1.logopath);
        public static int slip_id;
        string nozzel_id_slip = "1";
        //bool start = true;
        public Nozzel1()
        {
            InitializeComponent();
        }

        private void Nozzel1_Load(object sender, EventArgs e)
        {




            vehicle_no_1 = textBox1.Text;

            //Thread print_noz1 = new Thread(print_data_noz1);
            ////print_noz1.Start();
            print_data_noz1();


        }

        private void print_data_noz1()
        {


            if (Form1.re == "1")
            {

                textBox1.Invoke(new MethodInvoker(
                       delegate
                       {
                           textBox1.Text = Form1.arduino_data[1];
                       }
                     ));


                PrintDocument printDocument = new PrintDocument();
                //printPreviewDialog1.Document = printDocument1;
                printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

                printDocument.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);
                printDocument.Print();
                Form1.re = "0";
                Form1.arduino_data[0] = "0";
                this.Close();
            }
        }



















        private void button1_Click(object sender, EventArgs e)
        {
            //start = false;

            vehicle_no_1 = textBox1.Text;

            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            //MessageBox.Show("1");
            try
            {
                connection.Open();

                string query = "UPDATE nozzel1 SET Vehicle_no = @newSection WHERE Slip_Id = @studentId;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@newSection", vehicle_no_1);
                cmd.Parameters.AddWithValue("@studentId", slip_id);

                cmd.ExecuteNonQuery();
                //MessageBox.Show("database okay");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Err" +
                    "or: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //PrintDocument printDocument = new PrintDocument();
            //printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            //printDocument.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);
            //printDocument.Print();
            //printPreviewDialog1.Document = printDocument;

            //printPreviewDialog1.ShowDialog();
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

            this.Close();

        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //check_prog(e, Form1.cn1, Form1.rn1, Form1.ln1, textBox1.Text, nozzel_id_slip, slip_id);

            //vehicle_no_1 = textBox1.Text;

            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);

            // Load your logo image
            Image logo = Image.FromFile("C:\\Users\\HC\\Downloads\\Local Machine Fuel Pump Application\\euro image.jpg");


            // Draw the logo
            int logoWidth = 50; // Adjust the width as needed
            int logoHeight = (int)(((float)logoWidth / (float)logo.Width) * logo.Height); // Maintain aspect ratio
            graphics.DrawImage(logo, 110, -2, logoWidth, logoHeight);

            // Draw other receipt content
            //graphics.DrawString("Receipt", font, Brushes.Black, 100, 100 + logoHeight + 10);
            // Add more drawing/printing code for the receipt content

            font.Dispose();
            logo.Dispose();



            //e.Graphics.DrawString("Al  Petroleum  ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 70));
            //e.Graphics.DrawString("Kachahry  Road Sahiwal  ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(35, 90));
            //e.Graphics.DrawString("0322-2229301 ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 120));

            e.Graphics.DrawString("JANI Petroleum Service ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 70));
            e.Graphics.DrawString("198/GB Samundri Road Murid Wala", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(35, 90));
            e.Graphics.DrawString("0333-40224551  ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(80, 120));




            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 130));





            e.Graphics.DrawString("Date       : " + DateTime.Now.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 150));

            e.Graphics.DrawString("Slip No    : " + slip_id, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 170));

            e.Graphics.DrawString("Nozzel No  : 1", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 190));
            e.Graphics.DrawString("Vehicle No : " + textBox1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 210));
            e.Graphics.DrawString("Liter Qty    : " + textBox1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 230));
            e.Graphics.DrawString("Rate          : " + textBox1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString("Total cash  : " + textBox1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 270));
            e.Graphics.DrawString("============================================================================================", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, 290));
            e.Graphics.DrawString("Thanks For Visiting Us", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(55, 310));
            e.Graphics.DrawString("Powerd by : Power Soft 0300-9698745", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(30, 330));

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        public static void check_prog(PrintPageEventArgs e, string cash, string rate, string liter, string vehicle, string noz_slip, int slip)
        {
            //vehicle_no_1 = textBox1.Text;

            Graphics ev = e.Graphics;


            Font font = new Font("Arial", 10);

            // Load your logo image
            Image logo = Image.FromFile(Form1.logopath);

            // Draw the logo
            int logoWidth = 120; // Adjust the width as needed
            int logoHeight = (int)(((float)logoWidth / (float)logo.Width) * logo.Height); // Maintain aspect ratio
            ev.DrawImage(logo, 80, -2, logoWidth, logoHeight);


            // Draw other receipt content
            //graphics.DrawString("Receipt", font, Brushes.Black, 100, 100 + logoHeight + 10);
            // Add more drawing/printing code for the receipt content

            font.Dispose();
            logo.Dispose();



            //e.Graphics.DrawString("Al Munir Petroleum  ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 70));
            //e.Graphics.DrawString("Kachahry  Road Sahiwal  ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(35, 90));
            //e.Graphics.DrawString("0322-2229301 ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 120));

            ev.DrawString("Allied 1 Maraka Petroleum ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 70));
            ev.DrawString("25 KM Multan Road Lahore", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, 90));
            ev.DrawString("09242111100700  ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(80, 120));




            ev.DrawString("--------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 130));





            ev.DrawString("Date       : " + DateTime.Now.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 150));

            ev.DrawString("Slip No    : " + slip.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 170));

            ev.DrawString("Nozzel No  : " + noz_slip, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 190));
            ev.DrawString("Vehicle No : " + vehicle, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 210));
            ev.DrawString("Liter Qty    : " + liter, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 230));
            ev.DrawString("Rate          : " + rate, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 250));
            ev.DrawString("Total cash    : " + cash, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 270));
            ev.DrawString("============================================================================================", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, 290));
            ev.DrawString("Thanks For Visiting Us", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(55, 310));
            ev.DrawString("Powerd by : Power Soft 0300-9698745", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(30, 330));

        }

    }
}
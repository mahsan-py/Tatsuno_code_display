using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{
    public partial class Nozzel4 : Form
    {
        string nozzel_id_slip = "4";
        public static int slip_id;
        public static string vehicle_no_4 = "0";
        public Nozzel4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicle_no_4 = textBox1.Text;
            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "UPDATE nozzel1 SET Vehicle_no = @newSection WHERE Slip_Id = @studentId;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@newSection", vehicle_no_4);
                cmd.Parameters.AddWithValue("@studentId", slip_id);

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


            //printPreviewDialog1.Document = printDocument1;
            //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            //printPreviewDialog1.ShowDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            printDocument.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            printDocument.Print();
            //Form1.re = "0";
            //Form1.arduino_data[0] = "0";
            //start = true;


            this.Close();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Nozzel1.check_prog(e, Form1.cn4, Form1.rn4, Form1.ln4, textBox1.Text, nozzel_id_slip, slip_id);

            //Graphics graphics = e.Graphics;
            //Font font = new Font("Arial", 10);

            //// Load your logo image
            //Image logo = Image.FromFile("C:\\Users\\SC\\Documents\\Local Machine Fuel Pump Application\\euro image.jpg");

            //// Draw the logo
            //int logoWidth = 50; // Adjust the width as needed
            //int logoHeight = (int)(((float)logoWidth / (float)logo.Width) * logo.Height); // Maintain aspect ratio
            //graphics.DrawImage(logo, 110, -2, logoWidth, logoHeight);

            //// Draw other receipt content
            ////graphics.DrawString("Receipt", font, Brushes.Black, 100, 100 + logoHeight + 10);
            //// Add more drawing/printing code for the receipt content

            //font.Dispose();
            //logo.Dispose();



            //e.Graphics.DrawString("KALLU Petroleum Service ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 70));
            //e.Graphics.DrawString("198/EB Samundri Road Murid Wala", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(35, 90));
            //e.Graphics.DrawString("0333-4039998  ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(65, 120));





            //e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 130));





            //e.Graphics.DrawString("Date       : " + DateTime.Now.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 150));

            //e.Graphics.DrawString("Slip No    : " + slip_id, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 170));

            //e.Graphics.DrawString("Nozzel No  : 4", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 190));
            //e.Graphics.DrawString("Vehicle No : " + textBox1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 210));
            //e.Graphics.DrawString("Liter Qty    : " + Form1.ln4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 230));
            //e.Graphics.DrawString("Rate          : " + Form1.rn4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 250));
            //e.Graphics.DrawString("Total cash  : " + Form1.cn4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 270));
            //e.Graphics.DrawString("============================================================================================", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, 290));
            //e.Graphics.DrawString("Powerd by : Power Soft 0300-9698745", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 300));

        }

        private void Nozzel4_Load(object sender, EventArgs e)
        {
            vehicle_no_4 = textBox1.Text;

            print_data_noz1();

        }

        private void print_data_noz1()
        {

            if (Form1.re == "4")
            {

                textBox1.Invoke(new MethodInvoker(
                       delegate
                       {
                           textBox1.Text = Form1.arduino_data[1];
                       }
                     ));


                PrintDocument printDocument = new PrintDocument();
                //printPreviewDialog1.Document = printDocument1;
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

                printDocument.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
                printDocument.Print();
                Form1.re = "0"; textBox1.Text = "0";
                this.Close();

            }

            //Form1.arduino_data[1] = "0";
            //Form1.arduino_data[2] = "0";

        }
    }
}

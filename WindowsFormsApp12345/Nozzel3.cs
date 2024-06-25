using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{
    public partial class Nozzel3 : Form
    {
        string nozzel_id_slip = "3"; public static int slip_id;
        public static string vehicle_no_3 = "0";
        public Nozzel3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicle_no_3 = textBox1.Text;
            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "UPDATE nozzel1 SET Vehicle_no = @newSection WHERE Slip_Id = @studentId;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@newSection", vehicle_no_3);
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



            PrintDocument printDocument = new PrintDocument();

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            printDocument.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            printDocument.Print();

            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();

            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Nozzel1.check_prog(e, Form1.cn3, Form1.rn3, Form1.ln3, textBox1.Text, nozzel_id_slip, slip_id);
        }

        private void Nozzel3_Load(object sender, EventArgs e)
        {
            vehicle_no_3 = textBox1.Text;
            print_data_noz1();

        }

        private void print_data_noz1()
        {

            if (Form1.re == "3")
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

                printDocument.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
                printDocument.Print();
                Form1.re = "0"; textBox1.Text = "0";
                this.Close();
                //
                //Form1.arduino_data[0] = "0"; this.Close();
            }

            //Form1.arduino_data[1] = "0";
            //Form1.arduino_data[2] = "0";

        }
    }
}

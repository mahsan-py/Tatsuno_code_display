using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;

namespace WindowsFormsApp12345
{
    public partial class mannualslip : Form
    {
        public string nozzel_no, vehicle_no;
       int  slip_no;
       public static  DataGridView dataGridView1 = new DataGridView();
        public mannualslip(string veh_no)
        {
            InitializeComponent();
            vehicle_no = veh_no;
            this.FormClosing += new FormClosingEventHandler(mannualslip_FormClosing);
            dataGridView1.Columns.Add("Product", "Product");
            dataGridView1.Columns.Add("Rate", "Rate");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Price", "Price");

            // Set DataGridView properties
            dataGridView1.Width = 400; // Set the width of the DataGridView
            dataGridView1.Height = 300; // Set the height of the DataGridView
            dataGridView1.ReadOnly = true; // Set it to read-only if you don't want editing

            // Calculate the position to align to the middle right of the form
            int x = 440 ; // Calculate x position
            int y = (this.ClientSize.Height - dataGridView1.Height) / 2; // Calculate y position

            // Set the location of the DataGridView
            dataGridView1.Location = new Point(x, y);

            // Add DataGridView to the form's controls
            this.Controls.Add(dataGridView1);

     


        }
        private void mannualslip_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public static void  create_data_grid()
        {
            dataGridView1.Columns.Add("Product", "Product");
            dataGridView1.Columns.Add("Rate", "Rate");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Price", "Price");
        }

        private void mannualprint_Click(object sender, EventArgs e)
        {


            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintPreviewDialog printDialog = new PrintPreviewDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }


        }

        public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            print_data_gridview( e, printslippage.nozzelprint,  vehicle_no,  slip_no.ToString());
           
        }

        private void mannualslip_Load(object sender, EventArgs e)
        {

        }

        private void data_add_Click(object sender, EventArgs e)
        {
            add_data_grid(productBox.Text, ratebox.Text, qtybox.Text, cashbox.Text);
            
        }



        public static void add_data_grid(string product,string rate,string qty , string cash)
        {
            DataGridViewRow row = new DataGridViewRow();

            // Populate the cells of the row with your data
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = product;
            row.Cells[1].Value = rate;
            row.Cells[2].Value = qty;
            row.Cells[3].Value = cash;
            dataGridView1.Rows.Add(row);

            dataGridView1.Show();

        }
        public static void print_data_gridview(PrintPageEventArgs e,string nozzel_id,string vehicle_id,string slip_id)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10, FontStyle.Regular);
            int startX = 65;
            int startY = 140;

            // Load your logo image
            Image logo = Image.FromFile(Form1.logopath);

            // Draw the logo
            int logoWidth = 120;
            int logoHeight = (int)(((float)logoWidth / (float)logo.Width) * logo.Height);
            graphics.DrawImage(logo, startX, startY - logoHeight, logoWidth, logoHeight);

            // Draw header
            graphics.DrawString("KALLU Petroleum Service", font, Brushes.Black, new Point(startX, startY));
            graphics.DrawString("198/GB Samundri Road Murid Wala", font, Brushes.Black, new Point(startX - 30, startY + 20));
            graphics.DrawString("0333-4039998", font, Brushes.Black, new Point(startX + 45, startY + 50));
            startY += 80;

            // Draw horizontal line
            graphics.DrawString("--------------------------------------------------------------------------------------------", font, Brushes.Black, new Point(10, startY));
            startY += 10;

            // Draw receipt content
            graphics.DrawString("Date    : " + DateTime.Now.ToString(), font, Brushes.Black, new Point(10, startY));
            graphics.DrawString("Noz#: "+ nozzel_id , font, Brushes.Black, new Point(200, startY));
            startY += 20;
            graphics.DrawString("Slip No    : " + slip_id, font, Brushes.Black, new Point(10, startY));
            graphics.DrawString("Vehicle # "+vehicle_id, font, Brushes.Black, new Point(190, startY));
            startY += 20;

            // Draw horizontal line
            graphics.DrawString("--------------------------------------------------------------------------------------------", font, Brushes.Black, new Point(10, startY));

            startY += 20;
            graphics.DrawString("Product", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, startY));
            graphics.DrawString("Qty", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(70, startY));
            graphics.DrawString("Rate", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(140, startY));
            graphics.DrawString("Price", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, startY));

            startY += 10;
            graphics.DrawString(".................................................................................", font, Brushes.Black, new Point(10, startY));

            startY += 20;

            // Draw DataGridView content
            int rowHeight = 20;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string product = row.Cells["Product"].Value?.ToString();
                string qty = row.Cells["Quantity"].Value?.ToString();
                string rate = row.Cells["Rate"].Value?.ToString();
                string totalCash = row.Cells["Price"].Value?.ToString();

                //all_data_sum = int.Parse(totalCash);
                graphics.DrawString(product, font, Brushes.Black, new Point(10, startY));
                graphics.DrawString(qty, font, Brushes.Black, new Point(70, startY));
                graphics.DrawString(rate, font, Brushes.Black, new Point(140, startY));
                graphics.DrawString(totalCash, font, Brushes.Black, new Point(200, startY));



                startY += rowHeight;
            }

            // Draw horizontal line
            graphics.DrawString("============================================================================================", font, Brushes.Black, new Point(0, startY));
            startY += 20;

            graphics.DrawString("TotalCash = ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(90, startY));

            startY += 20;
            // Draw footer
            graphics.DrawString("Thanks For Visiting Us", font, Brushes.Black, new Point(55, startY));
            graphics.DrawString("Powerd by : Power Soft 0300-9698745", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(30, startY + 20));

            // Dispose of resources
            font.Dispose();
            logo.Dispose();
        }

    }
    }

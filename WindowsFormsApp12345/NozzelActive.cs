using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{
    public partial class NozzelActive : Form
    {
        private TextBox[] textBoxes;
        private Label[] label_data;
        public NozzelActive()
        {
            InitializeComponent();
            textBoxes = new TextBox[10]; // Create an array to hold the textboxes
            label_data = new Label[10];
            CreateTextBoxesAndLabel1();
            CreateTextBoxesAndLabel2();
            CreateTextBoxesAndLabel3();
            mysql_read_data_for_price();
        }

        private void NozzelActive_Load(object sender, EventArgs e)
        {
            
            

        }
        private void CreateTextBoxesAndLabel1()
        {
            int startX_Label = 30;
            int startX_Text = 110;
            int startY = 100;
            int spacing = 10;
            int waqfa = 0;

          

            for (int i = 0; i < 4; i++)
            {
                TextBox textBox = new TextBox();
                Label label = new Label();

                label.Location = new System.Drawing.Point(startX_Label + waqfa, startY + spacing);
                textBox.Location = new System.Drawing.Point(startX_Text + waqfa, startY+5 );
                textBox.Multiline=true;
                

                textBox.Size = new System.Drawing.Size(125, 45);

                textBox.Font = new Font(textBox.Font, FontStyle.Bold); // Set font to bold
                textBox.Font = new Font(textBox.Font.FontFamily, 16);
                textBox.TextAlign = HorizontalAlignment.Center;
                

                label.Size = new System.Drawing.Size(100, 50);
                label.Font = new Font(textBox.Font, FontStyle.Bold); // Set font to bold
                label.Font = new Font(textBox.Font.FontFamily, 16);
                this.Controls.Add(textBox);
                this.Controls.Add(label);

                textBoxes[i] = textBox; // Store the textbox in the array
                label_data[i]= label;
                textBoxes[i].Text = "Hello"+i;
                label_data[i].Text = "Noz" + (i+1)+":";
                waqfa = 250+waqfa;



            }
           
        }
        private void CreateTextBoxesAndLabel2()
        {
            int startX_Label = 30;
            int startX_Text = 110;
            int startY = 200;
            int spacing = 10;
            int waqfa = 0;

           

            for (int i = 4; i < 8; i++)
            {
                TextBox textBox = new TextBox();
                Label label = new Label();

                label.Location = new System.Drawing.Point(startX_Label + waqfa, startY + spacing);
                textBox.Location = new System.Drawing.Point(startX_Text + waqfa, startY + 5);
                textBox.Multiline = true;


                textBox.Size = new System.Drawing.Size(125, 45);

                textBox.Font = new Font(textBox.Font, FontStyle.Bold); // Set font to bold
                textBox.Font = new Font(textBox.Font.FontFamily, 16);
                textBox.TextAlign = HorizontalAlignment.Center;


                label.Size = new System.Drawing.Size(100, 50);
                label.Font = new Font(textBox.Font, FontStyle.Bold); // Set font to bold
                label.Font = new Font(textBox.Font.FontFamily, 16);
                this.Controls.Add(textBox);
                this.Controls.Add(label);

                textBoxes[i] = textBox; // Store the textbox in the array
                label_data[i] = label;
                textBoxes[i].Text = "Hello" + i;
                label_data[i].Text = "Noz" + (i + 1) + ":";
                waqfa = 250 + waqfa;



            }

        }
        private void CreateTextBoxesAndLabel3()
        {
            int startX_Label = 30;
            int startX_Text = 110;
            int startY = 300;
            int spacing = 10;
            int waqfa = 0;

            

            for (int i = 8; i < 10; i++)
            {
                TextBox textBox = new TextBox();
                Label label = new Label();

                label.Location = new System.Drawing.Point(startX_Label + waqfa, startY + spacing);
                textBox.Location = new System.Drawing.Point(startX_Text + waqfa, startY + 5);
                textBox.Multiline = true;


                textBox.Size = new System.Drawing.Size(125, 45);

                textBox.Font = new Font(textBox.Font, FontStyle.Bold); // Set font to bold
                textBox.Font = new Font(textBox.Font.FontFamily, 16);
                textBox.TextAlign = HorizontalAlignment.Center;


                label.Size = new System.Drawing.Size(100, 50);
                label.Font = new Font(textBox.Font, FontStyle.Bold); // Set font to bold
                label.Font = new Font(textBox.Font.FontFamily, 16);
                this.Controls.Add(textBox);
                this.Controls.Add(label);

                textBoxes[i] = textBox; // Store the textbox in the array
                label_data[i] = label;
                textBoxes[i].Text = "Hello" + i;
                label_data[i].Text = "Noz" + (i + 1) + ":";
                waqfa = 250 + waqfa;



            }

        }




        private void mysql_read_data_for_price()
        {

            for (int i = 1; i < 11; i++)
            {
                MySqlConnection connection = new MySqlConnection(Appsetting.ConnectionString());

                connection.Open();

                MySqlCommand cmd;
                cmd = connection.CreateCommand();


                cmd.CommandText = "SELECT `Price` FROM `nozzelconfiguration` WHERE `Id`=@id;";
                cmd.Parameters.AddWithValue("@id", i);
              

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                
                while (reader.Read())
                {


                    // Check if textBoxes is not null and has elements
                    if (textBoxes != null && textBoxes.Length > 0)
                    {

                        textBoxes[i-1].Text = reader.GetString("Price");
                        
                        // Access the name of the nozzel TextBox



                    }
                    else
                    {
                        MessageBox.Show("Nozzel TextBox not found");
                    }
                }


                connection.Close();

            }


        }



        public void update_price_db()
        {
            MySqlConnection connection = new MySqlConnection(Appsetting.ConnectionString());
            for (int i = 1; i < 11; i++)
            {



                connection.Open();

                MySqlCommand cmd;
                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE `nozzelconfiguration` SET `Price`=@price WHERE Id=@id;";
                cmd.Parameters.AddWithValue("@id", i);
                cmd.Parameters.AddWithValue("@price", textBoxes[i-1].Text);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void update_value_Click(object sender, EventArgs e)
        {
            update_price_db();
        }
    }
}

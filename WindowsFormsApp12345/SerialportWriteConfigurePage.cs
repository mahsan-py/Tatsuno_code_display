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
    public partial class SerialportWriteConfigurePage : Form
    {

        NozzleViewModel nvz = new NozzleViewModel();

        private CheckBox[] checkboxes;
        private TextBox[] comtextbox = new TextBox[10];
        private Label[] labeldata = new Label[10];


        public SerialportWriteConfigurePage()
        {
            InitializeComponent();
        }

        private void SerialportWriteConfigurePage_Load(object sender, EventArgs e)
        {
            checkboxes = new CheckBox[10];

            create_label1(60, 99 , 0 , 5);
            create_textbox1(150, 99 ,  0, 5);
            create_checkbox1(250, 99, 0, 5);



            create_label1(410, 99 , 5 , 10);
            create_textbox1(500, 99, 5, 10);
            create_checkbox1(600, 99, 5, 10);


            portwrite_checked_status();



        }
        private void create_checkbox1(int x, int y, int initialize_value, int endvalue)
        {
            int waqfa = 0;
            for (int i = initialize_value; i < endvalue; i++)
            {
                CheckBox checkbox = new CheckBox();


                checkbox.Location = new System.Drawing.Point(x, y + waqfa);



                checkbox.Size = new System.Drawing.Size(20, 13);

                //checkbox.Text = "Check me!" + i;
                this.Controls.Add(checkbox);




                waqfa = 32 + waqfa;
                checkboxes[i] = checkbox;

                


            }

        }
        private void create_textbox1(int x, int y, int initialize_value, int endvalue)
        {
            int waqfa = 0;
            for (int i = initialize_value; i < endvalue; i++)
            {
                TextBox textbox = new TextBox();

                textbox.Location = new System.Drawing.Point(x, y + waqfa);
                textbox.Size = new System.Drawing.Size(74, 20);
                textbox.Text = Form1.serial_write_data_display_port[i];

                this.Controls.Add(textbox);

                waqfa = 32 + waqfa;
                comtextbox[i] = textbox;
            }
        }
        private void create_label1(int x,int y , int initialize_value , int endvalue)
        {
            int waqfa = 0;
            for (int i = initialize_value; i < endvalue; i++)
            {
                Label label = new Label();

                label.Location = new System.Drawing.Point(x, y + waqfa);
                label.Size = new System.Drawing.Size(74, 20);
                label.Text = "COM" + (i+1);

                this.Controls.Add(label);

                waqfa = 32 + waqfa;
                labeldata[i] = label;
            }
        }

        public void portwrite_checked_status()
        {
            for (int i = 0; i<10; i++)
            {
                if (Form1.serial_write_data_display_status[i] == true)
                {
                    checkboxes[i].Checked=true;
                }
                else
                {
                    checkboxes[i].Checked = false;
                }
            }

        }

        private void okay_port_status_Click(object sender, EventArgs e)
        {
            // RealTime Data changed

            for (int i = 0; i < 10; i++)
            {
                if (checkboxes[i].Checked == true)
                {
                    Form1.serial_write_data_display_status[i] = true;
                }
                else
                {
                    Form1.serial_write_data_display_status[i] = false;
                }

                Form1.serial_write_data_display_port[i] = comtextbox[i].Text;



                
            }


            update_check_box_value_write_port();


        }


        private void update_check_box_value_write_port()
        {
            MySqlConnection connection = new MySqlConnection(Appsetting.ConnectionString());
            for (int i = 1; i < 11; i++)
            {
                byte xc;
                bool x = checkboxes[i - 1].Checked;
                if (x == true)
                    xc = 1;
                else xc = 0;

                connection.Open();

                MySqlCommand cmd;
                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE `serial_write_data` SET `nozzle_status`=@active , `com_name`=@setname  WHERE serial_write_id=@id;";
                cmd.Parameters.AddWithValue("@id", i);
                cmd.Parameters.AddWithValue("@active", xc);
                cmd.Parameters.AddWithValue("@setname", comtextbox[i-1].Text);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }


    }
}

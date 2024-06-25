using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{

    public partial class Setting : Form
    {
        
        public static string v;
        public static string shift_safe_password_text;
        public static string application_close_password_text;
        public static string automation_safe_password_text;
        public static string setting_safe_password_text;
        public static string pricechange;
        public static string dsply;
        private CheckBox[] checkboxes;

        public Setting()
        {
            InitializeComponent();

            checkboxes = new CheckBox[10];
            
            create_checkbox1(325,  103);
            //create_checkbox2(331, 323);
            operation_perform_checkbox();

       

            string jsonContent = File.ReadAllText(Form1.settingfilepath);



            read_write_data obj1 = JsonSerializer.Deserialize<read_write_data>(jsonContent);


            setting_pswd_text.Text = obj1.setting;

            shift_psw_text.Text = obj1.shift_start;

            auto_text.Text = obj1.automation;

            close_text.Text = obj1.close;
            price_change.Text = obj1.pricechange;
            display.Text = obj1.dsply;



            com1.Text = obj1.comport1;
            com2.Text = obj1.comport2;
            com3.Text = obj1.comport3;
            com4.Text = obj1.comport4;
            com5.Text = obj1.comport5;
            com6.Text = obj1.comport6;

            com7.Text = obj1.comport7;
            com8.Text = obj1.comport8;
            com9.Text = obj1.comport9;
            com10.Text = obj1.comport10;
            com11.Text = obj1.comport11; // Arduino 
            com12.Text = obj1.comport12; // nozzel11
            com13.Text = obj1.comport13; // nozzel12
            com14.Text = obj1.comport14;
            com15.Text = obj1.comport15;
            com16.Text = obj1.comport16;
            com17.Text = obj1.comport17;




            comboBox1.Text = obj1.custom_nozzel1;
            comboBox2.Text = obj1.custom_nozzel2;
            comboBox3.Text = obj1.custom_nozzel3;
            comboBox4.Text = obj1.custom_nozzel4;

            comboBox5.Text = obj1.custom_nozzel5;
            comboBox6.Text = obj1.custom_nozzel6;
            comboBox7.Text = obj1.custom_nozzel7;
            comboBox8.Text = obj1.custom_nozzel8;
            comboBox9.Text = obj1.custom_nozzel9;
            comboBox10.Text = obj1.custom_nozzel10;
            comboBox12.Text = obj1.custom_nozzel12;
            comboBox13.Text = obj1.custom_nozzel13;
            comboBox14.Text = obj1.custom_nozzel14;
            comboBox15.Text = obj1.custom_nozzel15;
            comboBox16.Text = obj1.custom_nozzel16;
            comboBox17.Text = obj1.custom_nozzel17;


            group_capacity1.Text = obj1.Tank1;
            group_capacity2.Text = obj1.Tank2;
            group_capacity3.Text = obj1.Tank3;
            group_capacity4.Text = obj1.Tank4;
            group_capacity5.Text = obj1.Tank5;


            group_capacity6.Text = obj1.Tank6;
            group_capacity7.Text = obj1.Tank7;
            group_capacity8.Text = obj1.Tank8;
            group_capacity9.Text = obj1.Tank9;
            group_capacity10.Text = obj1.Tank10;
            group_capacity12.Text = obj1.Tank12;
            group_capacity13.Text = obj1.Tank13;
            group_capacity14.Text = obj1.Tank14;
            group_capacity15.Text = obj1.Tank15;
            group_capacity16.Text = obj1.Tank16;
            group_capacity17.Text = obj1.Tank17;


        }

        private void ok_setting_button_Click(object sender, EventArgs e)
        {

            update_check_box_value();
            read_write_data mmm = new read_write_data();
            {

                if (shift_psw_text.Text != "") { mmm.shift_start = shift_psw_text.Text; }
                if (auto_text.Text != "") { mmm.automation = auto_text.Text; }
                if (close_text.Text != "") { mmm.close = close_text.Text; }
                if (setting_pswd_text.Text != "") { mmm.setting = setting_pswd_text.Text; }
                if (price_change.Text != "") { mmm.pricechange = price_change.Text; }
                if (display.Text != "") { mmm.dsply = display.Text; }



                if (com1.Text != "") { mmm.comport1 = com1.Text; }
                if (com2.Text != "") { mmm.comport2 = com2.Text; }
                if (com3.Text != "") { mmm.comport3 = com3.Text; }
                if (com4.Text != "") { mmm.comport4 = com4.Text; }
                if (com5.Text != "") { mmm.comport5 = com5.Text; }
                if (com6.Text != "") { mmm.comport6 = com6.Text; }


                if (com7.Text != "") { mmm.comport7 = com7.Text; }
                if (com8.Text != "") { mmm.comport8 = com8.Text; }
                if (com9.Text != "") { mmm.comport9 = com9.Text; }
                if (com10.Text != "") { mmm.comport10 = com10.Text; }
                if (com11.Text != "") { mmm.comport11 = com11.Text; }
                if (com12.Text != "") { mmm.comport12 = com12.Text; }
                if (com13.Text != "") { mmm.comport13 = com13.Text; }
                if (com14.Text != "") { mmm.comport14 = com14.Text; }
                if (com15.Text != "") { mmm.comport15 = com15.Text; }
                if (com16.Text != "") { mmm.comport16 = com16.Text; }
                if (com17.Text != "") { mmm.comport17 = com17.Text; }



                if (comboBox1.Text != "") { mmm.custom_nozzel1 = comboBox1.Text; }
                if (comboBox2.Text != "") { mmm.custom_nozzel2 = comboBox2.Text; }
                if (comboBox3.Text != "") { mmm.custom_nozzel3 = comboBox3.Text; }
                if (comboBox4.Text != "") { mmm.custom_nozzel4 = comboBox4.Text; }

                if (comboBox5.Text != "") { mmm.custom_nozzel5 = comboBox5.Text; }
                if (comboBox6.Text != "") { mmm.custom_nozzel6 = comboBox6.Text; }
                if (comboBox7.Text != "") { mmm.custom_nozzel7 = comboBox7.Text; }
                if (comboBox8.Text != "") { mmm.custom_nozzel8 = comboBox8.Text; }
                if (comboBox9.Text != "") { mmm.custom_nozzel9 = comboBox9.Text; }
                if (comboBox10.Text != "") { mmm.custom_nozzel10 = comboBox10.Text; }
                if (comboBox12.Text != "") { mmm.custom_nozzel12 = comboBox12.Text; }
                if (comboBox13.Text != "") { mmm.custom_nozzel13 = comboBox13.Text; }
                if (comboBox14.Text != "") { mmm.custom_nozzel14 = comboBox14.Text; }
                if (comboBox15.Text != "") { mmm.custom_nozzel15 = comboBox15.Text; }
                if (comboBox16.Text != "") { mmm.custom_nozzel16 = comboBox16.Text; }
                if (comboBox17.Text != "") { mmm.custom_nozzel17 = comboBox17.Text; }

                if (group_capacity1.Text != "") { mmm.Tank1 = group_capacity1.Text; }
                if (group_capacity2.Text != "") { mmm.Tank2 = group_capacity2.Text; }
                if (group_capacity3.Text != "") { mmm.Tank3 = group_capacity3.Text; }

                if (group_capacity4.Text != "") { mmm.Tank4 = group_capacity4.Text; }
                if (group_capacity5.Text != "") { mmm.Tank5 = group_capacity5.Text; }
                if (group_capacity6.Text != "") { mmm.Tank6 = group_capacity6.Text; }

                if (group_capacity7.Text != "") { mmm.Tank7 = group_capacity7.Text; }

                if (group_capacity8.Text != "") { mmm.Tank8 = group_capacity8.Text; }
                if (group_capacity9.Text != "") { mmm.Tank9 = group_capacity9.Text; }
                if (group_capacity10.Text != "") { mmm.Tank10 = group_capacity10.Text; }
                if (group_capacity12.Text != "") { mmm.Tank12 = group_capacity12.Text; }
                if (group_capacity13.Text != "") { mmm.Tank13 = group_capacity13.Text; }
                if (group_capacity14.Text != "") { mmm.Tank14 = group_capacity14.Text; }

                if (group_capacity15.Text != "") { mmm.Tank15 = group_capacity15.Text; }
                if (group_capacity16.Text != "") { mmm.Tank16 = group_capacity16.Text; }
                if (group_capacity17.Text != "") { mmm.Tank17 = group_capacity17.Text; }


            }


            string json_data = JsonSerializer.Serialize(mmm);
            File.WriteAllText(Form1.settingfilepath, json_data);
            this.Close();


        }

        private void Setting_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void create_checkbox1(int x,int y)
        {
            int waqfa=0;
            for (int i = 0; i < 10; i++)
            {
                CheckBox checkbox = new CheckBox();
                

                checkbox.Location = new System.Drawing.Point(x , y + waqfa);



                checkbox.Size = new System.Drawing.Size(20,13);

                checkbox.Text = "Check me!"+i;
                this.Controls.Add(checkbox);



              
                waqfa = 30 + waqfa;
                checkboxes[i] = checkbox;


            }
        }

        private void create_checkbox2(int x, int y)
        {
            int waqfa = 0;
            for (int i = 5; i < 10; i++)
            {
                CheckBox checkbox = new CheckBox();


                checkbox.Location = new System.Drawing.Point(x, y + waqfa);



                checkbox.Size = new System.Drawing.Size(20, 13);


                this.Controls.Add(checkbox);




                waqfa = 32 + waqfa;
                checkboxes[i] = checkbox;


            }
        }

       

        private void operation_perform_checkbox()
        {
            checkboxwork ch = new checkboxwork();

            
            for (int i=0; i<10; i++)
            {
               
                if (ch.get_active_nozzel_db_data(i+1)== true)
                {
                    checkboxes[i].Checked = true;
                }
            }
        }

        private void update_check_box_value()
        {
            MySqlConnection connection = new MySqlConnection(Appsetting.ConnectionString());
            for (int i = 1; i < 11; i++)
            {
                byte xc;
                bool x = checkboxes[i-1].Checked;
                if (x == true)
                    xc = 1;
                else xc = 0;

                connection.Open();

                MySqlCommand cmd;
                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE `nozzelconfiguration` SET `IsActive`=@active WHERE Id=@id;";
                cmd.Parameters.AddWithValue("@id", i);
                cmd.Parameters.AddWithValue("@active", xc);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

    }
}

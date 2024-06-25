using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WindowsFormsApp12345
{

    public partial class Automation : Form
    {
        public static string noz1;
        public static string noz2;
        public static string noz3;
        public static string noz4;
        public static string noz5;
        public static string noz6;
        public static string noz7;
        public static string noz8;
        public static string noz9;
        public static string noz10;

        public static int print_rate1;
        public static int print_rate2;
        public static int print_rate3;
        public static int print_rate4;
        public static int print_rate5;
        public static int print_rate6;
        public static int print_rate7;
        public static int print_rate8;
        public static int print_rate9;
        public static int print_rate10;



        //public static int print1;
        //public static int print2;
        //public static int print3;
        //public static int print4;
        //public static int print5;
        //public static int print6;
        //public static int print7;
        //public static int print8;
        //public static int print9;
        //public static int print10;
        public Automation()
        {

            //noz1=obj1.noz1_active;
            //noz2 = obj1.noz2_active;
            //noz3 = obj1.noz3_active;
            //noz4 = obj1.noz4_active;
            //noz5 = obj1.noz5_active;
            //noz6 = obj1.noz6_active;
            //noz7 = obj1.noz7_active;
            //noz8 = obj1.noz8_active;
            //noz9 = obj1.noz9_active;
            //noz10 = obj1.noz10_active;




            InitializeComponent();
        }

        private void Automation_Load(object sender, EventArgs e)
        {
            read_write_data obj1 = JsonSerializer.Deserialize<read_write_data>(File.ReadAllText(Form1.automationfilepath));
            print_rate1 = obj1.Range1;
            print_rate2 = obj1.Range2;
            print_rate3 = obj1.Range3;
            print_rate4 = obj1.Range4;
            print_rate5 = obj1.Range5;
            print_rate6 = obj1.Range6;
            print_rate7 = obj1.Range7;
            print_rate8 = obj1.Range8;
            print_rate9 = obj1.Range9;
            print_rate10 = obj1.Range10;

            textBox1.Text = print_rate1.ToString();
            textBox2.Text = print_rate2.ToString();
            textBox3.Text = print_rate3.ToString();
            textBox4.Text = print_rate4.ToString();
            textBox5.Text = print_rate5.ToString();
            textBox6.Text = print_rate6.ToString();
            textBox7.Text = print_rate7.ToString();
            textBox8.Text = print_rate8.ToString();
            textBox9.Text = print_rate9.ToString();
            textBox10.Text = print_rate10.ToString();

            if (obj1.noz1_condition == "Active") { checkBox1.CheckState = CheckState.Checked; } else { checkBox1.CheckState = CheckState.Unchecked; }
            if (obj1.noz2_condition == "Active") { checkBox2.CheckState = CheckState.Checked; } else { checkBox2.CheckState = CheckState.Unchecked; }
            if (obj1.noz3_condition == "Active") { checkBox3.CheckState = CheckState.Checked; } else { checkBox3.CheckState = CheckState.Unchecked; }
            if (obj1.noz4_condition == "Active") { checkBox4.CheckState = CheckState.Checked; } else { checkBox4.CheckState = CheckState.Unchecked; }
            if (obj1.noz5_condition == "Active") { checkBox5.CheckState = CheckState.Checked; } else { checkBox5.CheckState = CheckState.Unchecked; }
            if (obj1.noz6_condition == "Active") { checkBox6.CheckState = CheckState.Checked; } else { checkBox6.CheckState = CheckState.Unchecked; }
            if (obj1.noz7_condition == "Active") { checkBox7.CheckState = CheckState.Checked; } else { checkBox7.CheckState = CheckState.Unchecked; }
            if (obj1.noz8_condition == "Active") { checkBox8.CheckState = CheckState.Checked; } else { checkBox8.CheckState = CheckState.Unchecked; }
            if (obj1.noz9_condition == "Active") { checkBox9.CheckState = CheckState.Checked; } else { checkBox9.CheckState = CheckState.Unchecked; }
            if (obj1.noz10_condition == "Active") { checkBox10.CheckState = CheckState.Checked; } else { checkBox10.CheckState = CheckState.Unchecked; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            read_write_data mmm = new read_write_data();
            {
                if (checkBox1.Checked)
                { mmm.noz1_condition = "Active"; }
                else { mmm.noz1_condition = "Non_Active"; }

                if (checkBox2.Checked)
                { mmm.noz2_condition = "Active"; }
                else { mmm.noz2_condition = "Non_Active"; }

                if (checkBox3.Checked)
                { mmm.noz3_condition = "Active"; }
                else { mmm.noz3_condition = "Non_Active"; }

                if (checkBox4.Checked)
                { mmm.noz4_condition = "Active"; }
                else { mmm.noz4_condition = "Non_Active"; }

                if (checkBox5.Checked)
                { mmm.noz5_condition = "Active"; }
                else { mmm.noz5_condition = "Non_Active"; }

                if (checkBox6.Checked)
                { mmm.noz6_condition = "Active"; }
                else { mmm.noz6_condition = "Non_Active"; }

                if (checkBox7.Checked)
                { mmm.noz7_condition = "Active"; }
                else { mmm.noz7_condition = "Non_Active"; }

                if (checkBox8.Checked)
                { mmm.noz8_condition = "Active"; }
                else { mmm.noz8_condition = "Non_Active"; }

                if (checkBox9.Checked)
                { mmm.noz9_condition = "Active"; }
                else { mmm.noz9_condition = "Non_Active"; }

                if (checkBox10.Checked)
                { mmm.noz10_condition = "Active"; }
                else { mmm.noz10_condition = "Non_Active"; }

                int.TryParse(textBox1.Text, out int range_data1);
                int.TryParse(textBox2.Text, out int range_data2);
                int.TryParse(textBox3.Text, out int range_data3);
                int.TryParse(textBox4.Text, out int range_data4);
                int.TryParse(textBox5.Text, out int range_data5);

                int.TryParse(textBox6.Text, out int range_data6);
                int.TryParse(textBox7.Text, out int range_data7);
                int.TryParse(textBox8.Text, out int range_data8);
                int.TryParse(textBox9.Text, out int range_data9);
                int.TryParse(textBox10.Text, out int range_data10);



                mmm.Range1 = range_data1; mmm.Range2 = range_data2; mmm.Range3 = range_data3;
                mmm.Range4 = range_data4; mmm.Range5 = range_data5;

                mmm.Range6 = range_data6; mmm.Range7 = range_data7; mmm.Range8 = range_data8;
                mmm.Range9 = range_data9; mmm.Range10 = range_data10;

            }

            string json_data = JsonSerializer.Serialize(mmm);
            File.WriteAllText(Form1.automationfilepath, json_data);

            //if (checkBox1.Checked)
            //{

            //    int.TryParse(textBox1.Text, out print1);
            //}
            //else if(checkBox2.Checked)
            //{
            //    int.TryParse(textBox2.Text, out print2);
            //}
            //else if (checkBox3.Checked)
            //{
            //    int.TryParse(textBox3.Text, out print3);
            //}

            //else if (checkBox4.Checked)
            //{
            //    int.TryParse(textBox4.Text, out print4);
            //}
            //else if (checkBox5.Checked)
            //{
            //    int.TryParse(textBox5.Text, out print5);
            //}
            //else if (checkBox6.Checked)
            //{
            //    int.TryParse(textBox6.Text, out print6);
            //}
            //else if (checkBox7.Checked)
            //{
            //    int.TryParse(textBox7.Text, out print7);
            //}

            //else if (checkBox8.Checked)
            //{
            //    int.TryParse(textBox8.Text, out print8);
            //}
            //else if (checkBox9.Checked)
            //{
            //    int.TryParse(textBox9.Text, out print9);
            //}

            //else if (checkBox10.Checked)
            //{
            //    int.TryParse(textBox10.Text, out print10);
            //}

            this.Close();

        }
    }
}

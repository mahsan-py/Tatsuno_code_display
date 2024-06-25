using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{

    public partial class Form1 : Form
    {
        bool coun, coun2 = false;
        private DateTime cacheExpiryTime;

        public static bool[] serial_write_data_display_status = new bool[10];
        bool[] counter = new bool[10];

        public static string[] serial_write_data_display_port = new string[10];

        bool one_time_cal = false;

        string application_path, img_path;

        int main_index = 0;

        string n_id2;

        int dbId = 0;
        int dbNozzel_ID = 1;   // @AQ
        int dbAddress = 2;     //65,66,67
        int dbBccAddress = 3;  //6,7
        int dbType = 4;
        int dbPrice = 5;       //200.89
        int dbActive = 6;      //true/false








        delayService delayService = new delayService();
        long hi_byte, lo_byte;
        private Thread start_now;
        static SerialPort serialPort;
        private string readBuffer;

        string EndofTransmission = "\u0004";

        string Enquiry = "\u0005";

        string StartOfHeading = "\u0001";

        string StartOfText = "\u0002";

        string EndOfText = "\u0003";

        string Acknowledge = "\u0006";

        string DataLinkEscape = "\u0010";




        string temBuffer;
        string noz_address, noz2_address;

        byte bcc;


        NozzleViewModel sd = new NozzleViewModel();
        serialwriteconfg SERIAL_IN_DISPLAY = new serialwriteconfg();




        int barrr;
        string tank_losing;
        string app_path;
        public static string logopath;
        public static string settingfilepath, automationfilepath;



        public static string[] arduino_data;
        float final_cash, final_liter;
        public static float liter1, liter2, liter3, liter4, liter5, liter6, liter7, liter8, liter9, liter10, liter11, liter12, liter13, liter14, liter15, liter16;



        string[] pricequery = new string[17];
        string[] literquery = new string[17];
        MySqlCommand[] pricecommand = new MySqlCommand[17];
        MySqlCommand[] litercommand = new MySqlCommand[17];

        MySqlDataReader[] pricereader = new MySqlDataReader[17];
        MySqlDataReader[] literreader = new MySqlDataReader[17];
        float[] price = new float[17];
        float[] liter = new float[17];
        string[] noz_category = new string[17];




        string noiz_noz11, noiz_noz12, noiz_noz13, noiz_noz14, noiz_noz15, noiz_noz16, noiz_noz5, noiz_noz1, noiz_noz2, noiz_noz3, noiz_noz4, noiz_noz8, noiz_noz6, noiz_noz7, noiz_noz9, noiz_noz10;

        private static DateTime shift_start;

        public float cash_value_nozzel1;

        public static int shift_id = 0;

        float super_liter_array;
        float super_cash_array;
        float diesel_liter_array;
        float diesel_cash_array;
        float hobc_liter_array;
        float hobc_cash_array;
        MySqlCommand tank_reader_command;
        public static Form1 instance1;

        float losing_value_super, losing_value_diesel;






        MySqlConnection Nozzel_connection;
        public static String re;





        private void button2_Click_2(object sender, EventArgs e)
        {
            mannualslip form = new mannualslip("");
            form.Show();
        }

        private void printn14_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn14.Text, raten14.Text, litern14.Text, "14");
            printpage.Show();
        }

        string cus_noz_tank1, cus_noz_tank2, cus_noz_tank3, cus_noz_tank4, cus_noz_tank5, cus_noz_tank6, cus_noz_tank7, cus_noz_tank8, cus_noz_tank9, cus_noz_tank10, cus_noz_tank12, cus_noz_tank13, cus_noz_tank14, cus_noz_tank15, cus_noz_tank16, cus_noz_tank17, cus_noz_tank18;

        private void printn13_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn13.Text, raten13.Text, litern13.Text, "13");
            printpage.Show();
        }

        private void printn15_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn15.Text, raten15.Text, litern15.Text, "15");
            printpage.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void printn16_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn16.Text, raten16.Text, litern16.Text, "16");
            printpage.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void printn12_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn12.Text, raten12.Text, litern12.Text, "12");
            printpage.Show();
        }

        private void printn11_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn11.Text, raten11.Text, litern11.Text, "11");
            printpage.Show();
        }

        private void tank3_capacity_remaining__value_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void cashn4_Click(object sender, EventArgs e)
        {

        }

        private void litern4_Click(object sender, EventArgs e)
        {

        }

        private void raten4_Click(object sender, EventArgs e)
        {

        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


        }

        private void tank2_capacity_remaining__value_Click(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }



        private void textn11_TextChanged(object sender, EventArgs e)
        {

        }





        //public static System.IO.Ports.SerialPort Port1;
        //public static System.IO.Ports.SerialPort Port2;
        //public static System.IO.Ports.SerialPort Port3;
        //public static System.IO.Ports.SerialPort Port4;
        //public static System.IO.Ports.SerialPort Port5;
        //public static System.IO.Ports.SerialPort Port6;
        public static System.IO.Ports.SerialPort[] Port = new SerialPort[6];
        public static System.IO.Ports.SerialPort[] writePort = new SerialPort[10];

        private void label7_Click(object sender, EventArgs e)
        {

        }


        string[,] list_data = new string[10, 7];


        public Form1()

        {
            instance1 = this;

            checkboxwork ch = new checkboxwork();
            InitializeComponent();

            application_path = AppDomain.CurrentDomain.BaseDirectory;
            img_path = System.IO.Path.Combine(application_path, "img");

            for (int i = 0; i < 10; i++)
            {
                list_data[i, dbActive] = ch.get_active_nozzel_db_data(i + 1).ToString();
            }





            app_path = AppDomain.CurrentDomain.BaseDirectory;
            img_path = System.IO.Path.Combine(app_path, "img");

            logopath = (System.IO.Path.Combine(img_path, "logo.png"));
            settingfilepath = System.IO.Path.Combine(img_path, "ahsn.json");
            automationfilepath = System.IO.Path.Combine(img_path, "automation_json_file.json");

            string jsonContentsetting = File.ReadAllText(settingfilepath);
            string jsonContentautomation = File.ReadAllText(automationfilepath);

            read_write_data obj1 = JsonSerializer.Deserialize<read_write_data>(jsonContentsetting);

            Setting.shift_safe_password_text = obj1.shift_start;
            Setting.automation_safe_password_text = obj1.automation;
            Setting.application_close_password_text = obj1.close;
            Setting.setting_safe_password_text = obj1.setting;
            Setting.pricechange = obj1.pricechange;
            Setting.dsply = obj1.dsply;

            //cus_noz1 means custom _nozzel1






            noz_category[1] = obj1.custom_nozzel1;
            noz_category[2] = obj1.custom_nozzel2;
            noz_category[3] = obj1.custom_nozzel3;
            noz_category[4] = obj1.custom_nozzel4;

            noz_category[5] = obj1.custom_nozzel5;
            noz_category[6] = obj1.custom_nozzel6;
            noz_category[7] = obj1.custom_nozzel7;
            noz_category[8] = obj1.custom_nozzel8;
            noz_category[9] = obj1.custom_nozzel9;
            noz_category[10] = obj1.custom_nozzel10;
            noz_category[11] = obj1.custom_nozzel12;
            noz_category[12] = obj1.custom_nozzel13;
            noz_category[13] = obj1.custom_nozzel14;
            noz_category[14] = obj1.custom_nozzel15;
            noz_category[15] = obj1.custom_nozzel16;
            noz_category[16] = obj1.custom_nozzel17;

            litern1.Text = "0.00"; raten1.Text = "0.00"; cashn1.Text = "0.00";
            litern2.Text = "0.00"; raten2.Text = "0.00"; cashn2.Text = "0.00";
            litern3.Text = "0.00"; raten3.Text = "0.00"; cashn3.Text = "0.00";
            litern4.Text = "0.00"; raten4.Text = "0.00"; cashn4.Text = "0.00"; cashn5.Text = "0.00";
            litern5.Text = "0.00"; raten5.Text = "0.00";
            litern6.Text = "0.00"; raten6.Text = "0.00"; cashn6.Text = "0.00";
            litern7.Text = "0.00"; raten7.Text = "0.00"; cashn7.Text = "0.00";
            litern8.Text = "0.00"; raten8.Text = "0.00"; cashn8.Text = "0.00";
            litern9.Text = "0.00"; raten9.Text = "0.00"; cashn9.Text = "0.00";
            litern10.Text = "0.00"; raten10.Text = "0.00"; cashn10.Text = "0.00";














            noiz_noz1 = obj1.custom_nozzel1;
            noiz_noz2 = obj1.custom_nozzel2;
            noiz_noz3 = obj1.custom_nozzel3;
            noiz_noz4 = obj1.custom_nozzel4;

            noiz_noz6 = obj1.custom_nozzel6;
            noiz_noz7 = obj1.custom_nozzel7;
            noiz_noz8 = obj1.custom_nozzel8;
            noiz_noz9 = obj1.custom_nozzel9;
            noiz_noz10 = obj1.custom_nozzel10;




            noiz_noz11 = obj1.custom_nozzel12;
            noiz_noz12 = obj1.custom_nozzel13;
            noiz_noz13 = obj1.custom_nozzel14;
            noiz_noz14 = obj1.custom_nozzel15;
            noiz_noz15 = obj1.custom_nozzel16;
            noiz_noz16 = obj1.custom_nozzel17;
            noiz_noz5 = obj1.custom_nozzel5;


            cus_noz_tank1 = obj1.Tank1;
            cus_noz_tank2 = obj1.Tank2;
            cus_noz_tank3 = obj1.Tank3;
            cus_noz_tank4 = obj1.Tank4;

            cus_noz_tank5 = obj1.Tank5;
            cus_noz_tank6 = obj1.Tank6;
            cus_noz_tank7 = obj1.Tank7;
            cus_noz_tank8 = obj1.Tank8;
            cus_noz_tank9 = obj1.Tank9;
            cus_noz_tank10 = obj1.Tank10;
            cus_noz_tank12 = obj1.Tank12;
            cus_noz_tank13 = obj1.Tank13;
            cus_noz_tank14 = obj1.Tank14;
            cus_noz_tank15 = obj1.Tank15;
            cus_noz_tank16 = obj1.Tank16;
            cus_noz_tank17 = obj1.Tank17;








            // Color Scheme,Text  changed.........
            if (noz_category[1] == "Super") { groupBox1.BackColor = Color.DarkOrange; groupBox1.Text = "Nozzel1_super"; }

            else if (noz_category[1] == "Diesel") { groupBox1.BackColor = Color.CornflowerBlue; groupBox1.Text = "Nozzel1_Diesel"; }

            else if (noz_category[1] == "Hobc") { groupBox1.BackColor = Color.PaleGreen; groupBox1.Text = "Nozzel1_Hobc"; }

            if (noz_category[2] == "Super") { groupBox2.BackColor = Color.DarkOrange; groupBox2.Text = "Nozzel2_super"; }
            else if (noz_category[2] == "Diesel") { groupBox2.BackColor = Color.CornflowerBlue; groupBox2.Text = "Nozzel2_Diesel"; }
            else if (noz_category[2] == "Hobc") { groupBox2.BackColor = Color.PaleGreen; groupBox2.Text = "Nozzel2_Hobc"; }

            if (noz_category[3] == "Super") { groupBox3.BackColor = Color.DarkOrange; groupBox3.Text = "Nozzel3_super"; }
            else if (noz_category[3] == "Diesel") { groupBox3.BackColor = Color.CornflowerBlue; groupBox3.Text = "Nozzel3_Diesel"; }
            else if (noz_category[3] == "Hobc") { groupBox3.BackColor = Color.PaleGreen; groupBox3.Text = "Nozzel3_Hobc"; }

            if (noz_category[4] == "Super") { groupBox4.BackColor = Color.DarkOrange; groupBox4.Text = "Nozzel4_super"; }
            else if (noz_category[4] == "Diesel") { groupBox4.BackColor = Color.CornflowerBlue; groupBox4.Text = "Nozzel4_Diesel"; }
            else if (noz_category[4] == "Hobc") { groupBox4.BackColor = Color.PaleGreen; groupBox4.Text = "Nozzel4_Hobc"; }


            if (noz_category[5] == "Super") { groupBox5.BackColor = Color.DarkOrange; groupBox5.Text = "Nozzel5_super"; }
            else if (noz_category[5] == "Diesel") { groupBox5.BackColor = Color.CornflowerBlue; groupBox5.Text = "Nozzel5_Diesel"; }
            else if (noz_category[5] == "Hobc") { groupBox5.BackColor = Color.PaleGreen; groupBox5.Text = "Nozzel5_Hobc"; }



            if (noz_category[6] == "Super") { groupBox6.BackColor = Color.DarkOrange; groupBox6.Text = "Nozzel6_super"; }
            else if (noz_category[6] == "Diesel") { groupBox6.BackColor = Color.CornflowerBlue; groupBox6.Text = "Nozzel6_Diesel"; }
            else if (noz_category[6] == "Hobc") { groupBox6.BackColor = Color.PaleGreen; groupBox6.Text = "Nozzel6_Hobc"; }


            if (noz_category[7] == "Super") { groupBox7.BackColor = Color.DarkOrange; groupBox7.Text = "Nozzel7_super"; }
            else if (noz_category[7] == "Diesel") { groupBox7.BackColor = Color.CornflowerBlue; groupBox7.Text = "Nozzel7_Diesel"; }
            else if (noz_category[7] == "Hobc") { groupBox7.BackColor = Color.PaleGreen; groupBox7.Text = "Nozzel7_Hobc"; }

            if (noz_category[8] == "Super") { groupBox8.BackColor = Color.DarkOrange; groupBox8.Text = "Nozzel8_super"; }
            else if (noz_category[8] == "Diesel") { groupBox8.BackColor = Color.CornflowerBlue; groupBox8.Text = "Nozzel8_Diesel"; }
            else if (noz_category[8] == "Hobc") { groupBox8.BackColor = Color.PaleGreen; groupBox8.Text = "Nozzel8_Hobc"; }


            if (noz_category[9] == "Super") { groupBox9.BackColor = Color.DarkOrange; groupBox9.Text = "Nozzel9_super"; }
            else if (noz_category[9] == "Diesel") { groupBox9.BackColor = Color.CornflowerBlue; groupBox9.Text = "Nozzel9_Diesel"; }
            else if (noz_category[9] == "Hobc") { groupBox9.BackColor = Color.PaleGreen; groupBox9.Text = "Nozzel9_Hobc"; }

            if (noz_category[10] == "Super") { groupBox10.BackColor = Color.DarkOrange; groupBox10.Text = "Nozzel10_super"; }
            else if (noz_category[10] == "Diesel") { groupBox10.BackColor = Color.CornflowerBlue; groupBox10.Text = "Nozzel10_Diesel"; }
            else if (noz_category[10] == "Hobc") { groupBox10.BackColor = Color.PaleGreen; groupBox10.Text = "Nozzel10_Hobc"; }



            if (noz_category[11] == "Super") { groupBox11.BackColor = Color.DarkOrange; groupBox11.Text = "Nozzel11_super"; }
            else if (noz_category[11] == "Diesel") { groupBox11.BackColor = Color.CornflowerBlue; groupBox11.Text = "Nozzel11_Diesel"; }
            else if (noz_category[11] == "Hobc") { groupBox11.BackColor = Color.PaleGreen; groupBox11.Text = "Nozzel11_Hobc"; }



            if (noz_category[12] == "Super") { groupBox12.BackColor = Color.DarkOrange; groupBox12.Text = "Nozzel12_super"; }
            else if (noz_category[12] == "Diesel") { groupBox12.BackColor = Color.CornflowerBlue; groupBox12.Text = "Nozzel12_Diesel"; }
            else if (noz_category[12] == "Hobc") { groupBox12.BackColor = Color.PaleGreen; groupBox12.Text = "Nozzel12_Hobc"; }


            if (noz_category[13] == "Super") { groupBox13.BackColor = Color.DarkOrange; groupBox13.Text = "Nozzel13_super"; }
            else if (noz_category[13] == "Diesel") { groupBox13.BackColor = Color.CornflowerBlue; groupBox13.Text = "Nozzel13_Diesel"; }
            else if (noz_category[13] == "Hobc") { groupBox13.BackColor = Color.PaleGreen; groupBox13.Text = "Nozzel13_Hobc"; }

            if (noz_category[14] == "Super") { groupBox14.BackColor = Color.DarkOrange; groupBox14.Text = "Nozzel14_super"; }
            else if (noz_category[14] == "Diesel") { groupBox14.BackColor = Color.CornflowerBlue; groupBox14.Text = "Nozzel14_Diesel"; }
            else if (noz_category[14] == "Hobc") { groupBox14.BackColor = Color.PaleGreen; groupBox14.Text = "Nozzel14_Hobc"; }


            if (noz_category[15] == "Super") { groupBox15.BackColor = Color.DarkOrange; groupBox15.Text = "Nozzel15_super"; }
            else if (noz_category[15] == "Diesel") { groupBox15.BackColor = Color.CornflowerBlue; groupBox15.Text = "Nozzel15_Diesel"; }
            else if (noz_category[15] == "Hobc") { groupBox15.BackColor = Color.PaleGreen; groupBox15.Text = "Nozzel15_Hobc"; }

            if (noz_category[16] == "Super") { groupBox16.BackColor = Color.DarkOrange; groupBox16.Text = "Nozzel16_super"; }
            else if (noz_category[16] == "Diesel") { groupBox16.BackColor = Color.CornflowerBlue; groupBox16.Text = "Nozzel16_Diesel"; }
            else if (noz_category[16] == "Hobc") { groupBox16.BackColor = Color.PaleGreen; groupBox16.Text = "Nozzel16_Hobc"; }


            string[] serial_val = { obj1.comport1, obj1.comport2, obj1.comport3, obj1.comport4, obj1.comport5, obj1.comport6 };

            for (int i = 0; i < 6; i++)
            {
                serialportfunc(i + 1, serial_val[i]); // call function 
            }





            Nozzel_connection = new MySqlConnection(Appsetting.ConnectionString());



            // Initialize and start the timer

        }



        public void serialportfunc(int count, string serialPortname)
        {
            try
            {
                Port[count - 1] = new SerialPort();

                Port[count - 1].PortName = serialPortname;
                Port[count - 1].BaudRate = 19200;
                Port[count - 1].Handshake = Handshake.None;
                Port[count - 1].DataBits = 8;
                Port[count - 1].Parity = Parity.Even;
                Port[count - 1].ParityReplace = 59;

                Port[count - 1].StopBits = StopBits.One;
                Port[count - 1].RtsEnable = false;

                //Port[count - 1].ErrorReceived += new SerialErrorReceivedEventHandler(DataReceivedErrorHandler);
                if (count == 1)
                {
                    Port[0].DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler1);
                }
                else if (count == 2) { Port[count - 1].DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler2); }
                else if (count == 3) { Port[count - 1].DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler3); }
                else if (count == 4) { Port[count - 1].DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler4); }
                else if (count == 5) { Port[count - 1].DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler5); }
                Port[count - 1].Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void serial_write_func(int count, string serialPortname)
        {
            try
            {
                writePort[count - 1] = new SerialPort();

                writePort[count - 1].PortName = serialPortname;
                writePort[count - 1].BaudRate = 9600;

                writePort[count - 1].DataBits = 8;


                writePort[count - 1].StopBits = StopBits.One;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void DataReceivedHandler1(object sender, SerialDataReceivedEventArgs e)
        {

            object lockOn = new object();
            lock (lockOn)
            {


                string temBuffer = "";


                SerialPort serialPort = (SerialPort)sender;

                temBuffer = serialPort.ReadExisting(); // Read all available data from the serial port

                if (temBuffer.Length >= 9 && true)
                {
                    var tempArray = temBuffer.Split('Q');
                    var id = tempArray[0].Last().ToString();
                    this.readBuffer = "\u0002" + id + "Q" + tempArray.Last();
                    serialPort.DiscardInBuffer();
                    Form1 form1 = this;

                    this.Invoke(new EventHandler(form1.DoUpdate));

                }


            }


        }

        private void DataReceivedHandler2(object sender, SerialDataReceivedEventArgs e)
        {

            object lockOn = new object();
            lock (lockOn)
            {
                string temBuffer = "";

                SerialPort serialPort = (SerialPort)sender;
                temBuffer = serialPort.ReadExisting(); // Read all available data from the serial port

                if (temBuffer.Length >= 9)
                {
                    var tempArray = temBuffer.Split('Q');
                    var id = tempArray[0].Last().ToString();
                    this.readBuffer = "\u0002" + id + "Q" + tempArray.Last();
                    serialPort.DiscardInBuffer();

                    Form1 form1 = this;
                    this.Invoke(new EventHandler(form1.DoUpdate));



                    //Invoke((Action)(() => DoUpdate(2, 3)));

                }
            }
        }
        private void DataReceivedHandler3(object sender, SerialDataReceivedEventArgs e)
        {
            object lockOn = new object();
            lock (lockOn)
            {
                string temBuffer = "";

                SerialPort serialPort = (SerialPort)sender;
                temBuffer = serialPort.ReadExisting(); // Read all available data from the serial port

                if (temBuffer.Length >= 9)
                {
                    var tempArray = temBuffer.Split('Q');
                    var id = tempArray[0].Last().ToString();
                    this.readBuffer = "\u0002" + id + "Q" + tempArray.Last();
                    serialPort.DiscardInBuffer();

                    Form1 form1 = this;
                    this.Invoke(new EventHandler(form1.DoUpdate));



                    //Invoke((Action)(() => DoUpdate(4, 5)));

                }
            }
        }
        private void DataReceivedHandler4(object sender, SerialDataReceivedEventArgs e)
        {
            object lockOn = new object();
            lock (lockOn)
            {
                string temBuffer = "";

                SerialPort serialPort = (SerialPort)sender;
                temBuffer = serialPort.ReadExisting(); // Read all available data from the serial port

                if (temBuffer.Length >= 9)
                {
                    var tempArray = temBuffer.Split('Q');
                    var id = tempArray[0].Last().ToString();
                    this.readBuffer = "\u0002" + id + "Q" + tempArray.Last();
                    serialPort.DiscardInBuffer();

                    Form1 form1 = this;
                    this.Invoke(new EventHandler(form1.DoUpdate));
                }
            }
        }
        private void DataReceivedHandler5(object sender, SerialDataReceivedEventArgs e)
        {
            object lockOn = new object();
            lock (lockOn)
            {
                string temBuffer = "";

                SerialPort serialPort = (SerialPort)sender;
                temBuffer = serialPort.ReadExisting(); // Read all available data from the serial port

                if (temBuffer.Length >= 9)
                {
                    var tempArray = temBuffer.Split('Q');
                    var id = tempArray[0].Last().ToString();
                    this.readBuffer = "\u0002" + id + "Q" + tempArray.Last();
                    serialPort.DiscardInBuffer();

                    Form1 form1 = this;
                    this.Invoke(new EventHandler(form1.DoUpdate));
                }
            }
        }
        //private void DataReceivedErrorHandler(object sender, SerialErrorReceivedEventArgs e)
        //{

        //        SerialPort sp = (SerialPort)sender;
        //        string indata = sp.ReadExisting();
        //        MessageBox.Show(string.Concat("An error has occured", indata));

        //}

        private void Form1_Load(object sender, EventArgs e)

        {



            for (int i = 0; i < 10; i++)
            {
                (string xgh1, bool hjj1) = SERIAL_IN_DISPLAY.GetSerialWriteNozzleDbData(i + 1);
                serial_write_data_display_port[i] = xgh1;
                serial_write_data_display_status[i] = hjj1;
            }

            for (int i = 0; i < 10; i++)
            {
                serial_write_func(i + 1, serial_write_data_display_port[i]);
            }


            try
            {
                string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";



                string query = "select *from nozzel1 ORDER BY Shift_ID DESC LIMIT 1;";
                try
                {
                    tank_losing = "SELECT * FROM `tank_losing_db` Where ID=4;";
                }
                catch
                {
                    MessageBox.Show("not_okay");
                }

                using (MySqlConnection connect = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(query, connect);

                    tank_reader_command = new MySqlCommand(tank_losing, connect);



                    connect.Open();

                    using (MySqlDataReader reader1 = command.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            string slip_shift_id = reader1["Shift_ID"].ToString();
                            int.TryParse(slip_shift_id, out shift_id);
                            label2.Text = shift_id.ToString();

                        }

                    }

                    using (MySqlDataReader reader2 = tank_reader_command.ExecuteReader())
                    {
                        if (reader2.Read())
                        {
                            label5.Text = reader2["Super_Tank"].ToString();
                            label6.Text = reader2["Diesel_Tank"].ToString();

                            float.TryParse(label6.Text, out losing_value_diesel);
                            float.TryParse(label5.Text, out losing_value_super);
                        }


                    }


                    connect.Close();
                }







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



                        litercommand[j].Parameters.AddWithValue("@id", shift_id);
                        pricecommand[j].Parameters.AddWithValue("@cashid", shift_id);



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










                        if (noz_category[j] == "Super") { super_sum_cash_liter(price[j], liter[j]); }
                        else if (noz_category[j] == "Diesel") { diesel_sum_cash_liter(price[j], liter[j]); }
                        else if (noz_category[j] == "Hobc") { hobc_sum_cash_liter(price[j], liter[j]); }






                    }
                    connection.Close();

                    totaln1.Text = liter[1].ToString();
                    totaln2.Text = liter[2].ToString();
                    totaln3.Text = liter[3].ToString();
                    totaln4.Text = liter[4].ToString();
                    totaln5.Text = liter[5].ToString();
                    totaln6.Text = liter[6].ToString();
                    totaln7.Text = liter[7].ToString();
                    totaln8.Text = liter[8].ToString();
                    totaln9.Text = liter[9].ToString();
                    totaln10.Text = liter[10].ToString();
                    totaln11.Text = liter[11].ToString();
                    totaln12.Text = liter[12].ToString();
                    totaln13.Text = liter[13].ToString();
                    totaln14.Text = liter[14].ToString();
                    totaln15.Text = liter[15].ToString();
                    totaln16.Text = liter[16].ToString();

                }






            }
            catch { MessageBox.Show("Please connect the Data Base XAmpp server is OFF"); Environment.Exit(0); }

            try
            {

                // Open the serial port
                //serialPort.Open();
                //MessageBox.Show("opened");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            NozzelDbConfig configuration = new NozzelDbConfig();


            list_data = configuration.Config();

            for (int i = 0; i < 10; i++)
            {
                // Assuming sd.BccAddress and sd.NozzleAddress are byte arrays
                // Initialize the arrays if necessary
                if (sd.BccAddress == null)
                    sd.BccAddress = new byte[10]; // Assuming you want an array of length 10
                if (sd.NozzleAddress == null)
                    sd.NozzleAddress = new byte[10]; // Assuming you want an array of length 10

                if (sd.NozzleRate == null)
                    sd.NozzleRate = new string[10];
                // Assuming list_data is a multidimensional array or similar data structure
                // Convert data to bytes and assign to the arrays
                string rate = list_data[i, dbPrice];
                string rate1 = rate.Substring(0, 3);

                string rate2 = rate.Substring(3, 2);

                byte bccByte = Convert.ToByte(list_data[i, dbBccAddress]);
                byte nozzleByte = Convert.ToByte(list_data[i, dbAddress]);

                sd.BccAddress[i] = bccByte;
                sd.NozzleAddress[i] = nozzleByte;
                sd.NozzleRate[i] = rate1 + "." + rate2;
            }









            Form1 form1 = this;
            this.start_now = new Thread(new ThreadStart(form1.processNozzles));
            //Thread start_now1 = new Thread(new ThreadStart(form1.processNozzles1));
            this.start_now.Start();
            //start_now1.Start();
            Thread keypad_print = new Thread(arduino_print);
            Thread next_shift_start = new Thread(aggli_shift);




            next_shift_start.Start();
            //keypad_print.Start();

        }




        private void processNozzles()
        {
            while (true)
            {





                nozzle3_function(sd, 1);
                nozzle4_function(sd, 1);
                nozzle5_function(sd, 2);
                nozzle6_function(sd, 2);

                nozzle7_function(sd, 3);
                nozzle8_function(sd, 3);
                nozzle9_function(sd, 4);
                nozzle10_function(sd, 4);
                nozzle1_function(sd, 0);
                nozzle2_function(sd, 0);
            }


        }


        private void nozzle1_function(NozzleViewModel nozzle, int i)

        {
            try
            {
                //list_data[Row No, col No ]
                //
                if (list_data[0, dbActive] == "True")
                {



                    if (nozzle.power_string[0] == "00")
                    {
                        this.check_for_power(nozzle, 0);

                        this.nozzle_power_on(nozzle, Port[i], 0);
                    }
                    else
                    {

                        Port[i].Write("\u0004@Q\u0005");
                        this.delayService.ShortDelay();
                        if (!string.IsNullOrEmpty(nozzle.NozzlePosition[0]))
                        {
                            this.nozzle_status(nozzle, Port[i], 0);
                            this.delayService.ShortDelay();
                            if (nozzle.NozzlePosition[0].Equals("680", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[0].Equals("684", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[0].Equals("65", StringComparison.OrdinalIgnoreCase))
                            {
                                Port[i].Write(string.Concat(this.DataLinkEscape, "1"));
                                this.delayService.ShortDelay();

                            }
                            if (nozzle.NozzlePosition[0].Equals("681", StringComparison.OrdinalIgnoreCase))
                            {


                                this.nozzle_release_now(nozzle, Port[i], 0);


                                this.nozzle_status(nozzle, Port[i], 0);
                            }
                            if (nozzle.NozzlePosition[0].Equals("683", StringComparison.OrdinalIgnoreCase))
                            {



                                this.nozzle_status(nozzle, Port[i], 0);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Catch any other exceptions (if needed)
                MessageBox.Show("An error occurred:1 " + ex.Message);
            }


        }
        private void nozzle2_function(NozzleViewModel nozzle, int i)

        {
            try
            {
                //list_data[Row No, col No ]
                //
                if (list_data[1, dbActive] == "True")
                {



                    if (nozzle.power_string[1] == "00")
                    {
                        this.check_for_power(nozzle, 1);

                        this.nozzle_power_on(nozzle, Port[i], 1);
                    }
                    else
                    {

                        Port[i].Write("\u0004AQ\u0005");
                        this.delayService.ShortDelay();
                        if (!string.IsNullOrEmpty(nozzle.NozzlePosition[1]))
                        {
                            this.nozzle_status(nozzle, Port[i], 1);
                            this.delayService.ShortDelay();
                            if (nozzle.NozzlePosition[1].Equals("680", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[1].Equals("684", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[1].Equals("65", StringComparison.OrdinalIgnoreCase))
                            {
                                Port[i].Write(string.Concat(this.DataLinkEscape, "1"));
                                this.delayService.ShortDelay();

                            }
                            if (nozzle.NozzlePosition[1].Equals("681", StringComparison.OrdinalIgnoreCase))
                            {


                                this.nozzle_release_now(nozzle, Port[i], 1);


                                this.nozzle_status(nozzle, Port[i], 1);
                            }
                            if (nozzle.NozzlePosition[1].Equals("683", StringComparison.OrdinalIgnoreCase))
                            {



                                this.nozzle_status(nozzle, Port[i], 1);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Catch any other exceptions (if needed)
                MessageBox.Show("An error occurred:2 " + ex.Message);
            }


        }


        private void nozzle3_function(NozzleViewModel nozzle, int i)

        {
            try
            {
                //list_data[Row No, col No ]
                //
                if (list_data[2, dbActive] == "True")
                {



                    if (nozzle.power_string[2] == "00")
                    {
                        this.check_for_power(nozzle, 2);

                        this.nozzle_power_on(nozzle, Port[i], 2);
                    }
                    else
                    {

                        Port[i].Write("\u0004BQ\u0005");
                        this.delayService.ShortDelay();
                        if (!string.IsNullOrEmpty(nozzle.NozzlePosition[2]))
                        {
                            this.nozzle_status(nozzle, Port[i], 2);
                            this.delayService.ShortDelay();
                            if (nozzle.NozzlePosition[2].Equals("680", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[2].Equals("684", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[2].Equals("65", StringComparison.OrdinalIgnoreCase))
                            {
                                Port[i].Write(string.Concat(this.DataLinkEscape, "1"));
                                this.delayService.ShortDelay();

                            }
                            if (nozzle.NozzlePosition[2].Equals("681", StringComparison.OrdinalIgnoreCase))
                            {


                                this.nozzle_release_now(nozzle, Port[i], 2);


                                this.nozzle_status(nozzle, Port[i], 2);
                            }
                            if (nozzle.NozzlePosition[2].Equals("683", StringComparison.OrdinalIgnoreCase))
                            {



                                this.nozzle_status(nozzle, Port[i], 2);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Catch any other exceptions (if needed)
                MessageBox.Show("An error occurred:3 " + ex.Message);
            }


        }

        private void nozzle4_function(NozzleViewModel nozzle, int i)

        {
            try
            {
                //list_data[Row No, col No ]
                //
                if (list_data[3, dbActive] == "True")
                {



                    if (nozzle.power_string[3] == "00")
                    {
                        this.check_for_power(nozzle, 3);

                        this.nozzle_power_on(nozzle, Port[i], 3);
                    }
                    else
                    {

                        Port[i].Write("\u0004CQ\u0005");
                        this.delayService.ShortDelay();
                        if (!string.IsNullOrEmpty(nozzle.NozzlePosition[3]))
                        {
                            this.nozzle_status(nozzle, Port[i], 3);
                            this.delayService.ShortDelay();
                            if (nozzle.NozzlePosition[3].Equals("680", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[3].Equals("684", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[3].Equals("65", StringComparison.OrdinalIgnoreCase))
                            {
                                Port[i].Write(string.Concat(this.DataLinkEscape, "1"));
                                this.delayService.ShortDelay();

                            }
                            if (nozzle.NozzlePosition[3].Equals("681", StringComparison.OrdinalIgnoreCase))
                            {


                                this.nozzle_release_now(nozzle, Port[i], 3);


                                this.nozzle_status(nozzle, Port[i], 3);
                            }
                            if (nozzle.NozzlePosition[3].Equals("683", StringComparison.OrdinalIgnoreCase))
                            {



                                this.nozzle_status(nozzle, Port[i], 3);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Catch any other exceptions (if needed)
                MessageBox.Show("An error occurred:4 " + ex.Message);
            }


        }

        private void nozzle5_function(NozzleViewModel nozzle, int i)

        {
            try
            {
                //list_data[Row No, col No ]
                //
                if (list_data[4, dbActive] == "True")
                {



                    if (nozzle.power_string[4] == "00")
                    {
                        this.check_for_power(nozzle, 4);

                        this.nozzle_power_on(nozzle, Port[i], 4);
                    }
                    else
                    {

                        Port[i].Write("\u0004DQ\u0005");
                        this.delayService.ShortDelay();
                        if (!string.IsNullOrEmpty(nozzle.NozzlePosition[4]))
                        {
                            this.nozzle_status(nozzle, Port[i], 4);
                            this.delayService.ShortDelay();
                            if (nozzle.NozzlePosition[4].Equals("680", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[4].Equals("684", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[4].Equals("65", StringComparison.OrdinalIgnoreCase))
                            {
                                Port[i].Write(string.Concat(this.DataLinkEscape, "1"));
                                this.delayService.ShortDelay();

                            }
                            if (nozzle.NozzlePosition[4].Equals("681", StringComparison.OrdinalIgnoreCase))
                            {


                                this.nozzle_release_now(nozzle, Port[i], 4);


                                this.nozzle_status(nozzle, Port[i], 4);
                            }
                            if (nozzle.NozzlePosition[4].Equals("683", StringComparison.OrdinalIgnoreCase))
                            {



                                this.nozzle_status(nozzle, Port[i], 4);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Catch any other exceptions (if needed)
                MessageBox.Show("An error occurred:5 " + ex.Message);
            }


        }
        private void nozzle6_function(NozzleViewModel nozzle, int i)

        {
            try
            {
                //list_data[Row No, col No ]
                //
                if (list_data[5, dbActive] == "True")
                {



                    if (nozzle.power_string[5] == "00")
                    {
                        this.check_for_power(nozzle, 5);

                        this.nozzle_power_on(nozzle, Port[i], 5);
                    }
                    else
                    {

                        Port[i].Write("\u0004EQ\u0005");
                        this.delayService.ShortDelay();
                        if (!string.IsNullOrEmpty(nozzle.NozzlePosition[5]))
                        {
                            this.nozzle_status(nozzle, Port[i], 5);
                            this.delayService.ShortDelay();
                            if (nozzle.NozzlePosition[5].Equals("680", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[5].Equals("684", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[5].Equals("65", StringComparison.OrdinalIgnoreCase))
                            {
                                Port[i].Write(string.Concat(this.DataLinkEscape, "1"));
                                this.delayService.ShortDelay();

                            }
                            if (nozzle.NozzlePosition[5].Equals("681", StringComparison.OrdinalIgnoreCase))
                            {


                                this.nozzle_release_now(nozzle, Port[i], 5);


                                this.nozzle_status(nozzle, Port[i], 5);
                            }
                            if (nozzle.NozzlePosition[5].Equals("683", StringComparison.OrdinalIgnoreCase))
                            {



                                this.nozzle_status(nozzle, Port[i], 5);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Catch any other exceptions (if needed)
                MessageBox.Show("An error occurred:6 " + ex.Message);
            }


        }

        private void nozzle7_function(NozzleViewModel nozzle, int i)

        {
            try
            {
                //list_data[Row No, col No ]
                //
                if (list_data[6, dbActive] == "True")
                {



                    if (nozzle.power_string[6] == "00")
                    {
                        this.check_for_power(nozzle, 6);

                        this.nozzle_power_on(nozzle, Port[i], 6);
                    }
                    else
                    {

                        Port[i].Write("\u0004FQ\u0005");
                        this.delayService.ShortDelay();
                        if (!string.IsNullOrEmpty(nozzle.NozzlePosition[6]))
                        {
                            this.nozzle_status(nozzle, Port[i], 6);
                            this.delayService.ShortDelay();
                            if (nozzle.NozzlePosition[6].Equals("680", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[6].Equals("684", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[6].Equals("65", StringComparison.OrdinalIgnoreCase))
                            {
                                Port[i].Write(string.Concat(this.DataLinkEscape, "1"));
                                this.delayService.ShortDelay();

                            }
                            if (nozzle.NozzlePosition[6].Equals("681", StringComparison.OrdinalIgnoreCase))
                            {


                                this.nozzle_release_now(nozzle, Port[i], 6);


                                this.nozzle_status(nozzle, Port[i], 6);
                            }
                            if (nozzle.NozzlePosition[6].Equals("683", StringComparison.OrdinalIgnoreCase))
                            {



                                this.nozzle_status(nozzle, Port[i], 6);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Catch any other exceptions (if needed)
                MessageBox.Show("An error occurred:7 " + ex.Message);
            }


        }


        private void nozzle8_function(NozzleViewModel nozzle, int i)

        {
            try
            {
                //list_data[Row No, col No ]
                //
                if (list_data[7, dbActive] == "True")
                {



                    if (nozzle.power_string[7] == "00")
                    {
                        this.check_for_power(nozzle, 7);

                        this.nozzle_power_on(nozzle, Port[i], 7);
                    }
                    else
                    {

                        Port[i].Write("\u0004GQ\u0005");
                        this.delayService.ShortDelay();
                        if (!string.IsNullOrEmpty(nozzle.NozzlePosition[7]))
                        {
                            this.nozzle_status(nozzle, Port[i], 7);
                            this.delayService.ShortDelay();
                            if (nozzle.NozzlePosition[7].Equals("680", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[7].Equals("684", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[7].Equals("65", StringComparison.OrdinalIgnoreCase))
                            {
                                Port[i].Write(string.Concat(this.DataLinkEscape, "1"));
                                this.delayService.ShortDelay();

                            }
                            if (nozzle.NozzlePosition[7].Equals("681", StringComparison.OrdinalIgnoreCase))
                            {


                                this.nozzle_release_now(nozzle, Port[i], 7);


                                this.nozzle_status(nozzle, Port[i], 7);
                            }
                            if (nozzle.NozzlePosition[7].Equals("683", StringComparison.OrdinalIgnoreCase))
                            {



                                this.nozzle_status(nozzle, Port[i], 7);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Catch any other exceptions (if needed)
                MessageBox.Show("An error occurred:8 " + ex.Message);
            }


        }

        private void nozzle9_function(NozzleViewModel nozzle, int i)

        {
            try
            {
                //list_data[Row No, col No ]
                //
                if (list_data[8, dbActive] == "True")
                {



                    if (nozzle.power_string[8] == "00")
                    {
                        this.check_for_power(nozzle, 8);

                        this.nozzle_power_on(nozzle, Port[i], 8);
                    }
                    else
                    {

                        Port[i].Write("\u0004HQ\u0005");
                        this.delayService.ShortDelay();
                        if (!string.IsNullOrEmpty(nozzle.NozzlePosition[8]))
                        {
                            this.nozzle_status(nozzle, Port[i], 8);
                            this.delayService.ShortDelay();
                            if (nozzle.NozzlePosition[8].Equals("680", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[8].Equals("684", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[8].Equals("65", StringComparison.OrdinalIgnoreCase))
                            {
                                Port[i].Write(string.Concat(this.DataLinkEscape, "1"));
                                this.delayService.ShortDelay();

                            }
                            if (nozzle.NozzlePosition[8].Equals("681", StringComparison.OrdinalIgnoreCase))
                            {


                                this.nozzle_release_now(nozzle, Port[i], 8);


                                this.nozzle_status(nozzle, Port[i], 8);
                            }
                            if (nozzle.NozzlePosition[8].Equals("683", StringComparison.OrdinalIgnoreCase))
                            {



                                this.nozzle_status(nozzle, Port[i], 8);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Catch any other exceptions (if needed)
                MessageBox.Show("An error occurred:9 " + ex.Message);
            }


        }


        private void nozzle10_function(NozzleViewModel nozzle, int i)

        {
            try
            {
                //list_data[Row No, col No ]
                //
                if (list_data[9, dbActive] == "True")
                {



                    if (nozzle.power_string[9] == "00")
                    {
                        this.check_for_power(nozzle, 9);

                        this.nozzle_power_on(nozzle, Port[i], 9);
                    }
                    else
                    {

                        Port[i].Write("\u0004IQ\u0005");
                        this.delayService.ShortDelay();
                        if (!string.IsNullOrEmpty(nozzle.NozzlePosition[9]))
                        {
                            this.nozzle_status(nozzle, Port[i], 9);
                            this.delayService.ShortDelay();
                            if (nozzle.NozzlePosition[9].Equals("680", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[9].Equals("684", StringComparison.OrdinalIgnoreCase) || nozzle.NozzlePosition[9].Equals("65", StringComparison.OrdinalIgnoreCase))
                            {
                                Port[i].Write(string.Concat(this.DataLinkEscape, "1"));
                                this.delayService.ShortDelay();

                            }
                            if (nozzle.NozzlePosition[9].Equals("681", StringComparison.OrdinalIgnoreCase))
                            {


                                this.nozzle_release_now(nozzle, Port[i], 9);


                                this.nozzle_status(nozzle, Port[i], 9);
                            }
                            if (nozzle.NozzlePosition[9].Equals("683", StringComparison.OrdinalIgnoreCase))
                            {



                                this.nozzle_status(nozzle, Port[i], 9);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Catch any other exceptions (if needed)
                MessageBox.Show("An error occurred:10 " + ex.Message);
            }


        }





        private void nozzle_release_now(NozzleViewModel nozzle, SerialPort serialPort, int d_index)
        {
            try
            {
                serialPort.Write(string.Concat(this.DataLinkEscape, "1"));
                this.delayService.ShortDelay();
                this.noz_rel_msg(nozzle, d_index);
                serialPort.Write(string.Concat(this.EndofTransmission, Convert.ToChar((int)nozzle.NozzleAddress[d_index]), "A", this.Enquiry));
                this.delayService.ShortDelay();
                serialPort.Write(nozzle.line[d_index, 0]);
                this.delayService.ShortDelay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nozzle not realeae");
            }
        }

        private void noz_rel_msg(NozzleViewModel nozzle, int d_index)
        {

            var aav = checked((byte)Convert.ToChar(list_data[d_index, dbPrice].Substring(0, 1)));
            nozzle.noz_price[d_index, 1] = checked((byte)Convert.ToChar(list_data[d_index, dbPrice].Substring(0, 1)));
            nozzle.noz_price[d_index, 2] = checked((byte)Convert.ToChar(list_data[d_index, dbPrice].Substring(1, 1)));
            nozzle.noz_price[d_index, 3] = checked((byte)Convert.ToChar(list_data[d_index, dbPrice].Substring(2, 1)));
            nozzle.noz_price[d_index, 4] = checked((byte)Convert.ToChar(list_data[d_index, dbPrice].Substring(3, 1)));
            nozzle.noz_price[d_index, 5] = checked((byte)Convert.ToChar(list_data[d_index, dbPrice].Substring(4, 1)));

            this.bcc = checked((byte)(nozzle.NozzleAddress[d_index] ^ 65));
            this.bcc = checked((byte)(this.bcc ^ 50));
            this.bcc = checked((byte)(this.bcc ^ 50));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 49));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 50));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc ^= nozzle.noz_price[d_index, 1];
            this.bcc ^= nozzle.noz_price[d_index, 2];
            this.bcc ^= nozzle.noz_price[d_index, 3];
            this.bcc ^= nozzle.noz_price[d_index, 4];
            this.bcc ^= nozzle.noz_price[d_index, 5];
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 3));

            nozzle.line[d_index, 1] = string.Concat(this.StartOfText, Convert.ToChar(nozzle.NozzleAddress[d_index]), "A2201");
            nozzle.line[d_index, 2] = "00000000";
            string[,] strArrays = nozzle.line;
            string[] str = new string[] { "20", Convert.ToChar((int)nozzle.noz_price[d_index, 1]).ToString(), Convert.ToChar((int)nozzle.noz_price[d_index, 2]).ToString(), Convert.ToChar((int)nozzle.noz_price[d_index, 3]).ToString(), Convert.ToChar((int)nozzle.noz_price[d_index, 4]).ToString(), Convert.ToChar((int)nozzle.noz_price[d_index, 5]).ToString() };
            strArrays[d_index, 3] = string.Concat(str);
            nozzle.line[d_index, 4] = "00000000";
            nozzle.line[d_index, 5] = "00000000";
            nozzle.line[d_index, 6] = "00000000";
            nozzle.line[d_index, 7] = "00000000";
            nozzle.line[d_index, 8] = "00000000";
            nozzle.line[d_index, 9] = "00000000";
            nozzle.line[d_index, 10] = "00000000";
            nozzle.line[d_index, 11] = string.Concat(this.EndOfText, Convert.ToChar((int)this.bcc)).ToString();
            var strArrays1 = nozzle.line;
            str = new string[] { nozzle.line[d_index, 1], nozzle.line[d_index, 2], nozzle.line[d_index, 3], nozzle.line[d_index, 4], nozzle.line[d_index, 5], nozzle.line[d_index, 6], nozzle.line[d_index, 7], nozzle.line[d_index, 8], nozzle.line[d_index, 9], nozzle.line[d_index, 10], nozzle.line[d_index, 11] };
            strArrays1[d_index, 0] = string.Concat(str);
        }

        private void nozzle_status(NozzleViewModel nozzle, SerialPort serialPort, int Machine)
        {
            try
            {

                // \u0004AA\u0005
                serialPort.Write(string.Concat(this.EndofTransmission, Convert.ToChar(nozzle.NozzleAddress[Machine]), "A", this.Enquiry));
                this.delayService.ShortDelay();
                // \0002AA15\u0003\a
                serialPort.Write(string.Concat(this.StartOfText, Convert.ToChar(nozzle.NozzleAddress[Machine]), "A15", this.EndOfText, Convert.ToChar(nozzle.BccAddress[Machine])));
                this.delayService.ShortDelay();
                // \u0004AQ\u0005
                serialPort.Write(string.Concat(this.EndofTransmission, Convert.ToChar(nozzle.NozzleAddress[Machine]), "Q", this.Enquiry));
                this.delayService.ShortDelay();
                // \u00101
                serialPort.Write(string.Concat(this.DataLinkEscape, "1"));
                this.delayService.ShortDelay();
            }
            catch (Exception ex)
            {
            }
        }

        private void nozzle_power_on(NozzleViewModel nozzle, SerialPort serialPort, int d_index)
        {

            serialPort.Write("\u00101");
            this.delayService.ShortDelay();
            this.delayService.ShortDelay();
            serialPort.Write(string.Concat("\u0004", Convert.ToString(Convert.ToChar((int)nozzle.NozzleAddress[d_index])), "A\u0005"));
            this.delayService.ShortDelay();
            this.delayService.ShortDelay();

            SerialPort serialPort1 = serialPort;
            string[] str = new string[] { "\u0002", Convert.ToString(Convert.ToChar((int)nozzle.NozzleAddress[d_index])), "A00", Convert.ToString(Convert.ToChar((int)nozzle.msg_byte[d_index, 1])), Convert.ToString(Convert.ToChar((int)nozzle.msg_byte[d_index, 2])), "1   \u0003", Convert.ToString(Convert.ToChar((int)this.bcc)) };
            serialPort.Write(string.Concat(str));
            this.delayService.ShortDelay();
            this.delayService.ShortDelay();
            serialPort.Write(string.Concat("\u0004", Convert.ToString(Convert.ToChar((int)nozzle.NozzleAddress[d_index])), "A\u0005"));
            this.delayService.ShortDelay();
            this.delayService.ShortDelay();
            serialPort.Write(string.Concat("\u0002", Convert.ToString(Convert.ToChar((int)nozzle.NozzleAddress[d_index])), "A15\u0003\u0006"));
            this.delayService.ShortDelay();
            this.delayService.ShortDelay();
            serialPort.Write(string.Concat("\u0004", Convert.ToString(Convert.ToChar((int)nozzle.NozzleAddress[d_index])), "Q\u0005"));
            this.delayService.ShortDelay();
            this.delayService.ShortDelay();
            serialPort.Write("\u00101");
            this.delayService.ShortDelay();
            this.delayService.ShortDelay();

        }


        private void check_for_power(NozzleViewModel nozzle, int d_index)
        {
            double add_res = 0.0;
            string addition;
            string unpack;



            nozzle.bytcommand[d_index, 1] = Microsoft.VisualBasic.CompilerServices.Conversions.ToByte(string.Concat("&H", nozzle.power_msg[d_index].Substring(5, 2)));
            nozzle.bytcommand[d_index, 2] = Microsoft.VisualBasic.CompilerServices.Conversions.ToByte(string.Concat("&H", nozzle.power_msg[d_index].Substring(7, 2)));
            nozzle.bytcommand[d_index, 3] = Microsoft.VisualBasic.CompilerServices.Conversions.ToByte(string.Concat("&H", nozzle.power_msg[d_index].Substring(9, 2)));
            nozzle.bytcommand[d_index, 4] = Microsoft.VisualBasic.CompilerServices.Conversions.ToByte(string.Concat("&H", nozzle.power_msg[d_index].Substring(11, 2)));
            nozzle.bytcommand[d_index, 5] = Microsoft.VisualBasic.CompilerServices.Conversions.ToByte(string.Concat("&H", nozzle.power_msg[d_index].Substring(13, 2)));
            nozzle.bytcommand[d_index, 6] = Microsoft.VisualBasic.CompilerServices.Conversions.ToByte(string.Concat("&H", nozzle.power_msg[d_index].Substring(15, 2)));
            byte[] numArray = new byte[] { nozzle.bytcommand[d_index, 1], nozzle.bytcommand[d_index, 2], nozzle.bytcommand[d_index, 3], nozzle.bytcommand[d_index, 4], nozzle.bytcommand[d_index, 5], nozzle.bytcommand[d_index, 6] };
            string checksum = calcSum(numArray);

            if (checksum.Length == 3)
            {
                hi_byte = (long)Microsoft.VisualBasic.CompilerServices.Conversions.ToByte(string.Concat("&H", checksum.Substring(0, 1)));
                lo_byte = (long)Microsoft.VisualBasic.CompilerServices.Conversions.ToByte(string.Concat("&H", checksum.Substring(1, 2)));
                add_res = (double)(checked(this.hi_byte + this.lo_byte));
            }
            else if (checksum.Length == 4)
            {
                this.hi_byte = (long)Microsoft.VisualBasic.CompilerServices.Conversions.ToByte(string.Concat("&H", checksum.Substring(0, 2)));
                this.lo_byte = (long)Microsoft.VisualBasic.CompilerServices.Conversions.ToByte(string.Concat("&H", checksum.Substring(2, 2)));
                add_res = (double)(checked(this.hi_byte + this.lo_byte));
            }
            addition = Microsoft.VisualBasic.Conversion.Hex(add_res);
            if (addition.Length == 2)
            {
                unpack = string.Concat(Microsoft.VisualBasic.Conversion.Hex((int)Convert.ToChar(addition.Substring(1, 1))), Microsoft.VisualBasic.Conversion.Hex((int)(Convert.ToChar(addition.Substring(0, 1)))));
                nozzle.msg_byte[d_index, 2] = checked((byte)Convert.ToChar(addition.Substring(1, 1)));
                nozzle.msg_byte[d_index, 1] = checked((byte)Convert.ToChar(addition.Substring(0, 1)));
            }
            else if (addition.Length == 3)
            {
                unpack = string.Concat(Microsoft.VisualBasic.Conversion.Hex((int)Convert.ToChar(addition.Substring(2, 1))), Microsoft.VisualBasic.Conversion.Hex((int)(Convert.ToChar(addition.Substring(1, 1)))));
                nozzle.msg_byte[d_index, 2] = checked((byte)Convert.ToChar(addition.Substring(2, 1)));
                nozzle.msg_byte[d_index, 1] = checked((byte)Convert.ToChar(addition.Substring(1, 1)));
            }
            this.msg_making(nozzle, d_index);
            nozzle.power_string[d_index] = "";
        }

        private string calcSum(byte[] args)
        {
            long CRC;
            long HB1;
            long LB1;
            long[] CRCT = new long[256];
            string[] str = new string[] { Convert.ToString(Convert.ToChar((int)args[0])), Convert.ToString(Convert.ToChar((int)args[1])), Convert.ToString(Convert.ToChar((int)args[2])), Convert.ToString(Convert.ToChar((int)args[3])), Convert.ToString(Convert.ToChar((int)args[4])), Convert.ToString(Convert.ToChar((int)args[5])) };
            string DataCRC1 = string.Concat(str);
            int i = 0;
            do
            {
                CRC = (long)i;
                int J = 1;
                do
                {
                    CRC = ((CRC & (long)1) != (long)1 ? checked((long)Math.Round(Math.Truncate((double)CRC / 2))) : checked((long)Math.Round(Math.Truncate((double)CRC / 2))) ^ (long)33800);
                    J = checked(J + 1);
                }
                while (J <= 8);
                CRCT[i] = CRC;
                i = checked(i + 1);
            }
            while (i <= 255);
            CRC = (long)0;
            int num = DataCRC1.Length;
            for (i = 0; i < num; i = checked(i + 1))
            {
                HB1 = checked((long)Math.Round(Math.Truncate((double)CRC / 256)));
                LB1 = checked(CRC - checked((long)256 * HB1));
                CRC = CRCT[checked((int)(LB1 ^ (long)Convert.ToChar(DataCRC1.Substring(i, 1))))] ^ HB1;
            }
            HB1 = checked((long)Math.Round(Math.Truncate((double)CRC / 256)));
            LB1 = checked(CRC - checked((long)256 * HB1));
            string calcSum = string.Concat(Convert.ToInt32(LB1).ToString("X"), Convert.ToInt32(HB1).ToString("X"));
            return calcSum;
        }

        private void Active_Nozzel_Click(object sender, EventArgs e)
        {
            // mein ne 1 hi form ko use krke enko seprae kya ha essi lye seting form use kiya ha 
            Setting_password setting_password_form = new Setting_password();
            setting_password_form.Show();
        }

        private void msg_making(NozzleViewModel nozzle, int d_index)
        {
            this.bcc = checked((byte)(nozzle.NozzleAddress[d_index] ^ 65));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc = checked((byte)(this.bcc ^ 48));
            this.bcc ^= nozzle.msg_byte[d_index, 1];
            this.bcc ^= nozzle.msg_byte[d_index, 2];
            this.bcc = checked((byte)(this.bcc ^ 49));
            this.bcc = checked((byte)(this.bcc ^ 32));
            this.bcc = checked((byte)(this.bcc ^ 32));
            this.bcc = checked((byte)(this.bcc ^ 32));
            this.bcc = checked((byte)(this.bcc ^ 3));
        }


        public void DoUpdate(object sender, EventArgs e)

        {
            StringBuilder asciihexOUT = new StringBuilder();
            //string str = readBuffer;
            byte[] byteArray = Encoding.ASCII.GetBytes(readBuffer);
            int length = checked(checked((int)byteArray.Length) - 1);
            for (int i = 0; i <= length; i = checked(i + 1))
            {
                string cal = string.Concat(byteArray[i].ToString("X"), "");
                asciihexOUT.Append(string.Concat(byteArray[i].ToString("X"), ""));  // Convert byte to hexadecimal string
            }
            string ascii_data = asciihexOUT.ToString();

            if (!string.IsNullOrEmpty(ascii_data))
            {
                string n_id = ascii_data.Substring(0, 1);
                if (n_id.Equals("2", StringComparison.OrdinalIgnoreCase))
                {
                    if (this.readBuffer.Length >= 9)
                    {
                        string nozzleId = this.readBuffer.Substring(1, 1);

                        string get_array_index = nozzleId + "Q68";

                        (int row, int col) index = FindElementIndex(list_data, get_array_index);
                        try
                        {
                            sd.BufferData[index.row] = this.readBuffer;
                            this.data_setting(sd, ascii_data, index.row, n_id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }



                    }
                }
            }

        }


        private void data_setting(NozzleViewModel nozzle, string ascii_data, int FirstMachine, string n_id)
        {
            if (n_id.Equals("2", StringComparison.OrdinalIgnoreCase))
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (nozzle != null && !string.IsNullOrEmpty(nozzle.BufferData[FirstMachine]))
                {
                    if (nozzle.BufferData[FirstMachine].Length >= 28)
                    {
                        this.n_id2 = nozzle.BufferData[FirstMachine].Substring(1, 5);
                        this.dispensing_status(nozzle, FirstMachine);
                    }

                    else if (nozzle.BufferData[FirstMachine].Length == 11)
                    {
                        string nozzleId = nozzle.BufferData[FirstMachine].Substring(1, 2);

                        string get_array_index = nozzleId + "68";

                        (int row, int col) index = FindElementIndex(list_data, get_array_index);

                        sd.power_msg[index.row] = ascii_data;
                        sd.power_string[index.row] = nozzle.BufferData[index.row].Substring(3, 2);

                        // if (nozzleId == "@Q")
                        // {
                        //     sd.power_msg[0] = ascii_data;
                        //     sd.power_string[0] = nozzle.BufferData[0].Substring(3, 2);
                        // }
                        //else if (nozzleId == "AQ")
                        // {
                        //     sd.power_msg[1] = ascii_data;
                        //     sd.power_string[1] = nozzle.BufferData[1].Substring(3, 2);
                        // }
                    }
                }





            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dispensing_status(NozzleViewModel nozzle, int index)
        {

            string t = nozzle.BufferData[index].Substring(1, 4);

            if (t.Equals("@Q68", StringComparison.OrdinalIgnoreCase) && CheckString(nozzle.BufferData[index]) == true)
            {
                this.nozzle1_process(nozzle, index);

            }
            else if (t.Equals("AQ68", StringComparison.OrdinalIgnoreCase) && CheckString(nozzle.BufferData[index]) == true)
            {
                this.nozzle2_process(nozzle, index);
            }
            else if (t.Equals("BQ68", StringComparison.OrdinalIgnoreCase) && CheckString(nozzle.BufferData[index]) == true)
            {
                this.nozzle3_process(nozzle, index);
            }
            else if (t.Equals("CQ68", StringComparison.OrdinalIgnoreCase) && CheckString(nozzle.BufferData[index]) == true)
            {
                this.nozzle4_process(nozzle, index);
            }
            else if (t.Equals("DQ68", StringComparison.OrdinalIgnoreCase) && CheckString(nozzle.BufferData[index]) == true)
            {
                this.nozzle5_process(nozzle, index);
            }
            else if (t.Equals("EQ68", StringComparison.OrdinalIgnoreCase) && CheckString(nozzle.BufferData[index]) == true)
            {
                this.nozzle6_process(nozzle, index);
            }
            else if (t.Equals("FQ68", StringComparison.OrdinalIgnoreCase) && CheckString(nozzle.BufferData[index]) == true)
            {
                this.nozzle7_process(nozzle, index);
            }
            else if (t.Equals("GQ68", StringComparison.OrdinalIgnoreCase) && CheckString(nozzle.BufferData[index]) == true)
            {
                this.nozzle8_process(nozzle, index);
            }
            else if (t.Equals("HQ68", StringComparison.OrdinalIgnoreCase) && CheckString(nozzle.BufferData[index]) == true)
            {
                this.nozzle9_process(nozzle, index);
            }
            else if (t.Equals("IQ68", StringComparison.OrdinalIgnoreCase) && CheckString(nozzle.BufferData[index]) == true)
            {
                this.nozzle10_process(nozzle, index);
            }


        }

        private void printslip_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            Environment.Exit(0);
        }


        private void SERIALPORTDISPLAY_Click(object sender, EventArgs e)
        {
            // mein ne 1 hi form ko use krke enko seprae kya ha essi lye seting form use kiya ha 
            Setting_password setting_password_form = new Setting_password();
            setting_password_form.Show();
        }

        private void nozzle1_process(NozzleViewModel nozzle, int index)
        {
            if (nozzle != null)
            {

                nozzle.NozzlePosition[index] = nozzle.BufferData[index].Substring(3, 3);
                //         liter
                string liter1 = nozzle.BufferData[index].Substring(9, 3);
                string liter2 = nozzle.BufferData[index].Substring(12, 2);
                nozzle.Liter = liter1 + "." + liter2;
                nozzle.Liter = nozzle.Liter.TrimStart('0');
                //         Rate

                //         Cash

                string Cash1 = nozzle.BufferData[index].Substring(22, 6);
                string Cash2 = nozzle.BufferData[index].Substring(28, 1);

                nozzle.Cash1 = Cash1 + "." + Cash2;
                nozzle.Cash1 = nozzle.Cash1.TrimStart('0');
                //         Liter



                if (nozzle.NozzlePosition[index].Equals("680"))
                {
                    textn1.Text = "NOZZLE";
                    textn1.BackColor = Color.Blue;
                    pictureBox1.Image = new Bitmap(System.IO.Path.Combine(img_path, "rest.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    if (counter[index])
                    {
                        float litervalve = float.Parse(nozzle.Liter);
                        float cashvalve = float.Parse(nozzle.Cash1);
                        liter[1] += litervalve;

                        summision(cashvalve, litervalve, raten1.Text, noiz_noz1, "1", cus_noz_tank1);
                        counter[index] = false;
                    }


                }
                else if (nozzle.NozzlePosition[index].Equals("681"))
                {
                    textn1.Text = "Ready";
                    textn1.BackColor = Color.Green;
                    cashn1.Text = nozzle.Cash1;
                    litern1.Text = nozzle.Liter;
                    raten1.Text = nozzle.NozzleRate[index];
                    pictureBox1.Image = new Bitmap(System.IO.Path.Combine(img_path, "nozzelactive.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }


                }
                else if (nozzle.NozzlePosition[index].Equals("683"))
                {
                    textn1.Text = "Filling";
                    textn1.BackColor = Color.Purple;
                    pictureBox1.Image = new Bitmap(System.IO.Path.Combine(img_path, "Filling.jpg"));

                    cashn1.Text = nozzle.Cash1;
                    litern1.Text = nozzle.Liter;
                    raten1.Text = nozzle.NozzleRate[index];
                    one_time_cal = true;
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();

                    }
                    counter[index] = true;
                }
                else if ((nozzle.NozzlePosition[index].Equals("684")) && one_time_cal)
                {
                    one_time_cal = false;
                    textn1.Text = "SET BACK";
                    textn1.BackColor = Color.Black;

                    float litervalve = float.Parse(nozzle.Liter);
                    float cashvalve = float.Parse(nozzle.Cash1);
                    liter[1] += litervalve;

                    summision(cashvalve, litervalve, raten1.Text, noiz_noz1, "1", cus_noz_tank1);

                    litern1.Text = nozzle.Liter;

                    totaln1.Text = liter[1].ToString();
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = false;
                }

                textBox1.Text = nozzle.BufferData[index];
                float datawriteliter = float.Parse(litern1.Text) * 100;
                float datawritecash = float.Parse(cashn1.Text) * 100;
                float datawriterate = float.Parse(raten1.Text) * 100;


                //string dataToSend = ","+","+$"{raten1.Text},{cashn1.Text},{litern1.Text}";
                string dataToSend = "0,0,       " + datawriteliter.ToString() + ",     " + datawritecash.ToString() + ",        000" + datawriterate.ToString() + ", OK";
                if (writePort[index].IsOpen && serial_write_data_display_status[index] == true)
                {
                    writebox1.Text = dataToSend;
                    writePort[index].WriteLine(dataToSend);
                }

                writePort[index].Close();
            }
        }

        private void nozzle2_process(NozzleViewModel nozzle, int index)
        {
            if (nozzle != null)
            {

                nozzle.NozzlePosition[index] = nozzle.BufferData[index].Substring(3, 3);
                //         liter
                string liter1 = nozzle.BufferData[index].Substring(9, 3);
                string liter2 = nozzle.BufferData[index].Substring(12, 2);
                nozzle.Liter = liter1 + "." + liter2;
                nozzle.Liter = nozzle.Liter.TrimStart('0');
                //         Rate

                //         Cash

                string Cash1 = nozzle.BufferData[index].Substring(22, 6);
                string Cash2 = nozzle.BufferData[index].Substring(28, 1);
                nozzle.Cash1 = Cash1 + "." + Cash2;
                nozzle.Cash1 = nozzle.Cash1.TrimStart('0');
                //         Liter



                if (nozzle.NozzlePosition[index].Equals("680"))
                {
                    textn2.Text = "NOZZLE";
                    textn2.BackColor = Color.Blue;
                    pictureBox2.Image = new Bitmap(System.IO.Path.Combine(img_path, "rest.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    if (counter[index])
                    {
                        float litervalve = float.Parse(nozzle.Liter);
                        float cashvalve = float.Parse(nozzle.Cash1);
                        liter[2] += litervalve;

                        summision(cashvalve, litervalve, raten2.Text, noiz_noz2, "2", cus_noz_tank2);
                        counter[index] = false;
                    }
                }
                else if (nozzle.NozzlePosition[index].Equals("681"))
                {
                    textn2.Text = "Ready";
                    textn2.BackColor = Color.Green;
                    cashn2.Text = nozzle.Cash1;
                    litern2.Text = nozzle.Liter;
                    raten2.Text = nozzle.NozzleRate[index];
                    pictureBox2.Image = new Bitmap(System.IO.Path.Combine(img_path, "nozzelactive.jpg"));

                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }

                }
                else if (nozzle.NozzlePosition[index].Equals("683"))
                {
                    textn2.Text = "Filling";
                    textn2.BackColor = Color.Purple;
                    pictureBox2.Image = new Bitmap(System.IO.Path.Combine(img_path, "Filling.jpg"));

                    cashn2.Text = nozzle.Cash1;
                    litern2.Text = nozzle.Liter;
                    raten2.Text = nozzle.NozzleRate[index];
                    one_time_cal = true;
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = true;

                }
                else if ((nozzle.NozzlePosition[index].Equals("684")) && one_time_cal)
                {
                    one_time_cal = false;
                    textn2.Text = "SET BACK";
                    textn2.BackColor = Color.Black;
                    litern2.Text = nozzle.Liter;

                    float litervalve = float.Parse(nozzle.Liter);
                    float cashvalve = float.Parse(nozzle.Cash1);
                    liter[2] += litervalve;
                    summision(cashvalve, litervalve, raten2.Text, noiz_noz2, "2", cus_noz_tank2);
                    totaln2.Text = liter[2].ToString();
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = false;

                }

                textBox2.Text = nozzle.BufferData[index];
                float datawriteliter = float.Parse(litern2.Text) * 100;
                float datawritecash = float.Parse(cashn2.Text) * 100;
                float datawriterate = float.Parse(raten2.Text) * 100;


                //string dataToSend = ","+","+$"{raten1.Text},{cashn1.Text},{litern1.Text}";
                string dataToSend = "0,0,       " + datawriteliter.ToString() + ",     " + datawritecash.ToString() + ",        000" + datawriterate.ToString() + ", OK";
                if (writePort[index].IsOpen && serial_write_data_display_status[index] == true)
                {
                    writebox2.Text = dataToSend;
                    writePort[index].WriteLine(dataToSend);
                }

                writePort[index].Close();
            }
        }

        private void nozzle3_process(NozzleViewModel nozzle, int index)
        {
            if (nozzle != null)
            {

                nozzle.NozzlePosition[index] = nozzle.BufferData[index].Substring(3, 3);
                //         liter
                string liter1 = nozzle.BufferData[index].Substring(9, 3);
                string liter2 = nozzle.BufferData[index].Substring(12, 2);
                nozzle.Liter = liter1 + "." + liter2;
                nozzle.Liter = nozzle.Liter.TrimStart('0');
                //         Rate

                //         Cash

                string Cash1 = nozzle.BufferData[index].Substring(22, 6);
                string Cash2 = nozzle.BufferData[index].Substring(28, 1);
                nozzle.Cash1 = Cash1 + "." + Cash2;
                nozzle.Cash1 = nozzle.Cash1.TrimStart('0');
                //         Liter



                if (nozzle.NozzlePosition[index].Equals("680"))
                {
                    textn3.Text = "NOZZLE";
                    textn3.BackColor = Color.Blue;
                    pictureBox3.Image = new Bitmap(System.IO.Path.Combine(img_path, "rest.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    if (counter[index])
                    {
                        float litervalve = float.Parse(nozzle.Liter);
                        float cashvalve = float.Parse(nozzle.Cash1);
                        liter[3] += litervalve;

                        summision(cashvalve, litervalve, raten3.Text, noiz_noz3, "3", cus_noz_tank3);
                        counter[index] = false;
                    }
                }
                else if (nozzle.NozzlePosition[index].Equals("681"))
                {
                    textn3.Text = "Ready";
                    textn3.BackColor = Color.Green;
                    cashn3.Text = nozzle.Cash1;
                    litern3.Text = nozzle.Liter;
                    raten3.Text = nozzle.NozzleRate[index];
                    pictureBox3.Image = new Bitmap(System.IO.Path.Combine(img_path, "nozzelactive.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }



                }
                else if (nozzle.NozzlePosition[index].Equals("683"))
                {
                    textn3.Text = "Filling";
                    textn3.BackColor = Color.Purple;
                    pictureBox3.Image = new Bitmap(System.IO.Path.Combine(img_path, "Filling.jpg"));

                    cashn3.Text = nozzle.Cash1;
                    litern3.Text = nozzle.Liter;
                    raten3.Text = nozzle.NozzleRate[index];
                    one_time_cal = true;
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = true;
                    //lbl2Image.Image = Image.FromFile(string.Concat(this.CurrentDirectoryPath, "\\Images\\003.jpg"));
                }
                else if ((nozzle.NozzlePosition[index].Equals("684")) && one_time_cal)
                {
                    one_time_cal = false;
                    textn3.Text = "SET BACK";
                    textn3.BackColor = Color.Black;

                    float litervalve = float.Parse(nozzle.Liter);
                    float cashvalve = float.Parse(nozzle.Cash1);
                    liter[3] += litervalve;
                    summision(cashvalve, litervalve, raten3.Text, noiz_noz3, "3", cus_noz_tank3);
                    totaln3.Text = liter[3].ToString();
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = false;
                }

                textBox3.Text = nozzle.BufferData[index];

                float datawriteliter = float.Parse(litern3.Text) * 100;
                float datawritecash = float.Parse(cashn3.Text) * 100;
                float datawriterate = float.Parse(raten3.Text) * 100;


                //string dataToSend = ","+","+$"{raten1.Text},{cashn1.Text},{litern1.Text}";
                string dataToSend = "0,0,       " + datawriteliter.ToString() + ",     " + datawritecash.ToString() + ",        000" + datawriterate.ToString() + ", OK";
                if (writePort[index].IsOpen && serial_write_data_display_status[index] == true)
                {
                    writebox3.Text = dataToSend;
                    writePort[index].WriteLine(dataToSend);
                }

                writePort[index].Close();

            }


        }
        private void nozzle4_process(NozzleViewModel nozzle, int index)
        {
            if (nozzle != null)
            {

                nozzle.NozzlePosition[index] = nozzle.BufferData[index].Substring(3, 3);
                //         liter
                string liter1 = nozzle.BufferData[index].Substring(9, 3);
                string liter2 = nozzle.BufferData[index].Substring(12, 2);
                nozzle.Liter = liter1 + "." + liter2;
                nozzle.Liter = nozzle.Liter.TrimStart('0');
                //         Rate

                //         Cash

                string Cash1 = nozzle.BufferData[index].Substring(22, 6);
                string Cash2 = nozzle.BufferData[index].Substring(28, 1);
                nozzle.Cash1 = Cash1 + "." + Cash2;
                nozzle.Cash1 = nozzle.Cash1.TrimStart('0');
                //         Liter



                if (nozzle.NozzlePosition[index].Equals("680"))
                {
                    textn4.Text = "NOZZLE";
                    textn4.BackColor = Color.Blue;
                    pictureBox4.Image = new Bitmap(System.IO.Path.Combine(img_path, "rest.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    if (counter[index])
                    {
                        float litervalve = float.Parse(nozzle.Liter);
                        float cashvalve = float.Parse(nozzle.Cash1);
                        liter[4] += litervalve;

                        summision(cashvalve, litervalve, raten4.Text, noiz_noz4, "4", cus_noz_tank4);
                        counter[index] = false;
                    }
                }
                else if (nozzle.NozzlePosition[index].Equals("681"))
                {
                    textn4.Text = "Ready";
                    textn4.BackColor = Color.Green;
                    cashn4.Text = nozzle.Cash1;
                    litern4.Text = nozzle.Liter;
                    raten4.Text = nozzle.NozzleRate[index];
                    pictureBox4.Image = new Bitmap(System.IO.Path.Combine(img_path, "nozzelactive.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }


                }
                else if (nozzle.NozzlePosition[index].Equals("683"))
                {
                    textn4.Text = "Filling";
                    textn4.BackColor = Color.Purple;
                    pictureBox4.Image = new Bitmap(System.IO.Path.Combine(img_path, "Filling.jpg"));

                    cashn4.Text = nozzle.Cash1;
                    litern4.Text = nozzle.Liter;
                    raten4.Text = nozzle.NozzleRate[index];
                    one_time_cal = true;
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = true;
                    //lbl2Image.Image = Image.FromFile(string.Concat(this.CurrentDirectoryPath, "\\Images\\003.jpg"));
                }
                else if ((nozzle.NozzlePosition[index].Equals("684")) && one_time_cal)
                {
                    one_time_cal = false;
                    textn4.Text = "SET BACK";
                    textn4.BackColor = Color.Black;

                    float litervalve = float.Parse(nozzle.Liter);
                    float cashvalve = float.Parse(nozzle.Cash1);
                    liter[4] += litervalve;
                    summision(cashvalve, litervalve, raten4.Text, noiz_noz4, "4", cus_noz_tank4);
                    totaln4.Text = liter[4].ToString();
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = false;
                }

                textBox4.Text = nozzle.BufferData[index];

                float datawriteliter = float.Parse(litern4.Text) * 100;
                float datawritecash = float.Parse(cashn4.Text) * 100;
                float datawriterate = float.Parse(raten4.Text) * 100;


                //string dataToSend = ","+","+$"{raten1.Text},{cashn1.Text},{litern1.Text}";
                string dataToSend = "0,0,       " + datawriteliter.ToString() + ",     " + datawritecash.ToString() + ",        000" + datawriterate.ToString() + ", OK";
                if (writePort[index].IsOpen && serial_write_data_display_status[index] == true)
                {
                    writebox4.Text = dataToSend;
                    writePort[index].WriteLine(dataToSend);
                }

                writePort[index].Close();




            }
        }
        private void nozzle5_process(NozzleViewModel nozzle, int index)
        {
            if (nozzle != null)
            {

                nozzle.NozzlePosition[index] = nozzle.BufferData[index].Substring(3, 3);
                //         liter
                string liter1 = nozzle.BufferData[index].Substring(9, 3);
                string liter2 = nozzle.BufferData[index].Substring(12, 2);
                nozzle.Liter = liter1 + "." + liter2;
                nozzle.Liter = nozzle.Liter.TrimStart('0');
                //         Rate

                //         Cash

                string Cash1 = nozzle.BufferData[index].Substring(22, 6);
                string Cash2 = nozzle.BufferData[index].Substring(28, 1);
                nozzle.Cash1 = Cash1 + "." + Cash2;
                nozzle.Cash1 = nozzle.Cash1.TrimStart('0');
                //         Liter



                if (nozzle.NozzlePosition[index].Equals("680"))
                {
                    textn5.Text = "NOZZLE";
                    textn5.BackColor = Color.Blue;
                    pictureBox5.Image = new Bitmap(System.IO.Path.Combine(img_path, "rest.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    if (counter[index])
                    {
                        float litervalve = float.Parse(nozzle.Liter);
                        float cashvalve = float.Parse(nozzle.Cash1);
                        liter[5] += litervalve;

                        summision(cashvalve, litervalve, raten5.Text, noiz_noz5, "5", cus_noz_tank5);
                        counter[index] = false;
                    }

                }
                else if (nozzle.NozzlePosition[index].Equals("681"))
                {
                    textn5.Text = "Ready";
                    textn5.BackColor = Color.Green;
                    cashn5.Text = nozzle.Cash1;
                    litern5.Text = nozzle.Liter;
                    raten5.Text = nozzle.NozzleRate[index];
                    pictureBox5.Image = new Bitmap(System.IO.Path.Combine(img_path, "nozzelactive.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }

                }
                else if (nozzle.NozzlePosition[index].Equals("683"))
                {
                    textn5.Text = "Filling";
                    textn5.BackColor = Color.Purple;
                    pictureBox5.Image = new Bitmap(System.IO.Path.Combine(img_path, "Filling.jpg"));

                    cashn5.Text = nozzle.Cash1;
                    litern5.Text = nozzle.Liter;
                    raten5.Text = nozzle.NozzleRate[index];
                    one_time_cal = true;
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = true;
                    //lbl2Image.Image = Image.FromFile(string.Concat(this.CurrentDirectoryPath, "\\Images\\003.jpg"));
                }
                else if ((nozzle.NozzlePosition[index].Equals("684")) && one_time_cal)
                {
                    one_time_cal = false;
                    textn5.Text = "SET BACK";
                    textn5.BackColor = Color.Black;

                    float litervalve = float.Parse(nozzle.Liter);
                    float cashvalve = float.Parse(nozzle.Cash1);
                    liter[5] += litervalve;
                    summision(cashvalve, litervalve, raten5.Text, noiz_noz5, "5", cus_noz_tank5);
                    totaln5.Text = liter[5].ToString();
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = false;
                }

                textBox5.Text = nozzle.BufferData[index];

                float datawriteliter = float.Parse(litern5.Text) * 100;
                float datawritecash = float.Parse(cashn5.Text) * 100;
                float datawriterate = float.Parse(raten5.Text) * 100;


                //string dataToSend = ","+","+$"{raten1.Text},{cashn1.Text},{litern1.Text}";
                string dataToSend = "0,0,       " + datawriteliter.ToString() + ",     " + datawritecash.ToString() + ",        000" + datawriterate.ToString() + ", OK";
                if (writePort[index].IsOpen && serial_write_data_display_status[index] == true)
                {
                    writebox5.Text = dataToSend;
                    writePort[index].WriteLine(dataToSend);
                }

                writePort[index].Close();

            }
        }
        private void nozzle6_process(NozzleViewModel nozzle, int index)
        {
            if (nozzle != null)
            {

                nozzle.NozzlePosition[index] = nozzle.BufferData[index].Substring(3, 3);
                //         liter
                string liter1 = nozzle.BufferData[index].Substring(9, 3);
                string liter2 = nozzle.BufferData[index].Substring(12, 2);
                nozzle.Liter = liter1 + "." + liter2;
                nozzle.Liter = nozzle.Liter.TrimStart('0');
                //         Rate

                //         Cash

                string Cash1 = nozzle.BufferData[index].Substring(22, 6);
                string Cash2 = nozzle.BufferData[index].Substring(28, 1);
                nozzle.Cash1 = Cash1 + "." + Cash2;
                nozzle.Cash1 = nozzle.Cash1.TrimStart('0');
                //         Liter



                if (nozzle.NozzlePosition[index].Equals("680"))
                {
                    textn6.Text = "NOZZLE";
                    textn6.BackColor = Color.Blue;
                    pictureBox6.Image = new Bitmap(System.IO.Path.Combine(img_path, "rest.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    if (counter[index])
                    {
                        float litervalve = float.Parse(nozzle.Liter);
                        float cashvalve = float.Parse(nozzle.Cash1);
                        liter[6] += litervalve;

                        summision(cashvalve, litervalve, raten6.Text, noiz_noz6, "6", cus_noz_tank6);
                        counter[index] = false;
                    }
                }
                else if (nozzle.NozzlePosition[index].Equals("681"))
                {
                    textn6.Text = "Ready";
                    textn6.BackColor = Color.Green;
                    cashn6.Text = nozzle.Cash1;
                    litern6.Text = nozzle.Liter;
                    raten6.Text = nozzle.NozzleRate[index];
                    pictureBox6.Image = new Bitmap(System.IO.Path.Combine(img_path, "nozzelactive.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }


                }
                else if (nozzle.NozzlePosition[index].Equals("683"))
                {
                    textn6.Text = "Filling";
                    textn6.BackColor = Color.Purple;
                    pictureBox6.Image = new Bitmap(System.IO.Path.Combine(img_path, "Filling.jpg"));

                    cashn6.Text = nozzle.Cash1;
                    litern6.Text = nozzle.Liter;
                    raten6.Text = nozzle.NozzleRate[index];
                    one_time_cal = true;
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = true;
                    //lbl2Image.Image = Image.FromFile(string.Concat(this.CurrentDirectoryPath, "\\Images\\003.jpg"));
                }
                else if ((nozzle.NozzlePosition[index].Equals("684")) && one_time_cal)
                {
                    one_time_cal = false;
                    textn6.Text = "SET BACK";
                    textn6.BackColor = Color.Black;

                    float litervalve = float.Parse(nozzle.Liter);
                    float cashvalve = float.Parse(nozzle.Cash1);
                    liter[6] += litervalve;
                    summision(cashvalve, litervalve, raten6.Text, noiz_noz6, "6", cus_noz_tank6);
                    totaln6.Text = liter[6].ToString();
                    // lbl2Image.Image = Image.FromFile(string.Concat(this.CurrentDirectoryPath, "\\Images\\004.jpg"));
                    //SaveSale(nozzle);
                    // lbl2NozzleSale.Text = this.saleService.GetNozzleSaleInCurrentShift(nozzle.PId);
                    //AutoPrintSale(nozzle);
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = false;
                }

                textBox6.Text = nozzle.BufferData[index];

                float datawriteliter = float.Parse(litern6.Text) * 100;
                float datawritecash = float.Parse(cashn6.Text) * 100;
                float datawriterate = float.Parse(raten6.Text) * 100;


                //string dataToSend = ","+","+$"{raten1.Text},{cashn1.Text},{litern1.Text}";
                string dataToSend = "0,0,       " + datawriteliter.ToString() + ",     " + datawritecash.ToString() + ",        000" + datawriterate.ToString() + ", OK";
                if (writePort[index].IsOpen && serial_write_data_display_status[index] == true)
                {
                    writebox6.Text = dataToSend;
                    writePort[index].WriteLine(dataToSend);
                }

                writePort[index].Close();


            }

        }

        private void nozzle7_process(NozzleViewModel nozzle, int index)
        {
            if (nozzle != null)
            {

                nozzle.NozzlePosition[index] = nozzle.BufferData[index].Substring(3, 3);
                //         liter
                string liter1 = nozzle.BufferData[index].Substring(9, 3);
                string liter2 = nozzle.BufferData[index].Substring(12, 2);
                nozzle.Liter = liter1 + "." + liter2;
                nozzle.Liter = nozzle.Liter.TrimStart('0');
                //         Rate

                //         Cash

                string Cash1 = nozzle.BufferData[index].Substring(22, 6);
                string Cash2 = nozzle.BufferData[index].Substring(28, 1);
                nozzle.Cash1 = Cash1 + "." + Cash2;
                nozzle.Cash1 = nozzle.Cash1.TrimStart('0');
                //         Liter



                if (nozzle.NozzlePosition[index].Equals("680"))
                {
                    textn7.Text = "NOZZLE";
                    textn7.BackColor = Color.Blue;
                    pictureBox7.Image = new Bitmap(System.IO.Path.Combine(img_path, "rest.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    if (counter[index])
                    {
                        float litervalve = float.Parse(nozzle.Liter);
                        float cashvalve = float.Parse(nozzle.Cash1);
                        liter[7] += litervalve;

                        summision(cashvalve, litervalve, raten7.Text, noiz_noz7, "7", cus_noz_tank7);
                        counter[index] = false;
                    }
                }
                else if (nozzle.NozzlePosition[index].Equals("681"))
                {
                    textn7.Text = "Ready";
                    textn7.BackColor = Color.Green;
                    cashn7.Text = nozzle.Cash1;
                    litern7.Text = nozzle.Liter;
                    raten7.Text = nozzle.NozzleRate[index];
                    pictureBox7.Image = new Bitmap(System.IO.Path.Combine(img_path, "nozzelactive.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }



                }
                else if (nozzle.NozzlePosition[index].Equals("683"))
                {
                    textn7.Text = "Filling";
                    textn7.BackColor = Color.Purple;
                    pictureBox7.Image = new Bitmap(System.IO.Path.Combine(img_path, "Filling.jpg"));

                    cashn7.Text = nozzle.Cash1;
                    litern7.Text = nozzle.Liter;
                    raten7.Text = nozzle.NozzleRate[index];
                    one_time_cal = true;
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = true;
                }
                else if ((nozzle.NozzlePosition[index].Equals("684")) && one_time_cal)
                {
                    one_time_cal = false;
                    textn7.Text = "SET BACK";
                    textn7.BackColor = Color.Black;

                    float litervalve = float.Parse(nozzle.Liter);
                    float cashvalve = float.Parse(nozzle.Cash1);
                    liter[7] += litervalve;
                    summision(cashvalve, litervalve, raten7.Text, noiz_noz7, "7", cus_noz_tank7);
                    totaln7.Text = liter[7].ToString();
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = false;
                }

                textBox7.Text = nozzle.BufferData[index];

                float datawriteliter = float.Parse(litern7.Text) * 100;
                float datawritecash = float.Parse(cashn7.Text) * 100;
                float datawriterate = float.Parse(raten7.Text) * 100;


                //string dataToSend = ","+","+$"{raten1.Text},{cashn1.Text},{litern1.Text}";
                string dataToSend = "0,0,       " + datawriteliter.ToString() + ",     " + datawritecash.ToString() + ",        000" + datawriterate.ToString() + ", OK";
                if (writePort[index].IsOpen && serial_write_data_display_status[index] == true)
                {
                    writebox7.Text = dataToSend;
                    writePort[index].WriteLine(dataToSend);
                }

                writePort[index].Close();


            }

        }
        private void nozzle8_process(NozzleViewModel nozzle, int index)
        {
            if (nozzle != null)
            {

                nozzle.NozzlePosition[index] = nozzle.BufferData[index].Substring(3, 3);
                //         liter
                string liter1 = nozzle.BufferData[index].Substring(9, 3);
                string liter2 = nozzle.BufferData[index].Substring(12, 2);
                nozzle.Liter = liter1 + "." + liter2;
                nozzle.Liter = nozzle.Liter.TrimStart('0');
                //         Rate

                //        8Cash

                string Cash1 = nozzle.BufferData[index].Substring(22, 6);
                string Cash2 = nozzle.BufferData[index].Substring(28, 1);
                nozzle.Cash1 = Cash1 + "." + Cash2;
                nozzle.Cash1 = nozzle.Cash1.TrimStart('0');
                //         Liter



                if (nozzle.NozzlePosition[index].Equals("680"))
                {
                    textn8.Text = "NOZZLE";
                    textn8.BackColor = Color.Blue;
                    pictureBox8.Image = new Bitmap(System.IO.Path.Combine(img_path, "rest.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    if (counter[index])
                    {
                        float litervalve = float.Parse(nozzle.Liter);
                        float cashvalve = float.Parse(nozzle.Cash1);
                        liter[8] += litervalve;

                        summision(cashvalve, litervalve, raten8.Text, noiz_noz8, "8", cus_noz_tank8);
                        counter[index] = false;
                    }
                }
                else if (nozzle.NozzlePosition[index].Equals("681"))
                {
                    textn8.Text = "Ready";
                    textn8.BackColor = Color.Green;
                    cashn8.Text = nozzle.Cash1;
                    litern8.Text = nozzle.Liter;
                    raten8.Text = nozzle.NozzleRate[index];
                    pictureBox8.Image = new Bitmap(System.IO.Path.Combine(img_path, "nozzelactive.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }


                }
                else if (nozzle.NozzlePosition[index].Equals("683"))
                {
                    textn8.Text = "Filling";
                    textn8.BackColor = Color.Purple;
                    pictureBox8.Image = new Bitmap(System.IO.Path.Combine(img_path, "Filling.jpg"));

                    cashn8.Text = nozzle.Cash1;
                    litern8.Text = nozzle.Liter;
                    raten8.Text = nozzle.NozzleRate[index];
                    one_time_cal = true;
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = true;
                }
                else if ((nozzle.NozzlePosition[index].Equals("684")) && one_time_cal)
                {
                    one_time_cal = false;
                    textn8.Text = "SET BACK";
                    textn8.BackColor = Color.Black;

                    float litervalve = float.Parse(nozzle.Liter);
                    float cashvalve = float.Parse(nozzle.Cash1);
                    liter[8] += litervalve;
                    summision(cashvalve, litervalve, raten8.Text, noiz_noz8, "8", cus_noz_tank8);
                    totaln8.Text = liter[8].ToString();
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = false;
                }

                textBox8.Text = nozzle.BufferData[index];
                float datawriteliter = float.Parse(litern8.Text) * 100;
                float datawritecash = float.Parse(cashn8.Text) * 100;
                float datawriterate = float.Parse(raten8.Text) * 100;


                //string dataToSend = ","+","+$"{raten1.Text},{cashn1.Text},{litern1.Text}";
                string dataToSend = "0,0,       " + datawriteliter.ToString() + ",     " + datawritecash.ToString() + ",        000" + datawriterate.ToString() + ", OK";
                if (writePort[index].IsOpen && serial_write_data_display_status[index] == true)
                {
                    writebox8.Text = dataToSend;
                    writePort[index].WriteLine(dataToSend);
                }

                writePort[index].Close();


            }

        }

        private void nozzle9_process(NozzleViewModel nozzle, int index)
        {
            if (nozzle != null)
            {

                nozzle.NozzlePosition[index] = nozzle.BufferData[index].Substring(3, 3);
                //         liter
                string liter1 = nozzle.BufferData[index].Substring(9, 3);
                string liter2 = nozzle.BufferData[index].Substring(12, 2);
                nozzle.Liter = liter1 + "." + liter2;
                nozzle.Liter = nozzle.Liter.TrimStart('0');
                //         Rate

                //        8Cash

                string Cash1 = nozzle.BufferData[index].Substring(22, 6);
                string Cash2 = nozzle.BufferData[index].Substring(28, 1);
                nozzle.Cash1 = Cash1 + "." + Cash2;
                nozzle.Cash1 = nozzle.Cash1.TrimStart('0');
                //         Liter



                if (nozzle.NozzlePosition[index].Equals("680"))
                {
                    textn9.Text = "NOZZLE";
                    textn9.BackColor = Color.Blue;
                    pictureBox9.Image = new Bitmap(System.IO.Path.Combine(img_path, "rest.jpg"));

                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    if (counter[index])
                    {
                        float litervalve = float.Parse(nozzle.Liter);
                        float cashvalve = float.Parse(nozzle.Cash1);
                        liter[9] += litervalve;

                        summision(cashvalve, litervalve, raten9.Text, noiz_noz9, "9", cus_noz_tank9);
                        counter[index] = false;
                    }
                }
                else if (nozzle.NozzlePosition[index].Equals("681"))
                {
                    textn9.Text = "Ready";
                    textn9.BackColor = Color.Green;
                    cashn9.Text = nozzle.Cash1;
                    litern9.Text = nozzle.Liter;
                    raten9.Text = nozzle.NozzleRate[index];
                    pictureBox9.Image = new Bitmap(System.IO.Path.Combine(img_path, "nozzelactive.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }


                }
                else if (nozzle.NozzlePosition[index].Equals("683"))
                {
                    textn9.Text = "Filling";
                    textn9.BackColor = Color.Purple;
                    pictureBox9.Image = new Bitmap(System.IO.Path.Combine(img_path, "Filling.jpg"));

                    cashn9.Text = nozzle.Cash1;
                    litern9.Text = nozzle.Liter;
                    raten9.Text = nozzle.NozzleRate[index];
                    one_time_cal = true;
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = true;
                }
                else if ((nozzle.NozzlePosition[index].Equals("684")) && one_time_cal)
                {
                    one_time_cal = false;
                    textn9.Text = "SET BACK";
                    textn9.BackColor = Color.Black;

                    float litervalve = float.Parse(nozzle.Liter);
                    float cashvalve = float.Parse(nozzle.Cash1);
                    liter[9] += litervalve;
                    summision(cashvalve, litervalve, raten9.Text, noiz_noz9, "9", cus_noz_tank9);
                    totaln9.Text = liter[9].ToString();
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = false;
                }

                textBox9.Text = nozzle.BufferData[index];


                float datawriteliter = float.Parse(litern9.Text) * 100;
                float datawritecash = float.Parse(cashn9.Text) * 100;
                float datawriterate = float.Parse(raten9.Text) * 100;


                //string dataToSend = ","+","+$"{raten1.Text},{cashn1.Text},{litern1.Text}";
                string dataToSend = "0,0,       " + datawriteliter.ToString() + ",     " + datawritecash.ToString() + ",        000" + datawriterate.ToString() + ", OK";
                if (writePort[index].IsOpen && serial_write_data_display_status[index] == true)
                {
                    writebox9.Text = dataToSend;
                    writePort[index].WriteLine(dataToSend);
                }

                writePort[index].Close();








            }

        }
        private void nozzle10_process(NozzleViewModel nozzle, int index)
        {
            if (nozzle != null)
            {

                nozzle.NozzlePosition[index] = nozzle.BufferData[index].Substring(3, 3);
                //         liter
                string liter1 = nozzle.BufferData[index].Substring(9, 3);
                string liter2 = nozzle.BufferData[index].Substring(12, 2);
                nozzle.Liter = liter1 + "." + liter2;
                nozzle.Liter = nozzle.Liter.TrimStart('0');
                //         Rate

                //        8Cash

                string Cash1 = nozzle.BufferData[index].Substring(22, 6);
                string Cash2 = nozzle.BufferData[index].Substring(28, 1);
                nozzle.Cash1 = Cash1 + "." + Cash2;
                nozzle.Cash1 = nozzle.Cash1.TrimStart('0');
                //         Liter



                if (nozzle.NozzlePosition[index].Equals("680"))
                {
                    textn10.Text = "NOZZLE";
                    textn10.BackColor = Color.Blue;
                    pictureBox10.Image = new Bitmap(System.IO.Path.Combine(img_path, "rest.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    if (counter[index])
                    {
                        float litervalve = float.Parse(nozzle.Liter);
                        float cashvalve = float.Parse(nozzle.Cash1);
                        liter[10] += litervalve;

                        summision(cashvalve, litervalve, raten10.Text, noiz_noz10, "10", cus_noz_tank10);
                        counter[index] = false;
                    }
                }
                else if (nozzle.NozzlePosition[index].Equals("681"))
                {
                    textn10.Text = "Ready";
                    textn10.BackColor = Color.Green;
                    cashn10.Text = nozzle.Cash1;
                    litern10.Text = nozzle.Liter;
                    raten10.Text = nozzle.NozzleRate[index];
                    pictureBox10.Image = new Bitmap(System.IO.Path.Combine(img_path, "nozzelactive.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }


                }
                else if (nozzle.NozzlePosition[index].Equals("683"))
                {
                    textn10.Text = "Filling";
                    textn10.BackColor = Color.Purple;
                    pictureBox10.Image = new Bitmap(System.IO.Path.Combine(img_path, "Filling.jpg"));

                    cashn10.Text = nozzle.Cash1;
                    litern10.Text = nozzle.Liter;
                    raten10.Text = nozzle.NozzleRate[index];
                    one_time_cal = true;
                    //lbl2Image.Image = Image.FromFile(string.Concat(this.CurrentDirectoryPath, "\\Images\\003.jpg"));
                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = true;
                }
                else if ((nozzle.NozzlePosition[index].Equals("684")) && one_time_cal)
                {
                    one_time_cal = false;
                    textn10.Text = "SET BACK";
                    textn10.BackColor = Color.Black;

                    float litervalve = float.Parse(nozzle.Liter);
                    float cashvalve = float.Parse(nozzle.Cash1);
                    liter[10] += litervalve;
                    summision(cashvalve, litervalve, raten10.Text, noiz_noz10, "10", cus_noz_tank10);
                    totaln10.Text = liter[10].ToString();

                    if (serial_write_data_display_status[index] && !writePort[index].IsOpen)
                    {
                        writePort[index].Open();
                    }
                    counter[index] = false;
                }

                textBox10.Text = nozzle.BufferData[index];

                float datawriteliter = float.Parse(litern10.Text) * 100;
                float datawritecash = float.Parse(cashn10.Text) * 100;
                float datawriterate = float.Parse(raten10.Text) * 100;


                //string dataToSend = ","+","+$"{raten1.Text},{cashn1.Text},{litern1.Text}";
                string dataToSend = "0,0,       " + datawriteliter.ToString() + ",     " + datawritecash.ToString() + ",        000" + datawriterate.ToString() + ", OK";
                if (writePort[index].IsOpen && serial_write_data_display_status[index] == true)
                {
                    writebox10.Text = dataToSend;
                    writePort[index].WriteLine(dataToSend);
                }

                writePort[index].Close();



            }

        }
        static bool CheckString(string input)
        {
            // Skip the first three characters
            string substring = input.Substring(3);

            // Check for any alphabetic or special characters
            foreach (char c in substring)
            {
                if (!char.IsDigit(c)) // if the character is not a digit, return false
                {
                    return false;
                }
            }

            return true; // return true if all characters are digits
        }






        private void aggli_shift()
        {

            while (true)
            {
                Thread.Sleep(100);
                try
                {
                    label2.Invoke(new MethodInvoker(
                                 delegate
                                 {
                                     label2.Text = shift_id.ToString();



                                     if (next_shift.confirm_data == true)
                                     {
                                         super_cash_array = 0; super_total_cash.Text = "0";
                                         super_liter_array = 0; super_total_ltr.Text = super_liter_array.ToString();
                                         hobc_cash_array = 0; hobc_total_cash.Text = "0";
                                         hobc_liter_array = 0; hobc_total_ltr.Text = hobc_liter_array.ToString();
                                         diesel_cash_array = 0; diesel_total_cash.Text = "0";
                                         diesel_liter_array = 0; diesel_total_ltr.Text = diesel_liter_array.ToString();
                                         final_cash = 0; final_total_ltr.Text = "0";
                                         final_liter = 0; final_total_cash.Text = "0";
                                         totaln1.Text = "00.0";
                                         totaln2.Text = "00.0";
                                         totaln3.Text = "00.0";
                                         totaln4.Text = "00.0";
                                         totaln5.Text = "00.0";
                                         totaln6.Text = "00.0";
                                         totaln7.Text = "00.0";
                                         totaln8.Text = "00.0";
                                         totaln9.Text = "00.0";
                                         totaln10.Text = "00.0";
                                         totaln11.Text = "00.0";

                                         for (int i = 1; i < 11; i++)
                                         {
                                             liter[i] = 0;
                                         }

                                     }
                                 }));
                    next_shift.confirm_data = false;

                    string jsn_path = File.ReadAllText(@"C:\Users\SC\Documents\Local Machine Fuel Pump Application\ahsn.json");
                    read_write_data obj1 = JsonSerializer.Deserialize<read_write_data>(jsn_path);

                    Setting.shift_safe_password_text = obj1.shift_start;
                    Setting.automation_safe_password_text = obj1.automation;
                    Setting.application_close_password_text = obj1.close;
                    Setting.setting_safe_password_text = obj1.setting;
                }

                catch
                {

                }
            }
        }
        private void arduino_print()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(100);
                    string data1 = Port[6].ReadLine();
                    last_data.Invoke(new MethodInvoker(
                          delegate
                          {
                              last_data.Text = data1;


                          }
                        ));

                    arduino_data = data1.Split(',');

                    if (arduino_data[0] == "1")
                    {
                        int slipid = last_id_get("1", 0);
                        Arduinoprint(cashn1.Text, raten1.Text, litern1.Text, "1", slipid, arduino_data[1]);
                    }
                    else if (arduino_data[0] == "2")
                    {
                        int slipid = last_id_get("2", 0);
                        Arduinoprint(cashn2.Text, raten2.Text, litern2.Text, "2", slipid, arduino_data[1]);

                    }
                    else if (arduino_data[0] == "3")
                    {
                        int slipid = last_id_get("3", 0);
                        Arduinoprint(cashn3.Text, raten3.Text, litern3.Text, "3", slipid, arduino_data[1]);
                    }
                    else if (arduino_data[0] == "4")
                    {
                        int slipid = last_id_get("4", 0);
                        Arduinoprint(cashn4.Text, raten4.Text, litern4.Text, "4", slipid, arduino_data[1]);
                    }
                    else if (arduino_data[0] == "5")
                    {
                        int slipid = last_id_get("5", 0);
                        Arduinoprint(cashn5.Text, raten5.Text, litern5.Text, "5", slipid, arduino_data[1]);
                    }
                    else if (arduino_data[0] == "6")
                    {
                        int slipid = last_id_get("6", 0);
                        Arduinoprint(cashn6.Text, raten6.Text, litern6.Text, "6", slipid, arduino_data[1]);
                    }
                    else if (arduino_data[0] == "7")
                    {
                        int slipid = last_id_get("7", 0);
                        Arduinoprint(cashn7.Text, raten7.Text, litern7.Text, "7", slipid, arduino_data[1]);
                    }
                    else if (arduino_data[0] == "8")
                    {
                        int slipid = last_id_get("8", 0);
                        Arduinoprint(cashn8.Text, raten8.Text, litern8.Text, "8", slipid, arduino_data[1]);
                    }
                    else if (arduino_data[0] == "9")
                    {
                        int slipid = last_id_get("9", 0);
                        Arduinoprint(cashn9.Text, raten9.Text, litern9.Text, "9", slipid, arduino_data[1]);
                    }
                    else if (arduino_data[0] == "10")
                    {
                        int slipid = last_id_get("10", 0);
                        Arduinoprint(cashn10.Text, raten10.Text, litern10.Text, "10", slipid, arduino_data[1]);
                    }


                    else if (arduino_data[0] == "11")
                    {
                        int slipid = last_id_get("11", 0);
                        Arduinoprint(cashn11.Text, raten11.Text, litern11.Text, "11", slipid, arduino_data[1]);
                    }
                    else if (arduino_data[0] == "12")
                    {
                        int slipid = last_id_get("12", 0);
                        Arduinoprint(cashn12.Text, raten12.Text, litern12.Text, "12", slipid, arduino_data[1]);
                    }



                }

                catch { }



            }

        }
        private void super_sum_cash_liter(float x, float y)
        {
            super_cash_array += x;
            super_liter_array += y;
            super_total_cash.Text = super_cash_array.ToString("F2");
            super_total_ltr.Text = super_liter_array.ToString("F2");

            totall(x, y);
        }
        private void diesel_sum_cash_liter(float diesel_cash, float diesel_liter)
        {
            diesel_cash_array += diesel_cash;
            diesel_liter_array += diesel_liter;
            diesel_total_cash.Text = diesel_cash_array.ToString("F2");
            diesel_total_ltr.Text = diesel_liter_array.ToString("F2");
            totall(diesel_cash, diesel_liter);
        }

        private void hobc_sum_cash_liter(float hobc_cash, float hobc_liter)
        {
            hobc_cash_array += hobc_cash;
            hobc_liter_array += hobc_liter;
            hobc_total_cash.Text = hobc_cash_array.ToString("F2");
            hobc_total_ltr.Text = hobc_liter_array.ToString("F2");

            totall(hobc_cash, hobc_liter);
        }

        private void totall(float total_cash, float total_liter)
        {
            final_cash += total_cash;
            final_liter += total_liter;
            final_total_cash.Text = final_cash.ToString("F2");
            final_total_ltr.Text = final_liter.ToString("F2");
        }
        private void auto_Click(object sender, EventArgs e)
        {
            AutomationPassword form = new AutomationPassword();
            form.Show();
        }

        private void setting_Click(object sender, EventArgs e)
        {

            Setting_password setting_password_form = new Setting_password();
            setting_password_form.Show();


        }

        private void readjsondata_Click(object sender, EventArgs e)
        {
            string jsn_path = File.ReadAllText(@"C:\Users\SC\Documents\Local Machine Fuel Pump Application\ahsn.json");
            read_write_data obj1 = JsonSerializer.Deserialize<read_write_data>(jsn_path);

            Setting.shift_safe_password_text = obj1.shift_start;
            Setting.automation_safe_password_text = obj1.automation;
            Setting.application_close_password_text = obj1.close;
            Setting.setting_safe_password_text = obj1.setting;




            //a1.Text = obj1.shift_start;
            //a2.Text = obj1.automation;
            //a3.Text = obj1.close;
            //a4.Text = obj1.setting;
            barrr += 10;
            bar1.tank1_value = barrr;
            bar1.change_value_tank1();

            bar2.tank2_value = 30;
            bar2.change_value_tank2();
            //bar3.tank3_value = 130;
            //bar3.change_value_tank3();
        }

        private void printn1_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn1.Text, raten1.Text, litern1.Text, "1");
            printpage.Show();
        }

        private void printn2_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn2.Text, raten2.Text, litern2.Text, "2");
            printpage.Show();
        }



        private void printn3_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn3.Text, raten3.Text, litern3.Text, "3");
            printpage.Show();
        }

        public void shift_on_Click(object sender, EventArgs e)
        {
            Nozzel_connection.Close();
            next_shift form = new next_shift();
            form.Show();





        }



        private void database_history_Click(object sender, EventArgs e)
        {
            database form = new database();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void database_shift_start(double nozzel_liter_value, double nozzel_cash_value, string rate, string nozzel_no, string noz_ctg)
        {

            for (int i = 0; i < 1; i++)
            {
                Nozzel_connection.Open();
                MySqlCommand cmd;
                cmd = Nozzel_connection.CreateCommand();
                cmd.CommandText = "INSERT INTO `nozzel1`(`Nozzel_ID`,`Shift_ID`, `Vehicle_no`, `Price`, `Liter`,`Rate`,`Nozzel_Category`) VALUES (@Nozzel_no,@Shift_no,0,@Price_data,@Liter_data,@rate,@ctg);";

                //cmd.Parameters.AddWithValue("Nozzel_no", nozzel_no);
                cmd.Parameters.AddWithValue("@Nozzel_no", nozzel_no);
                cmd.Parameters.AddWithValue("@Shift_no", shift_id);
                //cmd.Parameters.AddWithValue("@slip", s);
                //cmd.Parameters.AddWithValue("@Vehicle", vehicle_data);
                cmd.Parameters.AddWithValue("@Price_data", nozzel_cash_value);
                cmd.Parameters.AddWithValue("@rate", rate);

                cmd.Parameters.AddWithValue("@Liter_data", nozzel_liter_value);
                cmd.Parameters.AddWithValue("@ctg", noz_ctg);
                cmd.ExecuteNonQuery();
                //This command run and insert the data in databse.
                Nozzel_connection.Close();
                //last_data.Text = lastInsertedID.ToString();


                //cmd.ExecuteNonQuery();    
                //data_insert = false;





            }


        }

        private void printn4_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn4.Text, raten4.Text, litern4.Text, "4");
            printpage.Show();
        }

        private void printn5_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn5.Text, raten5.Text, litern5.Text, "5");
            printpage.Show();
        }

        private void printn6_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn6.Text, raten6.Text, litern6.Text, "6");
            printpage.Show();
        }

        private void printn7_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn7.Text, raten7.Text, litern7.Text, "7");
            printpage.Show();
        }

        private void printn8_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn8.Text, raten8.Text, litern8.Text, "8");
            printpage.Show();
        }

        private void printn9_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn9.Text, raten9.Text, litern9.Text, "9");
            printpage.Show();
        }

        private void printn10_Click(object sender, EventArgs e)
        {
            printslippage printpage = new printslippage(cashn10.Text, raten10.Text, litern10.Text, "10");
            printpage.Show();
        }

        private void super_total_cash_TextChanged(object sender, EventArgs e)
        {

        }


        /// Comport 2 data recieved.





        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close_Form form = new Close_Form();
            form.Show();


        }

        private void cashn1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Tank_Setting_Click(object sender, EventArgs e)
        {
            Tank_Page form = new Tank_Page();
            form.Show();
        }

        private void tank1_super_product_lose(float losing_value)
        {

            float.TryParse(label5.Text, out losing_value_super);

            label5.Invoke(new MethodInvoker(
                         delegate
                         {
                             label5.Text = (losing_value_super - losing_value).ToString();

                         }
                       ));
            Nozzel_connection.Open();
            string query = "UPDATE tank_losing_db SET Super_Tank = @newSection Where ID=4;";
            MySqlCommand cmd = new MySqlCommand(query, Nozzel_connection);
            cmd.Parameters.AddWithValue("@newSection", label5.Text);
            cmd.ExecuteNonQuery();
            Nozzel_connection.Close();

        }
        private void tank2_diesel_product_lose(float losing_value)
        {

            float.TryParse(label6.Text, out losing_value_diesel);
            label6.Invoke(new MethodInvoker(
                         delegate
                         {
                             label6.Text = (losing_value_diesel - losing_value).ToString();

                         }
                       ));
            Nozzel_connection.Open();
            string query = "UPDATE tank_losing_db SET Diesel_Tank = @newSection Where ID=4;";
            MySqlCommand cmd = new MySqlCommand(query, Nozzel_connection);
            cmd.Parameters.AddWithValue("@newSection", label6.Text);
            cmd.ExecuteNonQuery();
            Nozzel_connection.Close();
        }
        private void tank3_hobc_product_lose(float losing_value)
        {







        }

        private string cashprint, rateprint, literprint, nozzleprint, vehicle_number;
        int slipidprint;

        public void Arduinoprint(string cash, string rate, string liter, string nozzel_no, int slipprint_no, string veh_no)
        {
            cashprint = cash;
            literprint = liter;
            rateprint = rate;
            nozzleprint = nozzel_no;
            slipidprint = slipprint_no;
            vehicle_number = veh_no;

            update_vehicle_no_in_db(nozzel_no, veh_no);


            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            printDocument.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            printDocument.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Nozzel1.check_prog(e, cashprint, rateprint, literprint, vehicle_number, nozzleprint, slipidprint);
        }

        public int last_id_get(string noz_id, int slip_id_no_db)
        {

            string connectionString = "Server=localhost;Database=munir_filling;Uid=root;Pwd=";
            string query = "SELECT Slip_ID FROM nozzel1 WHERE Nozzel_ID=@nozzel_id ORDER BY Slip_ID DESC LIMIT 1;"; // Assuming 'id' is the primary key column

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@nozzel_id", noz_id);

            try
            {
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Assuming you have columns named 'column1', 'column2', 'column3', etc.
                        slip_id_no_db = reader.GetInt16("Slip_ID");

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


        public void update_vehicle_no_in_db(string nozzelprint, string veh_no)
        {
            int slip_id = last_id_get(nozzelprint, 0);

            string vehicle_no = veh_no;
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
        }



        public void summision(float cash, float liter, string rate, string send_in_nozzle, string noz_id_db, string cus_tank)
        {
            if (send_in_nozzle == "Super" && cus_tank == "Tank1")
            {
                super_sum_cash_liter(cash, liter);
                database_shift_start(liter, cash, rate, noz_id_db, "Super");
                tank1_super_product_lose(liter);
            }

            else if (send_in_nozzle == "Diesel" && cus_tank == "Tank2")
            {



                diesel_sum_cash_liter(cash, liter);
                database_shift_start(liter, cash, rate, noz_id_db, "Diesel");



                tank2_diesel_product_lose(liter);


            }
            else if (send_in_nozzle == "Hobc" && cus_tank == "Tank3")
            {



                hobc_sum_cash_liter(cash, liter);
                database_shift_start(liter, cash, rate, noz_id_db, "Hobc");



            }
        }



        static (int, int) FindElementIndex(string[,] array, string element)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == element)
                    {
                        return (i, j);
                    }
                }
            }
            return (-1, -1); // Element not found
        }





    }


}

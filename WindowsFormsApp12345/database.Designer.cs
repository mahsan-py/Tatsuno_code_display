namespace WindowsFormsApp12345
{
    partial class database
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(database));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicle_data = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shift_data = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.slip_data = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.print_shift_report = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.Shift_slip = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.paginationvalue = new System.Windows.Forms.TextBox();
            this.DateTimeShiftReport = new System.Windows.Forms.Button();
            this.date_search = new System.Windows.Forms.Button();
            this.paginationsetup = new System.Windows.Forms.Button();
            this.delete_data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Nozzel1";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8"),
            resources.GetString("comboBox1.Items9"),
            resources.GetString("comboBox1.Items10")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Name = "label2";
            // 
            // vehicle_data
            // 
            resources.ApplyResources(this.vehicle_data, "vehicle_data");
            this.vehicle_data.Name = "vehicle_data";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // shift_data
            // 
            resources.ApplyResources(this.shift_data, "shift_data");
            this.shift_data.Name = "shift_data";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Name = "label5";
            // 
            // dateTimePicker2
            // 
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // slip_data
            // 
            resources.ApplyResources(this.slip_data, "slip_data");
            this.slip_data.Name = "slip_data";
            this.slip_data.TextChanged += new System.EventHandler(this.slip_data_TextChanged);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.Color.IndianRed;
            this.label15.Name = "label15";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.search, "search");
            this.search.ForeColor = System.Drawing.Color.PaleGreen;
            this.search.Name = "search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // print_shift_report
            // 
            this.print_shift_report.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.print_shift_report, "print_shift_report");
            this.print_shift_report.Name = "print_shift_report";
            this.print_shift_report.UseVisualStyleBackColor = false;
            this.print_shift_report.Click += new System.EventHandler(this.print_shift_report_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GreenYellow;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Shift_slip
            // 
            this.Shift_slip.BackColor = System.Drawing.Color.PaleGoldenrod;
            resources.ApplyResources(this.Shift_slip, "Shift_slip");
            this.Shift_slip.Name = "Shift_slip";
            this.Shift_slip.UseVisualStyleBackColor = false;
            this.Shift_slip.Click += new System.EventHandler(this.Shift_slip_Click);
            // 
            // btnRight
            // 
            resources.ApplyResources(this.btnRight, "btnRight");
            this.btnRight.BackColor = System.Drawing.Color.Green;
            this.btnRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRight.Name = "btnRight";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btn_left
            // 
            resources.ApplyResources(this.btn_left, "btn_left");
            this.btn_left.BackColor = System.Drawing.Color.Green;
            this.btn_left.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_left.Name = "btn_left";
            this.btn_left.UseVisualStyleBackColor = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // paginationvalue
            // 
            resources.ApplyResources(this.paginationvalue, "paginationvalue");
            this.paginationvalue.Name = "paginationvalue";
            // 
            // DateTimeShiftReport
            // 
            this.DateTimeShiftReport.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.DateTimeShiftReport, "DateTimeShiftReport");
            this.DateTimeShiftReport.Name = "DateTimeShiftReport";
            this.DateTimeShiftReport.UseVisualStyleBackColor = false;
            this.DateTimeShiftReport.Click += new System.EventHandler(this.DateTimeShiftReport_Click);
            // 
            // date_search
            // 
            this.date_search.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.date_search, "date_search");
            this.date_search.Name = "date_search";
            this.date_search.UseVisualStyleBackColor = false;
            this.date_search.Click += new System.EventHandler(this.date_search_Click);
            // 
            // paginationsetup
            // 
            resources.ApplyResources(this.paginationsetup, "paginationsetup");
            this.paginationsetup.BackColor = System.Drawing.Color.Green;
            this.paginationsetup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paginationsetup.Name = "paginationsetup";
            this.paginationsetup.UseVisualStyleBackColor = false;
            // 
            // delete_data
            // 
            this.delete_data.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.delete_data, "delete_data");
            this.delete_data.Name = "delete_data";
            this.delete_data.UseVisualStyleBackColor = false;
            this.delete_data.Click += new System.EventHandler(this.delete_data_Click);
            // 
            // database
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete_data);
            this.Controls.Add(this.paginationsetup);
            this.Controls.Add(this.DateTimeShiftReport);
            this.Controls.Add(this.date_search);
            this.Controls.Add(this.paginationvalue);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.Shift_slip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.print_shift_report);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.slip_data);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.shift_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vehicle_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "database";
            this.Load += new System.EventHandler(this.database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vehicle_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shift_data;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox slip_data;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button print_shift_report;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Shift_slip;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox paginationvalue;
        private System.Windows.Forms.Button DateTimeShiftReport;
        private System.Windows.Forms.Button date_search;
        private System.Windows.Forms.Button paginationsetup;
        private System.Windows.Forms.Button delete_data;
    }
}
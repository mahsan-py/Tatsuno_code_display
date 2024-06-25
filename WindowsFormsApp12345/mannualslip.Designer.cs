namespace WindowsFormsApp12345
{
    partial class mannualslip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mannualslip));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ratebox = new System.Windows.Forms.TextBox();
            this.qtybox = new System.Windows.Forms.TextBox();
            this.cashbox = new System.Windows.Forms.TextBox();
            this.mannualprint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.productBox = new System.Windows.Forms.TextBox();
            this.data_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "QTY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cash:";
            // 
            // ratebox
            // 
            this.ratebox.Location = new System.Drawing.Point(165, 126);
            this.ratebox.Name = "ratebox";
            this.ratebox.Size = new System.Drawing.Size(100, 20);
            this.ratebox.TabIndex = 5;
            // 
            // qtybox
            // 
            this.qtybox.Location = new System.Drawing.Point(165, 172);
            this.qtybox.Name = "qtybox";
            this.qtybox.Size = new System.Drawing.Size(100, 20);
            this.qtybox.TabIndex = 6;
            // 
            // cashbox
            // 
            this.cashbox.Location = new System.Drawing.Point(165, 222);
            this.cashbox.Name = "cashbox";
            this.cashbox.Size = new System.Drawing.Size(100, 20);
            this.cashbox.TabIndex = 7;
            // 
            // mannualprint
            // 
            this.mannualprint.Location = new System.Drawing.Point(32, 297);
            this.mannualprint.Name = "mannualprint";
            this.mannualprint.Size = new System.Drawing.Size(75, 23);
            this.mannualprint.TabIndex = 8;
            this.mannualprint.Text = "Print";
            this.mannualprint.UseVisualStyleBackColor = true;
            this.mannualprint.Click += new System.EventHandler(this.mannualprint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // productBox
            // 
            this.productBox.Location = new System.Drawing.Point(165, 37);
            this.productBox.Multiline = true;
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(140, 40);
            this.productBox.TabIndex = 9;
            // 
            // data_add
            // 
            this.data_add.Location = new System.Drawing.Point(165, 297);
            this.data_add.Name = "data_add";
            this.data_add.Size = new System.Drawing.Size(75, 23);
            this.data_add.TabIndex = 11;
            this.data_add.Text = "OK";
            this.data_add.UseVisualStyleBackColor = true;
            this.data_add.Click += new System.EventHandler(this.data_add_Click);
            // 
            // mannualslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 425);
            this.Controls.Add(this.data_add);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.mannualprint);
            this.Controls.Add(this.cashbox);
            this.Controls.Add(this.qtybox);
            this.Controls.Add(this.ratebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mannualslip";
            this.Text = "mannualslip";
            this.Load += new System.EventHandler(this.mannualslip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ratebox;
        private System.Windows.Forms.TextBox qtybox;
        private System.Windows.Forms.TextBox cashbox;
        private System.Windows.Forms.Button mannualprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox productBox;
        private System.Windows.Forms.Button data_add;
    }
}
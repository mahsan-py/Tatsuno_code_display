using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12345
{
    public class NozzleViewModel
    {
        public NozzleViewModel()
        {
            this.noz_price = new byte[10,12];
            this.line = new string[10,14];
            this.bytcommand = new byte[10,7];
            this.msg_byte = new byte[10,3];
            //this.bcc2 = 7;
            //this.BccAddress = 7;
            this.CanGetTotalizer = true;
            this.LastSaleDateTime = DateTime.Now;

            this.NozzlePosition = new string[10];
            this.power_msg = new string[10];
            this.BufferData = new string[10];
            this.power_string = new string[10];
       
            






        }
       
       
        public string[] NozzlePosition { get; set; } // AQ680
        public byte[] NozzleAddress { get; set; }   // BQ680
        public byte[] BccAddress { get; set; }
        public string Liter { get; set; }
      
        public string Cash1 { get; set; }
     
       

        
        public string[] NozzleRate { get; set; }

        
        public byte bcc2 { get; set; }
        public byte[,] noz_price { get; set; }
        public byte[,] bytcommand { get; set; }

        public string[,] line;

        internal readonly object noz2_address;

        public string[] power_msg { get; set; }
        public string[] power_string { get; set; }
        public byte[,] msg_byte { get; set; }
     
     
        public bool IsUpdateTotalizer { get; set; }
        public string[] BufferData { get; set; }
        public int p_str { get; set; }
       
        public bool IsActive { get; set; }
        public bool IsPrinter { get; set; }
        public bool IsAutoPrint { get; set; }
        public double AutoPrintRange { get; set; }
        public bool CanGetTotalizer { get; set; }
        public DateTime LastSaleDateTime { get; set; }

      
       

    }
}

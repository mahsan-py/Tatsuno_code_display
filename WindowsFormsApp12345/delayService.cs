using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApp12345
{
    public class delayService
    {

        public void ShortDelay()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(29);
            //long dmm = 0L;
            //do
            //{
            //    dmm = checked(dmm + (long)1);
            //}
            //while (dmm <= (long)16000000);
            stopwatch.Stop();
            var aa = stopwatch.Elapsed;
        }
    }
}

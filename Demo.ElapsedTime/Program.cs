using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.ElapsedTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startOfApp = DateTime.Now;
            int seconds = 75; // 10;

            // sleep uses milliseconds
            Thread.Sleep(seconds * 1000);

            DateTime endOfApp = DateTime.Now;
            TimeSpan elapsed = endOfApp.Subtract(startOfApp);

            //  string tmpminutes = duration.ToString("0:mm");
            //  string tmpseconds = duration.ToString("0:ss");

            //Console.WriteLine(tmpminutes + " " + tmpseconds);

            // Console.WriteLine("Duration: {0:dd Day(s) hh\\:mm\\:ss} days", duration);



            string tdays = elapsed.Days.ToString("0");
            string thours = elapsed.Hours.ToString("0");
            string tminutes = elapsed.Minutes.ToString("0");
            string tseconds = elapsed.Seconds.ToString("0");

            string elapsed_time =
                                 string.Format(" {0} Days : {1} Hours : {2} Minutes : {3} Seconds ",
                                tdays,
                                thours,
                                tminutes,
                                tseconds
                                )
                              ;
            Console.WriteLine(elapsed_time);
        }
    }
}

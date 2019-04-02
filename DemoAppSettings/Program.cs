using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DemoAppSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict =
             ConfigurationManager.AppSettings.AllKeys
            .Where(key => key.StartsWith("excel_summary_"))
            .ToDictionary(k => k, v => ConfigurationManager.AppSettings[v]);

            Console.ReadLine();
        }
    }
}

using Demo.Collection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PlaceHolderInfo> myPlaceholders = new List<PlaceHolderInfo>();

            PlaceHolderInfo tmp = new PlaceHolderInfo
            {
                data = "2019",
                location = "page1",
                placeholder = "<BYr>"
            };

            myPlaceholders.Add(tmp);

            PlaceHolderInfo tmp2 = new PlaceHolderInfo();
            tmp2.data = "Feb";
            tmp2.location = "page1";
            tmp2.placeholder = "<SMo>";

            myPlaceholders.Add(tmp2);

            foreach (var item in myPlaceholders)
            {
                Console.WriteLine(item.data + " " + item.placeholder);
            }
            Console.ReadLine();

            var place = myPlaceholders.First(p => p.placeholder == "<SMo>").data = "Jan";
            foreach (var item in myPlaceholders)
            {
                Console.WriteLine(item.data + " " + item.placeholder);
            }

            foreach (var item in myPlaceholders)
            {
                item.data = "";
            }
            foreach (var item in myPlaceholders)
            {
                Console.WriteLine(item.data + " " + item.placeholder);
            }

            string fmt1 = "#,##0.00";
            string fmt2 = "#,##0.00;(#,##0.00)";

            double posAmount = 12345.67;
            double negAmount = -12345.67;
            Console.WriteLine("posAmount.ToString(fmt1) returns " + posAmount.ToString(fmt1));
            Console.WriteLine("negAmount.ToString(fmt1) returns " + negAmount.ToString(fmt1));
            Console.WriteLine("posAmount.ToString(fmt2) returns " + posAmount.ToString(fmt2));
            Console.WriteLine("negAmount.ToString(fmt2) returns " + negAmount.ToString(fmt2));


            Console.ReadLine();
        }
    }
}

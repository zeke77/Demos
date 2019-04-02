using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demos.Abbreviate.Extensions;

namespace Demos.Abbreviate
{
    class Program
    {
        static void Main(string[] args)
        {

            string result1 = Abbreviate("Care Services Manager");

            string tmp = "care services zanager";
            string result1B = Abbreviate(tmp.UpperCaseFirst());

            string result2 = Abbreviate("Executive Director");
            string result3 = Abbreviate("Community Relations Mgr");

            string myList = "community relations mgr";
            string result4 = Abbreviate(myList.ToUpper());

            Console.WriteLine(result1);
            Console.WriteLine(result1B);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

        }


        private static string Abbreviate(string input)
        {

         string abbreviation = new string(input.Split()
          .Where(s => s.Length > 0 && char.IsLetter(s[0]) && char.IsUpper(s[0]))
          .Take(3)
          .Select(s => s[0])
          .ToArray());

          return abbreviation;

         }
    }

}

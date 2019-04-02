using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Eval
{
    class Program
    {
        public int myInteger = 7;

        static void Main(string[] args)
        {
            MainClass mc = new MainClass();

            mc.Test();

        }

        class MainClass
        {
            public int myInteger = 7;

            public void Test()
            {
                // Grabs the integer by the variables name
                int test = (int)this.GetType().GetField("myInteger").GetValue(this);

                Console.WriteLine(test);
            }
        }
    }
}

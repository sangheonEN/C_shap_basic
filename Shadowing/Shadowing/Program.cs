using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowing
{


    class Program
    {
        public static int number = 10;
        static void Main(string[] args)
        {
            //쉐도잉
            int number = 20;
            Console.WriteLine($"number = {number}");
            Console.WriteLine($"Program.number = {Program.number}");

            A a = new A();
            a.doA();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowing
{
    class A
    {
        public void doA()
        {
            Console.WriteLine("Program.number = " + Program.number);
            Console.WriteLine($"Program.number = {Program.number}");
        }
    }
}

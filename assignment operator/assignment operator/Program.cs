using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            a += 20;
            // a = a + 20;
            Console.WriteLine(a);

            a++;
            // a = a + 1;
            Console.WriteLine(a);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

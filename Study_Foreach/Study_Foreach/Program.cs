using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Study_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {

            Mycl cl1 = new Mycl();
            cl1.A = 10;
            cl1.B = 20;
            cl1.C = 30;
            Mycl cl2 = new Mycl();
            cl2.A = 100;
            cl2.B = 200;
            cl2.C = 300;
            Mycl cl3 = new Mycl();
            cl3.A = 1000;
            cl3.B = 2000;
            cl3.C = 3000;

            Mycl[] mycls_ary = { cl1, cl2, cl3 };

            foreach (Mycl item in mycls_ary)
            {
                Console.WriteLine($"item.A = {item.A}");
                Console.WriteLine($"item.B = {item.B}");
                Console.WriteLine($"item.C = {item.C}");
            }

        }
    }
}

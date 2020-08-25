using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
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
                if(item.B == 200)        // item.B 200이면 가장 가까운 for, switch문 etc.. 에서 빠져 나간다.
                {
                    break;
                }
                //if (item.B == 200)     // item.B 200이면 가장 가까운 for, switch문으로 돌아가 다음 for문을 시작한다.
                //{
                //    continue;
                //}
                Console.WriteLine($"item.C = {item.C}");
            }

            Thread.Sleep(3000);

            string a = "   po  ta TO   ";
            Console.WriteLine(a.Trim());
            Console.WriteLine(a.Replace(" ", ""));   // " " 공백을 없애기 위해 ""
            //Console.WriteLine(a.);

        }
    }
}

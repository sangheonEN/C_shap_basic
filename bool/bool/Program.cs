using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @bool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(52 > 283);
            Console.WriteLine(52 < 283);
            Console.WriteLine(52 == 283);

            // 3개의 논리연산자가 있을 경우 ()를 하여 연산의 우선순의를 정해주자.
            Console.WriteLine(52 < 283 || (52 > 269 && 25 > 233));
            Console.WriteLine(52 == 283 && 52 < 269);

            // bool 형 활용
            int a = 12; // ++a는 연산됨 and 연산에 의해 True
            Console.WriteLine(a < 20 && (++a < 16));
            Console.WriteLine($"a = {a}");

            int b = 20; // ++b는 연산되지 않음. and 연산에 의해 false
            Console.WriteLine(b < 20 && (++b < 24));
            Console.WriteLine($"b = {b}");

            // 수 범위 논리 연산 num = 5 num < 8 && num > 3
            int num = 5;
            Console.WriteLine(num > 3 && num < 8);

            // int == int32(32비트로 처리)
            // long = lnt64(64비트로 처리)
            int c = 30;
            int d = (int)30000l; // 정수 뒤에 l(엘)을 붙여주면 

            // bool 자료형
            bool one = 10 < 0;
            bool two = 20 > 0;
            Console.WriteLine(one);
            Console.WriteLine(two);


            




















            //try
            //{
            //    Console.WriteLine("김하영0" + "이상헌1" + "천재2" + "박순홍3" + "기모띠4" + "바보5");
            //    Console.WriteLine('a'+'A');     // char형으로하면 정수로 (아스키코드)표현됨!

            //    Console.WriteLine("안녕하세요"[0]);
            //    Console.WriteLine("안녕하세요"[100]);
            //    Console.WriteLine("안녕하세요"[3]);
            //    Console.WriteLine("안녕하세요"[2]);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("예외 발생!!");
            //}
           
        }
    }
}

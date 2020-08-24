using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace type_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 10;
            long b1 = 200;

            a1 = (int)b1;
            Console.WriteLine(a1);
            Console.WriteLine(a1.GetType());

            string a = 10.ToString();

            Console.WriteLine("a = " + a);
            int inta = int.Parse(a);
            Console.WriteLine("inta = " + inta);
            //string aa1 = 10;                            // string은 클래스 형식이라서 struct인 int 정수는 그 값이 저장이 안됨.
            string aa2 = 10 + "";

            // parse()를 사용한 형변환

            Console.WriteLine(int.Parse("10"));
            Console.WriteLine(float.Parse("20.3"));
            Console.WriteLine(long.Parse("10293"));
            Console.WriteLine(double.Parse("23294.32782"));

            Console.WriteLine(int.Parse("23").GetType());
            Console.WriteLine(long.Parse("232323").GetType());
            Console.WriteLine(float.Parse("23.2323").GetType());
            Console.WriteLine(double.Parse("23.38472").GetType());

            //소수 각 자리수 출력
            double num = 10.232424;
            Console.WriteLine(num.ToString("0.0"));
            Console.WriteLine(num.ToString("0.00"));
            Console.WriteLine(num.ToString("0.000"));
            Console.WriteLine(num.ToString("0.0000"));
        }
    }
}

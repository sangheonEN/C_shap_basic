using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = "abc".Contains("a");                 // abc 문자열에 a가 들어있는지??
            Console.WriteLine($"test = {test}");

            string b = "abc";

            if(test.Equals(b)) // 데이터 비교
            {
                Console.WriteLine("데이터는 같습니다.");
            }

            string a = "abc";

            if(a == b)        // 주소 값 비교
            {
                Console.WriteLine("주소 값이 같습니다!!");
            }

        }
    }
}

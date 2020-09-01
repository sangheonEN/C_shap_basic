using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Callbyreference_value
{

    class Program
    {
        //Call by reference

        public class Test
        {
            public int value = 10;
        }
        public static void Change_Ref(Test test)
        {
            test.value = 20;
        }


        //Call by value

        static void Change(int input)
        {
            input = 20;
        }

        static void Main(string[] args)
        {
            //Call by value 값 복사 (복사되지 않음)
            int a = 10;
            Change(a);
            Console.WriteLine($"a = {a}");


            //Call by reference
            Test t1 = new Test();
            Console.WriteLine($"t1 = {t1.value}");             // 값 복사 전 그냥 public int value 출력
            Change_Ref(t1);                                    // 값 복사
            Console.WriteLine($"t1 = {t1.value}");             // 값 복사 후 복사된 값 출력
        }
    }
}

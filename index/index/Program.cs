using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    // index 문법
    class A
    {
        private int a = 10;
        private int b = 1;
        private int c = 1;

        public int this[int index]
        {
            get { return a * index; }  // 값을 반환
            set { a = value; b = value; c = value; }
        }

        private int myprop = 100;
        public int MyProperty { get { return myprop; } set { myprop = value; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a[10]);
            a[10] = 20;
            a[5] = 100;
            Console.WriteLine(a[10]);
            Console.WriteLine(a[5]);

            // get : 값을 호출하면 반환하는 개념 set : 값을 바꿔주는 개념
            Console.WriteLine(a.MyProperty);
            a.MyProperty = 200;
            Console.WriteLine(a.MyProperty);
        }
    }
}

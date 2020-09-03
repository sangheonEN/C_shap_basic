using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class A
    {
        private int a = 10;
        protected int b = 20;
        public int c = 30;
    }

    // A는 B에 상속되니 B에서 protected 변수는 사용할 수 있음.
    class B : A
    {
        public String ReturnA() //문자열 리턴
        {
            //return a + "\r\n" + b + "\r\n" + c; // a는 private이니 당연히 사용 못함
            return "aaaaaaaaaaaaa" + "\r\n" + b + "\r\n" + c;
        }
    }
    class C
    {
        public void Test()
        {
            B b = new B();
            //Console.WriteLine(b.a);             // a는 private이니 당연히 사용 못함
            //Console.WriteLine(b.b);             // b는 protected라서 상속 관계가 아니라면 사용 할 수 없음
            Console.WriteLine(b.c);             // c는 public이니 모두 사용 가능
        }
    }

}

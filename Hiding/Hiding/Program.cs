using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Hiding
{
    //부모 클래스 virtual
    //자식 클래스 new override
    class A              //부모
    {
        public int value = 10;
        public virtual void doA()
        {
            Console.WriteLine("부모 doA함수");
            Console.WriteLine($"value = {value}");
        }
    }
    class B : A          //자식
    {
        public int value = 20;
        public new void doA()
        {
            Console.WriteLine($"자식 B클래스 doA함수");
            Console.WriteLine($"value = {value}");
            Console.WriteLine($"base.value = {base.value}");
        }
    }

    class C : A
    {
        public int value = 30;
        public override void doA()
        {
            Console.WriteLine($"자식 C클래스 doA함수");
            Console.WriteLine($"value = {value}");
            Console.WriteLine($"base.value = {base.value}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //B b = new B();
            //b.doA();

            //A b1 = new B();          // 다형성 개념 : 자식클래스는 부모클래스에 담을 수 있다. override >> 자식 클래스, new >> 부모 클래스
            //b1.doA();                // 자식클래스의 doA함수에 override로 선언하면 자식 클래스를 불러오고 new로 선언하면 부모 클래스를 불러온다.

            List<A> list = new List<A>()
            {
                new B(), new C(), new B(), new C()              // list[0] = new B(), list[1] = new C(), ...
            };

            foreach (A item in list)
            {
                item.doA();
            }

            // Object는 모든 클래스의 부모 클래스 따라서 다형성 개념에 따라 모든 클래스를 자식으로 하여 자식이 부모 클래스를 담아 줄수 있다.

        }
    }
}

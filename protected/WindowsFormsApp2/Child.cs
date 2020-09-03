using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent : 기본 생성자");
        }
        public Parent(int a)
        {
            Console.WriteLine($"a = {a}");
        }
    }
    class Child : Parent
    {
        public Child() : base(10)
        {
            Console.WriteLine("Ch : 기본 생성자");
        }
    }
}
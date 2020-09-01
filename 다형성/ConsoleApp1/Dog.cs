using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog : Animal
    {
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog()
        {
            this.Age = 0;
        }

        public void Eat()
        {
            base.Eat();
            Console.WriteLine("냠냠");
        }
        public void Sleep()
        {
            base.Sleep();
            Console.WriteLine("쿨쿨");
        }
        public void Bark()
        {
            //base.Bark();
            Console.WriteLine("왈왈");
        }
    }
}

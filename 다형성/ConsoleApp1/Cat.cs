using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cat : Animal
    {
        public int Age { get; set; }
        public Cat()
        {
            this.Age = 0;
        }
        public void Eat()
        {
            Console.WriteLine("욤욤");
        }
        public void Sleep()
        {
            Console.WriteLine("미유미유");
        }
        public void Bark()
        {
            Console.WriteLine("냥냥");
        }
    }
}

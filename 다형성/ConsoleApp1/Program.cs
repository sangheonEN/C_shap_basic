using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> list_Dog = new List<Dog>()
            {
                new Dog(), new Dog(), new Dog()
            };
            List<Cat> list_Cat = new List<Cat>()
            {
                new Cat(), new Cat(), new Cat()
            };
            //foreach (var item in list_Dog)
            //{
            //    item.Eat();
            //    item.Sleep();
            //    item.Bark();
            //}
            //foreach (var item in list_Cat)
            //{
            //    item.Eat();
            //    item.Sleep();
            //    item.Bark();
            //}

            // 다형성 (부모클래스에 자식클래스를 담을 수 있어서 사용함)
            List<Animal> list_Animal = new List<Animal>()
            {
                new Cat(), new Dog(), new Cat()
            };

            foreach (var item in list_Animal)
            {
                item.Eat();
                item.Sleep();
                if(item is Dog)
                {
                    ((Dog)item).Bark();
                }
                else
                {
                    ((Cat)item).Bark();
                }
            }
        }
    }
}

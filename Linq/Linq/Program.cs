using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return Name + ":" + Price + "원";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> output = new List<int>();

            //// 일반적인 짝수 출력 형태

            ////foreach (var item in input)
            ////{
            ////    if (item % 2 == 0)
            ////    {
            ////        output.Add(item);           // 짝수만 output List에 저장한다.
            ////    }
            ////}
            //return output;

            // Linq를 활용한 짝수 출력 형태
            //return from item in input
            //       where item % 2 == 0
            //       select item;


            ////Linq를 활용한 출력 조건 where 선언
            //var output = from item in input
            //             where (item > 5) && (item % 2 == 0)
            //             select item;
            //foreach (var item in output)
            //{
            //    Console.WriteLine(item);
            //}

            //// 익명 객체 사용
            //var output = from item in input
            //             where item % 2 == 0
            //             select new
            //             {
            //                 A = item * 2,
            //                 B = item / 2,
            //                 C = item + 100
            //             };
            //foreach(var item in output)
            //{
            //    Console.WriteLine(item.A);
            //    Console.WriteLine(item.B);
            //    Console.WriteLine(item.C);
            //    Console.WriteLine();

            // Linq 구문과 클래스 활용

            List<Product> input = new List<Product>()
            { new Product() {Name = "고구마", Price = 1000},
              new Product() {Name = "감자", Price = 540}
            };

            var output = from item2 in input
                         where item2.Price > 600
                         orderby item2.Name ascending
                         select item2;

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}

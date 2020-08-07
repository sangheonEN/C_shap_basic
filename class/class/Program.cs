using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------------------------------------------------------------//

            // 1) Random 클래스

            Console.WriteLine($"Random 이라는 클래스에 있는 Next 메서드 활용 하여 난수 출력");

            //Random 이라는 클래스에 있는 Next 메서드 활용 하여 난수 출력 (정수)
            Random random = new Random();
            Console.WriteLine(random.Next(1, 10));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(100, 1000));
            Console.WriteLine(random.Next(1000, 10000));
            Console.WriteLine(random.Next(10000, 100000));

            //Random 이라는 클래스에 있는 Next 메서드 활용 하여 난수 출력 (실수)
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 100);
            Console.WriteLine(random.NextDouble() * 1000);

            Console.WriteLine("\n");

            //-----------------------------------------------------------------------------------------------------------------------------------//


            // 2) List 클래스

            // 정수형 배열 List 클래스
            List<int> list = new List<int>();         // 표현식

            // List 클래스에 요소를 추가하기

            Console.WriteLine($"List 클래스 요소 추가");

            list.Add(10);                             // Add 메서드를 이용한 List 요소 추가
            list.Add(100);
            list.Add(1000);
            list.Add(10000);

            foreach (var item in list)
            {
                Console.WriteLine($"Count: {list.Count}\titem : {item}");                    // 각 요소 출력
            }

            Console.WriteLine("\n");


            // List 인스턴스 생성과 동시에 요소 추가

            Console.WriteLine($"List 클래스 요소 추가");

            List<int> list2 = new List<int>() { 52, 1923, 238, 33 };

            foreach (var item in list2)
            {
                Console.WriteLine($"Conut : {list2.Count} \t source : {item}");
            }

            Console.WriteLine("\n");


            // List 클래스에 요소를 삭제하기

            Console.WriteLine($"List 클래스 요소 삭제");

            List<int> list3 = new List<int>() { 52, 1923, 238, 33 };

            list3.Remove(1923);

            foreach (var item in list3)
            {
                Console.WriteLine($"Count : {list3.Count} \t source : {item}");
            }

            Console.WriteLine("\n");
        }
    }

}


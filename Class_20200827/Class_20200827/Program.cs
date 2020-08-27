using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Class_20200827
{
    class Car
    {
        public string carname;
        public int carnumber;
        public string carcolor;

        public void printCar()
        {
            Console.WriteLine($"{carname}, {carnumber}, {carcolor}");
        }
    }

    class A
    {
        public int b = 10;

        public static int a = 10;
        public static void doa()
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //static으로 선언되었을때 클래스의 변수, 함수 사용법
            Console.WriteLine(A.a);   // static이니까 생성자 없이 바로 사용할 수 있음
            A.doa();                  // static이니까 생성자 없이 바로 사용할 수 있음

            A A1 = new A();           // static 변수가 아니면 생성자를 선언해주고 생성자 변수를 가지고 Class의 변수를 사용 가능함.
            Console.WriteLine(A1.b);


            //
            List<Car> list = new List<Car>();
            list.Add(new Car() { carname = "기아", carnumber = 1, carcolor = "레드" });
            list.Add(new Car() { carname = "현대", carnumber = 2, carcolor = "보라" });
            list.Add(new Car() { carname = "삼성", carnumber = 3, carcolor = "블루" });

            foreach (Car item in list)
            {
                item.printCar();
            }


        }
    }
}

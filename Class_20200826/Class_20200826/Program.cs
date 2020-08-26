using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_20200826
{
    class Car
    {

        // 원래 기존에 Car() 생성자가 표현은 안되 있지만 생성이 되어 있는상태인데 임의로 내가 아래와 같이 선언해주면 override되어 생성이 된다.
        public Car()
        {
            Console.WriteLine("기본생성자");
        }

        //public Car(int a, int b, int c)
        //{
        //    carNumber = a;
        //    inTime = b;
        //    outTime = c;
        //}

        // 위와같이 a, b, c에 매개변수를 지정하면 아래에 메모리 구조에 생성했을때 a, b, c 매개변수가 무엇에 해당하는 변수인지 모르기 때문에
        // 아래에 생성자의 매개변수를 로컬 매개변수의 변수명과 일치시켜 알아보기 쉽게하려고 this.를 사용하여 로컬 이름이랑 같이 사용하게 한다.
        public Car(int carNumber, int inTime, int outTime)        
        {
            this.carNumber = carNumber;
            this.inTime = inTime;
            this.outTime = outTime;
        
        }

        public int carNumber;
        public int inTime;
        public int outTime;

        public void PrintInfo()
        {
            Console.WriteLine($"car Number : {this.carNumber}");
            Console.WriteLine($"car Number : {this.inTime}");
            Console.WriteLine($"car Number : {this.outTime}");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();                //Car() 객체 new로 heap 메모리에 할당
            car1.carNumber = 1;                  // Car 객체에 할당된 carNumber, inTime, OutTime 변수 사용
            car1.inTime = 13;
            car1.outTime = 14;
            //car1.PrintInfo();
            Car car2 = new Car();
            car2.carNumber = 2;
            car2.inTime = 15;
            car2.outTime = 16;
            //car2.PrintInfo();
            Car car3 = new Car();
            car3.carNumber = 3;
            car3.inTime = 16;
            car3.outTime = 17;
            //car3.PrintInfo();


            // 배열로 객체 생성

            Car[] cars = { car1, car2, car3 }; // 크기 증가시키면 예외가 생김

            //foreach  (Car item in cars)
            //{
            //    item.PrintInfo();
            //}

            Car car4 = new Car(1, 2, 3);
            car4.PrintInfo();
            //cars[3] = car4;                // 이미 배열에 0, 1, 2까지만 저장이 되어 있으므로 배열 3의 인덱스는 없어 예외로 처리됨




        }
    }
}

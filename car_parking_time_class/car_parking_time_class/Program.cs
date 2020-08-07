using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_parking_time_class
{
    // 클래스 생성
    class Car
    {
        public string Carname;
        public int intime;
        public int outtime;
        public bool isAccident;
    }
    class Program
    {
        static void Main(string[] args)
        {

            //string[] carname = new string[5];
            //carname[0] = "24아 2345";
            //carname[1] = "35허 5943";
            //carname[2] = "209호 1283";
            //carname[3] = "183가 6958";
            //carname[4] = "11거 1111";


            //int[] intime = new int[5];
            //intime[0] = 1;
            //intime[1] = 13;
            //intime[2] = 24;
            //intime[3] = 35;
            //intime[4] = 46;

            //int[] outtime = new int[5];
            //outtime[0] = 200;
            //outtime[1] = 300;
            //outtime[2] = 400;
            //outtime[3] = 500;
            //outtime[4] = 600;

            //bool[] isAccident = new bool[5];
            //isAccident[0] = true;
            //isAccident[0] = false;
            //isAccident[0] = false;
            //isAccident[0] = false;
            //isAccident[0] = true;

            Car[] c_cars = new Car[5];
            c_cars[0].Carname = new ("24아 2345");
            c_cars[0].intime = 1;
            c_cars[0].outtime = 200;
            c_cars[0].isAccident = true;

            c_cars[1].Carname = "35허 5943";
            c_cars[1].intime = 13;
            c_cars[1].outtime = 300;
            c_cars[1].isAccident = false;

            c_cars[2].Carname = "209호 1283";
            c_cars[2].intime = 24;
            c_cars[2].outtime = 400;
            c_cars[2].isAccident = false;

            c_cars[3].Carname = "183가 6958";
            c_cars[3].intime = 35;
            c_cars[3].outtime = 500;
            c_cars[3].isAccident = false;

            c_cars[4].Carname = "11거 1111";
            c_cars[4].intime = 46;
            c_cars[4].outtime = 600;
            c_cars[4].isAccident = true;

            for(int i = 0; i < c_cars.Length; i++)
            {
                if (c_cars[i].Carname == "209호 1283")
                {
                    Console.WriteLine($"intime : {c_cars[i].intime}");
                    break;
                }
            }
        }
    }
}

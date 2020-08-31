using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capsulation
{
    // 캡슐화 방법 : 하나의 클래스의 변수에 값을 사용하거나 변화시키거나 하기 위해 
    // 생성자를 초기화하는 방법(객체 생성시 값을 주어줘서 바꿔서 출력!)
    
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int height)
        {
            if(width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화 해주십시오.");
            }
        }
        public int Area()
        {
            return this.width * this.height;
        }

        public void Area2()
        {
            Console.WriteLine($"넓이 : {this.width * this.height}");
        }


        //------------------------------------------------------------------------------------------------------------------------------------//
        // get, set을 이용한 캡슐화   propfull +tab + tab 하면 자동완성

        private int width1;
        private int height1;

        public int Width
        {
            get { return width1; }
            set { width1 = value; }
        }
        public int Height
        {
            get { return height1; }
            set { height1 = value; }
        }
        public void Area3()
        {
            Console.WriteLine($"넓이 : {this.width1 * this.height1}");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            // 생성자를 초기화하는 방법(객체 생성시 값을 주어줘서 바꿔서 출력!)

            Box box1 = new Box(20, 30);
            box1.Area2();
            Console.WriteLine($"넓이 : {box1.Area()}");

            //------------------------------------------------------------------------------------------------------------------------------------//

            // get, set 방법

            Box box2 = new Box(200, 200);
            box2.Width = 200;
            box2.Height = 100;
            box2.Area3();

        }
    }
}

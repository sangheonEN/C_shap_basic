using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Database
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
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


            //Linq를 활용한 출력 조건 where 선언
            //var output = from item in input
            //             where (item > 5) && (item % 2 == 0)
            //             select item;
            //foreach (var item in output)
            //{
            //    Console.WriteLine(item);
            //}

            //Linq 결과 자료형과 변환



        }
    }
}

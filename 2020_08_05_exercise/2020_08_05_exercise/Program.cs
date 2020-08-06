using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _2020_08_05_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //func1();
            //func2();
            //func3();
            //func3_1();
            //func4();
            //func5();
            //func6_7();
            //func8();
            func9();       //수정필요



        }

        //사용자에게 태어난 년도를 입력 받아 그 해의 띠를 출력하는 프로그램을 작성하시오.
        static void func1()
        {
            string inputa = Console.ReadLine();
            int input = int.Parse(inputa);

            switch (input % 1912)
            {
                case 0:
                    Console.WriteLine("쥐");
                    break;
                case 1:
                    Console.WriteLine("소");
                    break;
                case 2:
                    Console.WriteLine("호랑이");
                    break;
                case 3:
                    Console.WriteLine("토끼");
                    break;
                case 4:
                    Console.WriteLine("용");
                    break;
                case 5:
                    Console.WriteLine("뱀");
                    break;
                case 6:
                    Console.WriteLine("말");
                    break;
                case 7:
                    Console.WriteLine("양");
                    break;
                case 8:
                    Console.WriteLine("원숭이");
                    break;
                case 9:
                    Console.WriteLine("닭");
                    break;
                case 10:
                    Console.WriteLine("개");
                    break;
                case 11:
                    Console.WriteLine("돼지");
                    break;
            }
        }

        //사용자에게 현재 월을 입력받아 계절을 출력하는 프로그램을 작성하시오.
        static void func2()
        {
            Console.WriteLine("해당 월 입력 : ");

            string input = Console.ReadLine();
            int input2 = int.Parse(input);

            while (true)
            {
                if (input2 <= 12 && input2 >= 0)
                {
                    switch (input2)
                    {
                        case 3:
                        case 4:
                            Console.WriteLine("봄입니다!");
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            Console.WriteLine("여름입니다!");
                            break;
                        case 10:
                            Console.WriteLine("가을입니다!");
                            break;
                        case 11:
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("겨울입니다!");
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("잘 못 입력하셨습니다.");
                    Console.WriteLine("해당 월 입력 : ");
                    input = Console.ReadLine();
                    input2 = int.Parse(input);
                }
            }
        }

        //현재 년도가 무슨 띠인지 구하는 프로그램을 작성하시오.
        static void func3()
        {
            long Month = DateTime.Now.Month;
            long Year = DateTime.Now.Year;

            Console.WriteLine("현재 년도 : " + Year + "\n" + "현재 월 : " + Month);

            switch (DateTime.Now.Year % 1912)
            {
                case 0:
                    Console.WriteLine("쥐");
                    break;
                case 1:
                    Console.WriteLine("소");
                    break;
                case 2:
                    Console.WriteLine("호랑이");
                    break;
                case 3:
                    Console.WriteLine("토끼");
                    break;
                case 4:
                    Console.WriteLine("용");
                    break;
                case 5:
                    Console.WriteLine("뱀");
                    break;
                case 6:
                    Console.WriteLine("말");
                    break;
                case 7:
                    Console.WriteLine("양");
                    break;
                case 8:
                    Console.WriteLine("원숭이");
                    break;
                case 9:
                    Console.WriteLine("닭");
                    break;
                case 10:
                    Console.WriteLine("개");
                    break;
                case 11:
                    Console.WriteLine("돼지");
                    break;
            }

        }

        //현재 월이 무슨 계절인지 구하는 프로그램을 작성하시오.
        static void func3_1()
        {
            Console.WriteLine("해당 월 입력 : " + DateTime.Now.Month);

            while (true)
            {
                if (DateTime.Now.Month <= 12 && DateTime.Now.Month >= 0)
                {
                    switch (DateTime.Now.Month)
                    {
                        case 3:
                        case 4:
                            Console.WriteLine("봄입니다!");
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            Console.WriteLine("여름입니다!");
                            break;
                        case 10:
                            Console.WriteLine("가을입니다!");
                            break;
                        case 11:
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("겨울입니다!");
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("잘 못 입력하셨습니다.");
                    Console.WriteLine("해당 월 입력 : ");
                }
            }
        }

        /* 4) 1~100까지 3의 배수를 제외한 합을 구하는 함수를 작성하세요. */
        static void func4()
        {
            int count = 0;


            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 != 0)
                {
                    count += i;
                }
            }
            Console.WriteLine(count);
        }

        /* 
         임의의 양수인 전체 "초" 시간을 사용자로부터 입력 받아 이를 "분"과 "초"로 변환하는 프로그램을 작성하세요.
            예시)
             - Input Total Second? 123
             - 2min 3sec
         */

        static void func5()
        {
            Console.Write("Total sec : ");
            string input1 = Console.ReadLine();
            int input = int.Parse(input1);

            int min = input / 60;
            int sec = input % 60;

            Console.WriteLine(min + "min" + sec + "sec");
        }

        /* 6. 입력된 알파벳 문자열(단 소문자로만 입력할 것)의 각 글자들이 해당 문자열에서 몇 번씩 나왔는지 출력하시오
                 예) leedongjoon   
        
         
        /* 7. 입력된 알파벳(단,소문자)에서 각각의 알파벳 글자가 최초로 등장하는 위치를 적으시오. 
                 예) aabbcc
                    a는 1번째에서 처음 등장합니다.
                    b는 3번째에서 처음 등장합니다.
                    c는 5번째에서 처음 등장합니다.
        */

        static void func6_7()
        {
            string str = Console.ReadLine();
            int[] alpabetPositioncheck = new int[26];
            int[] count = new int[100];

            int len = str.Length;

            // 입력 알파벳 문자의 빈도수 출력

            for (int i = 0; i < len; i++)
            {
                if (str[i] <= 'z' && str[i] >= 'a')
                {
                    if (str[i] <= 'z')
                    {
                        count[str[i] - 'a'] += 1;
                    }
                }

            }
            for (int i = 0; i < 26; i++)
            {
                if (count[i] >= 1)
                {
                    Console.WriteLine("\'" + (char)(i + 'a') + "\'는" + count[i] + "글자 입니다.");
                }
            }

            // 알파벳 몇번째에서 처음 나오는지

            for (int i = 0; i < len; i++)
            {

                int index = str[i] - 'a';

                alpabetPositioncheck[index]++;
                if (alpabetPositioncheck[index] == 1)                                     // ** 1이랑 같을 시점은 최초로 1이 된다. (중복되서 count 1 올라가면 출력하지 않음.)
                {
                    Console.WriteLine($"'{str[i]}'는 {i + 1}번째에 처음 등장합니다.");
                }
            }
        }

        //삼각형 모양 피라미드를 만드시오.

        static void func8()
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n ; i++)
            {
                for (int j = n-1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                for(int j = 1; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }


        // 5개의 숫자를 입력받은 뒤 가장 작은 수와 가장 큰 수를 출력하는 프로그램을 작성하시오.

        static void func9()
        {
            //int[] input = new int[5];
            //int len = input.Length;

            //int max = 0;
            //int min = 0;
            //int temp = 0;

            //for (int i = 0; i < len; i++)
            //{
            //    input[i] = int.Parse(Console.ReadLine());
            //}

            //for(int i = 0; i < len; i++)
            //{
            //    for(int j = i+1; j < len; j++)
            //    {
            //        if(input[i] < input[j])
            //        {
            //            temp = input[j];
            //            input[j] = input[i];
            //            input[i] = temp;
            //        }
            //    }
            //}
            //min = input[len - 1];
            //max = input[0];
            //Console.WriteLine($"가장 큰 수 : {max} \n 가장 작은 수 : {min}");


            int min = int.MinValue;
            int max = int.MaxValue;

            for(int i = 0; i < 5; i++)
            {
                Console.Write($"숫자를 입력하시오 : ");
                int input = int.Parse(Console.ReadLine());
                if(input > max)
                {
                    max = input;
                }
                if(input < min)
                {
                    min = input;
                }
            }
            Console.WriteLine($"가장 큰 값 : {max} 가장 작은 값 : {min}");
        }


        /*
         * 아래의 규칙을 따르는 수열의 20번째 숫자를 프로그램을 만들어 찾으시오.
            1, 11, 12, 1121, 122111, 112213
            첫 번째 수열 : 1
            두 번째 수열 : 1이 1개 = 11
            세 번째 수열 : 1이 2개 = 12
            네 번째 수열 : 1이 1개, 2가 1개 = 1121
            다섯 번째 수열 : 1이 2개, 2가 1개, 1이 1개 = 122111
            여섯 번째 수열 : 1이 1개, 2가 2개 1이 3개 = 112213
         */

        static void func10()
        {
            int nth = int.Parse(Console.ReadLine());

            string start = "1"; //start : 내가 파악해야 하는 수열
            // 계산 시작
            for (int i = 1; i < nth; i++)
            {
                // 출력
                Console.WriteLine(i + "번째: " + start);

                // 읽고 말하기 수열 계산
                string end = ""; //누적값
                char number = start[0]; //내가 가리키는 number
                int count = 0; //그 number의 개수
                for (int j = 0; j < start.Length; j++)
                {
                    if (number != start[j])
                    {
                        end = end + number + count;
                        number = start[j];
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                end = end + number + count; //start에 대하여 말하는 수열

                // 다음 단계 준비              // 
                start = end;
            }
            return start;
        }

    }
}

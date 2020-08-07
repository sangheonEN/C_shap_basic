using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_instance_Variable
{
    class User
    {

        public string name;
        public string password;
        public string ID;
        public int Phone_num;
        public string address;
        public DateTime regDate;

    }

    class Program
    {
        class Agenda
        {
            public string name;
            public string price;
            public int revision;
        }
        static void Main(string[] args)
        {
            Agenda project1 = new Agenda();

            project1.name = "원가절감";
            project1.price = "절감 금액 : 1,000,000,000원";
            project1.revision = 2;

            Console.WriteLine($" 프로젝트 명 : {project1.name} \n 프로젝트 내용 \n - {project1.price} \n - Rev_num : {project1.revision}");


            User[] asdf = new User[8];

            //asdf[1] = new User() { name = "이상헌", ID = "aaa", address = "aaaaa", password = "aaaaaaaa", Phone_num = 1123 };
            //if (asdf[0] == null)
            //{
            //    Console.WriteLine("!!!!!!!");
            //}

            asdf[0].name = "이상헌";
            asdf[2].name = "안중언";
            asdf[3].name = "박순홍";
            asdf[4].name = "박경태";
            asdf[5].name = "안재민";
            asdf[6].name = "정현욱";
            asdf[7].name = "김세인";

            asdf[0].ID = "jteks5";
            asdf[1].ID = "jteks5";
            asdf[2].ID = "jteks5";
            asdf[3].ID = "jteks5";
            asdf[4].ID = "jteks5";
            asdf[5].ID = "jteks5";
            asdf[6].ID = "jteks5";
            asdf[7].ID = "jteks5";

            for (int i = 0; i < asdf.Length; i++)
            {
                if (asdf[i].name == "이상헌")
                {
                    Console.WriteLine($"{asdf[i].name}님의 ID는 {asdf[i].name} 입니다.");
                }
                break;
            }
        }
    }
}

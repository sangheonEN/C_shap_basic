using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struck_class
{
    struct AA { }
    class BB { }

    class Program
    {
        static void Main(string[] args)
        {
            AA a;              // heap 영역의 AA라는 메모리영역이 할당됨

            BB b;              // heap 영역에서 null을 참조하다가 new로 생성자를 만들어주면 Heap에 BB라는 Class의 메모리 영역이 할당된다.

            BB c = new BB();   // new로 생성자를 만들어주면 Heap에 BB라는 Class의 메모리가 할당됨. c라는 인스턴스로 접근가능!
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate md = new MyDate();   // static이 아닌 함수로 선언했으니 new를 사용해 heap 영역에 할당한 뒤에 printDate 함수를 사용가능함.
            md.printDate();

            MyStaticDate.doPrintDate(); // static 함수로 선언했으니 doPrintDate함수를 바로 사용가능
        }
    }
}

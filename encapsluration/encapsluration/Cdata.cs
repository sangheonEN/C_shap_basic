using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsluration
{
    //변수만 넣을거
    partial class Cdata       // partial class를 만들면 똑같은 class 명을 가진 class를 또 만들 수 있음.
    {
        //외부에서 접근 못하도록 private으로 하고 get, set을 써서 간접적으로 접근 가능하게 만들어 준다.
        private string _stritem = string.Empty;              
        private string _strErrorname = string.Empty;                // 조건문에서 에러 메세지 문자열로 출력할 수 있게 하기
        public string StrErrorName
        {
            get { return _strErrorname; }
            //set { }
        }

        public string Stritem
        {
            //get                             읽기만 쓰기 위해
            set
            {
                if (string.IsNullOrEmpty(value)) // 읽어 온 value 값이 null이면 물건이 선택되지 않았다!!라고 알림을 주게
                {
                    _strErrorname = "물건을 선택하지 않았습니다!!";
                }
                else
                {
                    _stritem = value;
                }
            }

        }
        private int _Irate = 0;             
        public int IRate
        {
            //get                              읽기만 쓰기 위해
            set
            {
                if(value > 25)
                {
                    _strErrorname = "사장님만 해당 할인을 할 수 있습니다.";
                }
                else
                {
                    _Irate = value;
                }
            }
        }
        private int _Icount = 0;
        public int ICount
        {
            //    get { }                       읽기만 쓰기 위해
            set
            {
                if(value > 5)
                {
                    _strErrorname = "개별 물품은 5개이상 살수 없습니다.";
                }
                else if(value <= 0)
                {
                    _strErrorname = "물품의 갯수가 0개 입니다.";
                }
                else
                {
                    _Icount = value;
                }
            }
        }

    }
    partial class Cdata       // partial class를 만들면 똑같은 class 명을 가진 class를 또 만들 수 있음.
    {

    }
    partial class Cdata       // partial class를 만들면 똑같은 class 명을 가진 class를 또 만들 수 있음.
    {

    }
}

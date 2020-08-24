using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsluration
{
    //class에 enum을 하면 form에서 load가 되지 않음. 그냥 enum에 저장한 item 들을 사용하지 못해서 그냥 같은 namespace에서만 사용함
    public enum EnumItem
    {
        고기,
        과자,
        계란,
        라면,
        물,
        즉석식품,
        냉동식품,
    }

    public enum EnumRate
    {
        할인_3 = 3,
        할인_5 = 5,
        할인_10 = 10,
        할인_15 = 15,
        할인_20 = 20,
        사장할인_80 = 80,

    }

    //class Enumclass
    //{
    //}
}

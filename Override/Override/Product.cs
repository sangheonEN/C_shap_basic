using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Override
{
    class Product
    {
        public string m_Name;
        public int m_Price;
        public Product(string name, int price)
        {
            m_Name = name;
            m_Price = price;
        }

        public void printProduct()
        {
            MessageBox.Show($"제품명 : {m_Name}, 가격 : {m_Price}");
        }

        // 기본적으로 object에 들어가보면 각 자료형에 따라 virtual로 선언된 함수들이 있다. string은 Tostring(), int는 GetHashCode() 따라서 override를 이용해 해당 함수를 만들면 자기가 원하는 출력물을 만들 수 있다.
        public override string ToString()              
        {
            return $"제품명 : 하나투어, 가격 : 38300원 제발 올라라";
        }

        public override int GetHashCode()
        {
            return 100;
        }
    }

}

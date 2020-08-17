using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboList_Grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            productBindingSource.Add(new Product() { Name = "감자", Price = 500 });
            productBindingSource.Add(new Product() { Name = "고구마", Price = 1000 });
            productBindingSource.Add(new Product() { Name = "토마토", Price = 1500 });

            comboBox1.SelectedIndexChanged += DataSelected;      // 콤보박스의 인덱스가 바뀌면 DataSelected를 호출함.
            listBox1.SelectedIndexChanged += DataSelected;       // 리스트 박스의 인덱스가 바뀌면 DataSelected를 호출함

        }

        private void DataSelected(object sender, EventArgs e)       //object sender : object 자신 (예를들어 버튼도구라면 버튼 자신) 이벤트를 발생시키는 놈! button, label, combobox etc 모두가 될 수 있다.
        {

            if(sender is ComboBox)
            {
                ComboBox combo = (ComboBox)sender;                  // sender를 ComboBox로 강제 형변환을 해줘야 
                Product product = (Product)combo.SelectedItem;      // ComboBox에서 선택하는 것을 Product 클래스에 넣어준다.
                MessageBox.Show($"제품명 : {product.Name}" + $"{Environment.NewLine}" +
                    $"가격 : {product.Price}");
            }

            else if (sender is ListBox)
            {
                ListBox combo = (ListBox)sender;                  // sender를 ComboBox로 강제 형변환을 해줘야 
                Product product = (Product)combo.SelectedItem;      // ComboBox에서 선택하는 것을 Product 클래스에 넣어준다.
                MessageBox.Show($"제품명 : {product.Name}" + $"{Environment.NewLine}" +
                    $"가격 : {product.Price}");
            }

            //throw new NotImplementedException();        // 아무것도 구현 하지 않은 에러 메세지


        }
    }
}

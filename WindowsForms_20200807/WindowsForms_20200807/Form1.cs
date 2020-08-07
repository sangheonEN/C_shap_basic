using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_20200807
{
    public partial class Form1 : Form
    {
        Label l_11 = new Label();

        public Form1()
        {



            InitializeComponent();
            button_LEE.Text = "Random_Num";
            button_LEE.AutoSize = true;

            //Label l_11 = new Label();
            //l_11.Text = "11";
            //l_11.Location = new Point(100, 200);         // 새로운 포인트(위치 좌표 값 설정 가능)라는 객체를 생성하여 x, y 값을 지정
            //Controls.Add(l_11);                          // Controls.Add(내가 추가하는 인스턴스를 반영해라! 디스플레이해라!) 

            //for (int i = 0; i < 5; i++)
            //{
            //    Label l_11 = new Label();
            //    l_11.Location = new Point(300, 50 + (50 * i));         // 새로운 포인트(위치 좌표 값 설정 가능)라는 객체를 생성하여 x, y 값을 지정
            //    l_11.Text = "11_" + i + 1;
            //    Controls.Add(l_11);                          // Controls.Add(내가 추가하는 인스턴스를 반영해라! 디스플레이해라!) 

            //    Random rand = new Random();

            //    bool visiual = rand.Next(2) == 0 ? false : true;
            //    Thread.Sleep(10);
            //    button_LEE.Visible = visiual;

            //}

        }

        private void button_LEE_Click(object sender, EventArgs e)                    // button_LEE 의 버튼 픽쳐를 누르면 
        {
            MessageBox.Show("난수 생성");
            Random r = new Random();
            
            label1.Text = r.Next(1, 45).ToString();
            label2.Text = r.Next(1, 45).ToString();
            label3.Text = r.Next(1, 45).ToString();
            label4.Text = r.Next(1, 45).ToString();
            label5.Text = r.Next(1, 45).ToString();
            label6.Text = r.Next(1, 45).ToString();
            label7.Text = r.Next(1, 45).ToString();
            label8.Text = r.Next(1, 45).ToString();

            //l_11.Text = r.Next(1, 1000).ToString();


        }
    }
}

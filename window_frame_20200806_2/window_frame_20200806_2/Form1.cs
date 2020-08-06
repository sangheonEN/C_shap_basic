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

namespace window_frame_20200806_2
{

    public partial class Form1 : Form
    {
        public List<string> list = new List<string>();

        public Form1()
        {

            InitializeComponent();                  // 완전 초기화 기능 함수  

            // case 1) 여러 개의 버튼을 생성하되, 일정 확률로 버튼의 Visible을 지정해볼 것

            //my_btn.Text = "코드에서 변경!";
            //my_btn.Width = 100;

            //for(int i = 0; i < 5; i++)
            //{
            //    Button button = new Button();
            //    Controls.Add(button);
            //    Point pos = new Point();
            //    pos.X = 100;
            //    pos.Y = 100 + (30 * i);
            //    button.Location = pos;
            //    button.Text = "동적 생성" + (i+1) + "번째";
            //    button.AutoSize = true;
            //    Random rand = new Random();
            //    bool visible = rand.Next(2) == 0 ? false : true;
            //    Thread.Sleep(10);
            //    button.Visible = visible;
            //}


            // case 2) Label을 List (전역으로 선언) 와 연동하여 버튼을 만들어 삭제하고 추가하는 라벨 생성 가능

            
            ListText.Text = "List!!";

            Random rand = new Random();

            button1.Text = rand.Next(100).ToString();
            button5.Text = button1.Text;
            button2.Text = rand.Next(100).ToString();
            button6.Text = button2.Text;
            button3.Text = rand.Next(100).ToString();
            button7.Text = button3.Text;
            button4.Text = rand.Next(100).ToString();
            button8.Text = button4.Text;


        }

        private void mylabel_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //mylabel.Text = random.Next(1, 45).ToString();
            // mylabel.Text = random.Nextdouble().ToString(); 실수 Nextdouble() 0 ~ 1사이의 실수 출력
        }

        private void my_btn_Click(object sender, EventArgs e)
        {
            //my_btn.Text = "Click";
        }


        //// case 2) Label을 List (전역으로 선언) 와 연동하여 버튼을 만들어 삭제하고 추가하는 라벨 생성 가능

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(button1.Text);
            ListText.Text = "";
            foreach(var item in list)
            {
                ListText.Text += item + " ";
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(button2.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Add(button3.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Add(button4.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Remove(button5.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Remove(button6.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Remove(button7.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.Remove(button8.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window_frame_20200806
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_test.Text = "LSH";
            btnClickthis.Text = "천재";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Random r = new Random();
            lblHelloWorld.Text = r.Next(1, 10).ToString();            // 랜덤 객체 안에서 next(a, b) a부터 b 까지의 난수 출력이라는 함수를 가져온다. 난수를 가져올때 string으로 바꿔줘야함. 


            Label L1 = new Label();
            L1.Text = r.Next(1, 10).ToString();

            Point pos = new Point();                                  // 라벨L1의 위치정보 저장
            pos.X = 100;                                              // X 좌표
            pos.Y = 100;                                              // Y 좌표
            L1.Location = pos;                                        // Location 할당

            Controls.Add(L1);                                         // 추가

            //MessageBox.Show("Hello");
            //btn_test.AutoSize = true;
            //btn_test.Text += "+";
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {
            //lblHelloWorld.Text = "힝 속았지!";
        }

        private void btnClickthis_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            //btnClickthis.AutoSize = true;
            //btnClickthis.Text += "+";
        }
    }
}

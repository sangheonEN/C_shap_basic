using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace windows_form_example
{
    public partial class Form1 : Form
    {
        Random R = new Random();
        int solution;

        public Form1()
        {
            InitializeComponent();
            button1_random.Text = "정답 확인";
            label_random.Text = "1 ~ 100 사이의 수를 입력하시오.";
            label_rock_siser_paper.Text = "\'가위 바위 보\' 게임을 하겠습니다. 원하는 주먹을 입력하세요.";
            button__rock_siser_paper.Text = "정답 확인";

            solution = R.Next(1, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string text = textBox_output.Text;
            int text2 = int.Parse(textBox_output.Text);

            if (solution == text2)
            {
                MessageBox.Show(textBox_output.Text + " 정답입니다.");
                Application.Exit();
            }
            else if (solution > text2)
            {
                MessageBox.Show(textBox_output.Text + "수 보다 큽니다.");
            }
            else
            {
                MessageBox.Show(textBox_output.Text + "수 보다 작습니다.");
            }
        }

        private void button__rock_siser_paper_Click(object sender, EventArgs e)
        {

            int A = R.Next(1, 4);

            string text2 = textBox__rock_siser_paper.Text;

            int temp = 0;

            
            // 가위 : 1, 바위 : 2, 보 : 3

            if(text2 == "가위")
            {
                temp = 1;
            }
            else if(text2 == "바위")
            {
                temp = 2;
            }
            else if(text2 == "보")
            {
                temp = 3;
            }

            if(A == temp)
            {
                MessageBox.Show("무승부");
            }
            else if (A == 1 && temp == 2)
            {
                MessageBox.Show("승리하셨습니다.");
            }
            else if (A == 1 && temp == 3)
            {
                MessageBox.Show("패배하셨습니다.");
            }
            else if (A == 2 && temp == 1)
            {
                MessageBox.Show("패배하셨습니다.");
            }
            else if (A == 2 && temp == 3)
            {
                MessageBox.Show("승리하셨습니다.");
            }
            else if (A == 3 && temp == 1)
            {
                MessageBox.Show("패배하셨습니다.");
            }
            else if (A == 3 && temp == 2)
            {
                MessageBox.Show("승리하셨습니다.");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("1등");
            listBox1.Items.Add("2등");
            listBox1.Items.Add("3등");
            listBox1.Items.Add("4등");
            listBox1.Items.Add("5등");
            listBox1.Items.Add("6등");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> str = new List<string>();

            str.Add("이상헌 천재");
            str.Add("김하영 천재");
            str.Add("이상헌 바보");
            str.Add("김하영 바보");
            str.Add("한화솔루션 주가 4만 돌파 가즈아!!");
            str.Add("셀트리온 속 좀 그만 썩이고 올라가자!!");
            str.Add("보테가 베네타 지갑 사자!!");

            Random a = new Random();

            int A = a.Next(0, 7);

            for(int i = 0; i <= A; i++)
            {
                
                Random_Label.Text = str[i];
            }
        }
    }
}

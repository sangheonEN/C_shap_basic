using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form_example
{
    public partial class Form1 : Form
    {
        Random R = new Random();
        int solution;

        public Form1()
        {
            InitializeComponent();
            button1.Text = "정답 확인";
            mylabel.Text = "1 ~ 100 사이의 수를 입력하시오.";

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

    }
}

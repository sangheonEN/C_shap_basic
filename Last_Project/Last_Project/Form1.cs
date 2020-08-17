using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Last_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += button2Click;           // button2Click 함수내용이 Click


            //델리게이트
            button3.Click += delegate (object sender, EventArgs e)      // 함수대신 delegate를 사용하여 변수처럼 사용할 수 있음.
            {
                MessageBox.Show("델리게이트!!!");
            };

            //람다 = 델리게이트 축약형

            button3.Click += (object sender, EventArgs e)
                =>
            {
                MessageBox.Show("람다");
            };

        }

        private void button2Click(object sender, EventArgs e)        // 메서드를 추가함
        {
            //throw new NotImplementedException();
            MessageBox.Show("메서드를 추가해서 이벤트 발생!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form에서 더블 클릭해서 이벤트 만듬!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 다른 이름으로 저장 창이 뜨게하는 코드
            saveFileDialog1.Filter = "모든파일 (*.*)|*.*|txt File(*.txt)|*.txt";
            saveFileDialog1.ShowDialog();

            int j = 0;

            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                j = int.Parse("asvb");
            }
            catch(FileLoadException)
            {
                MessageBox.Show("FileLoadException 하하");
            }
            catch (Exception except)  // 모든 범위의 Exception
            {
                MessageBox.Show("헉");
                MessageBox.Show(except.Message);
                MessageBox.Show(except.StackTrace);
                j = 0;
            }
            MessageBox.Show(saveFileDialog1.FileName);

        }
    }
}

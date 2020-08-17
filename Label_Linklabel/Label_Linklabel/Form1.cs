using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_Linklabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //linklabel 동적 생성 생성자에 중괄호하고 안에 Text, Location등의 정보를 입력 후 세미클론은 중괄호 끝에 붙인다.
            LinkLabel linklabel_temp = new LinkLabel()
            {
                Text = "글자",
                Location = new Point(200, 200)
            };

            linklabel_temp.Click += linklabel_temp_Click;

            Controls.Add(linklabel_temp);          // Controls.Add로 linklabel을 추가함.

        }

        private void linklabel_temp_Click(object sender, EventArgs e)         // Linklabel Click 이벤트 추가
        {
            //throw new NotImplementedException();
            MessageBox.Show("Hi there?");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://naver.com");   // 원하는 URL 주소로 들어감.
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            foreach(var item in Controls)
            {
                if(item is CheckBox)           // item is CheckBox : is의 역할 CheckBox 타입이다! 라는 뜻. True면 if문 실행
                {
                    CheckBox c = item as CheckBox;           // item을 CheckBox로 형변환
                    if(c.Checked)                            // c 체크박스에 체크가 되어있는 애들이라면 list에 c의 텍스트를 추가한다.
                    {
                        list.Add(c.Text);
                    }
                }
            }
            MessageBox.Show(string.Join("@", list)); // ,로 구분하여 메세지 박스에서 출력
            //list[0]@list[1]@ ...@list[Count-1] 상위에 선언한 List 클래스의 list 인스턴스를 [0] 번째 부터 Count-1 번째 까지 이어 붙임 하지만, @ <<내가설정함 구분자 기준으로 각 인덱스를 나눠줌.
        }
    }
}

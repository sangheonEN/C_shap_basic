using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Button> myButtons = new List<Button>();
        List<Button> mylist = new List<Button>();

        public int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //COUNT 변수를 사용한 버튼 동적 생성
        private void button1_Click(object sender, EventArgs e)
        {
            Button bun = new Button();
            myButtons.Add(bun);
            if (count < 100)
            {
                myButtons[count].Location = new Point(50 + 25 * count, 50 + 25 * count);
                myButtons[count].Name = "myButton" + count.ToString();
                myButtons[count].Text = "Button" + count.ToString();
                Controls.Add(myButtons[count]);
                count++;
            }
            else
            {
                Application.Exit();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            foreach (var item in mylist)
            {
                Console.WriteLine($"{item.Location}");
                Console.WriteLine($"{item.Text}");
            }
        }


        //random을 사용한 버튼 동적 생성
        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Button bun = new Button();
            bun.Location = new System.Drawing.Point(random.Next(10,770), random.Next(10,450));
            bun.Size = new System.Drawing.Size(75, 23);
            bun.Text = "버튼추가";
            bun.UseVisualStyleBackColor = true;
            bun.Click += new System.EventHandler(this.button3_Click);

            this.Controls.Add(bun);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Button item in mylist)
            {
                this.Controls.Remove(item);
            }
            //this.Controls.Clear();
        }
    }
}

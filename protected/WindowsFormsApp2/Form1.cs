using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    // 접근 제한자 protected
    // protected : 상속관계에서 접근이 가능함.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            B b = new B();
            textBox1.Text = "abc" + Environment.NewLine + "abc";
            textBox1.Text = b.ReturnA();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Child ch1 = new Child();
        
        }
    }
}

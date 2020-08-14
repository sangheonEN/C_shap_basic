using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        class CustomerForm : Form { }

        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;   //속성에서 지정가능
        }

        // Form 안에 해당 Form을 넣음 (주식회사 프로그램 보면 내부에 창이 많이 띄어지는 것)
        private void button1_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.MdiParent = this;
            form.Show();
        }

        // 다른 Form을 생성하여 MDI로 Form1 안에 Form2를 넣음
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();                          
            form2.MdiParent = this;
            form2.Show();
        }
    }
}

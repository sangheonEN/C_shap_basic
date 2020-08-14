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

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}

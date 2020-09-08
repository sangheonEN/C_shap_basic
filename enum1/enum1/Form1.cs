using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enum1
{
    public partial class Form1 : Form
    {
        enum OderState { Ordered = 1, Paymented = 2, Prepared = 3, Sended = 4}
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(OderState.Ordered.ToString());
            MessageBox.Show(OderState.Paymented.ToString());
            MessageBox.Show(OderState.Prepared.ToString());
            MessageBox.Show(OderState.Sended.ToString());

        }
    }
}

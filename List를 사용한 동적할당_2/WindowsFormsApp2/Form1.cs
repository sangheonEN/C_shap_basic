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
    public partial class Form1 : Form
    {
        List<Button> mybtn = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Button btn = new Button();

            btn.Location = new System.Drawing.Point(random.Next(100,400), random.Next(100,400));
            btn.Size = new System.Drawing.Size(131, 56);
            btn.Text = "button_add";
            btn.UseVisualStyleBackColor = true;
            btn.Click += new System.EventHandler(this.button_add_Click);

            mybtn.Add(btn);

            this.Controls.Add(btn);

        }

        private void button_log_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }
    }
}

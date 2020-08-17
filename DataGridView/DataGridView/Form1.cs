using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        List<Product> plist = new List<Product>();
        public Form1()
        {
            InitializeComponent();

            plist.Add(new Product() { Name = "디올 옴므 F/W 20 자카드 반지갑", Price = 600000, Color = "Special Fix" });
            plist.Add(new Product() { Name = "고야드 인서트 카드지갑", Price = 500000, Color = "Green" });
            plist.Add(new Product() { Name = "보테가 베네타 카드지갑", Price = 620000, Color = "Black" });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = plist;

        }
    }
}

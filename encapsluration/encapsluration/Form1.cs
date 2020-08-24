using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encapsluration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // EnumItem을 collection형태로 변경하는 방법
            EnumItem[] ei = (EnumItem[])Enum.GetValues(typeof(EnumItem));

            foreach (EnumItem itemi in ei)
            {
                cboxitem.Items.Add(itemi.ToString());
            }

            EnumRate[] er = (EnumRate[])Enum.GetValues(typeof(EnumRate));

            foreach (EnumRate itemr in er)
            {
                cboxrate.Items.Add(itemr.ToString());

            }


            //    cboxitem.Items.Add(EnumItem.계란.ToString());
            //    cboxitem.Items.Add(EnumItem.고기.ToString());
            //    cboxitem.Items.Add(EnumItem.과자.ToString());
            //    cboxitem.Items.Add(EnumItem.냉동식품.ToString());
            //    cboxitem.Items.Add(EnumItem.라면.ToString());
            //    cboxitem.Items.Add(EnumItem.물.ToString());
            //    cboxitem.Items.Add(EnumItem.즉석식품.ToString());
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Cdata _ = new Cdata();

            //_.Stritem = "ㅁㄴㅇㄹㄴㅇㄹ";         // set을 호출 하는 방법 문자형을 넣어주면 저게 set이 된다.
            //string dd = _.Stritem;                // dd가 get이 된다. get은 private 변수라도 반환하여 그 변수를 다른 변수에 저장해서 사용할 수 있게 한다.


            //if(cboxitem.Text != null)
            //{
            //    _.SetStritem(cboxitem.Text);
            //}
            //_.Irate = int.Parse(cboxitem.Text);
            //_.Icount = int.Parse(cboxitem.Text);
          
        }
    }
}

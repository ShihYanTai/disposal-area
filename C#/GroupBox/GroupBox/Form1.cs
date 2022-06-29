using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            string gift = "",sel = "";
            if(radioButton1.Checked == true)
            {
                total = 55000;
            }
            else if(radioButton2.Checked == true)
            {
                total = 45000;
            }
            else if (radioButton3.Checked == true)
            {
                total = 30000;
            }
            else
            {
                total = 0;
            }
            if(radioButton4.Checked == true)
            {
                gift = "行動電源";
            }
            else if(radioButton5.Checked == true)
            {
                gift = "燒錄機";
            }
            else
            {
                gift = "請先選購筆電好禮送";
            }

            if(checkBox1.Checked == true)
            {
                total += 1600;
                sel += "行動硬碟 ";
            }
            if(checkBox2.Checked == true)
            {
                total += 1200;
                sel += "無線傳輸器";
            }
            if(checkBox3.Checked == true)
            {
                total += 800;
                sel += "後背包";
            }
            sel = sel == ""?"": "\n 選配 : " + sel; //如非空字串則顯示加點項目
            label1.Text = $"總計 : {total} 元 \n 好禮 : {gift + sel}";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

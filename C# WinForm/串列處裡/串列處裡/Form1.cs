using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 串列處裡
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        List<int> mylist = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) mylist.Add(rd.Next(101));
            textBox1.AppendText(" 新增 10 個元素 \r\n");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText(" 共有 " + mylist.Count.ToString() + " 個元素 \r\n");
            foreach (var item in mylist) textBox1.AppendText(item.ToString() + "\r\n");
            textBox1.AppendText(" 串列容量 = " + mylist.Capacity.ToString() + "\r\n");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int[] array;
            array = mylist.ToArray();
            textBox1.Clear();
            foreach(var item in array) textBox1.AppendText(item.ToString() + "\r\n");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            mylist.Sort();
            textBox1.AppendText(" 排序完成\r\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int v;
            bool fg;

            v = Convert.ToInt32(textBox2.Text);
            fg = false;
            foreach (var item in mylist)
            {
                if (item == v)
                {
                    fg = true; break;

                }
            }
            if (fg) textBox1.AppendText("第" + mylist.IndexOf(v).ToString() + " 個 \r\n");
            else textBox1.AppendText(" 找不到此元素 \r\n");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool fg;
            int v;

            v = Convert.ToInt32(textBox2.Text);
            fg = mylist.Remove(v);
            if (fg == true) textBox1.AppendText(" 移除成功 \r\n");
            else textBox1.AppendText(" 無此元素 \r\n");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mylist.Clear();
            textBox1.AppendText(" 清除串列 \r\n");
        }
    }
}

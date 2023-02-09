using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 委派_Multicast
{
    public partial class Form1 : Form
    {
        delegate void Dgate();
        public Form1()
        {
            InitializeComponent();
        }
        public void PreWords()
        {
            textBox1.AppendText("今日特價商品 : ");
        }
        public void Item()
        {
            if (radioButton1.Checked) textBox1.AppendText(" 雙層鉛筆盒 \r\n");
            else textBox1.AppendText("精美手工皂 \r\n");
        }
        public void Sold()
        {
            Random rd = new Random();
            int num;

            num = rd.Next(1, 30);
            textBox1.AppendText(" 只剩下 " + num + " 個\r\n");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dgate DelFunc1 = PreWords;
            Dgate DelFunc2 = Item;
            Dgate DelFunc3 = Sold;
            Dgate AllDel;

            AllDel = DelFunc1 + DelFunc2;
            AllDel();

            AllDel -= DelFunc2;
            AllDel += DelFunc3;

            AllDel();
        }
    }
}

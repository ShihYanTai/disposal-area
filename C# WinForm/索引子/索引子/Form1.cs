using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 索引子
{
    public partial class Form1 : Form
    {
        MyClass myclass;
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
            myclass = new MyClass(10);

            // 透過索引子設定 number 屬性
            for (int i = 0; i < 10; i++) myclass[i] = rd.Next(100);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 透過索引子讀取 number 屬性
            for (int i = 0; i < 10; i++) textBox1.AppendText(myclass[i].ToString() + "\r\n");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // 直接讀取 number 屬性
            for (int i = 0; i < 10; i++) textBox1.AppendText(myclass.number[i].ToString() + "\r\n");
        }
        class MyClass
        {
            public int[] number; // 陣列型式的屬性
            public MyClass(int num)
            {
                if (num <= 0) num = 10;
                number = new int[num];
            }
            public int this[int index]
            {
                get { return number[index]; }
                set { number[index] = value; }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多個索引子
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 5;
            int index;
            string str;
            MyClass myClass = new MyClass(num);
            int[] score = new int[] { 80, 92, 67, 84, 60 };
            string[] name = new string[] { " 王小明 ", " 真美麗 ", " 王老五 ", " 瑪莉 ", " 約翰 " };
            for(int i = 0;i < num; i++) myClass.Add(i, name[i], score[i]);
            index = Convert.ToInt32(textBox1.Text) - 1;
            if(index < 0 || index >= num)
            {
                MessageBox.Show(" 無此編號 ");
                return;
            }
            str = myClass[index];
            textBox2.AppendText(str + " 的分數 = ");
            textBox2.AppendText(myClass[str].ToString() + "\r\n");
        }
        class MyClass
        {
            int[] score;        // 分數
            string[] name;      // 姓名
            public MyClass(int num)
            {
                if (num <= 0) num = 5;
                score = new int[num];
                name = new string[num];
            }
            // 新增一筆資料 : 姓名、分數
            public void Add(int i, string str, int s)
            {
                if(i < 0 || i > score.Length - 1) return;
                name[i] = str;
                score[i] = s;
            }
            // 索引子 : 使用陣列索引值查詢姓名
            public string this[int i]
            {
                get
                {
                    if (i < 0 || i > name.Length - 1) return "";
                    else return name[i];
                }
            }
            // 索引子 : 使用姓名查詢分數
            public int this[string str]
            {
                get
                {
                    for(int i = 0;i < name.Length;i++)
                    {
                        if (str.Equals(name[i])) return score[i];
                    }
                    return -1;
                }
            }
        }
    }
}

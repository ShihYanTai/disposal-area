﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr1 = { 15, 32, 18, 5, 19, 2, 13, 8, 22 };
            int[] arr2 = { 11, 12, 13, 14, 15, 16 };
            int c;
            int[] arr4;
            int[] arr5 = new int[arr1.Length];

            // 將陣列 a 排序
            textBox1.AppendText("--- sort ---\r\n");
            Array.Sort(arr1);
            // Array.Sort(a,1,3); // 陣列 a 的索引值第 1-3 做排序
            foreach (var item in arr1)
                textBox1.AppendText(item.ToString() + "\r\n");

            // 尋找 18 是否在陣列 a 裡面
            textBox1.AppendText("-- binary search ---\r\n");
            c = Array.BinarySearch(arr1, 18);
            if (c < 0)
                textBox1.AppendText("找不到 \n");
            else
                textBox1.AppendText("在第" + c.ToString() + "個陣列位置 \r\n");

            //----------------------- clear ----------------------------------------------

            textBox1.AppendText("------clear-------\r\n");
            Array.Clear(arr1, 2, 4);
            foreach (var item in arr1)
                textBox1.AppendText(item.ToString() + "\r\n");

            //------------------------ clone --------------------------------------------

            textBox1.AppendText("-----clone--------\r\n");
            arr4 = (int[])arr2.Clone();
            foreach (var item in arr4)
                textBox1.AppendText(item.ToString() + "\r\n");

            //------------------------ copy ----------------------------------------------
            textBox1.AppendText("------CopyTo-------\r\n");
            arr1.CopyTo(arr5, 0);
            foreach (ValueType item in arr5)
                textBox1.AppendText(item.ToString() + "\r\n");

            //------------------------ reverse ----------------------------------------------
            textBox1.AppendText("----- Reverse ------\r\n");
            Array.Reverse(arr1);
            foreach(ValueType item in arr1)
                textBox1.AppendText(item.ToString() + "\r\n");
        }
    }
}

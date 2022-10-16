﻿using System;
using System.Windows.Forms;

namespace 可變數量參數
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fee;
            fee = compute(1, 3, 7); // 王小名
            label1.Text = " 王小明租金 =" + fee.ToString();

            fee = compute(1, 7);    // 王小名
            label2.Text = "王大明租金 =" + fee.ToString();
        }
        int compute(params int[] days)
        {
            double fee = 0;             // 租車費用
            for(int i = 0; i < days.Length; i++)
            {
                switch (days[i])
                {
                    case 6: // 星期六日
                    case 7: fee += 500;
                        break;
                    case 1: // 星期一五
                    case 5: fee += 500 * 0.9;
                        break;
                    case 2: // 星期二
                        fee += 500 * 0.85;
                        break;
                    case 3: // 星期三四
                    case 4: fee += 500 * 0.8;
                        break;
                }
            }
            // 將金額四捨五入之後再回傳
            return Convert.ToInt32(Math.Round(fee, MidpointRounding.AwayFromZero));
        }
    }
}

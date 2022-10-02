using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電腦周邊採買
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int w_h = 50;                                       // 按鈕的寬與高
            int gap = w_h + 20;                                 // 放置按鈕的位置，20為按鈕之間的間距。

            // 幫每一個按鈕進行設定
            for(int i = 0; i < 3; i++)
                for(int j = 0; j < 3; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Tag = i * 3 + j;                  // 設定按鍵唯一的編號
                    btn[i, j].Text = btn[i, j].Tag.ToString();
                    btn[i, j].Width = w_h;
                    btn[i, j].Height = w_h;
                    btn[i, j].Location = new Point(70 + j * gap, 70 + i * gap);
                    btn[i, j].Click += MyClick;                 // 設定按鍵的 Click 事件
                    this.Controls.Add(btn[i, j]);               // 把按鈕加入表單
                }
        }

        // ------------------- 自訂 Click 事件-----------------------------------

        private void MyClick(object sender, EventArgs e)
        {
            string str;
            // 將 sender 轉型成按鈕型別，並取得其Tag的資料
            str = ((Button)sender).Tag.ToString();
            label1.Text = str;
        }
    }
}

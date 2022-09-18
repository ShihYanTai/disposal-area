using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleBoy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            int x = 10;             // 初始座標
            int move = 10;          // 移動量
            int index = 0;          // 影像編號
            pictureBox1.Left = x;   // 設定初始的pictureBox1的位置 
                                    // 將imageList1的影像的寬與高設定給pictureBox1
            pictureBox1.Width = imageList1.ImageSize.Width;
            pictureBox1.Height = imageList1.ImageSize.Height;

            while(x + pictureBox1.Width + move < ClientSize.Height)
            {
                try
                {
                    pictureBox1.Image = imageList1.Images[index];
                }
                catch(Exception ex)
                {
                    return;
                }
                
                x += move;          // 下次移動的位置
                pictureBox1.Left = x;// 重新設定pictureBox1的位置

                if (++index > 4)    // 圖片索引加1，若圖片編號超過4
                {
                    index = 0;      // 則在重編編號1開始
                }

                Refresh();          // 表單重繪
                System.Threading.Thread.Sleep(100);     // 暫停0.1秒

                Application.DoEvents();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 建立Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;                            // 透過 PaintEventArgs 取得 Graphics
            Pen pen = new Pen(Color.Red, 3);                    // 宣告並建立畫筆

            g.DrawRectangle(pen, 25, 70, 200, 150);             // 畫一個矩形
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 透過 CreateGraphics() 建立 pictureBox1 的 Graphics
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 3);           // 宣告並建立畫筆
            // 畫一矩形 
            g.DrawRectangle(pen, 1, 1, 170, pictureBox1.Height - 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g;
            Pen pen = new Pen(Color.Yellow, 3);         // 宣告並建立畫筆

            pictureBox1.Image = Image.FromFile("pic1.bmp");
            g = Graphics.FromImage(pictureBox1.Image);
            g.DrawRectangle(pen, 10, 10, 100, 100);
        }
    }
}

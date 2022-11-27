using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 繪製文字
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            string str = " 最簡單的繪製文字方式";
            Font font = new Font("Time New Roman", 16);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.Clear(Color.White);
            g.DrawString(str, font, brush, 80, 50);
            font.Dispose();
            brush.Dispose();
            g.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g;
            StringFormat sformat = new StringFormat();
            Font font = new Font("Time New Roman", 16);
            SolidBrush brush = new SolidBrush(Color.Red);
            string str = "Every day is a \ngood day.";
            string str1 = "Every day is a good day.";
            Rectangle rect = new Rectangle(20, 120, 150, 50);
            g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);
            g.DrawString(str, font, brush, 20, 50);
            brush.Color = Color.Blue;
            sformat.Alignment = StringAlignment.Near;
            sformat.FormatFlags = StringFormatFlags.DirectionVertical;
            g.DrawString("垂直文字", font, brush, 180, 50, sformat);

            font.Dispose();
            brush.Dispose();
            g.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "AbcdEF, 你好嗎?";
            Font font = new Font("Times New Roman", 16);
            Graphics g;
            Point pt = new Point(50, 50);
            SizeF strSize;
            g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);
            g.DrawString(str, font, Brushes.Blue, pt);
            strSize = g.MeasureString(str, font);
            g.DrawRectangle(new Pen(Color.Red, 1), 50, 50, strSize.Width, strSize.Height);

            font.Dispose();
            g.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g;
            string str = " 早上 7 點起床，天氣很好，快樂上學 ";
            Font font = new Font("標楷體", 16);
            RectangleF strRect, rect1, rect2;
            Region[] strRegions;                // 儲存被框住的2個子字串的範圍
            StringFormat sf;                    // 字串格式
            // 設定字串中，欲量測的2個子字串的範圍
            CharacterRange[] ranges = { new CharacterRange(0, 5), new CharacterRange(10, 6) };
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            strRect = new RectangleF(20, 50, 400, 35);

            sf = new StringFormat();            // 配置字串格式
            // 將 2 個子字串的量測範圍 range 設定給字串格式
            sf.SetMeasurableCharacterRanges(ranges);

            // 繪製字串
            g.DrawString(str, font, Brushes.Black, 20, 50, sf);

            // 計算2個子字串的框住範圍
            strRegions = g.MeasureCharacterRanges(str, font, strRect, sf);

            // 取的第一的框住的子字串的矩形，並繪製此矩型
            rect1 = strRegions[0].GetBounds(g);
            g.DrawRectangle(new Pen(Color.Red, 1), Rectangle.Round(rect1));

            // 取得第二個被框住的子字串的矩陣，並繪製矩型
            rect2 = strRegions[1].GetBounds(g);
            g.DrawRectangle(new Pen(Color.Blue, 1), Rectangle.Round(rect2));

            font.Dispose();
            g.Dispose();
        }
    }
}

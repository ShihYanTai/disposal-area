using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 影像繪製縮放
{
    public partial class Form1 : Form
    {
        enum PROCESS_DPI_AWARENESS
        {
            PROCESS_DPI_UNAWARE = 0,
            PROCESS_SYSTEM_DPI_AWARE = 1,
            PROCESS_PER_MONITOR_DPI_AWARE = 2
        }
        [DllImport("shcore.dll")]
        static extern int SetProcessDpiAwareness(PROCESS_DPI_AWARENESS v);
        public Form1()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDpiAwareness(PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE);
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Size size = new Size(200, 100);
            g.Clear(Color.White);
            g.CopyFromScreen(0, 0, 10, 10, size);
            g.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Image img = Image.FromFile("train.png");
            Point ul = new Point(60, 10);           // 左上
            Point ur = new Point(300, 100);         // 右上
            Point ll = new Point(150, 150);         // 左下
            Point[] points = { ul, ur, ll };

            g.Clear(Color.White);
            g.DrawImage(img, 5, 5);
            MessageBox.Show("按鍵繼續");
            g.Clear(Color.White);

            // 顯示局部影像
            g.DrawImage(img, 10, 10, new Rectangle(50, 50, 100, 100), GraphicsUnit.Pixel);
            // 縮小影像
            g.DrawImage(img, new Rectangle(10, 120, 64, 64));
            // 繪製平行四邊形影像
            g.DrawImage(img, points);

            g.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            float wRes, hRes, dpi;                      // 影像的寬與高的 DPI、螢幕 DPI
            string str;
            Image img;
            int gap;

            g.Clear(Color.White);
            dpi = g.DpiX;
            img = Image.FromFile("circle-96.png");
            g.DrawImageUnscaled(img, 20, 50);
            wRes = img.HorizontalResolution;    // 影像寬的 DPI
            hRes = img.VerticalResolution;      // 影像長的 DPI
            gap = (int)((float)img.Width / wRes * dpi);
            str = "circle-96.png: " + img.Width.ToString() + "x" + img.Height.ToString() + "-\n" + wRes.ToString() + ", " + hRes.ToString();
            g.DrawString(str, new Font("Time New Roman", 12), new SolidBrush(Color.Black), new PointF(20, 2));
            img = Image.FromFile("circle-216.png");
            wRes = img.HorizontalResolution;
            hRes = img.VerticalResolution;
            g.DrawImageUnscaled(img, 40 + gap, 50);
            str = "circle-216.png: " + img.Width.ToString() + "x" + img.Height.ToString() + "-\n" + wRes.ToString() + ", " + hRes.ToString();
            g.DrawString(str, new Font("Time New Roman", 12), new SolidBrush(Color.Black), new PointF(40 + gap, 2));
            g.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Image img = Image.FromFile("train.png");
            g.DrawImageUnscaledAndClipped(img, new Rectangle(20, 20, img.Width / 2, img.Height / 2));
        }
    }
}

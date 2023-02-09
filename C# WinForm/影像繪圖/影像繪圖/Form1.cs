using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 影像繪圖
{
    public partial class Form1 : Form
    {   // 可以放在 From1.cs 也可以放在 Program.cs 裡面
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
            Image img1, img2;
            Pen pen = new Pen(Color.Red, 2);
            float imgDPI, scrDPI;                   // 影像、螢幕的DPI
            GraphicsUnit unit = GraphicsUnit.Pixel;
            RectangleF rectF;                       // 影像邊框的範圍

            scrDPI = g.DpiX;                        // 螢幕的DPI
            img1 = Image.FromFile("train.png");
            imgDPI = img1.HorizontalResolution;

            g.Clear(Color.White);
            img2 = (Image)img1.Clone();             // 複製影響
            g.DrawImageUnscaled(img2, 50, 10);

            // 因螢幕解析度和HDPI 的不同，調整影像邊框的大小
            rectF = img2.GetBounds(ref unit);
            rectF.X += 50;                          // 調整邊框的位置
            rectF.Y += 10;
            // 挑整邊框的大小
            rectF.Width = rectF.Width / imgDPI * scrDPI;
            rectF.Height = rectF.Height / imgDPI * scrDPI;
            g.DrawRectangle(pen, Rectangle.Round(rectF));

            g.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Image img, thumbImg;                    // 原始影像、縮圖影像
            Image.GetThumbnailImageAbort tnCallback;

            img = Image.FromFile("train.png");
            tnCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
            g.Clear(Color.White);
            // 製作 60x60 的縮圖
            thumbImg = img.GetThumbnailImage(60, 60, tnCallback, IntPtr.Zero);
            g.DrawImage(thumbImg, 50, 10);
            g.Dispose();
        }
        public bool ThumbnailCallback()
        {
            return false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Image img = Image.FromFile("train.png");

            g.Clear(Color.White);
            // 將影像水平翻轉
            img.RotateFlip(RotateFlipType.RotateNoneFlipX);
            g.DrawImageUnscaled(img, 50, 20);
            g.Dispose();
        }
    }
}

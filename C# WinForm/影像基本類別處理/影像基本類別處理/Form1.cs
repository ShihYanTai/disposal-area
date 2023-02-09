using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 影像基本類別處理
{
    public partial class Form1 : Form
    {
        enum PROCESS_PDI_AWARENESS
        {
            PROCESS_DPI_UNAWARE = 0, PROCESS_SYSTEM_DPI_AWARE = 1, PROCESS_PER_MONITOR_DPI_AWARE = 2
        }
        [DllImport("shcore.dll")]
        static extern int SetProcessDpiAwareness(PROCESS_PDI_AWARENESS v);
        public Form1()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDpiAwareness(PROCESS_PDI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g;
            Bitmap bmp = new Bitmap("India029.png");
            Pen pen = new Pen(Color.Red, 2);

            pictureBox1.Image = bmp;
            MessageBox.Show(" 按鍵繼續");
            // 將 bmp 重新初始化
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.LightBlue);

            g.DrawRectangle(pen, 50, 50, 300, 200);
            pictureBox1.Image = bmp;
            pictureBox1.Image.Save("pic.jpg");

            g.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Bitmap bmp, cloneBmp;
            Rectangle rect = new Rectangle(100, 100, 200, 150);
            PixelFormat pFormat;

            g.Clear(Color.White);
            bmp = new Bitmap("India029.png");
            pFormat = bmp.PixelFormat;
            cloneBmp = bmp.Clone(rect, pFormat);
            g.DrawImageUnscaled(cloneBmp, 0, 0);
            g.Dispose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Bitmap sBmp, tBmp;
            int w, h;
            byte gray;
            Color c;
            sBmp = new Bitmap("India029.png");
            w = sBmp.Width;
            h = sBmp.Height;
            tBmp = new Bitmap(w, h);

            for(int y = 0; y < h; y++)
            {
                for(int x = 0; x < w; x++)
                {
                    c = sBmp.GetPixel(x, y);
                    gray = (byte)(c.R * 0.299 + c.G * 0.587 + c.B * 0.114);
                    tBmp.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            /*
             如果使用 :
            pictureBox1.Image = tBmp;
            則在表單被縮小再回復，或是表單移出螢幕時，
            在 pictureBox 上的影像就不會消失。
             */
            g.Clear(Color.White);
            g.DrawImageUnscaled(tBmp, 0, 0);
            g.Dispose();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Bitmap bmp = new Bitmap("cup.png");
            g.Clear(Color.White);
            g.DrawImageUnscaled(bmp, 0, 0, bmp.Width, bmp.Height);
            bmp.MakeTransparent(Color.Red);
            g.DrawImageUnscaled(bmp, bmp.Width, 0, bmp.Width, bmp.Height);
            g.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace PhotoGallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ShowThumb(string[] filenames, int no, Graphics g)
        {
            // 根據視窗大小，計算縮圖大小 w, h 與位置 x, y
            double ratio = (double)this.ClientRectangle.Width / (double)this.ClientRectangle.Height;
            int noHorizontal = (int)Math.Ceiling(Math.Sqrt(ratio * filenames.Length));
            int noVertical = (int)Math.Ceiling((double)filenames.Length / noHorizontal);
            int w = this.ClientRectangle.Width / noHorizontal;
            int h = this.ClientRectangle.Height / noVertical;
            int x = no % noHorizontal * w;
            int y = no % noVertical * h;

            // 顯示縮圖
            Bitmap bmp = new Bitmap(filenames[no]);
            Image img = bmp.GetThumbnailImage(w, h, null, IntPtr.Zero);
            lock (g)
            {
                g.DrawImage(img, x, y);
            }
            img.Dispose();
            bmp.Dispose();
            Thread.Sleep(200); // 放慢速度，讓顯示的過程看得更清楚
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Gray);
            // 取得資料夾中的所有圖片檔路徑
            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\photos";
            string[] filenames = Directory.GetFiles(path, "*.jpg");

            // 逐一顯示每一個圖片的縮圖
            Parallel.For(0, filenames.Length, (i) =>
            {
                ShowThumb(filenames, i, e.Graphics);
            });
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}

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

namespace 快速影像處理
{
    public partial class Form1 : Form
    {
        enum PROCESS_DPI_AWARENESS
        {
            DPI_AWARENESS_UNAWARE = 0,
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
            Bitmap bmp = new Bitmap("India029.bmp");
            BitmapData bmpData;
            int skip; // 掃描線與影像真正寬度的差距
            byte gray;

            // 使用 DrawImage 或 DrawImageUnscaled 畫面不會自動重繪
            // 因此這裡直接將bmp設定給pictureBox1.Image
            pictureBox1.Image = bmp;


            /*
            如果原始影像是"India029.png，則像素格式不能使用
            原影像的像素格式，而必須使用 PixelFormat.Format24bppRgb。
            因為此張影像不是 RGB 24bits。因此要強制轉換成 PixelFormat.Format24bppRgb
             */
            bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            skip = bmpData.Stride - bmpData.Width * 3;

            // C# 不支援指標運算。通過使用unsafe 關鍵字，可以定義使用指標的不安全程式碼
            unsafe
            {
                byte* ptr = (byte*)(bmpData.Scan0);
                for(int y = 0; y < bmpData.Height; y++)
                {
                    for(int x = 0; x < bmpData.Width; x++)
                    {
                        gray = (byte)(0.299 * ptr[2] + 0.587 * ptr[1] +0.114 * ptr[0]);
                        ptr[2] = ptr[1] = ptr[0] = gray;
                        ptr += 3;
                    }
                    ptr += skip;
                }
            }
            bmp.UnlockBits(bmpData);
            pictureBox1.Image = bmp;
        }
    }
}

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

namespace DPI
{
    public partial class Form1 : Form
    {
        enum PROCESS_DPI_AWARENEW
        {
            PROCESS_DPI_UNAWARE = 0,
            PROCESS_SYSTEM_DPI_AWARE = 1,
            PROCESS_PER_MONITOR_DPI_AWARE = 2
        }
        [DllImport("shcore.dll")]
        static extern int SetProcessDpiAwareness(PROCESS_DPI_AWARENEW v);
        void dpiAwareness()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDpiAwareness(PROCESS_DPI_AWARENEW.PROCESS_PER_MONITOR_DPI_AWARE);
        }
        public Form1()
        {
            InitializeComponent();
            dpiAwareness();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int dpiD;               // DPI
            int sWidth, sHeight;    // 螢幕寬與高
            float dpiX, dpiY;       // 螢幕水平與垂直 DPI
            Graphics g;             // 表單 Graphics 物件
            string str;

            g = this.CreateGraphics();
            sWidth = Screen.PrimaryScreen.Bounds.Width;
            sHeight = Screen.PrimaryScreen.Bounds.Height;
            dpiX = g.DpiX;          // 取得水平 DPI
            dpiY = g.DpiY;          // 取得垂直 DPI
            dpiD = this.DeviceDpi;
            
            str = String.Format("Screen: Width={0}, " + "Height={1}\n" + "DpiX={2}, DpiY={3}, DPI={4}", sWidth, sHeight, dpiX, dpiY, dpiD);
            label1.Text = str;
            label2.Text = "Form's width=" + this.Width.ToString();
        }
    }
}

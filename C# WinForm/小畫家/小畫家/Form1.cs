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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace 小畫家
{
    public partial class Form1 : Form
    {
        Pen pen;            // 畫筆
        int func;           // 功能代號
        bool fgModified;    // 畫面是否更改
        Graphics g, gBack;  // pictureBox1 之繪圖物件與雙緩衝區之繪圖物件
        Point p1, p2;       // p1: 上一次的滑鼠座標，p2: 目前的滑鼠座標
        Bitmap bmp;         // 供雙緩衝區所使用

        enum PROCESS_DPI_AWARENESS
        {
            PROCESS_DPI_UNAWARE = 0,
            PROCESS_SYSTEM_DPI_AWARE = 1,
            PROCESS_PER_MONINOR_DPI_AWARE = 2
        }
        [DllImport("shcore.dll")]
        static extern int SetProcessDpiAwareness(PROCESS_DPI_AWARENESS v);
        public Form1()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDpiAwareness(PROCESS_DPI_AWARENESS.PROCESS_PER_MONINOR_DPI_AWARE);
            InitializeComponent();
            initial(); // 初始化
        }
        void initial()
        {
            func = 1; // 預設為鉛筆功能
            fgModified = false;

            // 筆寬設定
            for(int i = 1; i <= 15; i+=2) { toolStripComboBox1.Items.Add(i); };   // 筆寬 : 1,3,.....,15
            for(int i = 20;i <= 50; i += 5) { toolStripComboBox1.Items.Add(i); };   // 筆寬 : 20, 25, ...50
            toolStripComboBox1.SelectedIndex = 0;

            // 初始畫筆設定
            pen = new Pen(Color.Black, 1);
            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);

            // 雙緩衝區設定與初始化
            g = pictureBox1.CreateGraphics();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gBack = Graphics.FromImage(bmp);
            gBack.Clear(Color.White);
            g.DrawImage(bmp,0, 0);
            pictureBox1.Image= bmp;
        }
        // --------------顯示座標------------------------
        void showCoordinate(string x, string y)
        {
            toolStripStatusLabel1.Text = "X=" + x + ": Y=" + y;
        }
        // --------------清除繪圖區-----------------------
        void clearCanvas()
        {
            gBack.Clear(Color.White);
            g.DrawImage(bmp, 0, 0);
        }
        // --------------儲存檔案-------------------------
        void saveFile()
        {
            DialogResult result;
            result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK) { bmp.Save(saveFileDialog1.FileName, ImageFormat.Jpeg); };
        }
        private void itemNewFile_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (!fgModified) clearCanvas(); // 畫面未更改
            else
            {
                result = MessageBox.Show("檔案尚未儲存，要存檔嗎?", "存檔", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) saveFile();
                clearCanvas();
            }
            fgModified = false;
        }
        private void itemReadFile_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if(fgModified) 
            { 
                result = MessageBox.Show("檔案尚未儲存，要存檔嗎?", "存檔", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) saveFile();
                fgModified= false;
            }
            result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK) 
            { 
                bmp = new Bitmap(openFileDialog1.FileName);
                g.DrawImage(bmp, 0, 0);
                gBack = Graphics.FromImage(bmp);
            }
        }
        private void itemSaveFile_Click(object sender, EventArgs e)
        {
            if (fgModified)
            {
                saveFile();
                fgModified = false;
            }
        }
        private void itemEnd_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if(fgModified)
            {
                result = MessageBox.Show("檔案尚未儲存，要儲存嗎?", "儲存", MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK) saveFile();
            }
            Close();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
            func = 1;       // 選擇了鉛筆功能
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton2.Checked = false;
            func = 2;       // 選擇麼畫斜線功能
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                pen.Color = colorDialog1.Color;
        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int w;
            w = Convert.ToInt32(toolStripComboBox1.Items[toolStripComboBox1.SelectedIndex]);
            pen = new Pen(colorDialog1.Color, w);
            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            showCoordinate(e.X.ToString(), e.Y.ToString());
            if (e.Button != MouseButtons.Left) { return; }
            switch (func)
            {
                case 1:         // 鉛筆功能
                    p2 = e.Location;
                    gBack.DrawLine(pen, p1, p2);
                    g.DrawImage(bmp, 0, 0);
                    p1 = p2;
                    break;
                case 2:
                    p2 = e.Location;
                    g.DrawImage(bmp, 0, 0);
                    g.DrawLine(pen, p1, p2);
                    break;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch(func)
            {
                case 1:
                case 2:
                    p1 = e.Location;
                    break; 
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            gBack.Dispose();
            g.Dispose();
        }
    }
}

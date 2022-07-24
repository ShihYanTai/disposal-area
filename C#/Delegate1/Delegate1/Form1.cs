using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate double DArea(int d1, int d2);       // 宣告 DArea 委派名稱
        public static double TriA(int H,int B)
        {
            return (H * B) / 2;
        }
        public static double RecA(int L, int W)
        {
            return L * W;
        }
        public static String GetArea(int x,int y, DArea tv)    // 設計委派方法
        {
            double area = tv(x, y);
            return $"高:{x}, 底:{y}, 面積:{area}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int d1 = 20, d2 = 10;           // 設定 高、 低的初值
            DArea dv;                       // 設定 dv 為 DArea() 方法型別的委派變數
            dv = new DArea(TriA);           // 連結指定方法的委派方法
            label1.Text = "1. 三角形...";
            label2.Text = GetArea(d1, d2, dv);
            label3.Text = "2. 矩形...";
            label4.Text = GetArea(d1, d2, new DArea(RecA));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 建立畫筆之顏色寬度樣式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 6);

            p.DashStyle = DashStyle.Custom;
            p.DashCap = DashCap.Triangle;
            p.DashPattern = new float[] { 4, 2, 1, 3 };
            g.Clear(Color.White);
            g.DrawLine(p, 150, 100, 300, 100);

            p.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 10);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            p.LineJoin = LineJoin.Round;
            graphics.Clear(Color.White);
            graphics.DrawRectangle(p, new Rectangle(150, 50, 180, 100));

            p.Dispose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);

            graphics.Clear(Color.White);
            p.DashStyle = DashStyle.Dash;
            graphics.DrawLine(p, 150, 20, 300, 20);

            p.DashStyle = DashStyle.DashDot;
            graphics.DrawLine(p, 150, 60, 300, 60);

            p.DashStyle = DashStyle.DashDotDot;
            graphics.DrawLine(p, 150, 100, 300, 100);

            p.DashStyle = DashStyle.Dot;
            graphics.DrawLine(p, 150, 140, 300, 140);

            p.DashStyle = DashStyle.Solid;
            graphics.DrawLine(p, 150, 180, 300, 180);

            p.Dispose();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 10);

            pen.EndCap = LineCap.Triangle;
            graphics.Clear(Color.White);
            graphics.DrawLine(pen, 200, 100, 300, 100);

            pen.Dispose();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Image img = new Bitmap("wood.jpg");
            TextureBrush tb = new TextureBrush(img);
            Pen pn1 = new Pen(tb, 20);
            LinearGradientBrush lb = new LinearGradientBrush(new Rectangle(10, 10, 10, 10), Color.Red, Color.Yellow, 45);

            Pen pn2 = new Pen(lb, 20);
            graphics.Clear(Color.White);
            graphics.DrawRectangle(pn1, 130, 20, 200, 145);
            graphics.DrawEllipse(pn2, 155, 45, 150, 95);

            pn2.Dispose();
            pn1.Dispose();
            tb.Dispose();
            lb.Dispose();
        }
    }
}

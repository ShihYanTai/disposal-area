using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Bézier_curve
{
    public partial class Form1 : Form
    {
        Graphics g;
        Point[] points =
        {
            new Point(50,50), new Point(100, 30),
            new Point(150, 10), new Point(200, 70),
            new Point(300, 100), new Point(250, 150),
            new Point(150, 200), new Point(120, 100)
        };
        public Form1()
        {
            InitializeComponent();

            g = pictureBox1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            g.Clear(Color.White);
            Point start = new Point(10, 100);
            Point control1 = new Point(100, 10);
            Point control2 = new Point(150, 150);
            Point end = new Point(300, 100);

            g.DrawBezier(pen, start, control1, control2, end);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen BlackPen = new Pen(Color.Black, 2);
            g.Clear(Color.White);
            PointF start = new PointF(20, 80);
            PointF control1 = new PointF(100, 10);
            PointF control2 = new PointF(150, 50);
            PointF end1 = new PointF(200, 100);
            PointF control3 = new PointF(250, 120);
            PointF control4 = new PointF(300, 150);
            PointF end2 = new PointF(350, 200);
            PointF[] pointFs = { start, control1, control2, end1, control3, control4, end2 };

            g.DrawBeziers(BlackPen, pointFs);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pen rPen = new Pen(Color.Blue, 2);
            Pen gPen = new Pen(Color.Red, 2);
            float tension = 1.0f;           // tension
            FillMode fMode = FillMode.Winding; // fill mode

            g.Clear(Color.White);
            g.DrawLines(rPen, points);
            g.DrawClosedCurve(gPen, points, tension, fMode);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            g.Clear(Color.White);
            g.FillClosedCurve(redBrush, points);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            g.Dispose();
        }
    }
}

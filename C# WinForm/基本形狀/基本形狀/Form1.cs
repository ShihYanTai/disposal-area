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

namespace 基本形狀
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen = new Pen(Color.Red, 2);
        int angle = 0;
        Rectangle rect = new Rectangle(50, 20, 200, 200);
        Font font = new Font("Arial", 12);
        SolidBrush sb = new SolidBrush(Color.Blue);
        SolidBrush sb1 = new SolidBrush(Color.White);

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point pt1 = new Point(50, 20);
            Point pt2 = new Point(300, 100);
            Point[] pt3 = new Point[4];

            g.Clear(Color.White);
            pen.Width = 2;
            g.DrawLine(pen, pt1, pt2);
            pt3[0] = new Point(100, 100);
            pt3[1] = new Point(300, 200);
            pt3[2] = new Point(50, 150);
            pt3[3] = new Point(100, 100);
            g.DrawLines(pen, pt3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pen.Width = 10;
            for(int i = 0; i <= 10; i++)
            {
                g.DrawEllipse(pen, rect);
                rect.X += 10;
                rect.Y += 10;
                rect.Width -= 20;
                rect.Height -= 20;
                pen.Color = Color.FromArgb(255, 255, 100 + i * 15, 100 + i * 15);
            }
            // 還原 rect 原來的設定、pen 原來的顏色與寬度
            pen.Color = Color.Red;
            pen.Width = 1;
            rect = new Rectangle(50, 20, 200, 200);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pen.Width = 2;
            angle = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 2;
            g.DrawArc(pen, rect, 0, angle);
            g.FillRectangle(sb1, new Rectangle(110, 100, 120, 40));
            g.DrawString("angle=" + angle.ToString(), font, sb, 110, 100);
            if(angle >= 360) timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GraphicsPath gPath = new GraphicsPath();

            g.Clear(this.BackColor);
            pen.Color = Color.Blue;
            gPath.AddRectangle(new Rectangle(50, 20, 300, 200));
            for(int i = 1; i < 10; i++)
            {
                gPath.AddLine(new Point(50, 20 + i * 10), new Point(350, 20 + i * 10));
                gPath.CloseAllFigures();
            }
            pen.Color = Color.Red;
            gPath.AddEllipse(new Rectangle(50, 120, 300, 100));
            g.DrawPath(pen, gPath);     // 會以最後的顏色上色
            gPath.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Point[] pt = new Point[4];  // 4 個座標點
            pt[0] = new Point(120, 70);
            pt[1] = new Point(170, 45);
            pt[2] = new Point(270, 70);
            pt[3] = new Point(320, 170);

            g.Clear(Color.White);
            g.DrawPolygon(pen, pt);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            g.Dispose();
            sb.Dispose();
            sb1.Dispose();
            font.Dispose();
        }
    }
}

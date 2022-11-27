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

namespace 填色
{
    public partial class Form1 : Form
    {
        Rectangle react = new Rectangle(200, 30, 200, 140);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.LightPink);
            Rectangle small_react = new Rectangle(220, 50, 160, 100);

            g.FillRectangle(sb, react);
            sb.Color = Color.Red;
            g.FillRectangle(sb, small_react);
            sb.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Image img = Image.FromFile("view.jpg");

            TextureBrush tb = new TextureBrush(img, new Rectangle(0, 0, 50, 50));
            g.FillRectangle(tb, react);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle patn = new Rectangle(0, 0, 50, 50);
            Color start = Color.Yellow;
            Color end = Color.Orange;

            float[] pos = { 0.0f, .2f, .4f, .6f, .8f, 1.0f };
            float[] factors = { .2f, .4f, .8f, .8f, .4f, .2f };
            Blend bd = new Blend();
            bd.Factors = factors;
            bd.Positions = pos;

            LinearGradientBrush lb = new LinearGradientBrush(patn, start, end, LinearGradientMode.Horizontal);
            lb.Blend = bd;
            g.FillRectangle(lb, react);
            lb.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Color bc = Color.White;
            Color fc = Color.Black;
            HatchBrush hb = new HatchBrush(HatchStyle.Shingle, fc, bc);
            g.FillRectangle(hb, react);
            hb.Dispose();
        }
    }
}

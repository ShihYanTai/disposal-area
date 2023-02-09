using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算三角形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Triangle tri = new Triangle();
            tri.Width = int.Parse(textBox1.Text);
            tri.Height = int.Parse(textBox2.Text);
            label3.Text = tri.name + " 的面積 = " + tri.GetSize().ToString();

            Rect rect = new Rect(3,2);
            
            textBox1.Text = rect.Width.ToString();
            textBox2.Text = rect.Height.ToString();
            label4.Text = rect.name + " 的面積 = " + rect.GetSize(Width, Height);
        }
        class Rect
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public string name { get { return " 矩陣 "; } }
            public Rect()
            {
                Width = 1;
                Height = 1;
            }
            public Rect(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public virtual float GetSize()
            {
                return Width * Height;
            }
            public virtual float GetSize(int width, int height)
            {
                return Width * Height;
            }
        }
        class Triangle : Rect
        {
            new public string name { get { return " 三角形 "; } }
            public override float GetSize()
            {
                return base.GetSize() / 2.0f;
            }
        }
    }
}

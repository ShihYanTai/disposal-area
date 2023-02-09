using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 建構子
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Size s = new Size();
            Shape shp = new Shape(3,4);

            shp.Width = Convert.ToInt16(textBox1.Text);
            shp.Height = Convert.ToInt16(textBox2.Text);

            shp.getSize(ref s);

            label3.Text = s.Width.ToString();
            label4.Text = s.Height.ToString();
        }

        public class Shape
        {
            private int _width;
            private int _height;
            public Shape()
            {
                _width = 1;
                _height = 1;
            }
            public Shape(int width, int height)
            {
                _width = width;
                _height = height;
            }
            ~Shape()
            {
                MessageBox.Show("呼叫解構子");
            }
            public int Width
            {
                get { return _width; }
                set { _width = value; }
            }
            public int Height
            {
                get { return _height; }
                set { _height = value; }
            }
            public void getSize(ref Size size)
            {
                size.Width = _width;
                size.Height = _height;
            }
        }
    }
}

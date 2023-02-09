﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 建立類別與物件
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
            Shape shp = new Shape();

            shp.Width = Convert.ToInt16(textBox1.Text);
            shp.Height = Convert.ToInt16(textBox2.Text);

            shp.getSize(ref s);

            label3.Text = s.Width.ToString();
            label4.Text = s.Height.ToString();
        }

        public class Shape
        {
            private int _width = 1;
            private int _height = 1;

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
            public void getSize(ref Size s)
            {
                s.Width = _width;
                s.Height = _height;
            }
        }
    }
}

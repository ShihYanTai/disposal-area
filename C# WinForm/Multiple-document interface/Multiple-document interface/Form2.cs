using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_document_interface
{
    public partial class Form2 : Form
    {
        Pen p;
        Point point;
        Bitmap bmp;
        Graphics g;
        public Image getImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public Form2()
        {
            InitializeComponent();
            p = new Pen(Color.Red, 1);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
        }
        public Form2(string fileName)
        {
            InitializeComponent();
            p = new Pen(Color.Red, 1);
            bmp = new Bitmap(fileName);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                g.DrawLine(p, point, e.Location);
                pictureBox1.Image = bmp;
                point = e.Location;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(this.Text + "即將關閉");
        }
    }
}

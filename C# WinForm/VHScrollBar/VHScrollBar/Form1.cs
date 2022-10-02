using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VHScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;
            label1.Text = String.Format("R: {0}", r);
            label4.BackColor = Color.FromArgb(255, r, g, b);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;
            label1.Text = String.Format("R: {0}", g);
            label4.BackColor = Color.FromArgb(255, r, g, b);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;
            label1.Text = String.Format("R: {0}", b);
            label4.BackColor = Color.FromArgb(255, r, g, b);
        }
    }
}

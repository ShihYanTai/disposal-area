using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 隨機產生顏色
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Stop") button1.Text = "Start";
            else button1.Text = "Stop";

            timer1.Enabled = !timer1.Enabled;
        }
        void generate()
        {
            byte[] color = new byte[4];
            for (int i = 0; i < color.Length; i++) 
                color[i] = (byte)random.Next(256);
            label1.BackColor = Color.FromArgb(color[0], color[1], color[2], color[3]);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            generate();
        }
    }
}

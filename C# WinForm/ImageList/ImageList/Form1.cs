using System;
using System.Windows.Forms;

namespace ImageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            PicCat.Image=ImageCat.Images[n];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Btnplay.ImageList = ImageIcon;
            Btnplay.ImageIndex = 0;
            tmrFly.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Btnstop.ImageList = ImageIcon;
            Btnstop.ImageIndex = 1;
            tmrFly.Enabled = false;
        }

        private void tmrFly_Tick(object sender, EventArgs e)
        {
            n = n == 11 ? 0 : n + 1;
            PicCat.Image = ImageCat.Images[n];
            PicCat.Left += 50;
            if(PicCat.Left >= 300)
            {
                PicCat.Left = -50;
            }

        }
    }
}

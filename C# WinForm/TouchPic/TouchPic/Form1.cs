using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TouchPic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int SM_DIGITIZER = 94;
        [DllImport("User32.dll")]
        public static extern int GetSystemMetrics(int n);
        private void Form1_Load(object sender, EventArgs e)
        {
            int digitizerStatus = GetSystemMetrics(SM_DIGITIZER);
            if ((digitizerStatus &(0x80+0x40)) != 0)
            {
                MessageBox.Show("支援多點觸點");
            }
            else
            {
                MessageBox.Show("不支援多點觸點");
            }
            PicT1.SizeMode = PictureBoxSizeMode.StretchImage;
            PicT2.SizeMode = PictureBoxSizeMode.StretchImage;
            PicT3.SizeMode = PictureBoxSizeMode.StretchImage;
            PicT1.Image = Image.FromFile("pic1.png");
            PicT2.Image = Image.FromFile("pic2.png");
            PicT3.Image = Image.FromFile("pic3.png");
            PicT2.Click += PicT1_Click;
            PicT3.Click += PicT1_Click;
            PicT2.DoubleClick += PicT1_DoubleClick;
            PicT3.DoubleClick += PicT1_DoubleClick;
            PicT2.MouseClick += PicT1_MouseClick;
            PicT3.MouseClick += PicT1_MouseClick;
            this.MouseWheel += (object m_sender, MouseEventArgs m_e) =>
            {
                if (m_e.Delta > 0)
                {
                    this.Controls[0].Width += 8; this.Controls[0].Height += 6;
                }
                else
                {
                    this.Controls[0].Width -= 8; this.Controls[0].Height -= 6;
                }
            };
        }

        private void PicT1_Click(object sender, EventArgs e)
        {
            PictureBox picClick = (PictureBox)sender;
            this.Controls.SetChildIndex(picClick, 0);
            picClick.BringToFront();
        }

        private void PicT1_DoubleClick(object sender, EventArgs e)
        {
            PictureBox PicDClick = (PictureBox)sender;
            PicDClick.Size = new Size(160, 120);
        }

        private void PicT1_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox PicMClick = (PictureBox)sender;
            if(e.Button == MouseButtons.Right)
            {
                this.Controls.SetChildIndex(PicMClick,this.Controls.Count - 1);
            }

            //PicMClick.SendToBack();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabyCry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool drag = false;                          // 紀錄是否可以拖曳，預設為不允許拖曳
        int sX, sY;                                 // 紀錄滑鼠按下時座標值
        bool move = false;                          // 紀錄是否隨滑鼠移動圖片，預設為不可以

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            PicBaby.Image = ImgBaby.Images[1];
        }

        private void PicBaby_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;                            // 設為可拖曳
            sX = e.X;sY = e.Y;                      // 紀錄滑鼠指標的座標值
            PicBaby.Image = ImgBaby.Images[2];

        }

        private void PicBaby_MouseMove(object sender, MouseEventArgs e)
        {
            //if(drag)                                
            //    PicBaby.Left +=(e.X -sX);
            //    PicBaby.Top += (e.Y - sY); // 若drag = true 設置圖片X、Y 位置
        }

        private void PicBaby_MouseUp(object sender, MouseEventArgs e)
        {
            drag=false;                     // 設為不可拖曳
        }

        private void PicBaby_MouseLeave(object sender, EventArgs e)
        {
            PicBaby.Image=ImgBaby.Images[0];
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                move = true;
                PicBaby.Image = ImgBaby.Images[2];
            }
            else
            {
                move = false;
                PicBaby.Image = ImgBaby.Images[0];
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                PicBaby.Location = new Point(e.X, e.Y);
            }
            else
            {
                PicBaby.Location = new Point(e.X - 5, e.Y - 5);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicBaby.Image = ImgBaby.Images[0];
            PicBaby.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}

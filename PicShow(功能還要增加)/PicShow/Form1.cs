using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            PicPicture1.Left = 5; PicPicture1.Top = 5; // 預設圖片位置
            TsCboPic.SelectedIndex = 0;             // 預設選取下拉是清單第一個項目
            LblMsg.Text = TsTxtMsg.Text;            // 預 LblMsg 顯示 TsTxtMsg 的文字內容
            LblMsg.Parent = PicPicture1;             // 設LLblMsg 為 PicPicture的子物件
            LblMsg.BackColor = Color.Transparent;   // 設為透明背景色
        }

        private void TmrMove_Tick(object sender, EventArgs e)
        {
            PicPicture1.Left += 5;                   // 向左
            if(PicPicture1.Left < -375)              // 若圖片全部都移出就重來
            {
                PicPicture1.Left = 375;
            }
        }

        private void TsBtnStart_Click(object sender, EventArgs e)
        {
            TmrMove.Enabled = true;                 // 開啟計時器
        }

        private void TsBtnStop_Click(object sender, EventArgs e)
        {
            TmrMove.Enabled = false;                 // 關閉計時器
        }

        private void toolStrip1_TextChanged(object sender, EventArgs e)
        {
            LblMsg.Text = TsTxtMsg.Text;        // 設LblMsg的文字內容
        }

        private void TsCboPic_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (TsCboPic.SelectedIndex)
            {
                case 0:
                    PicPicture1.Image = Properties.Resources._1; break;
                case 1:
                    PicPicture1.Image = Properties.Resources._2; break;
                case 2:
                    PicPicture1.Image = Properties.Resources._3; break;
                case 3:
                    PicPicture1.Image = Properties.Resources._4; break;
                case 4:
                    PicPicture1.Image = Properties.Resources._5; break;
                case 5:
                    PicPicture1.Image = Properties.Resources._6; break;
            }
        }
    }
}

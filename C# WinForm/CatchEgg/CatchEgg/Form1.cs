using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchEgg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ok, miss; // 紀錄街道和

        private void HsbMove_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void HsbMove_ValueChanged(object sender, EventArgs e)
        {
            PicBowl.Left = HsbMove.Value - 26;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TmrFall.Start();        //啟動計時器
            ok = 0; miss = 0;       //預設接到和失敗的次數都為0
            BtnStart.Enabled = false;//開始鈕不能使用
        }

        private void TmrFall_Tick(object sender, EventArgs e)
        {
            PicEgg.Top += 10;   //雞蛋圖片下移 10 點
            if(PicEgg.Top + 12 >= PicBowl.Top)
            {
                if(PicEgg.Left >= PicBowl.Left && PicEgg.Left + 16 <= PicBowl.Left + 40)
                {
                    ok++;       //接到次數加1
                }
                else
                {
                    miss++;     //失誤次數加1
                }
                LblMsg.Text = $"接到 : {ok} 次    失誤 : {miss} 次";
                Random ran = new Random();
                PicEgg.Location = new Point(ran.Next(60, 300), 5);    // 設蛋的亂數

                if(ok + miss == 10)
                {
                    BtnStart.Enabled=true;      //開始鈕可以使用
                    TmrFall.Stop();             //關閉計時器
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HsbMove.Maximum = 300;
            HsbMove.Minimum = 40;  // 設卷軸的最大最小值
            HsbMove.Value = 220;    // 預設卷軸的值
            PicEgg.Image = Image.FromFile("egg.gif");   // 載入蛋的圖
            PicBowl.Image = Image.FromFile("bowl.gif");     // 載入碗的圖
            LblMsg.Text = "按開始鈕開始遊戲!";
        }
    }
}

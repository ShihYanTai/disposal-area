using System;
using System.Windows.Forms;
using System.Media;

namespace WinPlayMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MediaPlayer1.URL = @"D:\Visual C# 2019程式設計完全解析(I) 袋這新手打穩程式基礎\MP22129-examples\ch13範例\media\Dog.wmv";
            MediaPlayer1.Ctlcontrols.stop();        // 停止播放
            MediaPlayer1.Anchor = AnchorStyles.Left;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.play();        // 播放
            
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.pause();         // 暫停
            
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.stop();           // 停止
            
        }
    }
}

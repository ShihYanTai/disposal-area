using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace countdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sec;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NubMin.Minimum = 0;
            NubMin.Maximum = 10; // 設定時間範圍
            NubMin.Value = 0;   //設定初始值
            NubSec.Minimum = 0;
            NubSec.Maximum = 60;
            NubSec.Value = 30;
            LblSec.Text = "";
            timer1.Interval = 1000;     // 一秒觸發一次
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;      // 減秒
            LblSec.Text = sec.ToString();       // 顯示剩餘秒數
            if(sec == 0)        // 時間到0秒顯示如下
            {
                timer1.Stop();
                LblSec.Text = "時間到";
                BtnStart.Enabled=true;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // 計算倒數秒數
            sec = (int)NubMin.Value * 60 + (int)NubSec.Value;
            BtnStart.Enabled = false;
            BtnResart.Enabled = false;
            LblSec.Text =  $"剩餘 { sec.ToString()} 秒";   // 顯示秒數
            timer1.Start();     // 啟動倒數計時
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            BtnStart.Enabled = true;
            BtnResart.Enabled = true;
            LblSec.Text = $"時間暫停";
        }

        private void BtnResart_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            BtnStart.Enabled = false;
            BtnResart.Enabled = false;
            LblSec.Text = $"剩餘 {sec.ToString()} 秒";
            timer1.Start();

        }
    }
}

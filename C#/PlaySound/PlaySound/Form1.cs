using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;           // 引用 InteropServices 命名空間

namespace PlaySound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("winmm.dll")]                // 連結動態程式庫
        public static extern bool PlaySound(String FileName, int Mod, int Flag);
        int ans;
        private void Form1_Load(object sender, EventArgs e)
        {
            int x, y;
            Random ran = new Random();
            x = ran.Next(40, 70);
            y = ran.Next(30, 60);
            LblQ.Text = $"{x}+{y}={ans = x + y}";
            LblMsg.Text = $"請輸入{LblQ.Text}";
        }

        private void TxtAns_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c < '0' || c > '9') && c != 8)
            {
                if(c==13)
                {
                    if (int.Parse(TxtAns.Text) == ans)
                    {
                        LblMsg.Text = "正確答案!";
                        PlaySound(@"C:\Windows\Media\Alarm01.wav", 0, 1);
                    }
                    else
                    {
                        LblMsg.Text = "答案錯誤!";
                        PlaySound(@"C:\Windows\Media\Alarm02.wav", 0, 1);
                    }
                }
                else
                {
                    LblMsg.Text = "請輸入數字鍵!";
                    e.Handled = true;
                    PlaySound(@"C:\Windows\Media\Alarm03.wav", 0, 1);
                }
            }
            else
            {
                LblMsg.Text = "若輸入完成請按 Enter 鍵。";
            }
        }
    }
}

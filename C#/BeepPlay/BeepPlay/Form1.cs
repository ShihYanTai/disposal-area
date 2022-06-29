using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;       // 引用 InteropServices 命名空間

namespace BeepPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("kernel32.dll")]         // 連結動態程式庫
        public static extern bool Beep(int Frequency, int duration);    // 函式原型
        private void Form1_Load(object sender, EventArgs e)
        {
            Bn2.Click += Bn1_Click;
            Bn3.Click += Bn1_Click;
            Bn4.Click += Bn1_Click;
            Bn5.Click += Bn1_Click;
            Bn6.Click += Bn1_Click;
            Bn7.Click += Bn1_Click;
            Bn8.Click += Bn1_Click;
        }

        private void Bn1_Click(object sender, EventArgs e)
        {
            int[] Freq = { 523, 587, 659, 698, 784, 880, 988, 1046 };
            Button Bn = (Button)sender;
            Bn.Enabled = false;
            Beep(Freq[Bn.TabIndex], 500);
            Bn.Enabled = true;
        }
    }
}

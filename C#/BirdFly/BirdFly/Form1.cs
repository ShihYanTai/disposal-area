using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdFly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TsLblSpeed.Text = "慢速";
            TmrFly.Interval = 500;      // 預設計時器的間隔為500
            TsPrgFly.Maximum = 300;     // 設進度列的最大值
            TsPrgFly.Value = 0;         // 預設進度列的 Value 值為 0
        }

        private void MnuFast_Click(object sender, EventArgs e)
        {
            TmrFly.Interval = 100;
            TsLblSpeed.Text = "快速";
        }

        private void MnuSlow_Click(object sender, EventArgs e)
        {
            TmrFly.Interval = 500;
            TsLblSpeed.Text = "慢速";
        }

        private void TsBtnSpeed_ButtonClick(object sender, EventArgs e)
        {
            PicBird.Left = 0;
            TmrFly.Enabled = true;
        }

        private void TmrFly_Tick(object sender, EventArgs e)
        {
            if (PicBird.Left < 300)
            {
                PicBird.Left += 5;
                TsPrgFly.Value = PicBird.Left;
                TsLblMsg.Text = $"進度 : {TsPrgFly.Value / 3:#}";
            }
            else
            {
                TmrFly.Enabled = false;
                TsLblMsg.Text = "完成";
            }
        }
    }
}

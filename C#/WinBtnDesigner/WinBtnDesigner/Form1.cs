using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBtnDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TstxtInput.Text = "Hello, World!";      // 預設功能表文字方塊內文字
            fontDialog1.ShowColor = true;           // 設字型對話方塊中可以設定顏色
            fontDialog1.MinSize = 12;
            fontDialog1.MaxSize = 36;
            colorDialog1.FullOpen = true;           // 設色彩話方塊中自動開啟自訂色彩色盤
        }

        private void TstxtInput_TextChanged(object sender, EventArgs e)
        {
            BtnDesign.Text = TstxtInput.Text;       // 設 BtnDesign 和 TstxtInput 的文字相同
        }

        private void MnuFront_Click(object sender, EventArgs e)
        {       // 當使用者在字型對話中按確認鈕時
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {   // 設 BtnDesign 和字型對話方塊設定的字型相同
                BtnDesign.Font = fontDialog1.Font;
                // 設 BtnDesign 前景色和字型對話方塊設定的色彩相同
                BtnDesign.ForeColor = fontDialog1.Color;
            }

        }

        private void MnuColor_Click(object sender, EventArgs e)
        {   // 當使用者在色彩對話方塊中確定鈕時
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {   // 設 BtnDegin 背景色和色彩對話方塊設定的色彩相同
                BtnDesign.BackColor = colorDialog1.Color;
            }
            
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

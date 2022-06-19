using System;
using System.Drawing;
using System.Windows.Forms;

namespace MenuScript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtW.Multiline = true;          // 多行顯示文字
            TxtW.Dock = DockStyle.Fill;     // 填滿表單
            MnuStyle1.CheckOnClick = true;  // 切換勾選狀態
            MnuStyle2.CheckOnClick = true;  // 切換勾選狀態
            MnuSet2.CheckOnClick = true;    // 切換勾選狀態
            MnuSet1_Click(sender, e);       // 執行MnuSet1_Click 函式
        }

        private void MnuSet1_Click(object sender, EventArgs e)
        {
            TxtW.Text = "做該做的事是智慧，\r\n做不該做的事是愚痴。";
            MnuStyle1.Checked = false;      // 不勾選粗體
            MnuStyle2.Checked = false;      // 不勾選斜體
            // 預設字型為"新明細體",大小為12,樣式一般
            TxtW.Font = new Font("新明細體", 12, FontStyle.Regular);
        }

        private void MnuSet2_Click(object sender, EventArgs e)
        {
            if(MnuSet2.Checked == true)     // 若有勾選
            {
                MnuSize1.Enabled = false;  // 大小 9 不能勾選
                MnuSize2.Enabled = false;  // 大小 12 不能勾選
            }
            else
            {
                MnuSize1.Enabled = true;   // 大小 9 能使用
                MnuSize2.Enabled = true;   // 大小 12 能使用
            }
        }

        private void MnuSet3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuFont1_Click(object sender, EventArgs e)
        {
            TxtW.Font = new Font("標楷體", TxtW.Font.Size, TxtW.Font.Style);
        }

        private void MnuFont2_Click(object sender, EventArgs e)
        {
            TxtW.Font = new Font("新明細體", TxtW.Font.Size, TxtW.Font.Style);
        }

        private void MnuSize1_Click(object sender, EventArgs e)
        {
            TxtW.Font = new Font(TxtW.Font.Name, 9, TxtW.Font.Style);
        }

        private void MnuSize2_Click(object sender, EventArgs e)
        {
            TxtW.Font = new Font(TxtW.Font.Name, 12, TxtW.Font.Style);
        }

        private void MnuSize3_Click(object sender, EventArgs e)
        {
            TxtW.Font = new Font(TxtW.Font.Name, 20, TxtW.Font.Style);
        }

        private void MnuSize4_Click(object sender, EventArgs e)
        {
            TxtW.Font = new Font(TxtW.Font.Name, 24, TxtW.Font.Style);
        }

        private void MnuStyle1_Click(object sender, EventArgs e)
        {
            TxtW.Font = new Font(TxtW.Font.Name, TxtW.Font.Size, TxtW.Font.Style ^ FontStyle.Italic);
        }

        private void MnuStyle_Click(object sender, EventArgs e)
        {

        }

        private void MnuStyle2_Click(object sender, EventArgs e)
        {
            TxtW.Font = new Font(TxtW.Font.Name, TxtW.Font.Size, TxtW.Font.Style ^ FontStyle.Bold);
        }
    }
}

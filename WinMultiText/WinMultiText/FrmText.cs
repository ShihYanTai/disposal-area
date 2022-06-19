using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMultiText
{
    public partial class FrmText : Form
    {
        public FrmText()
        {
            InitializeComponent();
        }

        private void MnuCopy_Click(object sender, EventArgs e)
        {
            if (TxtInput.SelectedText != "")    // 若選取的字串不等於空字串
            {
                TxtInput.Copy();                // 複製選取的文字到剪貼簿
            }
        }

        private void MnuPaste_Click(object sender, EventArgs e)
        {
            TxtInput.Paste();                   // 將剪貼簿內文複製到游標處
        }

        private void MnuCut_Click(object sender, EventArgs e)
        {
            if(TxtInput.SelectedText != "")     // 若選取的字串不等於空字串
            {
                TxtInput.Cut();                 // 剪下選取的文字並複製到剪貼簿
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close();                       // 關閉目前表單
        }

        private void FrmText_Load(object sender, EventArgs e)
        {
            TxtInput.Multiline = true;          // 設定文字方塊可以多行
            TxtInput.Dock = DockStyle.Fill;     // 調整控制項大小為填滿整個表單
            TxtInput.ScrollBars = ScrollBars.Both;// 設定水平卷軸及垂直卷軸
        }
    }
}

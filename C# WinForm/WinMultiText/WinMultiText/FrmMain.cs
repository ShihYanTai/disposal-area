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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnAdd.Enabled = false;     // 新增文件鈕 不能使用
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FrmPass fP = new FrmPass(); // 宣告 fP 為 FrmPass 表單的物件實體
            fP.ShowDialog();            // 用強制回應對話方塊方式來顯示 FrmPW 表單
            BtnAdd.Enabled = true;      // 新增文件可以使用
            BtnLogin.Enabled = false;   // 登入時不能使用
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            num++;      //  新增文件的次數加 1
            FrmText fT = new FrmText();     // 宣告 fT 為 FrmText表單的物件實體
            fT.Text = $"文件{num}";         // 設定表單的標題文字內容
            fT.Show();                      // 顯示fT表單
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();             // 設定離開
        }
    }
}

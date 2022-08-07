using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TxtMsg.ReadOnly = true;
            TxtMsg.Text = PubClass.sMsg;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            Hide();     // 隱藏目前表單
            Frm1 f1 = new Frm1();
            f1.Show();  // 顯示新建立的表單
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();     // 結束程式
        }
    }
}

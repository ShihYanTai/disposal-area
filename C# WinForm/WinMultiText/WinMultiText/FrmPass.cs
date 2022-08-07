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
    public partial class FrmPass : Form
    {
        public FrmPass()
        {
            InitializeComponent();
        }
        int num = 0;        // 紀錄密碼輸入次數

        private void BtnOK_Click(object sender, EventArgs e)
        {
            num++;          // 密碼輸入 +1
            // 若ID = "happy" 且 PassWord = "168"
            if (TxtID.Text == "happy" && TxtPW.Text == "168")
            {
                this.Close();
            }
            else
            {
                if (num < 3)// 若輸入次數小於3
                {
                    DialogResult result = MessageBox.Show("再試一次", "密碼錯誤", MessageBoxButtons.YesNo);
                    
                    if (result == DialogResult.Yes)
                    {
                        TxtID.Text = TxtPW.Text = "";   // 清空文字方塊
                        TxtID.Focus();                  // 使 TxtID 成為作用物件
                    }
                    else
                    {
                        Application.Exit();             // 使用者不想輸入結束程式
                    }
                }
                else
                {
                    MessageBox.Show("連續三次密碼錯誤","結束程式",MessageBoxButtons.OK);
                    Application.Exit();                 // 輸入次數 = 3 結束程式
                }

            }
        }
    }
}

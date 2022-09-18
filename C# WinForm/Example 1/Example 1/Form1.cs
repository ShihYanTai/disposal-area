using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Example_1
{
    public partial class Form1 : Form
    {
        string account, password;
        public Form1()
        {
            InitializeComponent();
            account = Interaction.InputBox("輸入帳號", "登入", "Mary", -1, -1);
            password = Interaction.InputBox("輸入密碼", "登入", "", -1, -1);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label1.Text = "帳號 :" + account;
            label2.Text = "密碼 :" + password;
        }
    }
}

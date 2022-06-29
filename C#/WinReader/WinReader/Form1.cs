using System;
using System.Windows.Forms;
using System.IO;

namespace WinReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            double x, sum = 0;
            int count = 0;          // 紀錄有效數值狀態
            BtnSum.Enabled = false; // 使本按鍵無效
            StreamReader SR;        // 宣告串流讀取器物件
            try
            {
                SR = new StreamReader("in.txt"); // 建立串流讀取器物件
            }
            catch
            {
                TxtShow.Text = "檔案開啟失敗";
                return;
            }
            while (true) // 無窮迴圈
            {
                string data = SR.ReadLine();    // 讀取一行字串資料
                if (data == null)               // 已達串流末端，則脫離迴圈
                    break;
                else
                    if (double.TryParse(data, out x)) sum += x; count++; // 字串轉浮點數，加總計數器加一
            }
            TxtShow.Text = $"總和 : {sum:#.00} 平均 : {(sum / count):#.00}";
            SR.Close();
        }
    }
}

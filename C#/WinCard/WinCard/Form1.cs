using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {       // 指定列印相關控制項的資料來源為 printDocument1
            printPreviewDialog1.Document = printDocument1;
            pageSetupDialog1.Document = printDocument1;
            printDialog1.Document = printDocument1;
            fontDialog1.ShowColor = true;   // 可設定字型顏色
            TxtCom.Text = "○○股份有限公司";
            TxtTitle.Text = "資訊長";
            TxtName.Text = "張三";
            PicLogo.Image = Image.FromFile("logo.png"); // 載入圖檔
        }

        private void MnuFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = this.ActiveControl.Font;

            // 當使用者在字型對話方塊中按確定鈕時

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {   // 設定目前作用中控制項和字型對話框設定的字型相同
                this.ActiveControl.Font = fontDialog1.Font;
                this.ActiveControl.ForeColor = fontDialog1.Color;
            }
        }

        private void MnuSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();      // 顯示列印格式對話框
            // 設定 printDocument1 的列印格式等於列印格式對話框的設定
            printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
        }

        private void MnuPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();   // 顯示瀏覽列印對話方塊
        }

        private void MnuPrint_Click(object sender, EventArgs e)
        {   // 若在列印對話框按確定鈕
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();         // 執行 print 方法
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;                                    // 宣告繪圖物件 g
            Single x = printDocument1.DefaultPageSettings.Margins.Left; // 讀取左邊界
            Single y = printDocument1.DefaultPageSettings.Margins.Right;// 讀取右邊界
            // 字型樣式 f 紀錄 TxtCom 中的字型樣式
            Font f = new Font(TxtCom.Font.Name, TxtCom.Font.Size, TxtCom.Font.Style);
            // 宣告筆刷物件顏色為 TxtCom 的前景
            SolidBrush b = new SolidBrush(TxtCom.ForeColor);
            g.DrawString(TxtCom.Text, f, b,TxtCom.Left + x,TxtCom.Top +y);  // 印 TxtCom.Text
            f = new Font(TxtTitle.Font.Name, TxtTitle.Font.Size, TxtTitle.Font.Style);
            b = new SolidBrush(TxtTitle.ForeColor);
            g.DrawString(TxtTitle.Text, f, b,TxtTitle.Left + x,TxtTitle.Top + y); // 印 TxtTilte.Text
            f = new Font(TxtName.Font.Name, TxtName.Font.Size, TxtName.Font.Style);
            b = new SolidBrush(TxtName.ForeColor);
            g.DrawString(TxtName.Text, f, b,TxtName.Left + x,TxtName.Top + y);  // 印 TxtName.Txt
            g.DrawImage(PicLogo.Image, PicLogo.Left + x, PicLogo.Top + y,PicLogo.Width, PicLogo.Height);    // 用 DrawImage 方法印出 PicLogo 圖檔
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

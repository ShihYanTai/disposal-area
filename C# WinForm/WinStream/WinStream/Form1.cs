using System.Windows.Forms;
using System.IO;

namespace WinStream
{
    public partial class Form1 : Form
    {
        string[] product;               // 宣告陣列
        int k;                          // 宣告陣列索引變數
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            TxtPad.Text = "";
            TxtShow.Text = "";
            LblMsg.Text = "目前沒有資料";
        }

        private void BtnClear_Click(object sender, System.EventArgs e)
        {
            TxtPad.Text = "";
            LblMsg.Text = "資料保留";
        }

        private void BtnCreate_Click(object sender, System.EventArgs e)
        {
            string FileName = @"D:\My\File.txt";            // 指定存入文字檔檔名
            FileInfo FileFo = new FileInfo(FileName);
            if(!Directory.Exists(FileFo.DirectoryName))     // 檢查路徑和檔名是否存在
                Directory.CreateDirectory(FileFo.DirectoryName);    // 不存在則建立
            StreamWriter SW = FileFo.CreateText();
            SW.WriteLine(TxtPad.Text);
            SW.Flush();
            SW.Close();

            product = new string[999];                      // 建立陣列
            k = 0;                                          // 陣列索引變數
            foreach(string item in TxtPad.Lines)
            {
                product[k++] = item;
            }
            TxtShow.Lines = product;                        // 將陣列資料顯示在 TxtShow 控制項上
            LblMsg.Text = " 資料已新增 !...";
            TxtPad.Text = "";
        }

        private void BtnAppend_Click(object sender, System.EventArgs e)
        {
            string FileName = @"D:\My\File.txt";            // 指定存入的文字檔檔名
            FileInfo FinFo = new FileInfo(FileName);
            StreamWriter SW = FinFo.AppendText();
            SW.WriteLine(TxtPad.Text);
            SW.Flush();
            SW.Close();
            LblMsg.Text = " 資料已加入 !...";
            foreach(string item in TxtPad.Lines)            // 將輸入資料置入陣列
                product[k++] = item;

            TxtShow.Lines = product;                        // 將陣列資料顯示在TxtShow 控制項上
            TxtPad.Text = "";
        }

        private void BtnEnd_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}

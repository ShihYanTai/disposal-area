using System;
using System.Windows.Forms;
using System.IO;

namespace OWinFileOperate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 設第一個畫面
            TxtSource.Text = @"D:\test.txt";    // 來源檔案文字方塊預設值
            TxtSource.Focus();                  // 來源檔案文字方塊取得駐點
            TxtShow.ReadOnly = true;            // 訊息方塊唯讀
            TxtDest.Enabled = false;            // 目的檔案文字方塊無效
            TxtDir.Enabled = false;             // 目的檔案文字方塊無效
            TxtShow.Text = "請輸入「來源檔案」完整名稱後，按 < 建立 > 鈕。";
            BtnCheck.Enabled = false;           // <查看>鈕無效
            BtnCopy.Enabled = false;            // <複製>鈕無效
            BtnCreate.Enabled = true;          // <建立>鈕有效
            BtnDelete.Enabled = false;          // <刪除>鈕無效
            BtnMove.Enabled = false;            // <搬移>鈕無效
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string filename = TxtSource.Text;
            FileInfo fInfo = new FileInfo(filename);
            string path = fInfo.DirectoryName;
            if(!Directory.Exists(path)) Directory.CreateDirectory(path);    // 確認位置檔案夾是否存在，沒有則建立資料夾
            if (fInfo.Exists) TxtShow.Text = $"{fInfo.Name} 檔案已存在!";    // 確認檔案存在，顯示訊息
            else
            {
                FileStream fs = fInfo.Create();                             // 建立檔案串流物件 fs ， 開啟檔案
                TxtShow.Text = $"{fInfo.Name} 檔案建立成功。";
                fs.Close();                                                 // 關閉檔案
            }
            // 設立第二操作畫面
            BtnCreate.Enabled = false;                                      // 建立按鈕失效
            BtnCopy.Enabled=true;                                           // 複製按鈕有效
            TxtDest.Enabled=true;                                           // 目的文字方塊有效
            TxtDest.Text = @"D:\Copy.doc";                                  // 目的檔案文字方塊預設值
            TxtDest.Focus();                                                // 目的檔案文字方塊取得駐點
            TxtSource.Enabled = false;                                      // 來源檔案文字方塊失效
            TxtShow.Text += "\r\n\r\n\r\n";
            TxtShow.Text += "再來\r\n";
            TxtShow.Text += "輸入「目的檔案」完整名稱後，按[複製]鈕。";
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            FileInfo SourceInfo = new FileInfo(TxtSource.Text);
            FileInfo DestInfo = new FileInfo(TxtDest.Text);
            string path = DestInfo.DirectoryName;
            try
            {
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);   // 若檔案夾不存在則建立資料夾
                SourceInfo.CopyTo(TxtDest.Text, true);                          // 將來源檔案複製到目的檔案
                TxtShow.Text = $"{SourceInfo.FullName} 檔案成功複製給\r\n";
                TxtShow.Text += DestInfo.FullName;
                // 設定第三個操作畫面
                BtnCopy.Enabled = false;                                        // 複製按鈕失效
                BtnCheck.Enabled = true;                                       // 查看按鈕有效
                TxtDest.Enabled = false;                                        // 目的檔案文字方塊失效
                TxtDir.Enabled = true;                                          // 資料夾名稱文字方塊有效
                TxtDir.Text = @"D:\my\";                                        // 資料夾名稱文字方塊預設值
                TxtDir.Focus();                                                 // 資料夾名稱文字方塊駐點
                TxtShow.Text += "\r\n\r\n\r\n";
                TxtShow.Text += "接著\r\n";
                TxtShow.Text += "輸入來源檔案「資料夾名稱」後，按 [查看] 鈕";
            }
            catch (Exception ex)
            {
                TxtShow.Text = $"{ex.Message}";
            }

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo DestInfo = new FileInfo(TxtDir.Text);
                string path = DestInfo.DirectoryName;
                int no = 0;
                if (Directory.Exists(path))
                {
                    string[] ListName = new string[] { };
                    ListName = Directory.GetFiles(path);                        // 取得 path 指定資料夾內所有檔案名稱
                    TxtShow.Text = $"該資料夾有{ListName.Length}個檔案，表列如下 \r\n";
                    foreach (string FName in ListName)
                    {
                        no++;
                        TxtShow.Text += $"{no}.   {FName}\r\n";

                    }
                }
                else TxtShow.Text = "無此資料夾!";
                // 設定第四個操作畫面
                BtnCheck.Enabled = false;                                       // 複製按鈕失效
                BtnDelete.Enabled = true;                                       // 刪除鈕有效
                TxtShow.Text += "\r\n";
                TxtShow.Text += "接著\r\n";
                TxtShow.Text += "按 [刪除] 鈕，刪除「目的檔案」指定的檔案。";
            }
            catch (Exception ex)
            {
                TxtShow.Text = $"{ex.Message}";
            }



        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo DesInfo = new FileInfo(TxtDest.Text);
                DesInfo.Delete();                                               // 刪除檔案
                TxtShow.Text = $"{DesInfo.FullName} 檔案成功刪除。";
                TxtDest.Text = "";
                // 設定第五個操作畫面
                BtnDelete.Enabled = false;                                       // 刪除按鈕有效
                BtnMove.Enabled = true;                                        // 移動按鈕無效
                TxtDest.Enabled = true;                                         // 目的檔案文字方塊有效
                TxtDest.Focus();
                TxtShow.Text += "\r\n\r\n\r\n";
                TxtShow.Text += "最後刪除\r\n";
                TxtShow.Text += "輸入「目的檔案」完整名稱後，按[搬移]鈕";
            }
            catch(Exception ex)
            {
                TxtShow.Text = $"{ex.Message}";
            }

        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo SourceInfo = new FileInfo(TxtSource.Text);
                FileInfo DestInfo = new FileInfo(TxtDest.Text);
                string path = DestInfo.DirectoryName;
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);    // 若指定資料夾不存在，建立該資料夾
                if (DestInfo.Exists) DestInfo.Delete();                          // 若檔案存在則刪除
                TxtShow.Text = $"{SourceInfo.FullName} 檔案成功搬移。";
                TxtShow.Text += DestInfo.FullName;
                SourceInfo.MoveTo(TxtDest.Text);                                // 將來源檔案移到目的檔案
                                                                                // 設定第六個操作畫面
                TxtSource.Text = "";                                            // 來源檔文字方塊預設為空白
                TxtDest.Enabled = false;                                        // 目的檔案文字方塊失效
                BtnMove.Enabled = false;                                         // 搬移按鈕失效
                TxtShow.Text += "\r\n\r\n\r\n";
                TxtShow.Text += "請關閉程式視窗。";
            }
            catch(Exception ex)
            {
                TxtShow.Text = $"{ex.Message}";
            }


        }
    }
}

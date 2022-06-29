using System;
using System.Windows.Forms;
using System.IO;

namespace WinBinaryWR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string FileName = @"D:\my\data.bin";
        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo FileFo = new FileInfo(FileName);
            string path = FileFo.DirectoryName;
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);       // 指定來源檔不存在建立該資料夾
            BtnRead.Enabled = false;                                             // 讀取檔案失效
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            FileStream FOut = new FileStream(FileName, FileMode.OpenOrCreate);  // 建立檔案串流
            BinaryWriter BW = new BinaryWriter(FOut);
            BW.Write(TxtPad.Text);
            BW.Flush();                                                         // 清除緩衝區
            BW.Close();                                                         // 關閉資料串流
            FOut.Close();                                                       // 關閉檔案串流
            BtnRead.Enabled = true;                                             // 讀取檔按鈕有效
        }

        private void BtnCls_Click(object sender, EventArgs e)
        {
            TxtPad.Text = "";
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            FileStream FsIn = new FileStream(FileName, FileMode.OpenOrCreate);
            BinaryReader BR = new BinaryReader(FsIn);
            TxtPad.Text = BR.ReadString();
            BR.Close();
            FsIn.Close();
        }
    }
}

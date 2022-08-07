using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace WinBinaryCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string SourceFile = "image1.jpg";                   // 來源圖形檔案
        string DestFile = "image1-複製.jpg";                // 目的圖形檔案
        byte[] BufferData;                                  // 宣告位元組型別陣列
        private void Form1_Load(object sender, EventArgs e)
        {
           FileStream Fin = new FileStream(SourceFile, FileMode.Open);      // 開啟檔案串流
           BinaryReader BR = new BinaryReader(Fin);                        // 建立二進位串流讀取器
           long Size = BR.BaseStream.Length;                               // 資料串流長度
           BufferData = new byte[Size];                                    // 建立位元組陣列
           BufferData = BR.ReadBytes((int)Size);                           // 將讀取到的資料串流指向 BufferData 陣列
           PicShow.SizeMode = PictureBoxSizeMode.Zoom;                     // 影像以原比例自動調整大小
           PicShow.Image=Image.FromStream(Fin);                            // 影像來自檔案串流
           BR.Close();
           Fin.Close();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            FileStream Fout = new FileStream(DestFile, FileMode.OpenOrCreate);// 建立檔案串流
            BinaryWriter BW = new BinaryWriter(Fout);                         // 建立二位元寫入器
            BW.Write(BufferData);                                             // 將 bufferData 陣列內容寫入資料串流
            BW.Flush();                                                       // 清空緩衝區
            LblShow.Text = "已完成資料複製!...";
            BW.Close();                                                       // 關閉資料串流
            Fout.Close();                                                     // 關閉檔案串流
        }
    }
}

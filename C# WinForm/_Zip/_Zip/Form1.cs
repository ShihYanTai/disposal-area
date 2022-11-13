using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Zip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sourcePath;
            string extractPath = @".\extract";
            sourcePath = Application.StartupPath + @"\source";      // 設定壓縮目錄
            if (File.Exists("a.zip")) File.Delete("a.zip");
            try
            {
                // 建立壓縮檔
                ZipFile.CreateFromDirectory(sourcePath, "a.zip");
                textBox1.AppendText("建立壓縮檔完成\r\n"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //---------------------解壓縮----------------
            if(Directory.Exists(extractPath)) Directory.Delete(extractPath, true);
            try
            {
                // 建立壓縮檔
                ZipFile.ExtractToDirectory("a.zip",extractPath);
                textBox1.AppendText("解壓縮檔完成\r\n");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs;
            ZipArchive zip;
            ZipArchiveEntry entry;
            StreamWriter sw;
            try
            {
                using (fs = new FileStream("test.zip", FileMode.Create))
                {
                    using (zip = new ZipArchive(fs, ZipArchiveMode.Update))
                    {
                        entry = zip.CreateEntry("123.txt");
                        using (sw = new StreamWriter(entry.Open()))
                        {
                            textBox1.Clear();
                            textBox1.AppendText("這是寫入到 123.txt 的資料");
                            sw.Write(textBox1.Text);
                            textBox1.AppendText("\r\n 建立壓縮檔完成 \r\n");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ZipArchive zip;
            List<ZipArchiveEntry> list;
            if (!File.Exists("a.zip")) MessageBox.Show("壓縮檔不存在!!");  // 檢查 button1 所產生的 壓縮檔 a.zip 是否存在
            return;
            textBox1.Clear();
            try
            {
                using(zip = ZipFile.OpenRead("a.zip"))
                {
                    list = new List<ZipArchiveEntry>(zip.Entries);
                    textBox1.AppendText("壓縮檔內包含裡以下檔案 : \r\n");
                    foreach (var item in list) textBox1.AppendText(item.Name + "\r\n");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

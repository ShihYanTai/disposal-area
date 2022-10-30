using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strFileName = @"test1.txt";
            string[] strWrite = { "13256", "456789" };
            string[] strRead;
            try
            {
                File.AppendAllLines(strFileName, strWrite);
                MessageBox.Show("完成");
            }
            catch(Exception ex)
            {
                MessageBox.Show("寫入資料錯誤");
            }
            try
            {
                strRead = File.ReadAllLines(strFileName);
                foreach (var str in strRead) textBox1.AppendText(str + "\r\n");
            }
            catch(Exception ex)
            {
                MessageBox.Show("讀取資料錯誤");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strFileName = "test2.txt";
            FileStream fs = null;
            string str = "File.Open";
            try
            {
                fs = File.Open(strFileName, FileMode.Create, FileAccess.Write);
                MessageBox.Show("開啟檔案。");
                fs.Write(Encoding.UTF8.GetBytes(str), 0, str.Length);
                MessageBox.Show("寫入資料。");
            }
            catch(Exception ex)
            {
                MessageBox.Show("發生錯誤。");
                return;
            }
            finally
            {
                fs.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            string str = "File.Create";
            fs = File.Create("test3.txt", 256,FileOptions.SequentialScan);
            fs.Write(Encoding.UTF8.GetBytes(str), 0, str.Length);
            fs.Close();
            MessageBox.Show(" 建立檔案並寫入資料成功");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strSource = "test1.txt";
            string strTarget = "copy.txt";
            if (!File.Exists(strSource))
            {
                MessageBox.Show("檔案不存在，無法進行拷貝");
                return;
            }
            try
            {
                File.Copy(strSource, strTarget);
                if (File.Exists(strTarget)) MessageBox.Show("檔案拷貝成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show("拷貝檔案失敗");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strDelete = "copy.txt";
            if (!File.Exists(strDelete)) MessageBox.Show("檔案不存在。");
            else
            {
                try
                {
                    File.Delete(strDelete);
                    if (!File.Exists(strDelete)) MessageBox.Show("檔案刪除成功。");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("無法刪除檔案");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strSource = "test1.txt";
            string strTarget = @"..\move.txt";
            if (!File.Exists(strSource)) MessageBox.Show("檔案不存在。");
            else
            {
                try
                {
                    File.Move(strSource, strTarget);
                    if (File.Exists(strTarget)) MessageBox.Show("檔案移動成功。");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("檔案已存在，或檔案無法移動。");
                }
            }
        }
    }
}

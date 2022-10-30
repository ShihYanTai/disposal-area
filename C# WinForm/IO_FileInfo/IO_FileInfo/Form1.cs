using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_FileInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo fi;
            List<FileInfo> strlist;
            DirectoryInfo di;
            textBox1.Clear();
            fi = new FileInfo("IO_FileInfo.exe");
            if (fi.Exists) textBox1.AppendText("檔案存在\r\n");
            else textBox1.AppendText("檔案不存在\r\n");
            textBox1.AppendText("目前的路徑:\r\n" + fi.DirectoryName);
            di = fi.Directory;
            strlist = new List<FileInfo>(di.EnumerateFiles());
            textBox1.AppendText("\r\n===========\r\n" + "目錄下的檔案\r\n");
            foreach (var item in strlist) textBox1.AppendText(item.Name + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo fi;
            fi = new FileInfo("IO_FileInfo.exe");
            textBox1.Clear();
            textBox1.AppendText("檔案長度=" + fi.Length.ToString() + "bytes");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("test1.txt");
            StreamWriter sw = null;
            string str;
            if(!fi.Exists)
                using(sw = fi.CreateText())
                {
                    sw.WriteLine("建立新檔");
                }
            using(sw = fi.AppendText())
            {
                str = DateTime.Now.ToString();
                sw.WriteLine(str);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("text2.txt");
            string str = "132456897";
            FileStream fs;
            byte[] str1;
            if (fi.Exists) fi.Delete();
            using (fs = fi.Create())
                fs.Write(Encoding.UTF8.GetBytes(str), 0, str.Length);
            fi.Refresh();
            using(fs = fi.Open(FileMode.Open, FileAccess.Read))
            {
                str1 = new byte[fs.Length];
                fs.Read(str1, 0, (int)str1.Length);
                textBox1.AppendText(Encoding.Default.GetString(str1));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("text2.txt");
            FileStream fs;
            string str = "abcde";
            try
            {
                using(fs = fi.OpenWrite())
                {
                    fs.Write(Encoding.Default.GetBytes(str), 1, 3);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("test1.txt");
            FileInfo f;
            try
            {
                f = fi.Replace("text2.txt", "text2.txt.bak");
                textBox1.AppendText(f.Name.ToString());

            }
            catch(Exception ex)
            {
                MessageBox.Show("error");
            }
        }
    }
}

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

namespace _directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di;
            string strPath = @"C:\Users\GIGABYTE\source\repos";
            try
            {
                if (Directory.Exists(strPath))
                {
                    MessageBox.Show("目錄已存在");
                    return;
                }
                di = Directory.CreateDirectory(strPath);
                MessageBox.Show("建立目錄完成");
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strPath = @"C:\Users\GIGABYTE\source\repos";
            try
            {
                if (!Directory.Exists(strPath))
                {
                    MessageBox.Show("目錄不存在");
                    return;
                }
                Directory.Delete(strPath);
                MessageBox.Show("完成刪除目錄");
            }
            catch(Exception ex)
            {
                MessageBox.Show("無法刪除目錄");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strPath = @"..\..\";
            List<string> dirs;
            try
            {
                dirs = new List<string>(Directory.EnumerateDirectories(strPath, "*.*",SearchOption.AllDirectories));
            }
            catch(Exception ex)
            {
                MessageBox.Show("無法列舉目錄");
                return;
            }
            foreach (var item in dirs) textBox1.AppendText(item.ToString() + "\r\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo("SourceDir");
            if (di.Exists == false)
            {
                di.Create();
                DirectoryInfo dis = di.CreateSubdirectory("SubDir");
                MessageBox.Show("建立目錄 Source 與目錄 SubDir 成功");
            }
            else
            {
                MessageBox.Show("目錄已存在");
            }
            if (Directory.Exists(@"..\TempDir") == false)
            {
                di.MoveTo(@"..\TempDir");
                MessageBox.Show("移動目錄成功");
            }
            else MessageBox.Show("目錄已存在");
        }
    }
}

using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace File_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs;
            string data = "1234567890abcdefghijklnmlpqrstuvwxyz";
            if (File.Exists("text.txt")) File.Delete("test.tx");
            try
            {
                using(fs = new FileStream("test.txt", FileMode.Create, FileAccess.Write))
                {
                    fs.Write(Encoding.Default.GetBytes(data), 0, data.Length);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs;
            byte[] data;            // 儲存資料
            int count = 1, pos = 0; // 每次讀入的 byte 數 、 資料放置在陣列的位置
            int fileLength, len = 10;// 檔案長度 、 每次要讀入資料的 byte 數
            string str;
            try
            {
                using(fs= new FileStream("test.txt", FileMode.Open, FileAccess.Read))
                {
                    fileLength = (int)fs.Length;
                    str = "檔案長度=" + fileLength.ToString() + "\r\n";
                    textBox1.AppendText(str);
                    if(fileLength <= 0)
                    {
                        MessageBox.Show("檔案長度=0");
                        fs.Close();
                        return;
                    }
                    data = new byte[fileLength];    // 配置陣列空間
                    if(fileLength < len) len = fileLength;  // 如果檔案長度小於預設的讀入的 byte 數
                    // -----------------------------------------------------------------------------------

                    while(fileLength > 0)
                    {
                        count = fs.Read(data, pos, len);
                        str = String.Format("{0},{1}: {2}", count, pos, Encoding.Default.GetString(data));
                        pos += count;               // 下一次資料要放置在陣列位置
                        fileLength -= count;        // 剩餘的檔案長度
                        if (fileLength < len) len = fileLength;
                        textBox1.AppendText(str);
                        textBox1.AppendText("\r\n");
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
            FileStream fs;
            byte b;
            int fileLength, pos;
            if (!File.Exists("test.txt"))
            {
                MessageBox.Show("檔案不存在");
                return;
            }
            try
            {
                using(fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read))
                {
                    fileLength = (int)fs.Length;
                    textBox1.AppendText("檔案長度=" + fileLength.ToString() + "\r\n");
                    pos = (int)fs.Seek(3, SeekOrigin.Begin);
                    textBox1.AppendText("讀取位置=" + pos.ToString() + "\r\n");
                    textBox1.AppendText("讀取長度=" + (fileLength - pos).ToString() + "\r\n");
                    for(int i = 0; i < fileLength - pos; i++)
                    {
                        b = (byte)fs.ReadByte();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

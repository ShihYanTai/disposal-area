using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace imitation
{
    public partial class Form1 : Form
    {
        string[] Encode = { "BIG5", "GB2312", "Shift_JIS", "EUC-KR", "ANSI", "UTF-8", "UNICODE" };
        string wEncode = "", rEncode = "";

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        //------------------------------------------------------
        StreamWriter CreateFile(string filename, string code)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(filename, false, Encoding.GetEncoding(code));
            }
            catch(IOException ex)
            {
                MessageBox.Show(" 無法建立檔案");
                sw = null;
                return sw;
            }
            MessageBox.Show("建立檔案成功");
            return sw;
        }
        // --------------------------------------------------------
        bool WriteToFile(StreamWriter sw, string str)
        {
            bool fg = false;
            try
            {
                sw.WriteLine(str);
                fg = true;
            }
            catch(IOException ex)
            {
                MessageBox.Show(" 寫入檔案有誤");
                return fg;
            }
            MessageBox.Show("資料寫入 OK!");
            return fg;
        }
        // -----------------------------------------------------------
        StreamReader OpenFile(string fileName, string code)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName, Encoding.GetEncoding(code));
            }
            catch(IOException ex)
            {
                MessageBox.Show("無法開啟檔案");
                sr = null;
                return sr;
            }
            MessageBox.Show("開啟檔案成功");
            return sr;
        }
        bool ReadFromFile(StreamReader sr, ref string str)
        {
            bool fg = false;
            try
            {
                str = sr.ReadToEnd();
                fg = true;
            }
            catch(IOException ex)
            {
                MessageBox.Show("讀取資料有誤");
                return fg;
            }
            MessageBox.Show("讀取資料 OK");
            return fg;
        }
        void getEncode(int index, ref string strEncode)
        {
            strEncode = (index == 5) ? Encode[0] : Encode[index];   // ANSI
        }
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            getEncode(comboBox1.SelectedIndex, ref wEncode);
        }
        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            getEncode(comboBox2.SelectedIndex, ref rEncode);
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            StreamWriter sw = null;
            if (comboBox1.Text == "") 
            { 
                MessageBox.Show("請選擇一種編碼");
                return;
            };
            using (sw = CreateFile("file.txt", wEncode))
            {
                WriteToFile(sw, textBox1.Text);
            }
        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            StreamReader sr;
            string str = "";
            if (comboBox2.Text == "") 
            { 
                MessageBox.Show("請選擇一種編碼");
                return;
            }; 
            using(sr = OpenFile("file.txt", rEncode))
            {
                ReadFromFile(sr, ref str);
                textBox1.AppendText(str);
            }
        }
    }
}

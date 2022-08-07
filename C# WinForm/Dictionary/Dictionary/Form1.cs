using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 建立 Dictionary 物件 openWith，其索引與值的型別皆為字串
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("txt", "notepad.exe");         // 加入資料到物件 openWith 中
            openWith.Add("bmp", "paint.exe");            // Key 不能重複
            openWith.Add("rtf", "wordpad.exe");
            openWith.Add("dib", "paint.exe");           // Value 可以重複
            if (!openWith.ContainsKey("doc"))
            {
                openWith["doc"] = "winword.exe";        // 加入配對資料
            }
            label1.Text = "Dictionary 泛型物件 Key 與 Value 組配對資料 : ";
            foreach(KeyValuePair<string, string> pair in openWith)
            {
                TxtDic.Text += $"Key = {pair.Key} ,\tValue = {pair.Value}\r\n";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 字典
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> myDict;
        public Form1()
        {
            InitializeComponent();
            myDict = new Dictionary<string, string>()
            {
                {" 狗 ", " 哺乳類 " },
                {" 貓 ", " 哺乳類 " }
            };
            myDict.Add(" 蛇 ", " 爬蟲類 ");
            myDict.Add(" 青蛙 ", " 兩棲類 ");

            myDict[" 烏龜 "] = " 爬蟲類 ";

            foreach(var item in myDict)
            {
                textBox2.AppendText(String.Format("{0} -> {1}\r\n", item.Key, item.Value));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strName;
            strName = textBox1.Text;
            textBox2.Clear();
            if (myDict.ContainsKey(strName)) textBox2.AppendText(myDict[strName] + "\r\n");
            else textBox2.AppendText(" 查無此資料 \r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strName;
            string strValue;

            strName = textBox1.Text;
            textBox1.Clear();
            if (myDict.TryGetValue(strName, out strValue)) textBox2.AppendText(strValue + "\r\n");
            else textBox2.AppendText(" 查無此資料 \r\n");
        }
    }
}

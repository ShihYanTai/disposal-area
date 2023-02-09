using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 在串列搜尋資料
{
    public partial class Form1 : Form
    {
        string[] array = new string[] { "be able to ", "book", "capable", "book", "abler" };
        List<string> mylist;
        public Form1()
        {
            InitializeComponent();
            mylist = new List<string>(array);
        }
        bool MyFinder(string item)
        {
            if(item.Contains("able")) return true;
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            textBox1.Clear();
            // ------------------------ 尋找 "book" -------------------
            textBox1.AppendText("---- 尋找 \"book\" -------\r\n");
            str = mylist.Find(x => x == "book");
            textBox1.AppendText(str + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> listFind;
            textBox1.Clear();
            // ------------ 尋找包含 "able" 的元素 ----------------
            textBox1.AppendText("---- 包含 \"able\"----\r\n");
            listFind = mylist.FindAll(x => x.Contains("able"));
            foreach(var item in listFind) textBox1.AppendText(item + "\r\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> listFind1, listFind2;
            // 宣告委派
            Predicate<string> MyPredicate = MyFinder;
            textBox1.Clear();
            // ---------------- 使用委派 --------------------------
            textBox1.AppendText("---使用委派 --\r\n");
            // listFind1 = myListFindAll(MyFinder); 這樣也可以
            listFind1 = mylist.FindAll(MyPredicate);
            foreach (var item in listFind1) textBox1.AppendText(item + "\r\n");
            // ---------- 使用隱含委派 ----------------------------
            textBox1.AppendText("-- 使用隱含委派 ----\r\n");
            listFind2 = mylist.FindAll(delegate (string str) { return str.Contains("able"); });
            foreach(var item in listFind2) textBox1.AppendText(item + "\r\n");
        }
    }
}

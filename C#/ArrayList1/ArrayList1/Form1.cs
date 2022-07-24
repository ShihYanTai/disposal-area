using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayList1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String data(IEnumerable tarylst)
        {
            int n = 1;
            string st = "";
            foreach(Object obj in tarylst)
            {
                st += $"第{n}個元素資料內容 : {obj}\n";
                n++;
            }
            return st;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList arylst  = new ArrayList();    // 宣告並建立 arylst 串列
            //ArrayList arylst  = new ArrayList{"Alice", "Bob", 168, true};    // 宣告並建立 arylst 串列
            arylst.Add("Alice");
            arylst.Add("Bob");
            arylst.Add(168);
            arylst.Add(true);
            arylst.AddRange(new string[] { "David", "Eric" });
            arylst.Insert(2, "Jack");               // "Jack" 插在第3個元素處,元索引往後移
            arylst.Add("Ford");                     // 將"Ford" 插在字串最後
            string msg1 = $"目前 arylist 可存放元素總容量 : {arylst.Capacity}\n";
            string msg2 = $"目前 arylist 內所有元素共計 : {arylst.Count}\n";
            string msg = msg1 + msg2 + data(arylst);// 傳回串列內的元素
            MessageBox.Show(msg, "結果", MessageBoxButtons.OK);

            arylst.Remove("Ford");                  // 移除Ford
            arylst.RemoveAt(2);                     // 移除第 3 個元素,原索引往前移
            arylst.RemoveRange(2, 3);               // 移除第 3 個元素起共 3 個元素
            msg1 = $"目前 arylist 可存放元素總容量 : {arylst.Capacity}\n";
            msg2 = $"目前 arylist 內所有元素共計 : {arylst.Count}\n";
            msg = msg1 + msg2 + data(arylst);       // 傳回串列內的元素
            MessageBox.Show(msg, "結果", MessageBoxButtons.OK);
                
            arylst.Clear();                         // 移除串列中所有元素
            msg1 = $"目前 arylist 可存放元素總容量 : {arylst.Capacity}\n";
            msg2 = $"目前 arylist 內所有元素共計 : {arylst.Count}\n";
            msg = msg1 + msg2 + data(arylst);       // 傳回串列內的元素
            MessageBox.Show(msg, "結果", MessageBoxButtons.OK);
        }
    }
}

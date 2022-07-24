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

namespace QueueEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue QName;                // 宣告 Queue 集合類別 QName 佇列物件
        public String data(IEnumerable myList)      // 回傳佇列元素
        {
            string st = "";
            foreach(Object obj in myList)
            {
                st += $"{obj}  ";
            }
            return st;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QName = new Queue();                // 建立 Queue 集合類別 QName 佇列
            string[] aryName = { "David", "Tom", "Jack", "Mary", "Bob" };
            for(int i = 0; i < aryName.Length; i++)
            {
                QName.Enqueue(aryName[i]);      // 由佇列尾部加入一元素
            }
            TxtName.Text = data(QName);
            LblMsg.Text = $"原始資料,元素共計 : {QName.Count}";
        }

        private void BtnCln_Click(object sender, EventArgs e)
        {
            QName.Clear();                      // 清除 QName 佇列中所有元素
            TxtName.Text = data(QName);
            LblMsg.Text = "移除所有資料";
            BtnDel.Enabled = false;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            QName.Dequeue();                    // 移除 QName 佇列最前面一個元素
            TxtName.Text = data(QName);
            LblMsg.Text = $"移除一筆，元素共計 : {QName.Count}";
        }

        private void BtnIndex_Click(object sender, EventArgs e)
        {
            if(!(TxtAdd.Text == ""))            // 文字方塊需有內容
            {
                QName.Enqueue(TxtAdd.Text);     // 由佇列尾部加入一元素
                TxtName.Text = data(QName);
                LblMsg.Text = $"新增資料，元素共計 : {QName.Count}";
                TxtAdd.Text = "";
                BtnDel.Enabled = true;
            }
        }
    }
}

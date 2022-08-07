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

namespace StackEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack SName;                            // 宣告Stack 集合類別 SName堆疊物件
        public String data(IEnumerable myList)
        {
            string st = "";
            foreach (Object o in myList)
                st += $"{o} \r\n";
            return st;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SName = new Stack();
            string[] aryName = { "David", "Tom", "Jack", "Mary", "Bob" };
            for(int i = 0; i < aryName.Length; i++)
            {
                SName.Push(aryName[i]);         // 由堆疊頂端加入一元素
            }
            TxtName.Text = data(SName);
            LBlMsg.Text = $"原始資料，元素共計 : {SName.Count}";
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            SName.Pop();                        // 由 SName 堆疊頂端移除一個元素
            TxtName.Text = data(SName);
            LBlMsg.Text = $"移除一筆，元素共計 : {SName.Count}";
        }

        private void BtnTop_Click(object sender, EventArgs e)
        {
            try
            {
                LBlMsg.Text = $"第一個資料 : {SName.Peek()}";        // 讀取最前面資料
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            
        }

        private void BtnCln_Click(object sender, EventArgs e)
        {
            SName.Clear();                                      // 清除 Sname 堆疊所有元素
            TxtName.Text = data(SName);
            LBlMsg.Text = "移除所有資料";
            BtnDel.Enabled = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(TxtAdd.Text != "")
            {
                SName.Push(TxtAdd.Text);
                TxtName.Text = data(SName);
                LBlMsg.Text = $"新增資料，元素共計 : {SName.Count}";
                TxtAdd.Text = "";
                BtnDel.Enabled = true;
            }
        }
    }
}

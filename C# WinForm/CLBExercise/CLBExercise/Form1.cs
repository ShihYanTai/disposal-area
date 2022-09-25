using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLBExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            label1.Text = "第" + (e.Index + 1) + "項的狀態:" + e.NewValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 增加 4 個項目
            checkedListBox1.Items.Clear();                                          // 清除所有舊的項目
            for (int i = 0; i < 4; i++)
                checkedListBox1.Items.Add("Item " + (i + 1).ToString());
            // 預設勾選第一個項目
            checkedListBox1.SetItemChecked(0, true);
        }
        // -----------------------列出被勾選項目，方法 1 ------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            string str;
            textBox1.AppendText("----- 列出被勾選的項目，方法 1 -----\r\n");
            // --------------- 逐一檢查每一個項目的勾選狀態 ---------------------------
            for(int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
                if (checkedListBox1.GetItemChecked(i))
                {
                    str = "第 " + (i + 1).ToString() + " 項 :" + checkedListBox1.Items[i].ToString() + "\r\n";
                    textBox1.AppendText(str);
                }
        }
        // ------------------- 列出被勾選項目，方法 2 ---------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            string str = "";
            textBox1.AppendText("-- 列出被勾選的項目，方法2 ----\r\n");
            textBox1.AppendText("- 共有" + checkedListBox1.CheckedItems.Count + "被勾選\r\n");
            // ------ 直接使用 checkedListBox1.checkedItems ---------------------------
            foreach(var item in checkedListBox1.CheckedItems)
            {
                str = item.ToString()+ "\r\n";
                textBox1.AppendText(str);
            }
        }
        // ------------------- 列出被勾選項目，方法 3 ---------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("-- 列出被勾選項目，方法 3 -- \r\n");
            foreach (int item in checkedListBox1.CheckedIndices)
                textBox1.AppendText("第 " + (item + 1).ToString() + " 項被勾選。\r\n");
        }
        // ------------------- 目前哪個項目被點選 -------------------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            int i;
            i = checkedListBox1.SelectedIndex;
            textBox1.AppendText("-- 判斷哪個項目被點選-- \r\n");
            textBox1.AppendText("第 " + (i + 1).ToString() + "項目被點選\r\n");
        }
        // ----------------- 列出每勾選項目狀態 ---------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("----- 列出每項的勾選狀態 -----\r\n");
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                textBox1.AppendText("第 " + (i + 1).ToString() +" 項狀態 : "+checkedListBox1.GetItemCheckState(i).ToString() +" \r\n");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

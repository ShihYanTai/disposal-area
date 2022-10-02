using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv;
            if (!radioButton1.Checked)
                return;
            lv = (ListView)sender;                                              // 將 sender 轉型 ListView
            textBox1.Clear();
            foreach(ListViewItem item in lv.SelectedItems)
            {
                // 將 item 中所有的欄位裡的資料串在一起顯示
                foreach(ListViewItem.ListViewSubItem str in item.SubItems)
                {
                    textBox1.AppendText(str.Text.ToString() + " ");
                }
                textBox1.AppendText("\r\n");
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!radioButton2.Checked) return;
            textBox1.Clear();

            // 此事件再項目的選取狀態改變的時候會被觸發，所以要先篩選
            // 此項目是被"選取"的狀態，而不是在"非選取"的狀態。
            if (e.IsSelected)
            {
                // 先顯示編號
                textBox1.AppendText(e.ItemIndex.ToString() + " ");
                for(int i = 0;i < e.Item.SubItems.Count; i++)
                {
                    textBox1.AppendText(e.Item.SubItems[i].Text.ToString() + " ");
                }
                textBox1.AppendText("\r\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            // 取得選取的數量
            textBox1.AppendText("選取數 : " + listView1.SelectedItems.Count.ToString() + "\r\n");
            textBox1.AppendText("欄位數 : " + listView1.SelectedItems.Count.ToString() + "\r\n");

            foreach(ListViewItem item in listView1.SelectedItems)
            {
                foreach (ListViewItem.ListViewSubItem str in item.SubItems) textBox1.AppendText(str.Text.ToString() + " ");
                textBox1.AppendText("\t\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (int no in listView1.SelectedItems)
                listView1.Items[no].Remove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.Items[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }
    }
}

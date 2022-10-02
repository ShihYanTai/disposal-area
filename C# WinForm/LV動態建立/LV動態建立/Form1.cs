using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV動態建立
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string picPath;                                     // 存放圖示路徑
            Image image;
            picPath = Application.ExecutablePath;
            for(int i = 0; i < 6; i++)                          // 尋找存放圖片的目錄
                picPath = System.IO.Directory.GetParent(picPath).ToString();
            picPath += @"\pic\";
            // ------------------------- 建立男性和女性的小圖示-------------------------------------

            image = Image.FromFile(picPath + "icon2.png");
            imageList1.Images.Add(image);
            image = Image.FromFile(picPath + "icon3.png");
            imageList1.Images.Add(image);
            listView1.SmallImageList = imageList1;

            // ------------------------- 建立核取方塊小圖示-------------------------------------

            image = Image.FromFile(picPath + "icon7.png");
            imageList2.Images.Add(image);
            image = Image.FromFile(picPath + "icon8.png");
            imageList2.Images.Add(image);
            listView1.StateImageList = imageList2;
            button1.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ---------------------------------建立三個欄位 -------------------------------------------
            listView1.Columns.Add("姓名", 120);
            listView1.Columns.Add("住址", 150);
            listView1.Columns.Add("電話", 100);
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] name = { "張三郎", "真美麗", "王曉明" };
            string[] address = { "民生路225號", "愛國西路1號", "中央路120號" };
            string[] phone = { "12312", "16265165", "4551655" };
            listView1.CheckBoxes = true;            // 使用和取方塊
            for (int i = 0; i < 3; i++)
            {
                listView1.Items.Add(name[i]);
                listView1.Items[i].SubItems.Add(address[i]);
                listView1.Items[i].SubItems.Add(phone[i]);
                listView1.Items[i].StateImageIndex = 0;
            }
            listView1.Items[0].ImageIndex = 0;  //男性Icon
            listView1.Items[1].ImageIndex = 1;  // 女Icon
            listView1.Items[2].ImageIndex = 0;  // 男Icon
            button3.Enabled = false;
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            textBox1.Clear();
            foreach(ListViewItem item in listView1.CheckedItems)
            {
                foreach (ListViewItem.ListViewSubItem str in item.SubItems)
                {
                    textBox1.AppendText(str.Text.ToString() + " ");
                }
                textBox1.AppendText("\r\n");
            }
            listView1.Items[0].ImageIndex = 1;      //男性Icon
            listView1.Items[1].ImageIndex = 0;      // 女Icon
            listView1.Items[2].ImageIndex = 1;      // 男Icon

            button3.Enabled = false;
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            textBox1.Clear();
            foreach (ListViewItem item in listView1.CheckedItems) 
            {
                foreach(ListViewItem.ListViewSubItem str in item.SubItems)
                {
                    textBox1.AppendText(str.Text.ToString() + " ");
                }
                textBox1.AppendText("\r\n");
            }
        }
    }
}

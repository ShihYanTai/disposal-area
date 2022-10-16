using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 視窗表單布局
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.ContextMenuStrip = contextMenuStrip1;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void eSubItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "狀態:"+ eSubItem1.Text;
            if (eSubItem1.Text == "開始") eSubItem1.Text = "暫停";
            else eSubItem1.Text = "開始";
        }

        private void toolStripContainer1_ContentPanel_MouseMove(object sender, MouseEventArgs e)
        {
            string str;
            str = String.Format("X={0}, Y={1}", e.Location.X, e.Location.Y);
            toolStripStatusLabel1.Text = str;
        }

        private void cSubItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "更改";
        }

        private void cSubItem2_Click(object sender, EventArgs e)
        {
            label1.Text = "label1";
        }
        private void fSubItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("建立新檔");
        }
        private void OToolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("開啟舊檔");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_document_interface
{
    public partial class Form1 : Form
    {
        int MdiChildNo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void 開新檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 MdiChild;
            MdiChild = new Form2();
            MdiChild.MdiParent = this;
            MdiChild.Text = "MDI No. " + (++MdiChildNo).ToString();
            MdiChild.Show();
        }
        private void 讀取檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) return;

            Form2 MdiChild;
            MdiChild = new Form2(openFileDialog1.FileName);
            MdiChild.MdiParent = this;
            MdiChild.Text = "MDI NO. " + (++MdiChildNo).ToString();
            MdiChild.Show();
        }

        private void 儲存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm;

            if(saveFileDialog1.ShowDialog()!=DialogResult.OK) return;

            fm = (Form2)this.ActiveMdiChild;
            fm.getImage.Save(saveFileDialog1.FileName + ".png");
        }
        private void 取得子表單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] fmList;
            string str = "";

            fmList = this.MdiChildren;
            foreach (var item in fmList) str += item.Text + ", \n";
            MessageBox.Show(str);
            if (fmList.Length >= 1) ActivateMdiChild(fmList[fmList.Length / 2]);
        }
        private void 水平ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}

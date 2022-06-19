using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMidForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {// 子表單名稱清單顯示在MnuWindow 項目中
            menuStrip1.MdiWindowListItem = MnuWindow;


        }

        private void MnuAdd_Click(object sender, EventArgs e)
        {
            Form2 FrmChild = new Form2();       // declare FrmChild is object about Form2();
            FrmChild.MdiParent = this;          // order the parent's list
            int num = this.MdiChildren.Length;  // get the child array of number
            FrmChild.Text = $"表單 {num}";        // set the child title of text
            FrmChild.Show();                    // domenstrate the child object in the parent

        }

        private void MnuCasecade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);  // 子表單重疊並排
        }

        private void MnuHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);// 子表單水平排列
        }

        private void MnuVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);// 子表單垂直排列
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuScrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtW.Multiline = true;
            TxtW.Dock = DockStyle.Fill;
            MnuStyle1.CheckOnClick = true;
            MnuStyle2.CheckOnClick = true;
            MnuSet2.CheckOnClick = true;
            MnuSet1_Click(sender, e);
            TxtW.ContextMenuStrip = contextMenuStrip1;
            Clipboard.Clear();
        }

        private void MnuSet_Click(object sender, EventArgs e)
        {

        }

        private void MnuSet1_Click(object sender, EventArgs e)
        {
            TxtW.Text = "做該做的事是智慧，\r\n做不該做的事是愚痴。";
            MnuStyle1.Checked = false;
            MnuStyle2.Checked = false;
            TxtW.Font = new Font("新細明體", 12, FontStyle.Regular);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "編輯")
            {
                if(TxtW.SelectionLength > 0)
                {
                    MnuEdit1.Enabled = true;
                    MnuEdit3.Enabled = true;
                }
                else
                {
                    MnuEdit1.Enabled=false;
                    MnuEdit3.Enabled=false;
                }

                if(Clipboard.GetText() == "")
                {
                    MnuEdit2.Enabled = false;
                }
                else
                {
                    MnuEdit2.Enabled = true;
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(TxtW.SelectionLength > 0)
            {
                CMnuEdit1.Enabled = true;
                CMnuEdit3.Enabled = true;
            }
            else
            {
                CMnuEdit1.Enabled=false;
                CMnuEdit3.Enabled=false;
            }
            if (Clipboard.GetText() == "")
            {
                CMnuEdit2.Enabled=false;
            }
            else
            {
                CMnuEdit2.Enabled=true;
            }
        }

        private void MnuEdit1_Click(object sender, EventArgs e)
        {
            TxtW.Copy();
        }

        private void MnuEdit2_Click(object sender, EventArgs e)
        {
            TxtW.Paste();
        }

        private void MnuEdit3_Click(object sender, EventArgs e)
        {
            TxtW.Cut();
        }
    }
}

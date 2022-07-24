using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] range;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            BtnSort.Enabled = false;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            Array.Sort(range);
            label1.Text = range[0].ToString();
            label2.Text = range[1].ToString();
            label3.Text = range[2].ToString();
            label4.Text = range[3].ToString();
            label5.Text = range[4].ToString();
            label6.Text = range[5].ToString();
        }

        private void BtnCls_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int min = 1, max = 49, rndNum = 6;
            range = new int[rndNum];
            MarkRnd Rnd = new MarkRnd();
            Rnd.GetRnd(range, min, max, rndNum);
            label1.Text = range[0].ToString();
            label2.Text = range[1].ToString();
            label3.Text = range[2].ToString();
            label4.Text = range[3].ToString();
            label5.Text = range[4].ToString();
            label6.Text = range[5].ToString();
            BtnSort.Enabled = true;
        }
    }
}

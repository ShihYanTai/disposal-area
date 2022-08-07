using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 樹木投票
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = int.Parse("0") + "%";
            label2.Text = int.Parse("0") + "%";
            label3.Text = int.Parse("0") + "%";
            label4.Text = int.Parse("0") + "%";
            label5.Text = int.Parse("0") + "%";
            label6.Text = "投票數 : " + int.Parse("0");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Vote_Click(object sender, EventArgs e)
        {
            int sum = 0, total = 0;

            if (radioButton1.Checked == true)
            {
                sum ++;
            }
            else if (radioButton2.Checked == true)
            {
                sum ++;
            }
            else if (radioButton3.Checked == true)
            {
                sum ++;
            }
            else if (radioButton4.Checked == true)
            {
                sum ++;
            }
            else if (radioButton5.Checked == true)
            {
                sum ++;
            }
            
            label6.Text = $"投票數 : {sum}";
        }
    }
}

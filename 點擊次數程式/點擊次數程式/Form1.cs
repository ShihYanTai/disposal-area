using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 點擊次數程式
{
    public partial class Form1 : Form
    {
        int times = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            times++;
            timesLable.Text = "你已經點了..." +  times + "下";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            times = 0;
            timesLable.Text = "你已經點了..." + times + "下";
        }
    }
}

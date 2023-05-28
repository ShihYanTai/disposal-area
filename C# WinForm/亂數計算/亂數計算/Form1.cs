using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 亂數計算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rect myRect = new rect();
            myRect.Width = 12;
            myRect.Height = 10;
            myRect.Show(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            randomNum myRand = new randomNum(10);
            myRand.genNumbers();
            myRand.Show(textBox1);
        }
    }
}

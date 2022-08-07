using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalA resl = new CalA();
            int n1, n2;
            n1 = 10;n2 = 15;
            resl.SetValue(n1, n2);                          // 設定 CalA類別欄位 num1、num2
            label1.Text = $"{n1} + {n2} = {resl.GetSum()}";


            CalB res2 = new CalB();
            n1 = 20;n2 = 25;
            res2.SetValue(n1, n2);                          // 設定 CalB 欄位類別 num1、num2
            label2.Text = $"{n1} + {n2} = {resl.GetSum()}";
            label3.Text = $"{n1} + {n2} = {resl.GetSum()}";
        }
    }
}

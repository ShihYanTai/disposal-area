using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using circleLibrary;
namespace 動態函式庫
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius;
            circle cr = new circle();
            radius = Double.Parse((textBox1.Text != "") ? textBox1.Text : "0") ;
            cr.Radius = radius;
            label2.Text = "面積 = " + cr.getSize().ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Triangle tri1 = new Triangle();
            label1.Text = "A 三角形 採 Triangle() 預設建構函式...";
            label2.Text = $"底長:{tri1.Base},高度:{tri1.High},面積:{tri1.GetArea()}";

            Triangle tri2 = new Triangle(10);
            label3.Text = "A 三角形 採 Triangle(10) 預設建構函式...";
            label4.Text = $"底長:{tri2.Base},高度:{tri2.High},面積:{tri2.GetArea()}";

            Triangle tri3 = new Triangle(15, 25);
            label5.Text = "A 三角形 採 Triangle(15,25) 預設建構函式...";
            label6.Text = $"底長:{tri3.Base},高度:{tri3.High},面積:{tri3.GetArea()}";
        }
    }
}

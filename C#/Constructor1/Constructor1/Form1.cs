using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor1
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
            label1.Text = $"三角形面積 : {tri1.GetArea()}";
            Triangle tri2 = new Triangle(31, 25);
            label2.Text = $"三角形面積 : {tri2.GetArea()}";
        }
    }
}

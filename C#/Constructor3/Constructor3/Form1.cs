using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor3
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
            textBox1.Text = $" 底長 = {tri1.Base}" +
                $"\r\n 高度 = {tri1.High}" +
                $"\r\n 面積為 {tri1.GetArea()}";
            Triangle tri2 = new Triangle();
            textBox2.Text = $"底長 = {tri2.Base}" +
                $"\r\n 高度 = {tri2.High}" +
                $"\r\n 面積為 {tri2.GetArea()}";
            Triangle tri3 = new Triangle();
            textBox3.Text = $"底長 = {tri3.Base}" +
                $"\r\n 高度 = {tri3.High}" +
                $"\r\n 面積為 {tri3.GetArea()}";
        }
    }
}

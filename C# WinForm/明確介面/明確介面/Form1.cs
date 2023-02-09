using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 明確介面
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Myclass1 my = new Myclass1();
            IfaceA fa = my;
            IfaceB fb = my;

            textBox1.AppendText(fa.ShowInfo() + "\r\n");
            textBox1.AppendText(fb.ToString() + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Myclass2 my = new Myclass2();
            IfaceA fa = my;
            IfaceB fb = my;

            textBox1.AppendText(fa.ShowInfo() + "\r\n");
            textBox1.AppendText(fb.ToString() + "\r\n");
        }
        interface IfaceA
        {
            string ShowInfo();
        }
        interface IfaceB
        {
            string ShowInfo();
        }
        class Myclass1 : IfaceA, IfaceB
        {
            public string ShowInfo()
            {
                return "ShownInfo";
            }
        }
        class Myclass2 : IfaceA, IfaceB
        {
            string IfaceA.ShowInfo()
            {
                return "ShowInfo for IfaceA";
            }
            string IfaceB.ShowInfo()
            {
                return "ShowInfo for IfaceB";
            }
        }
    }
}

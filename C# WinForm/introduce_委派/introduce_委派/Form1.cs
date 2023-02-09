using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introduce_委派
{
    public partial class Form1 : Form
    {
        delegate string Dgate(string str);
        public Form1()
        {
            InitializeComponent();
        }
        public string HiMary(string str)
        {
            return "Hello, 早安， " + str + "\r\n";
        }
        public string HiJohn(string str)
        {
            return "Hello, 午安， " + str + "\r\n";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dgate DelFunc;
            DelFunc = HiMary;
            textBox1.AppendText(DelFunc(" 瑪莉"));

            DelFunc = HiJohn;
            textBox1.AppendText(DelFunc(" 約翰"));

        }
    }
}

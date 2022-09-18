using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleBoy
{
    public partial class Form3 : Form
    {
        bool fg = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;    // 總和
            int i = 1;
            textBox1.Clear();
            do
            {
                sum += i;
                textBox1.AppendText(sum.ToString() + "\r\n");
                i++;
                Application.DoEvents();
            }while(fg == true && i <= 10);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            fg = checkBox1.Checked;
            checkBox1.Text = "fg=" + fg.ToString();
        }
    }
}

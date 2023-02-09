using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 表單傳遞資料2
{
    public partial class Form1 : Form
    {
        public string strForm1;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2;
            DialogResult result;
            int v;

            form2 = new Form2("Hello, Form2. ");
            form2.Owner = this;
            form2.strPublic = "access public string";
            form2.setLabel3 = "Set label3.Text";

            result = form2.ShowDialog();
            label1.Text = result.ToString();

            v = form2.GetValue(6);
            label2.Text = v.ToString();
            label3.Text = strForm1;
        }
    }
}

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
    public partial class Form2 : Form
    {
        public string strPublic;
        public string setLabel3
        {
            get { return label3.Text; } 
            set { label3.Text = value; }
        }
        public int GetValue(int a)
        {
            return a += 10;
        }
        public Form2(string fromFrom1)
        {
            InitializeComponent();
            label1.Text = fromFrom1;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1;

            form1 = (Form1)this.Owner;
            label2.Text = strPublic;
            form1.strForm1 = "Message from form2.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 繼承
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classB classB = new classB();
            classB.b1 = 10;
            label1.Text = (classB.b1 + classB.a1).ToString();
            label2.Text = classB.ShowMsg();
        }
        class classA
        {
            public int a1 { get; set; }
            private int a2;
            protected int a3 { get; set; }
            public static int a4 { get; set; }
            public classA()
            {
                a1 = 5;
            }
            public string ShowMsg()
            {
                return " 來自 classA";
            }            
            public virtual string ShowMsg_1()
            {
                return " 來自 classA_1";
            }
        }
        class classB : classA
        {
            public int b1 { get; set; }
            
            new public string ShowMsg()
            {
                return " 來自 classB";
            }
            public override string ShowMsg_1()
            {
                return "Hello 妳好!";
            }
        }
    }
}

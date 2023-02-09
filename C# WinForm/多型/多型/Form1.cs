using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多型
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parent pt = new Parent();
            Child cd = new Child();

            textBox1.Clear();
            pt.name = "parent 類別";
            textBox1.AppendText(pt.ShowName() + "\r\n");
            cd.name = "chilld 類別";
            textBox1.AppendText(cd.ShowName() + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parent ptcd = new Child();
            textBox1.Clear();
            ptcd.name = "parent 類別";
            textBox1.AppendText(ptcd.ShowName() + "\r\n");
        }
        public class Parent
        {
            public string name { get; set; }
            public virtual string ShowName()
            {
                return "From Parent : " + name;
            }
        }
        public class Child : Parent
        {
            public override string ShowName()
            {
                return "From Child : " + name;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GType<int> testInt = new GType<int>();          // int 引數
            label1.Text = testInt.checkType(12344);         // 呼叫
            GType<double> testDouble = new GType<double>(); // double 引數
            label2.Text = testDouble.checkType(123.234);
            GType<string> testString = new GType<string>(); // string 引數
            label3.Text = testString.checkType("Hello!");
            GType<bool> testBool = new GType<bool>();       // boolean 引數
            label4.Text = testBool.checkType(false);         
        }
    }

}

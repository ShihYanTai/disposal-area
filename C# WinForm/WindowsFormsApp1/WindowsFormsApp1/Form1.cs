using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicInfoControl;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "";
            int age = 0;
            basicInfo1.getBasicInfo(ref name, ref age);
            label1.Text = " 姓名 : " + name;
            label2.Text = " 年齡 : " + age.ToString();
            basicInfo1.button1.Text = "改嚕";
        }
    }
}

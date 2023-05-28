using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicInfoControl
{
    public partial class basicInfo: UserControl
    {
        string name = " 無名氏 ";
        int age = 0;
        public basicInfo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") name = textBox1.Text;
            else
            {
                name = " 無名氏";
                textBox1.Text = name;
            }
            try
            {
                age = int.Parse(textBox2.Text);
            }
            catch(Exception)
            {
                age = 0;
                textBox2.Text = age.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            name = " 無名氏 ";
            age = 0;
            textBox1.Text = name;
            textBox2.Text = age.ToString();
        }
        public void getBasicInfo(ref string name, ref int age)
        {
            name = this.name;
            age = this.age;
        }
    }
}

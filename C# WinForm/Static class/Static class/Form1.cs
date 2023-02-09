using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float value;
            value = float.Parse(textBox1.Text);
            if (comboBox1.SelectedIndex == 0) label3.Text = TempConvertor.C2F(value).ToString();
            else label3.Text = TempConvertor.F2C(value).ToString();
        }
    }
    static class TempConvertor
    {
        public static float C2F(float cTemp)
        {
            float fTemp;
            fTemp = (cTemp * 9.0f / 5.0f) + 32.0f;
            return fTemp;
        }
        public static float F2C(float fTemp)
        {
            float cTemp;
            cTemp = (fTemp - 32.0f) * 5.0f / 9.0f;
            return cTemp;
        }
    }
}

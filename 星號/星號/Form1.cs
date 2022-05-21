using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 星號
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = (int)rowChooser.Value;
            string result = "";

            for (int i = 0; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += "*";
                }
                result += "*\r\n";
            }

            MessageBox.Show(result);
        }
    }
}

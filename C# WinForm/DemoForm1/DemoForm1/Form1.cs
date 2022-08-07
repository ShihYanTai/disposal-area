using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }
        class MatrixAdd
        {
            int[,] c = new int[2, 2];
            string result = "";
            public void matrixAdd(int[,] a, int[,] b)
            {
                for (int i = 0; i < 2; i++)
                {
                    for ( int j = 0; j < 2; j++)
                    {
                        c[i, j] = a[i, j] + b[i, j];
                    }
                }
            }
        }

    }
}

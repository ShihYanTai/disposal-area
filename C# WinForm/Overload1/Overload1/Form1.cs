using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overload1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class AMath
        {
            public int Add(int num1, int num2)
            {
                return num1 + num2;
            }
            public int Add(int[] num)
            {
                int tot = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    tot += num[i];
                }
                return tot;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AMath sum = new AMath();
            int n1 = 120, n2 = 40;
            label1.Text = $"{n1} + {n2} = {sum.Add(n1, n2)}";
            int[] n = { 11, 22, 33, 44 };
            label2.Text = $"{n[0]} + {n[1]} + {n[2]} + {n[3]} = {sum.Add(n)}";
        }
    }
}

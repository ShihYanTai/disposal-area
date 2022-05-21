using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小山ifelse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            for (int i = 0; i <= 9; i++)
            {
                text += "7 x " + i + " = " + 7 * i + "\r\n";
            }

            MessageBox.Show(text); // 用對話框把 text 顯示出來
        }
    }
}

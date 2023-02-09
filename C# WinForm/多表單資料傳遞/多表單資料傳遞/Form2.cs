using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多表單資料傳遞
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            DialogResult result;
            form1 = new Form1();
            result = form1.ShowDialog();
            switch(result)
            {
                case DialogResult.OK:
                    label1.Text = "From2 按下了 OK!";
                    break;
                case DialogResult.Cancel:
                    label1.Text = "Form2 按下了 Cancel";
                    break;
                default:
                    label1.Text = result.ToString();
                    break;
            }
        }
    }
}

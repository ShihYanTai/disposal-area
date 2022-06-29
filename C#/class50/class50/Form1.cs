using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Building<Worker> b = new Building<Worker>();

            b.Add(new Worker(" 小山貓"));
            b.Add(new Worker(" 大山貓"));

            b.Add(new Resident(" 刁民"));

            MessageBox.Show(b.ToString());
        }
    }
}

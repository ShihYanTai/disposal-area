using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOverride1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animal dog = new Animal();
            dog.Mammal = "狗";
            textBox1.Text = dog.msg();
            Person person = new Person();
            textBox2.Text = person.msg();
        }
    }
}

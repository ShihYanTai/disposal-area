using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 建立介面
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float price;
            string name;

            price = float.Parse(textBox3.Text);
            name = textBox1.Text;

            Items items = new Items(price, name);
            items.number = int.Parse(textBox2.Text);
            label5.Text = items.GetAmont().ToString();

        }
        interface Iface
        {
            float price { get; set; }
            int number { get; set; }
            string name { get; }
            float GetAmont();
        }
        class Items : Iface
        {
            public float price { get; set; }
            public int number { get; set; }
            public string name { get; }
            public Items(float p = 0, string str = "")
            {
                price = p;
                name = str;
                number = 0;
            }
            public float GetAmont()
            {
                return price * number;
            }
        }
    }
}

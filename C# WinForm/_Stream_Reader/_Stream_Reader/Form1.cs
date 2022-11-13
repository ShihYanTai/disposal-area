using System;
using System.IO;
using System.Windows.Forms;

namespace _Stream_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            char c;
            string str;
            textBox1.Clear();
            using(sr = new StreamReader("test1.txt"))
            {
                c = Convert.ToChar(sr.Peek());
                textBox1.AppendText(c.ToString() + "\r\n");
                str = sr.ReadLine();
                textBox1.AppendText(str.ToString() + "\r\n");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "test1.txt";
            StreamReader sr;
            string data;

            textBox1.Clear();
            using(sr=new StreamReader(fileName))
            {
                while(sr.Peek() >= 0)
                {
                    data = sr.ReadLine();
                    textBox1.AppendText(data);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string fileName = "test1.txt";
            StreamReader sr;
            string data;
            textBox1.Clear();
            using(sr = new StreamReader(fileName))
            {
                data = sr.ReadToEnd();
                textBox1.AppendText(data);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace 執行緒同步
{
    public partial class Form1 : Form
    {
        Thread thd1 = null, thd2 = null;
        object locker = new object();
        bool fg1 = false, fg2 = false;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(thd1 != null) thd1.Abort();
            else if(thd2 != null) thd2.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!fg1) fg1 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!fg2) fg2 = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thd1 = new Thread(() =>
            {
                while (true)
                {
                    if (fg1)
                    {
                        lock(locker)
                        {
                            for(int i = 0;i <10;i++)
                            {
                                textBox1.Invoke(new Action(() =>
                                {
                                    textBox1.AppendText("Thread1 1\r\n");
                                }));
                                Thread.Sleep(500);
                            }
                            fg1 = false;
                        }
                    }
                }
            });
            thd2 = new Thread(() =>
            {
                while (true)
                {
                    if (fg2)
                    {
                        lock(locker)
                        {
                            textBox1.Invoke(new Action(() =>
                            {
                                textBox1.AppendText("Thread 2\r\n");
                            }));
                            fg2 = false;
                        }
                    }
                }
            });
            thd1.Start();
            thd2.Start();
        }
    }
}

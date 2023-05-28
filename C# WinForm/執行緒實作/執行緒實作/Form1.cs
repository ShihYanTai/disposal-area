using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 執行緒實作
{
    public partial class Form1 : Form
    {
        bool fgDone_a, fgDone_b;
        int guess_a, guess_b;
        Thread th_a = null;
        bool fgRun;
        int num_a = 78, num_b = 50;

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.AppendText(guess_a.ToString() + "\r\n");
            if (fgDone_a)
            {
                timer1.Enabled = false;
                textBox1.AppendText("找到了\r\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thd = new Thread(count_a);
            th_a = thd;
            fgDone_a = false;
            guess_a = -1;
            thd.Start();
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("使用 Abort() 中止執行緒\r\n");
            th_a.Abort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("Interrupt() 中斷執行緒 \r\n");
            th_a.Interrupt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread thd = new Thread(count_b);
            fgDone_b = false;
            guess_a = -1;
            fgRun = true;
            thd.Start();
            timer2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fgRun = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox2.AppendText(guess_b.ToString() + "\r\n");
            if (fgDone_b)
            {
                timer2.Enabled = false;
                if(!fgRun) textBox2.AppendText("結束執行緒 \r\n");
                else textBox2.AppendText("找到了\r\n");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (th_a != null) th_a.Abort();
            fgRun = false;
        }

        public Form1()
        {
            InitializeComponent();
        }
        void count_a()
        {
            Random rd = new Random();
            try
            {
                while(guess_a !=num_a)
                {
                    guess_a = rd.Next(1, 101);
                    Thread.Sleep(100);
                }
                fgDone_a = true;
            }
            catch(ThreadAbortException ex)
            {
                timer1.Enabled = false;
            }
            catch(ThreadInterruptedException ex)
            {
                timer1.Enabled = false;
            }
        }
        void count_b()
        {
            Random rd = new Random();
            while(guess_b !=num_b && fgRun) 
            {
                guess_b = rd.Next(1, 101);
                Thread.Sleep(100);
            }
            fgDone_b = true;
        }
    }
}

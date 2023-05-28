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

namespace 執行續執行介面控制項
{
    public partial class Form1 : Form
    {
        delegate void SafeCall(string str);
        Thread[] myThreads = new Thread[] { null, null };
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }
        void safeControl()// 無參數
        {
            if(textBox1.InvokeRequired)
            {
                sum++;
                if (sum > int.MaxValue) sum = 0;
                MethodInvoker ivk = new MethodInvoker(safeControl);
                textBox1.Invoke(ivk, new object[] { });
            }
            else
                textBox1.AppendText("myThreads[1]: " + sum.ToString() + "\r\n");
        }
        void myFunc()
        {
            while(true)
            {
                safeControl();
                Thread.Sleep(1000);
            }
        }
        void safeControl_param(string str)
        {
            if (textBox1.InvokeRequired)
            {
                SafeCall ivk = new SafeCall(safeControl_param);
                textBox1.Invoke(ivk, new object[] { str });
            }
            else
                textBox1.AppendText(str + "\r\n");
        }
        void myFunc_param()
        {
            Random rd = new Random();
            int num;
            while(true)
            {
                num = rd.Next(1, 101);
                safeControl_param(" myThreads[0]: " + num.ToString());
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thd;
            if (myThreads[0] != null)
            {
                myThreads[0].Abort();
                myThreads[0].Join();
            }
            thd = new Thread(new ThreadStart(myFunc_param));
            myThreads[0] = thd;

            thd.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thd;
            if (myThreads[1] != null)
            {
                myThreads[1].Abort();
                myThreads[1].Join();
            }
            thd = new Thread(new ThreadStart(myFunc));
            myThreads[1] = thd;

            thd.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach(var item in myThreads) 
            {
                if (item != null)
                {
                    item.Abort();
                }
            }

        }
    }
}

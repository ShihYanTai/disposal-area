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

namespace Seamaphore_排隊繳費
{
    public partial class Form1 : Form
    {
        Semaphore semaphore;
        Thread[] thds = new Thread[5];
        delegate void SafeCall(string str);
        void safeControl(string str) { textBox1.AppendText(str); }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            semaphore = new Semaphore(0, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < thds.Length; i++)
            {
                thds[i] = new Thread(new ParameterizedThreadStart(param =>
                {
                    int no = (int)param;
                    string str;
                    SafeCall ivk = new SafeCall(safeControl);
                    str = String.Format(" 第 {0} 位在排隊 ... \r\n", no);
                    textBox1.Invoke(ivk, new Object[] { str });
                }));
            }
            for(int i = 0; i < thds.Length; i++) thds[i].Start( i + 1);
            textBox1.AppendText(" 尚未開始營業...\r\n");
            Thread.Sleep(3000);
            this.textBox1.AppendText("開始營業...\r\n");
            semaphore.Release(3);
        }
    }
}

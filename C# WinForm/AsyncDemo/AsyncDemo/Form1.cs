using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;             // 使用 Tread.sleep() 方法必須引用此命名空間
using System.Windows.Forms;

namespace AsyncDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 表單載入時指定 timer1 每隔一秒觸發 Tick 事件
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
        // 每隔一秒鐘再畫面上顯示目前時間
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }
        // 要執行的方法 
        int Add(int x, int y)
        {
            Thread.Sleep(5000);         // 模擬需要 5 秒才能執行
            return x + y;
        }
        // 按同步計算鈕
        private void BtnSync_Click(object sender, EventArgs e)
        {
            int no1 = int.Parse(txtNo1.Text);
            int no2 = int.Parse(txtNo2.Text);
            int answer = Add(no1, no2);
            lstAnswers.Items.Add(Convert.ToString(answer));
        }

        private void BtnAsync_Click(object sender, EventArgs e)
        {
            int no1 = int.Parse(txtNo1.Text);
            int no2 = int.Parse(txtNo2.Text);

            // TODO : 非同步呼叫

            Func<int, int, int> fnc = Add;              // 也可以這樣簡化方法位址的取得
            fnc.BeginInvoke(no1, no2, (ar) =>
            {
                int answer = fnc.EndInvoke(ar);
                Action act = () =>
                {
                    lstAnswers.Items.Clear();
                };
                this.Invoke(act);
            },null);

            //Func<int, int, int> func = new Func<int, int, int>(Add);
            //func.BeginInvoke(no1, no2, DataReturned, func);
        }

        //void UpdateUI(int no)
        //{
        //    lstAnswers.Items.Add(Convert.ToString(no));
        //}
        //void DataReturned(IAsyncResult ar)
        //{
        //    Func<int, int, int> fnc = (Func<int, int, int>)ar.AsyncState;
        //    int answer = fnc.EndInvoke(ar);
        //    Action<int> act = new Action<int>(UpdateUI);
        //    this.Invoke(act, answer);
        //}
    }
}

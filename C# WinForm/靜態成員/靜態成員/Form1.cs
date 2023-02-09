using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 靜態成員
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account Mary = new Account("Mary"); // MAry 的戶頭
            Account John = new Account("John"); // John 的戶頭

            Mary.Deposit(1000);
            textBox1.AppendText(Mary.name + " 儲存 1000 元 \r\n");
            textBox1.AppendText("共同存款有 " + Account.Money.ToString() +" 元 \r\n");
            textBox1.AppendText(John.name + " 有 " + John.getMoney().ToString() + " 元 \r\n");

            John.Widthrawal(300); // John 提款 300 元
            textBox1.AppendText(John.name + " 提款 300 元 \r\n");
            textBox1.AppendText(" 共同存款" + Account.Money.ToString()+" 元 \r\n");
            textBox1.AppendText(Mary.name + " 有 " + Mary.getMoney().ToString() + " 元 \r\n");
        }
        class Account
        {
            public static int Money = 0;
            public string name { get;}
            public Account(string str) { name = str; }
            public void Widthrawal(int m) 
            { 
                if(Money >= m) Money -= m;
            }
            public void Deposit(int m) 
            {
                if (m >= 0) Money += m;
            }
            public int getMoney()
            {
                return Money;
            }
        }
    }
}

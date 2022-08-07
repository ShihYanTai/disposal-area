using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayList2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList person;                           // 宣告 person 串列
        public String data(IEnumerable myList)
        {
            string st = "";
            foreach(Object o in myList)
            {
                st += $"{o}\r\n";
            }
            return st;
        }
        public void clean()
        {
            TxtName.Text = "";
            LblMsg.Text = "訊息";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 建立 person 串列內容
            person = new ArrayList { "Frod", "David", "Tom", "Jack", "Mary" };
            TxtPer.Text = data(person);
        }

        private void BtnPer_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            TxtPer.Text = data(person);
            clean();
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            person.Sort();
            TxtPer.Text = data(person);
            clean();
        }

        private void BtnRev_Click(object sender, EventArgs e)
        {
            person.Sort();
            person.Reverse();
            TxtPer.Text = data(person);
            clean();
        }

        private void BtnIndex_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            if (person.Contains(name))
            {
                LblMsg.Text = $"{name} 的索引值 :{person.IndexOf(name)}";
            }
            else
            {
                LblMsg.Text = $"{name} 不再名單中";
            }
        }
    }
}

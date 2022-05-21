using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 出題
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int div;

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnCheck.Enabled = BtnClear.Enabled = false;
            LblMsg.Text = "請出題...";
            ClsTest.MultiColumn = true;
            ClsTest.ColumnWidth = 50;
            ClsTest.CheckOnClick = true;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            div = rnd.Next(1, 6); //隨機出現1~5的因數
            LblDiv.Text = $"請勾選 {div} 的倍數:";
            ClsTest.Items.Clear();
            // 隨機產生 18 個 1~99 的整數
            for(int x=0; x<=17; x++)
            {
                ClsTest.Items.Add(rnd.Next(1,100));
            }
            LblMsg.Text = "請作答...";
            BtnNew.Enabled = false;
            BtnCheck.Enabled = BtnClear.Enabled = true;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int right = 0;
            int num;
            for(int x = 0;x <=17; x++)
            {
                num = int.Parse(ClsTest.Items[x].ToString());
                if(ClsTest.GetItemChecked(x) == true && num % div ==0) right++;
                LblMsg.Text = $"勾選正確 : {right} 個";
                BtnNew.Enabled = BtnCheck.Enabled = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            for(int x = 0; x < ClsTest.Items.Count; x++)
            {
                ClsTest.SetItemChecked(x, false);
            }
            LblMsg.Text = "請重新作答";
            BtnNew.Enabled = false;
            BtnCheck.Enabled = BtnClear.Enabled = true;
        }
    }
}

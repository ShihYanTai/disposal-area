using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 點餐
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                TxtQty1.Text = "1";
            }
            else
            {
                TxtQty1.Clear();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                TxtQty2.Text = "1";
            }
            else
            {
                TxtQty2.Clear();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) //如果有勾選
            {
                TxtQty3.Text = "1"; //設數量1
            }
            else
            {
                TxtQty3.Clear(); //數量清成空白
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qty1 = 0, qty2 = 0, qty3 = 0, total = 0; //預設三個商品的購買數量為0
            bool chk = false; //預設 checkBox =false，若有勾選商品就改為true
            if (checkBox1.Checked == true) //若有勾選checkBox1
            {
                try
                {
                    qty1 = int.Parse(TxtQty1.Text); //將TxtQty1.Text轉成整數
                }
                catch
                {
                    LblMsg.Text = "請輸入正整數!";return; //顯示錯誤提示訊息
                }
                if(qty1 <= 0)
                {
                    LblMsg.Text = "數量不能小於零!";return;
                }
                else
                {
                    total += qty1 * 50; //總價加上(數量 X 50)
                    chk = true; //設 chk = true 表有勾選商品
                }
            }
            if (checkBox2.Checked == true)
            {
                try
                {
                    qty2 = int.Parse(TxtQty2.Text); //將TxtQty1.Text轉成整數
                }
                catch
                {
                    LblMsg.Text = "請輸入正整數!";return ; //顯示錯誤提示訊息
                }
                if(qty2 <= 0) //若輸入的數量<=0
                {
                    LblMsg.Text = "數量不能小於零!";return; //顯示錯誤提示訊息
                }
                else
                {
                    total += qty2 * 80; //總價加上數量 X 80
                    chk = true; //設 chk =true 表有勾選商品
                }
            }
            if (checkBox3.Checked == true)
            {
                try
                {
                    qty3 = int.Parse(TxtQty3.Text); //將TxtQty1.Text轉成整數
                }
                catch
                {
                    LblMsg.Text = "請輸入正整數!"; return; //顯示錯誤提示訊息
                }
                if (qty3 <= 0) //若輸入的數量<=0
                {
                    LblMsg.Text = "數量不能小於零!"; return; //顯示錯誤提示訊息
                }
                else
                {
                    total += qty3 * 60; //總價加上數量 X 60
                    chk = true; //設 chk =true 表有勾選商品
                }
            }
            if(chk == true) //若有勾選商品
            {
                LblMsg.Text = $"{qty1 + qty2 + qty3} 件產品總價等於{total} 元";
            }
            else
            {
                LblMsg.Text = "請勾選產品並輸入數量後，在按<結帳>鈕";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "請先勾選產品，然後輸入數量，最後<結帳>鈕";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

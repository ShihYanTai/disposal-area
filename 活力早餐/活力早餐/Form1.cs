using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 活力早餐
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "活力早餐點餐系統";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TxtID.Text == "Jerry" && TxtPW.Text == "168") // 若使用者和密碼正確
            {
                LblMsg.Text = "歡迎使用本系統";
                if(tabControl1.SelectedIndex == 3)
                {
                    string order = "";      //點餐清單
                    int qty = 0,total = 0;  //預設三個商品的購買數量和總價為0
                    LblTotal.Text = order;
                    if(ChkM1.Checked == true)
                    {
                        try
                        {
                            qty = int.Parse(TxtM1.Text); //將TxtM1.Text轉成整數
                        }
                        catch
                        {
                            LblMsg.Text = "請輸入正整數!";qty = 0;return; //錯誤訊息
                        }
                        total += qty * 20; //總價加上數量 x 20
                        order += $"蛋餅:{qty}份{qty * 20} 元\n"; //加入清單
                    }
                    if(ChkM2.Checked == true) //若有勾選 ChkM2
                    {
                        try
                        {
                            qty =int.Parse(TxtM2.Text); //將 TxtM2.Text轉成整數
                        }
                        catch
                        {
                            LblMsg.Text = "請輸入正整數!";qty = 0;return; //錯誤訊息
                        }
                        total += qty * 30; //總價加上數量 x 30
                        order += $"三明治 : {qty} 份 {qty * 30} 元\n"; //加入清單
                    }
                    if(ChkR1.Checked == true) // 若勾選 ChkR1
                    {
                        try
                        {
                            qty=int.Parse(TxtR1.Text); //將TxtR1.Text轉成整數
                        }
                        catch
                        {
                            LblMsg.Text = "請輸入正整數!";qty=0;return; //錯誤訊息
                        }
                        total += qty * 15; //總價加上數量 x15
                        order += $"豆漿 : {qty} 杯 {qty * 15} 元\n"; //加入清單
                    }
                    if(ChkR2.Checked == true)
                    {
                        try
                        {
                            qty = int.Parse(TxtR2.Text); //將TxtR2.Text轉成整數
                        }
                        catch
                        {
                            LblMsg.Text = "請輸入正整數!";qty = 0;return; //錯誤訊息
                        }
                        total += qty * 20;
                        order += $"奶茶 : {qty} 杯 {qty * 20} 元\n"; //加入清單
                    }
                    LblTotal.Text = $"點餐清單 : \n{order}\n總價 : {total}";
                }
            }
            else
            {
                tabControl1.SelectedTab = tabPage1;
                LblMsg.Text = "請先輸入正確的使用者和密碼";
            }
        }

        private void ChkM1_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkM1.Checked == true)
            {
                TxtM1.Text = "1";
            }
            else
            {
                TxtM1.Clear();
            }
        }

        private void ChkM2_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkM2.Checked == true)
            {
                TxtM2.Text = "1";
            }
            else
            {
                TxtM2.Clear();
            }
        }

        private void ChkR1_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkR1.Checked == true)
            {
                TxtR1.Text = "1";
            }
            else
            {
                TxtR1.Clear();
            }
        }

        private void ChkR2_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkR2.Checked == true)
            {
                TxtR2.Text = "1";
            }
            else
            {
                TxtR2.Clear();
            }
        }
    }
}

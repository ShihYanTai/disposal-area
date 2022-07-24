using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CNumber Onum;               // 宣告 Onum 為 CNumber 類別的物件
        CWeight Owt;                // 宣告 Owt 為 CWeight 類別的物件
        CSum OSum;                  // 宣告 CSum 為 CSum 類別的物件

        private void BtnCal_Click(object sender, EventArgs e)
        {
            if(RdbNum.Checked == true)
            {
                try
                {
                    int num = int.Parse(TxtNum.Text);
                    double price = double.Parse(TxtPrice.Text);
                    Onum = new CNumber(num, price);
                    OSum = new CSum(Onum);                       // 動態連結
                }
                catch(Exception ex)
                {
                    MessageBox.Show("請輸入正確的型別資料!","錯誤");
                }
            }
            if(RdbWT.Checked == true)
            {
                try
                {
                    double wt = double.Parse(TxtNum.Text);
                    double price = double.Parse(TxtPrice.Text);
                    Owt = new CWeight(wt, price);
                    OSum = new CSum(Owt);                       // 動態連結
                    LblPrice.Text = OSum.priceMsg();
                    LblTot.Text = OSum.totMsg();
                }
                catch
                {
                    MessageBox.Show("請輸入正確的型別資料 ! ", "錯誤");
                }
            }
        }


        private void RdbWT_Click(object sender, EventArgs e)
        {
            LblBuy.Text = "輸入購買數量 :";
            TxtNum.Text = "";
            TxtPrice.Text = "";
            LblPrice.Text = "";
        }

        private void RdbNum_Click(object sender, EventArgs e)
        {
            LblBuy.Text = "輸入購買公斤數 :";
            TxtNum.Text = "";
            TxtPrice.Text = "";
            TxtPrice.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IExchange change;
        UStoNT cashUS = new UStoNT();
        JPtoNT cashJP = new JPtoNT();
        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if(RdbUSA.Checked == true)
            {
                try
                {
                    double cash = double.Parse(TxtCash.Text);
                    change = cashUS;
                    LblMsg.Text = $"美元 {cash} 元,可兌換新台幣 {change.Convert(cash)}元";
                }
                catch
                {
                    MessageBox.Show("請輸入正確的型別資料!", "錯誤");
                }
            }
            if(RdbJP.Checked == true)
            {
                try
                {
                    double cash = double.Parse(TxtCash.Text);
                    change = cashJP;
                    LblMsg.Text = $"日幣 {cash} 元,可兌換新台幣{change.Convert(cash)}元";
                }
                catch
                {
                    MessageBox.Show("請輸入正確的型別資料!", "錯誤");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MacDate.MinDate = DateTime.Today;   // 設選擇最小日期為今天
            MacDate.MaxSelectionCount = 7;      // 設最多可選擇 7 天
            MacDate.SelectionStart = DateTime.Today;    // 預設選擇日期為今日
        }

        private void MacDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            double m = MacDate.SelectionStart.Month;    // 使用 Month 屬性來取得所在月份
            switch (Math.Floor(m))      // 使用 Floor 方法取得小於( m- 1 )/3 的最大整數
            {
                case 0:
                    this.BackColor = Color.Green;
                    break;
                case 1:
                    this.BackColor = Color.Red;
                    break;
                case 2:
                    this.BackColor = Color.Yellow;
                    break;
                case 3:
                    this.BackColor = Color.Orange;
                    break;
            }
        }

        private void MacDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime d_start = MacDate.SelectionStart;      // d_start 記錄起始租借日期
            DateTime d_end = MacDate.SelectionEnd;      // d_end 紀錄結束租借日期
            TimeSpan ts = d_end - d_start;      // ts 為間隔時間
            int days = ts.Days + 1;     // 將間隔時間轉化成天數
            int rent;       // 紀錄租金
            switch (days)       // 根據天數來設定租金
            {
                case 1:     // 1 天設定租金為 2500 元
                    rent = 2500;
                    break;
                case 2:     // 2 ~ 3 天設定租金為 2300 元
                case 3:
                    rent = 2300;
                    break;
                default:        // 其餘天數設定租金為 2000 元
                    rent = 2000;
                    break;
            }
            LblMoney.Text = $"{days} 天的租金為 {days * rent} 元";
        }
    }
}

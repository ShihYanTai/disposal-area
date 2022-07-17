using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] scores = { 23, 45, 100, 87, 90, 65, 44 };
        private void Form1_Load(object sender, EventArgs e)
        {
           LstScore.DataSource = scores;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int search = 0;
            try
            {
                search = int.Parse(TxtScore.Text);
            }
            catch(Exception EX)
            {
                MessageBox.Show("請輸入數值", "錯誤");
                return;
            }
            var result = scores.Where(x => x == search).ToList();
            if(result.Count == 0)
            {
                MessageBox.Show("查無資料", "查詢結果");
            }
            else
            {
                LstScore.DataSource = result.ToList();
            }
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LstScore.DataSource = scores;
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            string[] info =
            {
                $"資料筆數:{scores.Count()}",
                $"最高分數:{scores.Max()}",
                $"最低分數:{scores.Min()}",
                $"平均分數:{(int)scores.Average()}",
                $"分數總和:{scores.Sum()}"
            };
            LstScore.DataSource = info;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            var result = scores.OrderByDescending(s => s);
            LstScore.DataSource = result.ToList();
        }
    }
}

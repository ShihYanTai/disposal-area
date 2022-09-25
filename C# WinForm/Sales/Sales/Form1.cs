using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 新增四列，並設定列高
            for(int i = 0; i <= 3; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 25;
            }
            // 最後一列用於計算平均，不需要由使用者輸入資料
            dataGridView1.Rows[3].ReadOnly = true;

            // 設定每一欄位的寬度
            for (int i = 0; i < 5; i++)
                dataGridView1.Columns[i].Width = 70;

            // 設定 dataGridView1 的寬與高
            dataGridView1.Width = dataGridView1.Columns[0].Width * 7;
            dataGridView1.Height = dataGridView1.Rows[0].Height * 6;

            // 輸入營業員的姓名
            dataGridView1.Rows[0].Cells[0].Value = "CTM601";
            dataGridView1.Rows[1].Cells[0].Value = "CTM507";
            dataGridView1.Rows[2].Cells[0].Value = "CTM512";
            dataGridView1.Rows[3].Cells[0].Value = "平均";

            dataGridView1.Columns[5].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Columns[3].DefaultCellStyle.BackColor = Color.LightGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] rev = new int[3, 4];
            Single avg;
            // ---------------------- 先將 dataGridView 裡的資料儲存到rev ----------------------------------------
            try
            {
                for (int i = 0; i < 3; i++)                                                     // 列 : 三個營業員
                    for (int j = 0; j < 4; j++)                                                 // 行 : 1-4月的營業額
                        rev[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j + 1].Value);

            }
            catch
            {
                MessageBox.Show("輸入有誤");
                return;
            }
            // ---------------------- 計算個人總平均 ----------------------------------------
            for (int i = 0; i < 3; i++)
            {
                avg = 0.0f;                                                                 // 先清除舊值
                for (int j = 0; j < 4; j++)                                                 // 個人營業額加總
                    avg += rev[i, j];
                avg /= 4.0f;                                                                // 計算平均
                dataGridView1.Rows[i].Cells[5].Value = avg.ToString();
            }
            // ---------------------- 計算個月總平均 ----------------------------------------
            for (int i = 0; i < 4; i++)
            {
                avg = 0.0f;                                                                 // 先清除舊值
                for (int j = 0; j < 3; j++)                                                 // 計算個別月份的加總
                    avg += rev[j,i];
                dataGridView1.Rows[3].Cells[i + 1].Value = avg.ToString();
            }

            //int rank, row, col, length;
            //int[,] arr = new int[3, 5];

            //rank = arr.Rank;        // 取得陣列arr的維度
            //row = arr.GetLength(0); // 列的數量
            //col = arr.GetLength(1); // 行的數量
            //length = arr.Length;    // 陣列總長度
        }
    }
}

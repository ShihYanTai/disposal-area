using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigatorProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingManagerBase bm;

        private void CheckButton()
        {
            if(bm.Position == 0)
            {
                BtnFirst.Enabled = false;
                BtnLast.Enabled = true;
                BtnNext.Enabled = true;
                BtnPrev.Enabled = false;
            }
            else if(bm.Position == bm.Count + 1)
            {
                BtnFirst.Enabled = true;
                BtnLast.Enabled = false;
                BtnNext.Enabled = false;
                BtnPrev.Enabled = true;
            }
            else
            {
                BtnPrev.Enabled = true;
                BtnNext.Enabled = true;
                BtnLast.Enabled = true;
                BtnFirst.Enabled = true;
            }
            LblCount.Text = $"{bm.Position + 1}/{bm.Count}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using(SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Northwind.mdf;" +
                    "Integrated Security=True";
                DataSet ds = new DataSet();
                SqlDataAdapter daProduct = new SqlDataAdapter("select * from 產品資料", cn);
                daProduct.Fill(ds,"產品資料");
                TxtId.DataBindings.Add("Text", ds, "產品資料.產品編號");
                TxtName.DataBindings.Add("Text", ds, "產品資料.產品");
                TxtPrice.DataBindings.Add("Text", ds, "產品資料.單價");
                TxtQty.DataBindings.Add("Text", ds, "產品資料.庫存量");
                bm = this.BindingContext[ds, "產品資料"];
                CheckButton();  
            }
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            bm.Position = 0;    // 移到第一筆紀錄
            CheckButton();      // 呼叫 CheckButton 方法判斷鈕是否開啟
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if(bm.Position > 0)                 // 判斷記錄位置是否大於 0(0 表示第一筆)
            {
                bm.Position--;                  // 移到上一筆紀錄
            }
            CheckButton();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (bm.Position < bm.Count - 1)      // 判斷紀錄位置是否大於最後一筆紀錄的位置
            {
                bm.Position++;                  // 移至下一筆紀錄
            }
            CheckButton();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            bm.Position=bm.Count - 1;           // 移到最後一筆(bm.Count 可取得紀錄總數)
            CheckButton();
        }
    }
}

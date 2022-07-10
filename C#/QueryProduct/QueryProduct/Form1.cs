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

namespace QueryProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingManagerBase bm;

        private void ShowRecord()
        {
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
                SqlDataAdapter daCategory = new SqlDataAdapter("select * from 產品類別", cn);
                daCategory.Fill(ds, "產品類別");
                SqlDataAdapter daProduct = new SqlDataAdapter("select * from 產品資料", cn);
                daProduct.Fill(ds, "產品資料");
                ds.Relations.Add("FK_產品資料_產品類別", ds.Tables["產品類別"].Columns["類別編號"], ds.Tables["產品資料"].Columns["類別編號"]);
                CboCategory.DataSource = ds;
                CboCategory.DisplayMember = "產品類別.類別名稱";
                TxtId.DataBindings.Add("Text", ds, "產品類別.FK_產品資料_產品類別.產品編號");
                TxtName.DataBindings.Add("Text", ds, "產品類別.FK_產品資料_產品類別.產品");
                TxtPrice.DataBindings.Add("Text", ds, "產品類別.FK_產品資料_產品類別.單價");
                bm = this.BindingContext[ds, "產品類別.FK_產品資料_產品類別"];
                ShowRecord();
            }

        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            bm.Position = 0;        // 移到第一筆資料
            ShowRecord();           // 呼叫 showRecord 方法
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (bm.Position > 0)    // 判斷記錄位置是否大於 0(0 表示第一筆)
            {
                bm.Position--;      // 移到上一筆紀錄

            }
            ShowRecord();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if(bm.Position < bm.Count - 1)      // 判斷記錄位置是否大於最後一筆記錄位置
            {
                bm.Position++;                  // 移到下一筆紀錄
            }
            ShowRecord();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count - 1;         // 移到最後一筆(bm.Count 可取得紀錄總數)
            ShowRecord();
        }
    }
}

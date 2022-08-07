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

namespace LinqDataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtProduct;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();     // 建立SqlConnection物件 cn
            // 設定 cn 連接 Northwind.mdf 資料庫檔案
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Northwind.mdf;" +
                "Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("select 產品編號, 產品, 單價, 庫存量 from 產品資料", cn);
            DataSet ds = new DataSet();                 // 建立 DataSet 物件 ds
            da.Fill(ds);                                // 將 da 物件所取得的資料填入 ds 物件
            dtProduct = ds.Tables[0];
            DvgShow.DataSource = dtProduct;
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            var result = from r in dtProduct.AsEnumerable()
                         select new 
                         { 
                             單價 = r.Field<decimal>("單價")
                         };
            string str = $"資料筆數: {result.Count()}\n" +
                        $"最高單價: {result.Max(r => r.單價)}\n" +
                        $"最低單價: {result.Min(r => r.單價)}\n" +
                        $"平均單價: {result.Average(r => r.單價)}\n" +
                        $"單價總和: {result.Sum(r => r.單價)}";
            MessageBox.Show(Text, str);
        }

        private void BtnPrice_Click(object sender, EventArgs e)
        {
            var result = from r in dtProduct.AsEnumerable()
                         select new
                         {
                             產品編號 = r.Field<int>("產品編號"),
                             產品 = r.Field<string>("產品"),
                             單價 = r.Field<decimal>("單價"),
                             庫存量 = r.Field<short>("庫存量")
                         };
            DvgShow.DataSource = result.OrderBy(r => r.單價).ToList();
        }

        private void BtnAmount_Click(object sender, EventArgs e)
        {
            var result = from r in dtProduct.AsEnumerable()
                         select new
                         {
                             產品編號 = r.Field<int>("產品編號"),
                             產品 = r.Field<string>("產品"),
                             單價 = r.Field<decimal>("單價"),
                             庫存量 = r.Field<short>("庫存量")
                         };
            DvgShow.DataSource = result.Where(r => r.產品.Contains(TxtSearch.Text)).ToList();
        }
    }
}

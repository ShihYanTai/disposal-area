using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 建立記憶體 DataTable 物件 TableProduct ， 用來存放產品資料
            DataTable TableProduct = new DataTable();
            // 在 TableProduct 建立編號等 DataColumn 欄位物件
            TableProduct.Columns.Add(new DataColumn("編號"));
            TableProduct.Columns.Add(new DataColumn("品名"));
            TableProduct.Columns.Add(new DataColumn("單價"));
            TableProduct.Columns.Add(new DataColumn("折扣"));

            // 在 TableProduct 新增第一筆資料紀錄 DataRow 物件
            DataRow Row_1 = TableProduct.NewRow();
            Row_1["編號"] = "A01";
            Row_1["品名"] = "洗衣機";
            Row_1["單價"] = "18200";
            Row_1["折扣"] = int.Parse(Row_1["單價"].ToString()) * 0.9;

            // 將 DataRow 物件放入 TableProduct 中
            TableProduct.Rows.Add(Row_1);

            // 在 TableProduct 新增第二筆資料紀錄 DataRow 物件
            DataRow Row_2 = TableProduct.NewRow();
            Row_2["編號"] = "A02";
            Row_2["品名"] = "洗碗機";
            Row_2["單價"] = "5800";
            Row_2["折扣"] = int.Parse(Row_2["單價"].ToString()) * 0.9;
            TableProduct.Rows.Add(Row_2);

            // 在 TableProduct 新增第三筆資料紀錄 DataRow 物件
            DataRow Row_3 = TableProduct.NewRow();
            Row_3["編號"] = "A03";
            Row_3["品名"] = "烘乾機";
            Row_3["單價"] = "13000";
            Row_3["折扣"] = int.Parse(Row_3["單價"].ToString()) * 0.9;
            TableProduct.Rows.Add(Row_3);

            // 指定 DataGridView1 控制項欲顯示資料來源為TableProduct
            dataGridView1.DataSource = TableProduct;

        }
    }
}

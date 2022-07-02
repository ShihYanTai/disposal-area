using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTableSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 建立記憶體 DataTable 物件 tableProduct，用來存放產品資料
            DataTable TableProduct = new DataTable();

            // 在 TableProduct 建立編號、品名、訂價 DataColumn 欄位物件
            TableProduct.Columns.Add(new DataColumn("編號"));
            TableProduct.Columns.Add(new DataColumn("品名"));
            TableProduct.Columns.Add(new DataColumn("訂價"));

            // 在 TableProduct 新增第一筆資料紀錄 DataRow 物件
            DataRow Row_1 = TableProduct.NewRow();
            Row_1["編號"] = "A01";
            Row_1["品名"] = "洗衣機";
            Row_1["訂價"] = "18200";

            // 將dataraw 物件放入 TableProduct 中
            TableProduct.Rows.Add(Row_1);

            // 在 TableProduct 新增第二筆資料紀錄 DataRow 物件
            DataRow Row_2 = TableProduct.NewRow();
            Row_2["編號"] = "A02";
            Row_2["品名"] = "洗碗機";
            Row_2["訂價"] = "5800";
            TableProduct.Rows.Add(Row_2);

            // 在 TableProduct 新增第三筆資料紀錄 DataRow 物件
            DataRow Row_3 = TableProduct.NewRow();
            Row_3["編號"] = "A03";
            Row_3["品名"] = "烘乾機";
            Row_3["訂價"] = "13000";
            TableProduct.Rows.Add(Row_3);
            
            string data = "";
            // 使用 for loop 讀出 TableProduct 的欄位名稱
            for (int i = 0; i < TableProduct.Columns.Count; i++) data += $"{TableProduct.Columns[i].ColumnName}\t";

            // 使巢狀 for loop 讀出 TableProduct 的所有紀錄
            for (int i = 0; i < TableProduct.Rows.Count; i++)
            {
                data += "\n";
                for (int k = 0; k < TableProduct.Columns.Count; k++) data += $"{TableProduct.Rows[i][k]}\t";
            }
            MessageBox.Show(data,"訂價資訊");

            
            // method 2. 

            /*
            string data = "";
            for (int i = 0; i < TableProduct.Rows.Count; i++) data += $"{TableProduct.Columns[i].ColumnName}\t";
            foreach (DataRow Row in TableProduct.Rows)
            {
                data += "\n";
                for (int j = 0; j < Row.ItemArray.Length; j++)
                {
                    data += $"{Row.ItemArray[j]}\t";
                }
            }
            MessageBox.Show(data, "訂價資訊");
            */
        }
    }
}

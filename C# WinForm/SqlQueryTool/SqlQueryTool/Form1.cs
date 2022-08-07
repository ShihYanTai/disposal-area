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

namespace SqlQueryTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "select * from 產品資料";
            toolStripButton1_Click(sender, e);          // 呼叫 toolStripButton1_Click 事件函式

        }
        // 按<查詢>鈕執行此事件
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // 為防止 SQL 語法錯誤，或資料庫連接失敗...等例外
            // 故將相關程式碼置於 try...catch 內
            try
            {
                // 建立 cn 為 SQLConnection 物件
                SqlConnection cn = new SqlConnection();
                // 設定 cn 連接 Northwind.mdf 資料庫檔案
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Northwind.mdf;" +
                    "Integrated Security=True";

                // 建立 da 為 DataAdapter 物件
                // da 代入查詢的SQL 語法為 toolStripTextBox1 文字方塊的內容
                SqlDataAdapter da = new SqlDataAdapter(toolStripTextBox1.Text, cn);

                // 建立 DataSet 物件 ds
                DataSet ds = new DataSet();
                // 將 da 物件所取得的資料填入 ds 物件
                da.Fill(ds);
                // dataGridView1 呈現資料來源為 ds 內第一個 DataTable 資料表(即 Table[0])
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

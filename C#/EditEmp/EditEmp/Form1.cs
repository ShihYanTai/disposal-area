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

namespace EditEmp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|ch15DB.mdf;" + 
                "Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            // 建立 SqlConnection 物件 db
            SqlConnection db = new SqlConnection();
            // 設定 db 連接本機 SQL Server 的 ch15DB.mdf 資料庫
            db.ConnectionString = Cn;
            // 建立 DataAdapter 物件 da
            // da 可查詢員工資料表的所有紀錄
            SqlDataAdapter da = new SqlDataAdapter("select * from 員工",db);
            // 建立 DataSet 物件 ds
            DataSet ds = new DataSet();
            // 將 da 物件所取得的資料填入 ds 物件
            da.Fill(ds);
            // dataGridView1 呈現的資料來源為 ds 內的第一個 DataTable 資料表(即 Table[0])
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString= Cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "insert into 員工(員工編號,姓名,職稱,薪資)values(" +
                    $"'{TxtId.Text}','{TxtName.Text}','{TxtP.Text}',{TxtSalary.Text})";
                cmd.ExecuteNonQuery();
                db.Close();
                Form1_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = Cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = $"upset 員工 set 姓名=N'{TxtName.Text}'," +
                    $"職稱=N'{TxtP.Text}',薪資={TxtSalary.Text}" +
                    $"where 員工編號='{TxtId.Text}'";
                cmd.ExecuteNonQuery ();
                db.Close();
                Form1_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString= Cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = $"delete from 員工 where 員工編號='{TxtId.Text}'";
                cmd.ExecuteNonQuery();
                db.Close();
                Form1_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

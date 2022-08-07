using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectionOleDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   // 存取 access 或 spl 6.5 以前資料庫
            string cn = "Provider = Microsoft.Jet.OLEDB.4.0;" + $@"Data Source={Application.StartupPath}\mrt.mdb";
            OleDbConnection conn = new OleDbConnection(cn);
            conn.Open();
            MessageBox.Show(conn.DataSource, "資料來源");
            conn.Close();

            // sql 7.0 以上版本
            string cn_1 = @"Data Source=(LocalDB)\MSSQLLocalDB;" + 
                "AttachDbFilename=|DataDirectory|Database1.mdf;" + 
                "Integrated Security=True";

            // Integrated Security True 為 windows帳號認證來連接資料庫

            /* SQL 帳號登入如下方式:
                string connectString =
                "Data Source=(local);User ID=ab;Password=MyPassword;" +
                "Initial Catalog=AdventureWorks";

            reference --> https://docs.microsoft.com/zh-tw/dotnet/api/system.data.sqlclient.sqlconnectionstringbuilder.integratedsecurity?view=dotnet-plat-ext-6.0
            */

            SqlConnection db = new SqlConnection(cn_1); 
            
            /* another way : SqlConnection db = new SqlConnection();
            db.ConnectionString = cn; // 使用 ConnectionString 屬性指定連結字串
             */
            db.Open();
            MessageBox.Show(db.Database, "資料庫");
            db.Close();
        }
    }
}

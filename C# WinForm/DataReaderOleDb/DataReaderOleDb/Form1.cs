using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataReaderOleDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                $@"{Application.StartupPath}\mrt.mdb"; // 資料庫連接字串
            OleDbConnection db = new OleDbConnection(cn);
            db.Open();                                 // 使用Open 方式開啟和資料庫連接
            OleDbCommand cmd = new OleDbCommand("select * from 路線資訊", db);
            OleDbDataReader dr = cmd.ExecuteReader();
            
            string data = "";       // 宣告字串存放內容
            
            for (int i = 0; i < dr.FieldCount; i++) data += $"{dr.GetName(i)}\t";
            
            data += "\n";
            while (dr.Read()) // 查看撈取資料是否還有row 有則 true 無則 false
            {
                for (int i = 0; i < dr.FieldCount; i++) data += $"{dr[i]}\t";
                
                data += "\n";
            }
            MessageBox.Show(data, "路線資訊");
            db.Close();

            // 撈取 SQL BD

            string Cn_Sql = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                "Integrated Security=True"; //資料庫連接字串
            SqlConnection DB_Sql = new SqlConnection(Cn_Sql);
            DB_Sql.Open();
            SqlCommand Cmd_Sql = new SqlCommand("select top 3 * from 書目",DB_Sql);
            SqlDataReader Dr_Sql = Cmd_Sql.ExecuteReader();
            string Data_Sql = "";
            for (int j = 0; j < Dr_Sql.FieldCount; j++) Data_Sql += $"{Dr_Sql.GetName(j)}\t";
            Data_Sql +="\n";
            while (Dr_Sql.Read())
            {
                for (int j = 0; j < Dr_Sql.FieldCount; j++) Data_Sql += $"{Dr_Sql[j]}\t";
                Data_Sql += "\n";
            }
            
            MessageBox.Show(Data_Sql, "書目");
            DB_Sql.Close();
        }
    }
}

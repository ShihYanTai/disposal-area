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

namespace 讀取資料庫的資料
{
    public partial class Form1 : Form
    {
        SqlConnection sqlDb = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cntStr = @"Data Source=(localDB)\MSSQLLocalDB;" +
                @"AttachDBFilename=|DataDirectory|\studentPoint.mdf;";
            try
            {
                sqlDb = new SqlConnection(cntStr);
                sqlDb.Open();
                button1.Enabled = true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(sqlDb != null) { sqlDb.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "SELECT stuBasic.學號,姓名,電話," +
                "住址,年齡,身高,體重 FROM stuBasic INNER JOIN " +
                "stuHealth ON stuBasic.學號 = stuHealth.學號";

            SqlCommand sqlCmd = new SqlCommand(sqlStr, sqlDb);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            int rowIndex = 0;
            dataGridView1.Font = new Font("新細明體", 10);
            for(int i = 0; i < sqlDr.FieldCount; i++) { dataGridView1.Columns.Add("column" + (i + 1).ToString(), sqlDr.GetName(i)); }
            while (sqlDr.Read() != false)
            {
                dataGridView1.Rows.Add();
                for(int i = 0;i < sqlDr.FieldCount; i++) { dataGridView1.Rows[rowIndex].Cells[i].Value = sqlDr.GetValue(i).ToString(); }
                rowIndex++;
            }
            sqlDr.Close();
            button1.Enabled = false;
        }
    }
}

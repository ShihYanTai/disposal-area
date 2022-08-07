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

namespace StuSourceQuery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // toolStripTextBox1.Text = "select * from 成績";
            TxtSqlCmd1.Text = "select 學號,姓名,國文,英文,數學,(國文+英文+數學) as 總分 from 成績 where (國文+英文+數學)>250;";
            TxtSqlCmd2.Text = "select top 3 學號,姓名,國文,英文,數學,(國文+英文+數學) as 總分 from 成績 order by 總分 desc;";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                    "Integrated Security=True";
                DataSet ds = new DataSet();
                SqlDataAdapter daSource = new SqlDataAdapter(toolStripTextBox1.Text, cn);
                
                daSource.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                if (toolStripTextBox1.Text == "") MessageBox.Show("請按下複製鈕，在執行");
                else MessageBox.Show(ex.Message);
                
            }
        }

        private void BtnCopy1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = TxtSqlCmd1.Text;
        }

        private void BtnCopy2_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = TxtSqlCmd2.Text;
        }
    }
}

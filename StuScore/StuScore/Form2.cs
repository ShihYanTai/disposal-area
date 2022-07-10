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

namespace StuScore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                "Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("select 學號,姓名,國文,英文,數學,(國文+英文+數學) as 總分 from 成績 order by 總分 desc", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource=ds.Tables[0];
            dataGridView1.Dock = DockStyle.Fill;
        }
    }
}

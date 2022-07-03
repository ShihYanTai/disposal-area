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

namespace Relations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                "Integrated Security=True";
            SqlConnection Db = new SqlConnection(Cn);

            DataSet Ds = new DataSet();
            SqlDataAdapter Dapulisher = new SqlDataAdapter("select * from 出版者", Cn);
            Dapulisher.Fill(Ds, "出版者");

            SqlDataAdapter DaBook = new SqlDataAdapter("select * from 書目", Cn);
            DaBook.Fill(Ds, "書目");

            Ds.Relations.Add("FK_出版者_書目", Ds.Tables["出版者"].Columns["編號"], Ds.Tables["書目"].Columns["書商"]);

            dataGridView1.Dock = DockStyle.Top;             // dataGridView1停駐在上方
            dataGridView1.DataSource = Ds;
            dataGridView1.DataMember = "出版者";
            dataGridView2.Dock = DockStyle.Fill;            // dataGridView2 整個畫面填滿
            dataGridView2.DataSource = Ds;
            dataGridView2.DataMember = "出版者.FK_出版者_書目";
        }
    }
}

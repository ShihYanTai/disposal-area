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

namespace DataAdapterSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string CN = @"Data Source=(localDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                "Integrated Security=True";
            SqlConnection DB = new SqlConnection(CN);
            DB.Open();
            SqlDataAdapter AP = new SqlDataAdapter("select * from 書目",DB);
            DataSet DS = new DataSet();
            AP.Fill(DS, "書目");
            dataGridView1.DataSource = DS.Tables["書目"];
            DB.Close();
        }
    }
}

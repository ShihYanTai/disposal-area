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

namespace EmpNav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                           "AttachDbFilename=|DataDirectory|Northwind.mdf;" +
                           "Integrated Security=True";

            DataSet ds = new DataSet();
            SqlDataAdapter daEmp = new SqlDataAdapter("select * from 員工",cn);
            daEmp.Fill(ds,"員工");
            CboName.DataSource = ds;
            CboName.DisplayMember = "員工.姓名";
            TxtId.DataBindings.Add("Text", ds, "員工.員工編號");
            TxtP.DataBindings.Add("Text", ds, "員工.職稱");
            TxtBirthday.DataBindings.Add("Text", ds, "員工.出生日期");
            TxtAdd.DataBindings.Add("Text", ds, "員工.地址");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "員工";
        }
    }
}

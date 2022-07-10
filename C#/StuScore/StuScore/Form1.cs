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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingManagerBase bm;

        void Edit(string sqlstr)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DataBindingsClear()
        {
            TxtId.DataBindings.Clear();
            TxtName.DataBindings.Clear();
            TxtChi.DataBindings.Clear();
            TxtEng.DataBindings.Clear();
            TxtMath.DataBindings.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection())  
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                    "Integrated Security=True";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select * from 成績", cn);
                da.Fill(ds,"成績");

                TxtId.DataBindings.Add("Text", ds, "成績.學號");
                TxtName.DataBindings.Add("Text", ds, "成績.姓名");
                TxtChi.DataBindings.Add("Text", ds, "成績.國文");
                TxtEng.DataBindings.Add("Text", ds, "成績.英文");
                TxtMath.DataBindings.Add("Text", ds, "成績.數學");
                bm = this.BindingContext[ds, "成績"];
                hScrollBar1.SmallChange = 1;
                hScrollBar1.LargeChange = 1;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = bm.Count - 1;
                hScrollBar1.Value = 0;
                LblCount.Text = $"{bm.Position + 1}/{bm.Count}";
            }

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            bm.Position = hScrollBar1.Value;
            LblCount.Text = $"{bm.Position + 1}/{bm.Count}";
        }

        private void BtnCls_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtChi.Text = "";
            TxtEng.Text = "";
            TxtMath.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Edit("insert into 成績(學號,姓名,國文,英文,數學)" +
                $"values('{TxtId.Text}',N'{TxtName.Text}'," +
                $"{TxtEng.Text},{TxtChi.Text},{TxtMath.Text})");
            DataBindingsClear();
            Form1_Load(sender, e);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Edit($"update 成績 set 姓名=N'{TxtName.Text}',國文={TxtChi.Text},英文={TxtEng.Text},數學={TxtMath.Text} where 學號={TxtId.Text}");
            DataBindingsClear();
            Form1_Load(sender, e);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            Edit($"delete from 成績 where 學號='{TxtId.Text}'");
            DataBindingsClear();
            Form1_Load(sender, e);
        }

        private void BtnScore_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

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

namespace 連接_SQL_Server_Express_LocalDB_資料庫
{
    public partial class Form1 : Form
    {
        SqlConnection sqlDb = null;
        //string cntStr = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
        //    @"AttachDBFilename = |DataDirectory|\student.mdf;";

        public Form1()
        {
            InitializeComponent();
        }
        protected void OnStateChange(object sender, StateChangeEventArgs args)
        {
            string str;
            str = String.Format("連線狀態從 {0} 轉變為 {1}", args.OriginalState, args.CurrentState);
            textBox1.AppendText(str + "\r\n");
        }
        void showInfo()
        {
            textBox1.AppendText("存取權 : " + sqlDb.AccessToken + "\r\n");
            textBox1.AppendText("連線 ID : " + sqlDb.ClientConnectionId + "\r\n");
            textBox1.AppendText("連線字串 : " + sqlDb.ConnectionString + "\r\n");
            textBox1.AppendText("連接逾時 : " + sqlDb.ConnectionTimeout + "\r\n");
            textBox1.AppendText("Database : " + sqlDb.Database + "\r\n");
            textBox1.AppendText("資料來源 : " + sqlDb.DataSource + "\r\n");
            textBox1.AppendText("伺服器版本 : " + sqlDb.ServerVersion + "\r\n");
            textBox1.AppendText("連線狀態 : " + sqlDb.State + "\r\n");
            textBox1.AppendText("工作站 ID : " + sqlDb.WorkstationId + "\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (sqlDb = new SqlConnection(cntStr))
            sqlDb = new SqlConnection(Properties.Settings.Default.conStr);
            {
                try
                {
                    sqlDb.StateChange += new StateChangeEventHandler(OnStateChange);
                    sqlDb.Open();
                    showInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

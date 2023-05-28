using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 連接OLE_DB資料庫
{
    public partial class Form1 : Form
    {
        OleDbConnection oleDb = null;
        string cntStr = "provider=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source = studentPoint.mdb";
        public Form1()
        {
            InitializeComponent();
        }
        protected void OnStateChange(object sender, StateChangeEventArgs args)
        {
            string str;
            str = String.Format("連線狀態 {0} 轉變為 {1}。", args.OriginalState, args.CurrentState);
            textBox1.AppendText(str + "\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "連接")
            {
                try
                {
                    oleDb = new OleDbConnection(cntStr);
                    oleDb.StateChange += new StateChangeEventHandler(OnStateChange);
                    oleDb.Open();
                    button1.Text = " 關閉連線";
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                oleDb.Close();
                button1.Text = "連接";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(oleDb == null || oleDb.State == ConnectionState.Closed) { return; }
            textBox1.AppendText("連線狀態 : " + oleDb.State.ToString() + "\r\n");
            textBox1.AppendText("連接字串 : " + oleDb.ConnectionString + "\r\n");
            textBox1.AppendText("連線逾時 : " + oleDb.ConnectionTimeout.ToString() + "\r\n");
            textBox1.AppendText("連線來源 : " + oleDb.DataSource.ToString() + "\r\n");
            textBox1.AppendText("連線提供者 : " + oleDb.Provider.ToString() + "\r\n");
            textBox1.AppendText("伺服器版本 : " + oleDb.ServerVersion.ToString() + "\r\n");
            textBox1.AppendText("狀態 : " + oleDb.State.ToString() + "\r\n");
        }
    }
}

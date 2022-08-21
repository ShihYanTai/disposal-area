using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTest_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] contexts = { };
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'adventureWorks2019DataSet.AWBuildVersion' 資料表。您可以視需要進行移動或移除。
            this.aWBuildVersionTableAdapter.Fill(this.adventureWorks2019DataSet.AWBuildVersion);
            string SQLInfo = System.Environment.CurrentDirectory + @"\config.ini";
            if(SQLInfo != null)
            {
                string DBName = DataInI.GetValue("ServerInfo", "DBInfo", "", SQLInfo);
                this.contexts = DBName.Split(',');

                foreach(string DBitem in contexts)
                {
                    comboBox2.Items.Add(DBitem.Trim());
                }

                string TableName = DataInI.GetValue("DBTable", "TableInfo", "", SQLInfo);

                if(TableName != null)
                {
                    foreach(string Tableitem in contexts)
                    {
                        comboBox1.Items.Add(Tableitem.Trim());
                    }
                }
                else
                {
                    // MyID 放入所以有table name
                    DataInI.SetValue("DBTable", "TableInfo", MyID, SQLInfo);
                }
                
            }
        }
    }
}

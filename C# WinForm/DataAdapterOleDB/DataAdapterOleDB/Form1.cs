using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapterOleDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            x = this.Width;
            y = this.Height;
            setTag(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            string CN = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                $@"{Application.StartupPath}\mrt.mdb";
            OleDbConnection DB = new OleDbConnection(CN);
            DB.Open();
            OleDbDataAdapter AP = new OleDbDataAdapter("select * from 路線資訊",DB);
            DataSet DS = new DataSet();
            AP.Fill(DS, "路線資訊");
            dataGridView1.DataSource = DS.Tables["路線資訊"];
            DB.Close();
            */

            // SQL 寫法

            string CN = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|DataBase1.mdf;" +
                "Integrated Security=True";
            SqlConnection DB = new SqlConnection(CN);
            DB.Open();
            SqlDataAdapter AP = new SqlDataAdapter("select * from 書目", DB);
            DataSet DS = new DataSet();
            AP.Fill(DS, "書目");
            dataGridView1.DataSource=DS.Tables["書目"];
            DB.Close();
        }

        /*-----------------------------------------------------------------------------------------------------------------------------------------------------*/
        
        // 視窗大小與控制元件大小一起更動 --> https://docs.microsoft.com/zh-tw/dotnet/api/system.windows.forms.control.resize?view=windowsdesktop-6.0

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }

        #region 控制元件大小隨窗體大小等比例縮放
        private float x;//定義當前窗體的寬度
        private float y;//定義當前窗體的高度
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            //遍歷窗體中的控制元件，重新設定控制元件的值
            foreach (Control con in cons.Controls)
            {
                //獲取控制元件的Tag屬性值，並分割後儲存字串陣列
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根據窗體縮放的比例確定控制元件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//寬度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//左邊距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//頂邊距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字型大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }
        #endregion
    }
}

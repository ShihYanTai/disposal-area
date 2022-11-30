using Auto_Run.Module;
using Serilog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Auto_Run.Module.DataIO;

namespace Auto_Run
{
    public partial class Form1 : Form
    {
        static string file = System.Environment.CurrentDirectory + @"\InfoSQL.ini";
        SqlConnectionStringBuilder sqlCommandBuilder = new SqlConnectionStringBuilder($"Server={DataIO.GetValue("Server", "Server", "", file)}" +
                                                                                      $";Database={DataIO.GetValue("Server", "Database", "", file)}" +
                                                                                      $";Trusted_Connection={DataIO.GetValue("Server", "Trusted_Connection", "", file)}" +
                                                                                      $";user id={DataIO.GetValue("Server", "user id", "", file)}" +
                                                                                      $";password={DataIO.GetValue("Server", "password", "", file)}");
        bool CheckAccount = false;

        public Form1()
        {
            InitializeComponent();
            // 視窗大小
            x = this.Width;
            y = this.Height;
            setTag(this);
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                label7.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                label11.Text = DateTime.Now.AddSeconds(-Convert.ToInt64(domainUpDown1.Text.ToString())).AddMinutes(-Convert.ToInt64(domainUpDown2.Text.ToString())).AddHours(-Convert.ToInt64(domainUpDown3.Text.ToString())).ToString("yyyy/MM/dd HH:mm:ss");

                DataIO dataIO = new DataIO(sqlCommandBuilder.ConnectionString);
                ReadFile readFile = new ReadFile();
                Calculate calculate = new Calculate();
                ConcurrentDictionary<DateTime, Dictionary<string, Min5Data>> Min5_Data = new ConcurrentDictionary<DateTime, Dictionary<string, Min5Data>>();

                DateTime Timer1 = Convert.ToDateTime(label11.Text);

                if (Timer1.Minute % 5 == 0 && Timer1.Second == 0)
                {
                    var Time_File_Text = await readFile.Read_filenameAsync();

                    dataIO.UpsertLog_DataAsync(Time_File_Text);

                    if (Timer1.Minute == 0)
                    {
                        Min5_Data = await dataIO.Read_AvgData5(DateTime.Now.AddHours(-1), DateTime.Now); // 計算小時區間
                        if (!Min5_Data.Keys.Contains(DateTime.Now)) return;
                        else
                        {
                            var Time_Min60data = await calculate.Minu60Data(Min5_Data);
                            dataIO.UpsertLog_60DataAsync(Time_Min60data);
                        }
                    }
                    Min5_Data = await dataIO.Read_AvgData5(DateTime.Today, DateTime.Now);

                    if (!Min5_Data.Keys.Contains(Timer1))
                    {
                        label9.Text = $"Today Progress : \r\n Couldn't find the {Timer1} data.\r\n Please, determining a File or Directory Exists D:\\plcdta and make to date of file.";
                        GridView_Progress[Timer1.Minute / 5 + 1, Timer1.Hour].Style.BackColor = Color.Empty;
                    }
                    else
                    {
                        label9.Text = $"Today Progress : {Min5_Data.Keys.Max()}"; 
                        GridView_Progress[Timer1.Minute / 5 + 1, Timer1.Hour].Style.BackColor = Color.Green;
                    }
                }
                if(Timer1.Hour == 0) GridView_Progress.DefaultCellStyle.BackColor = Color.Empty;
            }
            catch(Exception ex)
            {
                Log.Error(ex, string.Format("Failed at timer1_Tick"));
            }
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SetInitialRow();

                string file = System.Environment.CurrentDirectory + @"\InfoSQL.ini";
                sqlCommandBuilder["Database"] = DataIO.GetValue("Server", "Database", "", file);

                timer1.Enabled = true;
                timer1.Start();
                timer1.Interval = 1000;
                Recalculate.Visible = CheckAccount;

                DataIO dataIO = new DataIO(sqlCommandBuilder.ConnectionString);
                ReadFile readFile = new ReadFile();
                Calculate calculate = new Calculate();

                var Time_File_Text = await readFile.Read_filenameAsync(DateTime.Today, DateTime.Now);
                if(Time_File_Text.Count == 0) label9.Text = $"Today Progress : \r\n Couldn't find the {DateTime.Today} - {DateTime.Now} data.\r\n Please, determining a File or Directory Exists D:\\plcdta and make to date of file.";
                else dataIO.UpsertLog_DataAsync(Time_File_Text);

                var Min5Data = await dataIO.Read_AvgData5(DateTime.Today, DateTime.Now);
                if (Min5Data.Count == 0) return;
                else
                {
                    var Time_Min60data = await calculate.Minu60Data(Min5Data);
                    dataIO.UpsertLog_60DataAsync(Time_Min60data);
                }

                GridView_Progress.Invoke((MethodInvoker)delegate
                {
                    foreach (var Today_had_been_record in Min5Data.Keys.OrderBy(t => t.TimeOfDay))
                    {
                        GridView_Progress[Today_had_been_record.Minute / 5 + 1, Today_had_been_record.Hour].Style.BackColor = Color.Green;
                    }
                });

            }
            catch(Exception ex)
            {
                Log.Error(ex, string.Format("Failed at Form1_Load"));
            }
        }
        private async void Recalculate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommandBuilder["Database"] = DataIO.GetValue("Server", "Database", "", file);

                string StDateTime, EdDateTime;
                StDateTime = StartTime.Text;
                EdDateTime = EndTime.Text;

                DataIO dataIO = new DataIO(sqlCommandBuilder.ConnectionString);
                ReadFile readFile = new ReadFile();
                Calculate calculate = new Calculate();

                if (Recalculate.Enabled) GridView_Progress.DefaultCellStyle.BackColor = Color.Empty;

                var SpanTime_Items_Minu5Value = await readFile.Read_filenameAsync(Convert.ToDateTime(StDateTime), Convert.ToDateTime(EdDateTime));

                if (SpanTime_Items_Minu5Value.Count == 0) label9.Text = $"Today Progress : \r\n Couldn't find the {StDateTime} - {EdDateTime} data.\r\n Please, determining a File or Directory Exists D:\\plcdta and make to date of file.";
                else 
                {
                    dataIO.UpsertLog_DataAsync(SpanTime_Items_Minu5Value);
                    var Read_Span_SQLdata = await dataIO.Read_AvgData5(Convert.ToDateTime(StDateTime), Convert.ToDateTime(EdDateTime));
                    var Span_Minu60_Data = await calculate.Minu60Data(Read_Span_SQLdata);

                    ProcessBar(Span_Minu60_Data);

                    dataIO.UpsertLog_60DataAsync(Span_Minu60_Data);

                    foreach (var Today_had_been_record in Read_Span_SQLdata.Keys.OrderByDescending(t => t.TimeOfDay).Where(d => d > DateTime.Now.Subtract(DateTime.Now.TimeOfDay)))
                    {
                        GridView_Progress[Today_had_been_record.Minute / 5 + 1, Today_had_been_record.Hour].Style.BackColor = Color.Green;
                    }
                } 
            }
            catch(Exception ex)
            {
                Log.Error(ex, string.Format("Failed at Recalculate_Click"));
            }
        }
        private async void Login_Click(object sender, EventArgs e)
        {
            await Login_MethodAsync();
        }
        private async void Password_KeyDown(object sender, KeyEventArgs e)
        {
            await Login_MethodAsync();
            Recalculate.Focus();
        }
        private async void Recalculate_KeyDown(object sender, KeyEventArgs e)
        {
            await Login_MethodAsync();
        }

        // --------------------------------- UI 進度動態呈現 ------------------------------------------------
        private void SetInitialRow()
        {
            try
            {
                DataTable dt = new DataTable();

                for (int i = 0; i < 12; i++)
                {
                    if (i == 0) dt.Columns.Add(new DataColumn(@"Hour\Minute", typeof(string)));
                    dt.Columns.Add(new DataColumn($"{i * 5}", typeof(string)));

                }
                for (int i = 0; i < 24; i++) dt.Rows.Add(i);

                GridView_Progress.DefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
                GridView_Progress.DataSource = dt;
                GridView_Progress.RowHeadersVisible = false;
                GridView_Progress.Columns[0].Width = 100;
                GridView_Progress.ReadOnly = true;
                GridView_Progress.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                Log.Error(ex, string.Format("Failed at SetInitialRow"));
            }
        }
        private void ProcessBar(Dictionary<DateTime, Dictionary<string, Minu60>> Span_Minu60_Data)
        {
            try
            {
                progressBar1.Maximum = Span_Minu60_Data.Count;
                progressBar1.Value = 0;

                progressBar1.Step = 1;
                timer1.Enabled = true;
                label4.Text = $"Recalculate Status : \r\n{Span_Minu60_Data.Keys.Max()}";
                foreach (DateTime recalculate_time in Span_Minu60_Data.Keys)
                {
                    progressBar1.PerformStep();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, string.Format("Failed at ProcessBar"));
            }
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
        private void Form1_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }
        #endregion
        // --------------------------------- UI 進度動態呈現 ------------------------------------------------
        private async Task Login_MethodAsync()
        {
            try
            {
                sqlCommandBuilder["Database"] = DataIO.GetValue("Server", "DatabaseCenter", "", file);

                string account = Account.Text;
                string password = Password.Text;

                DataIO dataIO = new DataIO(sqlCommandBuilder.ConnectionString);

                if (CheckAccount)
                {
                    CheckAccount = false;
                    Account.Visible = !CheckAccount;
                    Password.Visible = !CheckAccount;
                    label5.Visible = !CheckAccount;
                    label6.Visible = !CheckAccount;
                    Recalculate.Visible = CheckAccount;
                    domainUpDown1.Visible = CheckAccount;
                    domainUpDown2.Visible = CheckAccount;
                    domainUpDown3.Visible = CheckAccount;
                    Login.Text = "User Login";
                    Account.Text = "";
                    Password.Text = "";
                    sqlCommandBuilder["Database"] = DataIO.GetValue("Server", "Database", "", file);
                }
                else
                {
                    CheckAccount = await dataIO.CheckLogin(account, password);

                    if (CheckAccount) Login.Text = $"{account} Logout";

                    Account.Visible = !CheckAccount;
                    Password.Visible = !CheckAccount;
                    label5.Visible = !CheckAccount;
                    label6.Visible = !CheckAccount;
                    Recalculate.Visible = CheckAccount;
                    domainUpDown1.Visible = CheckAccount;
                    domainUpDown2.Visible = CheckAccount;
                    domainUpDown3.Visible = CheckAccount;
                    sqlCommandBuilder["Database"] = DataIO.GetValue("Server", "Database", "", file);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, string.Format("Failed at Login_MethodAsync"));
            }
        }
    }
}

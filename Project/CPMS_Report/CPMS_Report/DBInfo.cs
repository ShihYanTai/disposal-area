using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System;
using System.Globalization;
using Microsoft.SqlServer.Server;

namespace CPMS_Report
{
    internal class DBInfo
    {
        //public static DataSet SQLTable;

        // 讀取或寫入 ini檔案方法
        internal class IniHelper
        {
            [DllImport("kernel32")]//回傳0表示失敗，非0為成功
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
            [DllImport("kernel32")]//回傳取得字串緩沖區的長度
            private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

            /// <summary>
            /// 讀取ini檔案
            /// </summary>
            /// <param name="Section">名稱</param>
            /// <param name="Key">關鍵字</param>
            /// <param name="defaultText">默認值</param>
            /// <param name="iniFilePath">ini檔案地址</param>
            /// <returns></returns>
            public static string GetValue(string Section, string Key, string defaultText, string iniFilePath)
            {
                if (File.Exists(iniFilePath))
                {
                    StringBuilder temp = new StringBuilder(1024);
                    GetPrivateProfileString(Section, Key, defaultText, temp, 1024, iniFilePath);
                    return temp.ToString();
                }
                else
                {
                    return defaultText;
                }
            }

            /// <summary>
            /// 寫入ini檔案
            /// </summary>
            /// <param name="Section">名稱</param>
            /// <param name="Key">關鍵字</param>
            /// <param name="defaultText">默認值</param>
            /// <param name="iniFilePath">ini檔案地址</param>
            /// <returns></returns>
            public static bool SetValue(string Section, string Key, string Value, string iniFilePath)
            {
                var pat = Path.GetDirectoryName(iniFilePath);
                if (Directory.Exists(pat) == false)
                {
                    Directory.CreateDirectory(pat);
                }
                if (File.Exists(iniFilePath) == false)
                {
                    File.Create(iniFilePath).Close();
                }
                long OpStation = WritePrivateProfileString(Section, Key, Value, iniFilePath);
                if (OpStation == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        // 提供登入SQL一開始帳密及server 進入時以master資料庫中
        private static string InitialConnection()
        {
            string Server = IniHelper.GetValue("Server", "name", "", @".\config.ini");

            return $@"Data Source={Server};Persist Security Info=True;User ID=sa;Password=atlasSQL";
        }
        // 讀取所有資料庫名稱除了 系統資料庫外
        public static List<string> DbSelectName()
        {
            try
            {
                string LoadSQLCommand = @"SELECT name, database_id, create_date  FROM sys.databases WHERE database_id > 4";

                using (SqlConnection cn = new SqlConnection(InitialConnection()))
                {
                    SqlCommand command = new SqlCommand(LoadSQLCommand, cn);
                    command.Connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    var columns = new List<string>();
                    while (dataReader.Read())
                    {
                        columns.Add(dataReader.GetValue(0).ToString());
                    }
                    return columns;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        //讀取資料庫所有表單
        /// <summary>
        /// 擷取資料庫名稱找出資料庫內的表單名稱
        /// </summary>
        /// <param name="DBName"></param>
        /// <returns></returns>
        public static List<string> SelectTableInfo(string DBName)
        {
            try
            {
                string LoadSQLCommand = $@"use [{DBName}] select name from sysobjects where xtype='U';";

                using (SqlConnection cn = new SqlConnection(InitialConnection()))
                {
                    SqlCommand command = new SqlCommand(LoadSQLCommand, cn);
                    command.Connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    var columns = new List<string>();
                    while (dataReader.Read())
                    {
                        columns.Add(dataReader.GetValue(0).ToString());
                    }
                    return columns;
                }
            }
            catch(Exception ex)
            {
                throw;
            }

        }
        //找尋表單內資料
        /// <summary>
        /// 提供資料庫名稱及表單名稱做查詢 MSSQL 所有欄位名稱
        /// </summary>
        /// <param name="DBName"></param>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public static Dictionary<string, string> RawDataColumnsInfo(string DBName, string TableName)
        {
            try
            {
                string LoadSQLCommand = $"USE [{DBName}] SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('{TableName}')";
                    //$"USE {DBName} SELECT [COLUMN_NAME] FROM information_schema.COLUMNS where TABLE_NAME = '{TableName}'";

                using (SqlConnection cn = new SqlConnection(InitialConnection()))
                {
                    SqlCommand command = new SqlCommand(LoadSQLCommand, cn);
                    command.Connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    var DataItem = new Dictionary<string, string>();
                    while (dataReader.Read())
                    {
                        if (dataReader.GetValue(0).ToString().Contains("_st"))
                        {
                            string st_same = dataReader.GetValue(0).ToString().Replace("_st", "");
                            if (DataItem[st_same].ToString() == st_same)
                            {
                                continue;
                            }
                            else
                                DataItem.Add(dataReader.GetValue(0).ToString().Substring(0, 3), dataReader.GetValue(0).ToString());
                        }
                        else
                            DataItem.Add(dataReader.GetValue(0).ToString(), dataReader.GetValue(0).ToString());
                    }
                    return DataItem;
                }
            }
            catch(Exception ex)
            {
                throw;
            }

        }
        // 代碼中文對照
        /// <summary>
        /// 在 infoItem 表單裝提供測項資料選單的中文名稱
        /// </summary>
        /// <param name="DBName"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ItemName(string DBName)
        {
            try
            {
                string LoadSQLCommand = $"USE {DBName} SELECT TOP (1000) sid , name FROM [infoItem]";
                using (SqlConnection cn = new SqlConnection(InitialConnection()))
                {
                    SqlCommand command = new SqlCommand(LoadSQLCommand, cn);
                    command.Connection.Open();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    var ItemInfoName = new Dictionary<string, string>();

                    while (sqlDataReader.Read())
                    {
                        ItemInfoName.Add(sqlDataReader.GetValue(0).ToString(), sqlDataReader.GetValue(1).ToString());
                    }
                    return ItemInfoName;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        // 有時間區間的查找資料庫表單內資料
        /// <summary>
        /// 提供資料庫名稱、表單名稱或是欄位名稱及起迄時間，查找表單內資料。若是欄位是個別查找資料庫查詢會回傳較慢造成程式中斷，所以會讓程式休息1秒鐘等待資料庫。
        /// </summary>
        /// <param name="DBName"></param>
        /// <param name="Tablename"></param>
        /// <param name="Columns"></param>
        /// <param name="Start"></param>
        /// <param name="End"></param>
        /// <returns></returns>
        public static DataSet DataTable(string DBName, string Tablename, string Columns, DateTime Start, DateTime End, string CREATEDATE = "CREATEDATE")
        {
            try
            {
                string DateStart = Start.ToString("u", DateTimeFormatInfo.InvariantInfo);
                string DateEnd = End.ToString("u", DateTimeFormatInfo.InvariantInfo);

                string DataSQLCommand = $"USE [{DBName}] SELECT Top 500 {Columns} FROM {Tablename} WHERE [{CREATEDATE}] BETWEEN " +
                                            $"'{DateStart.Remove(DateStart.IndexOf("Z"))}' AND '{DateEnd.Remove(DateEnd.IndexOf("Z"))}' order by {CREATEDATE} desc";

                using (SqlConnection cn = new SqlConnection(InitialConnection()))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = new SqlCommand(DataSQLCommand, cn);
                    DataSet dataSet = new DataSet();
                    Thread.Sleep(1000);
                    sqlDataAdapter.Fill(dataSet, Tablename);
                    return dataSet;
                }
            }
            catch(Exception ex)
            {
                throw;
            }

        }
        // 無時間區間的查找資料庫表單內資料
        /// <summary>
        /// 提供資料庫名稱、表單名稱或是欄位名稱，查找表單內資料。若是欄位是個別查找資料庫查詢會回傳較慢造成程式中斷，所以會讓程式休息1秒鐘等待資料庫。
        /// </summary>
        /// <param name="DBName"></param>
        /// <param name="Tablename"></param>
        /// <param name="Columns"></param>
        /// <returns></returns>
        /// 
        public static DataSet NoCreateDateDataTable(string DBName, string Tablename, string Columns, string CreateDate)
        {
            string NoCreateDateSQLCommand = $"USE [{DBName}] SELECT top 500 {Columns} FROM {Tablename} order by { CreateDate} desc";
            try
            {
                using (SqlConnection cn = new SqlConnection(InitialConnection()))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = new SqlCommand(NoCreateDateSQLCommand, cn);

                    DataSet dataSet = new DataSet();
                    Thread.Sleep(1000);
                    sqlDataAdapter.Fill(dataSet, Tablename);
                    return dataSet;
                }
            }
            catch(Exception ex)
            {
                throw;
            }

        }
        // 沒有 Createdate 欄位時做查找所有表單資料
        /// <summary>
        /// 如果沒有 Createdate 欄位會報錯誤
        /// </summary>
        /// <param name="DBName"></param>
        /// <param name="Tablename"></param>
        /// <param name="Columns"></param>
        /// <returns></returns>
        public static DataSet NoCreateDateDataTableNoOrder(string DBName, string Tablename, string Columns, string sort)
        {
            try
            {
                string NoCreateDateSQLCommand = $"USE [{DBName}] SELECT top 500 {Columns} FROM {Tablename} {sort}";

                using (SqlConnection cn = new SqlConnection(InitialConnection()))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = new SqlCommand(NoCreateDateSQLCommand, cn);

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet, Tablename);
                    return dataSet;
                }
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// 建立操作紀錄
        /// </summary>
        /// <param name="log"></param>
        /// <param name="isPrepend"></param>
        public void Log(string log, bool isPrepend = false)
        {
            string logFilePath = @".\log\log.txt";
            string time = "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] ";

            if (!Directory.Exists(@".\log"))
            {
                Directory.CreateDirectory(@".\log");
            }
            log = time + log;

            //紀錄log
            if (!File.Exists(logFilePath))
            {
                using (StreamWriter sw = File.CreateText(logFilePath))
                {
                    sw.WriteLine(log);
                }
            }

            if (!isPrepend)
            {
                // 插入最後一行
                using (StreamWriter sw = File.AppendText(logFilePath))
                {
                    sw.WriteLine(log);
                }
            }
            else
            {
                List<string> list = new List<string>();
                // 先讀取歷史log
                using (StreamReader sr = File.OpenText(logFilePath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        list.Add(s);
                    }
                }

                // 直接複寫，先寫入當前log，再寫入歷史log
                using (StreamWriter sw = File.CreateText(logFilePath))
                {
                    sw.WriteLine(log);
                    foreach (string it in list.ToArray())
                    {
                        sw.WriteLine(it);
                    }
                }
            }

        }
    }
}

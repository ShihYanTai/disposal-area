using Serilog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Run.Module
{
    internal class DataIO
    {
        private readonly string SqlConnectionstr;
        public class DataShema
        {
            public string Item { get; set; }
            public string TextCreateDate { get; set; }
            public string Unit { get; set; }
            public float? Item_Value { get; set; }
            public string Statue { get; set; }
        }
        public class Min5Data
        {
            public float? Rd5min_Value { get; set; }
            public string Rd5min_Status { get; set; }
        }
        public class Minu60
        {
            public float? Min60_Value { get; set; }
            public string Min60_Status { get; set; }
        }
        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
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
        public DataIO(string SqlConnectionstr)
        {
            this.SqlConnectionstr = SqlConnectionstr;
        }
        public class ReadFile
        {
            public async Task<Dictionary<DateTime, List<DataShema>>> Read_filenameAsync()
            {
                try
                {
                    DateTime Last_Trans_Time;
                    string Last_Trans_File;
                    Dictionary<DateTime, string> FileDict = new Dictionary<DateTime, string>();
                    Dictionary<DateTime, List<DataShema>> Time_File_Text = new Dictionary<DateTime, List<DataShema>>();
                    List<DataShema> Item_Text = new List<DataShema>();

                    string strPath = $@"D:\plcdta\{DateTime.Now.Year}\{DateTime.Now.Month}\";
                    var DirFileName = from FileName in Directory.EnumerateFiles(strPath)
                                      select FileName;
                    await Task.Run(() =>
                    {
                        foreach (var File_Name in DirFileName)
                        {
                            string[] filename_split = Path.GetFileName(File_Name).Replace(".txt", "").Split('_');
                            string time = filename_split[3].Insert(4, "/").Insert(7, "/").Insert(10, " ").Insert(13, ":").Insert(16, ":");

                            FileDict.Add(Convert.ToDateTime(time), Path.GetFileName(File_Name).Replace(".txt", ""));
                        }

                        Last_Trans_Time = FileDict.OrderByDescending(key => key.Key).First().Key;
                        Last_Trans_File = FileDict.OrderByDescending(key => key.Key).First().Value.ToString();

                        string Path_Last_Text = string.Concat(strPath, Last_Trans_File, ".txt");
                        string[] Read_Last_Text = File.ReadAllLines(Path_Last_Text);

                        foreach (string Read_Text in Read_Last_Text)
                        {
                            string[] strings = Read_Text.Split('\t');

                            DataShema FileList = new DataShema()
                            {
                                TextCreateDate = strings[3],
                                Item = (strings[0] == "N-NH4+") ? strings[0].Replace("+", "").Replace("-", "_") : strings[0],
                                Item_Value = float.Parse(strings[1]),
                                Unit = strings[2],
                                Statue = strings[4]
                            };
                            Item_Text.Add(FileList);
                        }
                        Time_File_Text.Add(Last_Trans_Time, Item_Text);
                    });

                    return Time_File_Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{DateTime.Now} 請檢查文件檔是否有正常時間傳送至磁碟，或是否有產生文件檔。");
                    Log.Error(ex, string.Format("Failed at Read_filenameAsync"));
                    throw;
                }
            }
            public async Task<Dictionary<DateTime, List<DataShema>>> Read_filenameAsync(DateTime StartTime, DateTime EndTime)
            {
                try
                {
                    var r = await Task.Run(() =>
                    {
                        Dictionary<DateTime, string> FileDict = new Dictionary<DateTime, string>();
                        Dictionary<DateTime, List<DataShema>> Month_Time_File_Text = new Dictionary<DateTime, List<DataShema>>();

                        string[] strings = { };
                        if (StartTime.Month == EndTime.Month)
                        {
                            string Sta_Path = $@"D:\plcdta\{StartTime.Year}\{String.Format("{0:00}", StartTime.Month)}\";
                            var DirFileName = (from FileName in Directory.EnumerateFiles(Sta_Path, "*.*", SearchOption.AllDirectories)
                                               select FileName).ToArray();

                            foreach (var File_Name in DirFileName)
                            {
                                string[] filename_split = Path.GetFileName(File_Name).Replace(".txt", "").Split('_');
                                string time = filename_split[3].Insert(4, "/").Insert(7, "/").Insert(10, " ").Insert(13, ":").Insert(16, ":");

                                FileDict.Add(Convert.ToDateTime(time), Path.GetFileName(File_Name).Replace(".txt", ""));
                            }

                            var Span_FIleTime_Paths = (from Span_FileTime in FileDict
                                                       where Span_FileTime.Key <= EndTime && Span_FileTime.Key >= StartTime
                                                       let Path_Span_File = Sta_Path + Span_FileTime.Value + ".txt"
                                                       select Path_Span_File).ToArray();

                            foreach (var Span_File_Paths in Span_FIleTime_Paths)
                            {
                                string[] Read_Texts = File.ReadAllLines(Span_File_Paths);
                                List<DataShema> Item_Text = new List<DataShema>();
                                DateTime Span_File_Time = Convert.ToDateTime(Span_File_Paths.Split('\\', '_', '.')[7].Insert(4, "/").Insert(7, "/").Insert(10, " ").Insert(13, ":").Insert(16, ":"));
                                foreach (string Read_Text in Read_Texts)
                                {
                                    strings = Read_Text.Split('\t');

                                    DataShema FileList = new DataShema()
                                    {
                                        TextCreateDate = strings[3],
                                        Item = (strings[0] == "N-NH4+") ? strings[0].Replace("+", "").Replace("-", "_") : strings[0],
                                        Item_Value = float.Parse(strings[1]),
                                        Unit = strings[2],
                                        Statue = strings[4]
                                    };
                                    Item_Text.Add(FileList);
                                }
                                Month_Time_File_Text.Add(Span_File_Time, Item_Text);
                            }
                        }
                        else if (StartTime.Month < EndTime.Month) // <------------- 有跨月範圍時
                        {
                            int Record_Month = StartTime.Month;

                            while (EndTime.Month >= Record_Month)
                            {
                                string Sta_Path = $@"D:\plcdta\{StartTime.Year}\{String.Format("{0:00}", Record_Month)}";
                                var Time_DirFIleName_Loop = (from FileName in Directory.EnumerateFiles(Sta_Path, "*.*", SearchOption.AllDirectories)
                                                             select FileName).ToArray();

                                foreach (var Span_File_Paths in Time_DirFIleName_Loop)
                                {
                                    string[] Read_Texts = File.ReadAllLines(Span_File_Paths);
                                    List<DataShema> Item_Text = new List<DataShema>();
                                    foreach (string Read_Text in Read_Texts)
                                    {
                                        strings = Read_Text.Split('\t');

                                        DataShema FileList = new DataShema()
                                        {
                                            TextCreateDate = strings[3],
                                            Item = (strings[0] == "N-NH4+") ? strings[0].Replace("+", "").Replace("-", "_") : strings[0],
                                            Item_Value = float.Parse(strings[1]),
                                            Unit = strings[2],
                                            Statue = strings[4]
                                        };
                                        Item_Text.Add(FileList);
                                    }
                                    Month_Time_File_Text.Add(Convert.ToDateTime(Item_Text[3].TextCreateDate.Insert(4, "/").Insert(7, "/").Insert(10, " ").Insert(13, ":").Insert(16, ":")), Item_Text);
                                }
                                Record_Month++;
                            }
                            var t = (from Span_Filter in Month_Time_File_Text
                                     where Span_Filter.Key >= StartTime && Span_Filter.Key <= EndTime
                                     select new
                                     {
                                         k = Span_Filter.Key,
                                         v = Span_Filter.Value
                                     }).ToList();
                            Month_Time_File_Text.Clear();
                            foreach (var Span_Filter in t) Month_Time_File_Text.Add(Span_Filter.k, Span_Filter.v);
                        }
                        return Month_Time_File_Text;
                    });
                    return r;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{DateTime.Now} 請檢查文件檔是否有正常時間傳送至磁碟，或是否有產生文件檔。");
                    Log.Error(ex, string.Format("Failed at Read_filenameAsync"));
                    throw;
                }
            }
        }
        public async void UpsertLog_DataAsync(Dictionary<DateTime, List<DataShema>> Time_File_Text)
        {
            try
            {
                Time_File_Text.TryGetValue(Time_File_Text.Keys.First(), out var Items_Text);
                string Col_Name = string.Join(",", Items_Text.Select(col => $"[{col.Item}], [{col.Item}_st]"));
                string Value_Params = string.Join(",", Items_Text.Select(vp => $"@{vp.Item}, @{vp.Item}_st"));
                string Set_Params = string.Join(",", Items_Text.Select(sp => $"[{sp.Item}]=@{sp.Item}, [{sp.Item}_st]=@{sp.Item}_st"));
                string UpSertStr = $"Update [dbo].[AvgData5] " +
                                   $"SET [CreateDate] = @CreateDate, " +
                                   $"[EPAcode] = '09HWS202', " +
                                   $"[UpdateDate] = @UpdateDate, {Set_Params} " +
                                   $"Where [CreateDate] = @createdate " +
                                   $"IF(@@ROWCOUNT = 0)" +
                                   $"BEGIN " +
                                   $"INSERT INTO [dbo].[AvgData5] " +
                                   $"([CreateDate], [EPAcode], [UpdateDate], {Col_Name})" +
                                   $"VALUES (@CreateDate, '09HWS202', @UpdateDate, {Value_Params}) " +
                                   "END";
                foreach (var temp in Time_File_Text.ToList())
                {
                    using (SqlConnection connection = new SqlConnection(SqlConnectionstr))
                    {
                        SqlCommand sqlCommand = new SqlCommand(UpSertStr, connection);
                        sqlCommand.Parameters.AddWithValue("createDate", temp.Key.ToString("yyyy-MM-dd HH:mm:ss"));
                        sqlCommand.Parameters.AddWithValue("updateDate", DateTime.Now);
                        int index = 0;
                        foreach (var item in Items_Text)
                        {
                            sqlCommand.Parameters.AddWithValue($"{item.Item}", temp.Value[index].Item_Value);
                            sqlCommand.Parameters.AddWithValue($"{item.Item}_st", temp.Value[index].Statue);
                            index++;
                        }
                        await sqlCommand.Connection.OpenAsync();
                        await sqlCommand.ExecuteNonQueryAsync();
                    }
                }

            }
            catch (Exception ex)
            {
                Log.Error(ex, string.Format("Failed at UpsertLog_DataAsync"));
                throw;
            }
        }
        public async void UpsertLog_60DataAsync(Dictionary<DateTime, Dictionary<string, DataIO.Minu60>> Min60Data)
        {
            try
            {
                Min60Data.TryGetValue(Min60Data.Keys.First(), out var Items_Text);
                string Col_Name = string.Join(",", Items_Text.Select(col => $"[{col.Key}], [{col.Key}_st]"));
                string Value_Params = string.Join(",", Items_Text.Select(vp => $"@{vp.Key}, @{vp.Key}_st"));
                string Set_Params = string.Join(",", Items_Text.Select(sp => $"[{sp.Key}]=@{sp.Key}, [{sp.Key}_st]=@{sp.Key}_st"));
                string UpSertStr = $"Update [dbo].[AvgData60] " +
                                   $"SET [CreateDate] = @CreateDate, " +
                                   $"[EPAcode] = '09HWS202', " +
                                   $"[UpdateDate] = @UpdateDate, {Set_Params} " +
                                   $"Where [CreateDate] = @createdate " +
                                   $"IF(@@ROWCOUNT = 0)" +
                                   $"BEGIN " +
                                   $"INSERT INTO [dbo].[AvgData60] " +
                                   $"([CreateDate], [EPAcode], [UpdateDate], {Col_Name})" +
                                   $"VALUES (@CreateDate, '09HWS202', @UpdateDate, {Value_Params}) " +
                                   "END";

                foreach (var temp in Min60Data.ToList())
                {
                    using (SqlConnection connection = new SqlConnection(SqlConnectionstr))
                    {
                        SqlCommand sqlCommand = new SqlCommand(UpSertStr, connection);

                        sqlCommand.Parameters.AddWithValue("createDate", temp.Key.ToString("yyyy-MM-dd HH:mm:ss"));
                        sqlCommand.Parameters.AddWithValue("updateDate", DateTime.Now);

                        foreach (var item in Items_Text)
                        {
                            sqlCommand.Parameters.AddWithValue($"{item.Key}", temp.Value[item.Key].Min60_Value);
                            sqlCommand.Parameters.AddWithValue($"{item.Key}_st", temp.Value[item.Key].Min60_Status);
                        }
                        await sqlCommand.Connection.OpenAsync();
                        await sqlCommand.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, string.Format("Failed at UpsertLog_60DataAsync"));
            }
        }
        public async Task<ConcurrentDictionary<DateTime, Dictionary<string, Min5Data>>> Read_AvgData5(DateTime Start, DateTime End)
        {
            try
            {
                string StrRead = $"SELECT * FROM [dbo].[AvgData5] WHERE [CreateDate] BETWEEN @Start AND @End ORDER BY [CreateDate] DESC";

                using (SqlConnection connection = new SqlConnection(SqlConnectionstr))
                {
                    SqlCommand sqlCommand = new SqlCommand(StrRead, connection);
                    sqlCommand.Parameters.AddWithValue("Start", Start.ToString("yyyy-MM-dd HH:mm:ss"));
                    sqlCommand.Parameters.AddWithValue("End", End.ToString("yyyy-MM-dd HH:mm:ss"));
                    await sqlCommand.Connection.OpenAsync();
                    IDataReader dataReader = await sqlCommand.ExecuteReaderAsync();
                    var record = new Dictionary<DateTime, Min5Data>();
                    var columns = new List<string>();
                    var result = new ConcurrentDictionary<DateTime, Dictionary<string, Min5Data>>();

                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        columns.Add(dataReader.GetName(i));
                    }
                    var Items_List = columns.Where(col => col.EndsWith("_st")).Select(name => name.Replace("_st", ""));

                    while (dataReader.Read())
                    {
                        DateTime CreateDate = (DateTime)dataReader["CreateDate"];
                        var recordMap = new Dictionary<string, Min5Data>();
                        result.TryAdd(CreateDate, recordMap);

                        foreach (var Item in Items_List)
                        {
                            Single.TryParse(dataReader[Item].ToString(), out var _Value);
                            var Data5min = new Min5Data
                            {
                                Rd5min_Value = _Value,
                                Rd5min_Status = dataReader[Item + "_st"].ToString()
                            };
                            recordMap.Add(Item, Data5min);
                        }
                        result.TryAdd(CreateDate, recordMap);
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, string.Format("Failed at Read_AvgData5"));
                throw;
            }
        }
        public async Task<bool> CheckLogin(string LoginUserID, string LoginPassWord)
        {
            bool Login_Judge = false;
            try
            {
                string strLogin = "Select * From [dbo].[infoUser]";

                using (SqlConnection conn = new SqlConnection(SqlConnectionstr))
                {
                    SqlCommand cmd = new SqlCommand(strLogin, conn);
                    await cmd.Connection.OpenAsync();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Login_Judge = (reader["UserID"].ToString().Equals(LoginUserID) && reader["Password"].ToString().Equals(LoginPassWord)) ? true : false;
                        if (Login_Judge) break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, string.Format("Failed at CheckLogin"));
            }
            return Login_Judge;
        }
    }
}

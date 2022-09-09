using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPMS_Report
{
    public partial class frmRawData : Form
    {
        private List<string> TableIni;
        private string[] ServerIni;
        private string SelectedDBName;
        public CheckBox[] checkBoxes;
        DBInfo dBInfo = new DBInfo();
        public frmRawData()
        {
            InitializeComponent();
            // 視窗大小
            x = this.Width;
            y = this.Height;
            setTag(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 時間選項格式
                dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
                dateTimePickerEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";

                dateTimePickerStart.Format = DateTimePickerFormat.Custom;
                dateTimePickerStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";

                // 資料庫下拉選單名稱
                ServerIni = DBInfo.DbSelectName().ToArray();
                // 表單下拉選單名稱
                TableIni = DBInfo.SelectTableInfo(ServerIni[0]);
                //塞入下拉選單物件中
                foreach (string ServerName in ServerIni)
                {
                    DbSelect.Items.Add(ServerName.Trim());
                }
                foreach (string TableName in TableIni)
                {
                    TableSelect.Items.Add(TableName.Trim());
                }
                DbSelect.SelectedIndex = DbSelect.FindStringExact(DbSelect.Items[0].ToString());
                TableSelect.SelectedIndex = TableSelect.FindStringExact(TableSelect.Items[0].ToString());

                //新增勾選所有時間選項
                DataItemGroup.Controls.Add(AllTime);
                AllTime.Checked = true;
                // 時間選項勾選查找資料庫方式不同


                if (AllTime.Checked && TableIni.Contains("date"))
                    NoCreateDateGridViewMethod(DbSelect, TableSelect, TableVeiw, "*");
                else if (TableIni.Contains("date"))
                    GridViewMethod(DbSelect, TableSelect, dateTimePickerStart, dateTimePickerEnd, TableVeiw, "*");
                else
                {
                    Sort();
                }
                    
                // 點選所有測項時個別測項都會被取消
                DataAllSelected_Click(DataAllSelected, e);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void DbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // 選擇不同資料庫時，在表單對話框會做同步更新
                SelectedDBName = DbSelect.Text;
                TableIni = DBInfo.SelectTableInfo(SelectedDBName);
                TableSelect.Items.Clear();

                foreach (string TableName in TableIni)
                {
                    TableSelect.Items.Add(TableName.Trim());
                }
                TableSelect.Text = TableSelect.Items[0].ToString();
            }
            catch
            {
                throw;
            }

        }
        private void TableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // 點選不同表單時會產生不同測項的勾選物件
                ComboBox senderComboBox = (ComboBox)sender;
                string SelectedItem = senderComboBox.SelectedItem.ToString();
                string SelectedDBName = DbSelect.Text;
                string SelectedItemsInfo = GetEachItems();
                Dictionary<string, string> DataItem = DBInfo.RawDataColumnsInfo(SelectedDBName, SelectedItem);

                // 清除不需要測項勾選物件的表單
                DataItemGroup.Controls.Clear();
                // 有data名稱的表單都有測項勾選需求，以下做新增勾選物件方式
                if (SelectedItem.Contains("data") && !SelectedItem.Contains("dataCalibrate"))
                {
                    int iStartLeft = 5, iStartTop = 15;
                    
                    int ItemsNum = DataItem.Count();
                    int DataItemtime = 0;
                    checkBoxes = new CheckBox[ItemsNum];
                    string ItemName = "";

                    // 代碼
                    Dictionary<string, string> infoItemName = DBInfo.ItemName(SelectedDBName);

                    foreach (KeyValuePair<string, string> kvp in DataItem)
                    {
                        string Default = "";
                        if (!infoItemName.TryGetValue(kvp.Key, out Default))
                        {
                            switch (kvp.Key)
                            {
                                case "G11":
                                    ItemName = "不透光率";
                                    break;
                                case "G11_0":
                                    ItemName = "0 秒不透光率";
                                    break;
                                case "G11_1":
                                    ItemName = "10 秒不透光率";
                                    break;
                                case "G11_2":
                                    ItemName = "20 秒不透光率";
                                    break;
                                case "G11_3":
                                    ItemName = "30 秒不透光率";
                                    break;
                                case "G11_4":
                                    ItemName = "40 秒不透光率";
                                    break;
                                case "G11_5":
                                    ItemName = "50 秒不透光率";
                                    break;
                                case "A231":
                                    ItemName = "一氧化氮";
                                    break;
                                case "A232":
                                    ItemName = "二氧化氮";
                                    break;
                                case "W01":
                                    ItemName = "水份";
                                    break;
                                case "SCR":
                                    ItemName = "注氨量";
                                    break;
                                case "FGD":
                                    ItemName = "母液循環量";
                                    break;
                                case "D01":
                                    ItemName = "Dust";
                                    break;
                            }
                        }
                        else
                            ItemName = infoItemName[kvp.Key].Substring(0);

                        checkBoxes[DataItemtime] = new CheckBox
                        {
                            Name = kvp.Key,
                            Text = $"{kvp.Key} ({ItemName})",
                            AutoSize = false,
                            Width = 230,
                            Height = 30
                        };

                        // 每個勾選物件註冊全選測項被點及時被取消事件
                        checkBoxes[DataItemtime].CheckedChanged += (s, e_newCC) => { var c = s as CheckBox; if (c.Checked) DataAllSelected.Checked = false; };
                        // 新增所有時間、所有狀態及所有資料勾選物件
                        DataItemGroup.Controls.Add(checkBoxes[DataItemtime]);
                        DataItemGroup.Controls.Add(DataAllSelected);
                        DataItemGroup.Controls.Add(DataShowStatus);

                        // 所有資料、維持狀態及所有時間是勾選狀態
                        DataAllSelected.Checked = true;
                        DataShowStatus.Checked = true;

                        DataItemGroup.Controls.Add(AllTime);
                        AllTime.Checked = true;


                        if (DataItemtime == 0)
                        {
                            checkBoxes[DataItemtime].Left = iStartLeft;
                            checkBoxes[DataItemtime].Top = iStartTop;
                        }
                        else if (DataItemtime % 5 == 0)
                        {
                            checkBoxes[DataItemtime].Top = checkBoxes[DataItemtime - 1].Top + checkBoxes[DataItemtime].Height;
                            checkBoxes[DataItemtime].Left = iStartLeft;
                        }
                        else
                        {
                            checkBoxes[DataItemtime].Top = checkBoxes[DataItemtime - 1].Top;
                            checkBoxes[DataItemtime].Left = checkBoxes[DataItemtime - 1].Left + checkBoxes[DataItemtime - 1].Width;
                        }
                        if (checkBoxes[DataItemtime].Text == "Id ()" ||
                            checkBoxes[DataItemtime].Text == "CreateDate ()" ||
                            checkBoxes[DataItemtime].Text == "EPAcode ()" ||
                            checkBoxes[DataItemtime].Text.Contains("EP_") ||
                            checkBoxes[DataItemtime].Text == "UpdateDate ()" ||
                            checkBoxes[DataItemtime].Text.Contains("_baf")
                            )
                        {
                            DataItemGroup.Controls.Remove(checkBoxes[DataItemtime]);
                        }

                        DataItemtime++;
                    }
                    // 排序測項勾選物件在groupbox內的順序
                    
                    if (AllTime.Checked && TableSelect.Text.Contains("data"))
                        NoCreateDateGridViewMethod(DbSelect, TableSelect, TableVeiw, "*");
                    else if (TableSelect.Text.Contains("data"))
                        GridViewMethod(DbSelect, TableSelect, dateTimePickerStart, dateTimePickerEnd, TableVeiw, "*");
                    else
                    {
                        Sort();
                    }
                }
                // 判斷是否勾選所有時間或是有選擇時間區段的查找，若沒有測項資料查找則只留下所有時間勾選物件在介面上

                else if (AllTime.Checked && DataItem.ContainsKey("Createdate"))
                {
                    NoCreateDateGridViewMethod(DbSelect, TableSelect, TableVeiw, "*");
                    DataItemGroup.Controls.Add(AllTime);

                }
                else if (!AllTime.Checked && DataItem.ContainsKey("Createdate"))
                {
                    GridViewMethod(DbSelect, TableSelect, dateTimePickerStart, dateTimePickerEnd, TableVeiw, "*");
                    DataItemGroup.Controls.Add(AllTime);
                }
                else if (SelectedItemsInfo.Contains("CreateDate"))
                {
                    DataItemGroup.Controls.Clear();
                    DataItemGroup.Controls.Add(AllTime);
                    AllTime.Checked = true;
                }
                else
                {
                    Sort();
                }
                DataItemGroup.Controls.Add(AllTime);

                NoCreatedateUnenble();

            }
            catch
            {
                throw;
            }

        }
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> DataItem = DBInfo.RawDataColumnsInfo(SelectedDBName, TableSelect.Text);

                // 查詢時 設備蒐集data 相關判斷 
                if (AllTime.Checked && DataAllSelected.Checked && DataShowStatus.Checked && TableSelect.Text.ToString().Contains("data"))       // 所有時間 所有測項 所有狀態
                {
                    NoCreateDateGridViewMethod(DbSelect, TableSelect, TableVeiw, "*");
                }
                else if (AllTime.Checked && DataAllSelected.Checked && !DataShowStatus.Checked && TableSelect.Text.ToString().Contains("data"))  // 所有時間 所有測項 沒有狀態顯示
                {

                    NoCreateDateGridViewMethod(DbSelect, TableSelect, TableVeiw, "*");
                }
                else if (AllTime.Checked && !DataAllSelected.Checked && DataShowStatus.Checked && TableSelect.Text.ToString().Contains("data"))  // 所有時間 個別測項 有狀態顯示
                {
                    string SelectedItemsInfo = GetEachItems();
                    NoCreateDateGridViewMethod(DbSelect, TableSelect, TableVeiw, SelectedItemsInfo);
                }
                else if (AllTime.Checked && !DataAllSelected.Checked && !DataShowStatus.Checked && TableSelect.Text.ToString().Contains("data")) // 所有時間 個別測項 沒有狀態顯示
                {
                    string SelectedItemsInfo = GetEachItems();
                    NoCreateDateGridViewMethod(DbSelect, TableSelect, TableVeiw, SelectedItemsInfo);
                }
                else if (!AllTime.Checked && DataAllSelected.Checked && DataShowStatus.Checked && TableSelect.Text.ToString().Contains("data")) // 個別時間 所有測項 有狀態顯示
                {
                    GridViewMethod(DbSelect, TableSelect, dateTimePickerStart, dateTimePickerEnd, TableVeiw, "*");
                }
                else if (!AllTime.Checked && DataAllSelected.Checked && !DataShowStatus.Checked && TableSelect.Text.ToString().Contains("data")) // 個別時間 所有測項 沒有狀態顯示
                {
                    string SelectedItemsInfo = GetEachItems();
                    GridViewMethod(DbSelect, TableSelect, dateTimePickerStart, dateTimePickerEnd, TableVeiw, SelectedItemsInfo);
                }
                else if (!AllTime.Checked && !DataAllSelected.Checked && DataShowStatus.Checked && TableSelect.Text.ToString().Contains("data")) // 個別時間 個別測項 有測項顯示
                {
                    string SelectedItemsInfo = GetEachItems();
                    GridViewMethod(DbSelect, TableSelect, dateTimePickerStart, dateTimePickerEnd, TableVeiw, SelectedItemsInfo);
                }
                else if (!AllTime.Checked && !DataAllSelected.Checked && !DataShowStatus.Checked && TableSelect.Text.ToString().Contains("data")) // 個別時間 個別測項 沒有狀態顯示
                {
                    string SelectedItemsInfo = GetEachItems();
                    GridViewMethod(DbSelect, TableSelect, dateTimePickerStart, dateTimePickerEnd, TableVeiw, SelectedItemsInfo);
                }
                else if (AllTime.Checked && !DataAllSelected.Checked && !DataShowStatus.Checked && !TableSelect.Text.ToString().Contains("data"))  // 所有時間 非設備蒐集數據 
                {
                    string SelectedItemsInfo = GetEachItems();
                    if (DataItem.ContainsKey("Createdate")) NoCreateDateGridViewMethod(DbSelect, TableSelect, TableVeiw, "*");
                    else if (DataItem.ContainsKey("MTime")) NoCreateDateGridViewMethod(DbSelect, TableSelect, TableVeiw, "*", "MTime");
                    else 
                    {
                        Sort();
                    }
                }
                else
                {
                    string SelectedItemsInfo = GetEachItems();
                    if (DataItem.ContainsKey("Createdate")) GridViewMethod(DbSelect, TableSelect, dateTimePickerStart, dateTimePickerEnd, TableVeiw, SelectedItemsInfo);
                    else if (DataItem.ContainsKey("MTime")) GridViewMethod(DbSelect, TableSelect, dateTimePickerStart, dateTimePickerEnd, TableVeiw, SelectedItemsInfo, "MTime");
                    else Sort();
                }
                NoCreatedateUnenble();
            }
            catch
            {
                throw;
            }

        }
        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                // 開起舊檔的事件
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = @".\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.Diagnostics.Process.Start("explorer.exe", openFileDialog.FileName);
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        private void SaveFile_Click(object sender, EventArgs e)
        {
            // 儲存gridview所查到的資料
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 3;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.FileName = $"{TableSelect.Text}.csv";

            string[] OutPut = new string[TableVeiw.Rows.Count + 1];
            int ColumnCount = TableVeiw.Columns.Count;
            string ColNames = "";

            bool fileError = false;
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        if (!fileError)
                        {
                            try
                            {
                                for (int i = 0; i < ColumnCount; i++)
                                {
                                    ColNames += TableVeiw.Columns[i].HeaderText.ToString() + ",";
                                }
                                OutPut[0] += ColNames + "\r\n";

                                for (int i = 0; i < TableVeiw.Rows.Count; i++)
                                {
                                    for (int j = 0; j < ColumnCount; j++)
                                    {
                                        OutPut[i] += TableVeiw.Rows[i].Cells[j].Value?.ToString() + ",";
                                    }
                                }
                                MessageBox.Show("Data Exported Successfully !!!", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                        myStream.Close();
                        File.WriteAllLines(saveFileDialog1.FileName, OutPut, Encoding.UTF8);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            catch
            {
                throw;
            }
        }

        // 以下為常用方法區域
        public static void GridViewMethod(ComboBox DbSelect, ComboBox TableSelect, DateTimePicker dateTimePickerStart, DateTimePicker dateTimePickerEnd, DataGridView TableVeiw, String SelectedItemsInfo, string Create = "CreateDate")
        {
            try
            {
                DataSet dataSet = DBInfo.DataTable(DbSelect.Text, TableSelect.Text, SelectedItemsInfo, dateTimePickerStart.Value, dateTimePickerEnd.Value, Create);
                TableVeiw.DataSource = dataSet;
                TableVeiw.DataMember = dataSet.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void NoCreateDateGridViewMethod(ComboBox DbSelect, ComboBox TableSelect, DataGridView TableVeiw, String SelectedItemsInfo, string CreateDate = "CreateDate")
        {
            try
            {
                DataSet dataSet = DBInfo.NoCreateDateDataTable(DbSelect.Text, TableSelect.Text, SelectedItemsInfo, CreateDate);
                TableVeiw.DataSource = dataSet;
                TableVeiw.DataMember = dataSet.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void NoCreateDateGridViewMethodNoOrder(ComboBox DbSelect, ComboBox TableSelect, DataGridView TableVeiw, String SelectedItemsInfo, string sort = "")
        {
            try
            {
                DataSet dataSet = DBInfo.NoCreateDateDataTableNoOrder(DbSelect.Text, TableSelect.Text, SelectedItemsInfo, sort);
                TableVeiw.DataSource = dataSet;
                TableVeiw.DataMember = dataSet.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        // 得到勾選測項的名稱除了所有時間所有狀態勾選物件名稱以外
        private List<string> GetSelectedSid()
        {
            try
            {
                List<string> sidList = new List<string>();
                foreach (Control ctl in DataItemGroup.Controls)
                {
                    if (ctl is CheckBox AllTimeStu && AllTimeStu.Checked && AllTimeStu.Name != "AllTime" && AllTimeStu.Name != "DataShowStatus" && DataShowStatus.Checked)
                    {
                        sidList.Add(AllTimeStu.Name);
                        if (!AllTimeStu.Name.Contains("EP"))
                        {
                            sidList.Add(AllTimeStu.Name + string.Format("_st"));
                        }
                        else
                        {
                            sidList.Add(AllTimeStu.Name);
                        }

                    }
                    else if (ctl is CheckBox AllTimeNoStu && AllTimeNoStu.Checked && AllTimeNoStu.Name != "AllTime" && !DataShowStatus.Checked)
                        sidList.Add(AllTimeNoStu.Name);
                }
                return sidList;
            }
            catch
            {
                throw;
            }

        }
        // 得到個別測項的欄位提供資料庫查尋欄位
        private string GetEachItems()
        {
            try
            {
                string SelectedItemsInfo = "";
                List<string> SelectedItems = GetSelectedSid();
                
                if (!DataAllSelected.Checked && TableSelect.Text.ToString().Contains("data"))
                {
                    foreach (string ItemInfo in SelectedItems)
                    {
                        SelectedItemsInfo += "," + "[" + ItemInfo + "]";
                    }
                    SelectedItemsInfo = "[CreateDate]" + SelectedItemsInfo;
                }
                else SelectedItemsInfo = "*";

                return SelectedItemsInfo;
            }
            catch
            {
                throw;
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
        private void frmRawData_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }
        #endregion
        // 當點選所有測項物件時個別測項會被維持位點選狀態
        private void DataAllSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender == DataAllSelected)
                {
                    foreach (var ctrl in DataItemGroup.Controls)
                    {
                        if (ctrl is CheckBox checkBoxes && checkBoxes != DataAllSelected && checkBoxes != DataShowStatus && checkBoxes != AllTime)
                        {
                            checkBoxes.Checked = false;
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        // 沒有時間區段的就不能有選擇時間範圍功能
        private void NoCreatedateUnenble()
        {
            // 如果沒有Createdate 時間則部有可搜尋時間區段功能
            Dictionary<string, string> DataItem = DBInfo.RawDataColumnsInfo(SelectedDBName, TableSelect.Text);

            if (!DataItem.ContainsKey("CreateDate") && !DataItem.ContainsKey("MTime"))
            {
                dateTimePickerStart.Enabled = false;
                dateTimePickerEnd.Enabled = false;

            }
            else
            {
                dateTimePickerStart.Enabled = true;
                dateTimePickerEnd.Enabled = true;

            }
        }
        // 協助除了有data表單以外的排序
        private void Sort()
        {
            Dictionary<string, string> DataItem = DBInfo.RawDataColumnsInfo(SelectedDBName, TableSelect.Text);
            if (!DataItem.ContainsKey("CreateDate") && !DataItem.ContainsKey("MTime"))
            {
                NoCreateDateGridViewMethodNoOrder(DbSelect, TableSelect, TableVeiw, "*");
            }

            else if (DataItem.ContainsKey("CreateDate"))
            {
                if (AllTime.Checked) NoCreateDateGridViewMethodNoOrder(DbSelect, TableSelect, TableVeiw, "*", "order by CreateDate Desc");
                else GridViewMethod(DbSelect, TableSelect, dateTimePickerStart, dateTimePickerEnd, TableVeiw, "*");
            }

            else if (DataItem.ContainsKey("MTime")) NoCreateDateGridViewMethodNoOrder(DbSelect, TableSelect, TableVeiw, "*", "order by MTime Desc");
        }
    }
}

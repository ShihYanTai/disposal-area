using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SQLTest_1
{
    internal class DB
    {
        public static string InitalConnection()
        {
            string ConnectionString = @"Data Source=DESKTOP-QIQVIAE\HUMBOLDT;" +
                                        "Persist Security Info=True;User ID=sa;Password=lovechelsea123";
            return ConnectionString;
        }
        public static DataSet GetData(string DBSelect, string Table)
        {
            using ( SqlConnection connection = new SqlConnection(DB.InitalConnection()))
            {
                string QueryString = $@"select * from {DBSelect}";

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(QueryString, connection);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, Table);
                return dataset;
            }
        }
    }

}

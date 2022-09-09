using System;
using System.Windows.Forms;

namespace CPMS_Report
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmRawData());
            }
            catch(Exception ex)
            {
                DBInfo info = new DBInfo();
                info.Log(ex.ToString());
            }
        }
    }
}

using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog.Exceptions;

namespace Auto_Run
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
                Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .Enrich.WithExceptionDetails()
                    .WriteTo.File(".\\log\\EpaGenerator.log", rollingInterval: RollingInterval.Day)
                    .CreateLogger();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                Log.Information($"EpaGenerator start. ");
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Program abort abnormally.");
            }
        }
    }
}

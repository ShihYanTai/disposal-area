 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
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
}

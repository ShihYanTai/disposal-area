using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string MyID = Console.ReadLine();
            //寫入檔案
            string file = System.Environment.CurrentDirectory + @"\config.ini";
            if (file != null)
            {
                IniHelper.SetValue("我的資料", "MyID", MyID, file);
            }
            Console.WriteLine("我輸入的ID為{0}", MyID);
            //讀取檔案
            if (file != null)
            {
                MyID = IniHelper.GetValue("我的資料", "MyID", "", file);
                Console.WriteLine("我讀取到的ID為{0}",MyID);
                Console.ReadLine();
            }
        }
    }
}

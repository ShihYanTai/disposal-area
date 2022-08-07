using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10
{
    internal class PubClass
    {
        public static string sMsg;      // 專案範圍公用變數
        public static string NewLine(string st)     // 專案公用方法
        {
            return st + "\r\n";         // 字串加上換行再回傳
        }
    }
}

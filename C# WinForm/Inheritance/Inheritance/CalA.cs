using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class CalA             // 父類別
    {
        protected int num1, num2;   // 欄位
        public void SetValue(int n1, int n2)    // 公用方法
        {
            num1 = n1; num2 = n2;
        }
        public int GetSum()                     // 公用方法
        {
            return num1 + num2;
        }
    }
}

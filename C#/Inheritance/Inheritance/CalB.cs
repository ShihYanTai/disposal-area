using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class CalB : CalA          // CalB 類別繼承 CalA類別
    {
        public int GetMult()            // 公用方法
        {
            return num1 * num2;
        }
    }
}

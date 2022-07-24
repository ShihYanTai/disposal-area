using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
    internal class Person : Animal              // 子類別 Person 繼承父類別 Animal
    {
        public override string msg()            // 複寫父類別的 msg() 方法
        {
            return "現在是執行 子類別 Person";
        }
    }
}

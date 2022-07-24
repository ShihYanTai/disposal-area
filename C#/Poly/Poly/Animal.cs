using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
    internal class Animal
    {
        public virtual string msg()         // 允許被子類別父類別複寫
        {
            return "現在執行 父類別 Animal";
        }
    }
}

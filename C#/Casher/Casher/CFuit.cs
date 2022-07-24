using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casher
{
    internal class CFuit
    {
        public double Price { get; set; }   // Price 為價格屬性
        public virtual double spend()       // 空殼的 spend() 方法，允許被覆蓋
        {
            return 0;
        }
    }
}

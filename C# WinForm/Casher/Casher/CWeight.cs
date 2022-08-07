using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casher
{
    internal class CWeight : CFuit      // CWeight 繼承 CFruit 類別
    {
        public double Weight { get; set; }      // Weight 為重量屬性
        public CWeight(double weight,double price)
        {
            Weight = weight;
            Price = price;
        }
        public override double spend()          // 複寫父類別的 spend() 方法
        {
            return Weight * Price;
        }
    }
}

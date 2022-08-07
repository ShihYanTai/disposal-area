using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casher
{
    internal class CSum
    {
        private static double sp, tot;
        public CSum(CFuit f)
        {
            sp = f.spend();
            tot += sp;
        }
        public string priceMsg()
        {
            return $"單項收費 : {sp} 元";
        }
        public string totMsg()
        {
            return $"累計收費 : {tot} 元";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    internal class BMath : AMath
    {
        public int Add(int[] num)
        {
            int tot = 0;
            for(int i = 0; i < num.Length; i++)
            {
                tot += num[i];
            }
            return tot;
        }
    }
}

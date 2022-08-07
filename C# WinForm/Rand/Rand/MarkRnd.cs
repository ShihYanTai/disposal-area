using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rand
{
    internal class MarkRnd
    {
        public void GetRnd(int[] data, int n1, int n2, int rNum)
        {
            int temp, n = 0;
            bool more;                  // 用來判斷產生的亂數是否重複
            Random rndObj = new Random();
            do
            {
                more = false;
                temp = rndObj.Next(n1, n2 + 1);
                for (int i = 0; i <= n; i++)
                {
                    if (data[i] == temp) more = true;
                }
                if (more == true) continue;
                data[n] = temp;
                n++;
            }
            while (n < rNum);
        }
    }
}

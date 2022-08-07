using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    internal class GList<T>                                 // 宣告泛型類別 Glist
    {
        private T[] ary = new T[5];                         // T 為型別引數，可存放 5 個資料
        private int index;                                  // 陣列索引值
        public void SaveToArray(T tData)                    // 存放資料到陣列
        {
            if (index < ary.Length)
            {
                ary[index] = tData;
                index++;
            }
        }
        public String data()
        {
            string st = "";
            for (int i = 0; i < ary.Length; i++)
            {
                st += $" ary[{i}] = {ary[i]} \r\n";
            }
            return st;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    internal class JPtoNT : IExchange           // 宣告 UStoNT類別來實作 IExchange 介面
    {
        public double Rate                      // 實作 IExchange 介面屬性
        {
            get { return 0.26; }
        }
        public double Convert(double JPd)       // 實作 IExchange 介面方法
        {
            return JPd * Rate;
        }
    }
}

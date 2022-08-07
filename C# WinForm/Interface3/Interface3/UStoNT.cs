using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    internal class UStoNT : IExchange       // 宣告 UStoNT 類別來實作 IExchange 介面
    {
        public double Rate                  // 實作 IExchange 見面屬性
        {
            get { return 28.35; }
        }
        public double Convert(double USd)   // 實作 IExchange 介面方法
        {
            return USd * Rate;
        }
    }
}

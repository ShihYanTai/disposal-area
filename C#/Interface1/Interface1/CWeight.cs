using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal class CWeight : IConvert               // 宣告 CWeight 類別實作 IConvert 介面
    {
        private double mult = 453.59;               // 1 lb = 453.59 g
        public double Mult
        {
            get { return mult; }
            set { mult = value; }
        }
        public double Convert(double lb)            // 實作 Convert() 方法
        {
            return Mult * lb;
        }
    }
}

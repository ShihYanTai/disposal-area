using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface IConvert
    {
        double Mult { get; set; }          // 倍率屬性
        double Convert(double w);           // 換算重量的方法原型
    }
}

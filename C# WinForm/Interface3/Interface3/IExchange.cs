using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    interface IExchange
    {
        double Rate { get; }            // 匯率屬性
        double Convert(double c);       // 兌換成台幣的方法原型
    }
}

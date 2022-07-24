using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    interface IPass
    {
        int Score { get; set; }         // 分數屬性
        String Pass(int grade);         // 判斷及格
                                        // 原型方法
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    interface ILevel
    {
        int High { get; set; }          // 高標屬性
        int Low { get; set; }           // 低標屬性
        String Level(int grade);        //辨識等第 原型方法
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor2
{
    internal class Triangle
    {
        public int Base { get; set; }   // Base 為底長屬性
        public int High { get; set; }  // High  為高度屬性
        public Triangle()               // 沒有引數的 default constructor
        {
            Base = 15;
            High = 15;
        }
        public Triangle(int H)          // 一個高度引數的建構函式 constructor
        {
            Base = 15;
            High = H;
        }
        public Triangle(int B, int H)   // 含有底和高的建構函式 constructor
        {
            Base = B;
            High = H;
        }
        public double GetArea()         // 方法成員
        {
            return (double)Base * High / 2;
        }
    }
}

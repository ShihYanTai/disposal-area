using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class Triangle
    {
        public int Base { get; set; }           // Base 為底長屬性
        public int Hight { get; set; }          // Hight 為高度屬性
        public Triangle()                       // 沒引數的 default constructor
        {
            Base = 0;
            Hight = 0;
        }
        public Triangle(int B, int H)           // 含有底和高引數的建構函式
        {
            Base = B;
            Hight = H;
        }
        public double GetArea()                 // 方法成員
        {
            return (double)Base * Hight / 2;
        }
    }
}

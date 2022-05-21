using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics

namespace 台大開放課程3
{
    internal class Program
    {
        static void GetAreaAndPerimeterOfASquare(int a, ref int area,ref int perimeter)
        {
            area = a * a;
            perimeter = 4 * a;
        }

        static void GetAreaAndPerimeterOfASquareUsingOut(int a, out int area, out int perimeter)
        {
            area = a * a;
            perimeter=4 * a;
        }

        static void Main(string[] args)
        {
            int a = 5;
            int perimeter1 = 0;
            int area1 = 0;

            GetAreaAndPerimeterOfASquare(
                a, ref area1, ref perimeter1);
            Debug.Assert(area1 == 25 && perimeter1 == 20);

            int perimeter2;
            int area2;

            GetAreaAndPerimeterOfASquareUsingOut(
                a, out area2, out perimeter2);
            Debug.Assert(area2 == 25 && perimeter2 == 20);
           
            // out 不像 ref 需要設定初始值 設定地址
        }
    }
}

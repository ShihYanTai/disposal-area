using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace 台大開放課程2
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static int GCD(int x, int y)
        {
            if (x < y) Swap(ref x, ref y); // x 較小時,需交換x 與 y

            int remainder;
            
            while(y != 0)
            {
                remainder = x % y;
                x = y;
                y = remainder;
            }
            return x;
        }

        static void Main(string[] args)
        {

            Debug.Assert(GCD(1, 5) == 1);
            Debug.Assert(GCD(12, 18) == 6);
            Debug.Assert(GCD(17, 13) == 1);
            Console.Write("輸入第一個正整數: ");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.Write("輸入第二個正整數: ");
            int y=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("兩數的最大公因數為{0}", GCD(x, y));
        }
    }
}

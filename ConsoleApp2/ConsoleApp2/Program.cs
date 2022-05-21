using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static int HorizontalDistance(double v0,int t)
        {
            double x = v0 * t;
            return (int)x;
        }

        static int VerticalDistance(double g, int t)
        {
            double y = 0.5 * g * t * t;
            return (int)y;
        }

        static void Main(string[] args)
        {
            char[,] Screen = { };
            
            double v0 = 0, g = 9.8;
            int x, y,i,j;
            int NX = x;
            int NY = y;
            int NT = 7;
            for(int t = 0;t < NT; ++t)
            {
                x = HorizontalDistance(v0, t);
                y = VerticalDistance(g, t);

                Screen[y, x] = ' ';
                if (x >= NX || y >= NY) break;
                Screen[y, x] = 'o';
                Console.Clear();
                for (i = 0; i < NY; ++i){
                for (j = 0; j < NX; ++j) { 
                Console.Write(Screen[i,j]);
                }
                Console.WriteLine();
            }
            }
        }
    }
}

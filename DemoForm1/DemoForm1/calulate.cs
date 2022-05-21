using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm1
{
    internal class calulate
    {
        private static int[,] Add(int[,] a, int[,] b)
        {
            int[,] result = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    result[i,j] = a[i,j] + b[i, j];
                }
            }
            return result;
        }

        private static int[,] subtract(int[,] a, int[,] b)
        {
            int[,] result = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }
        private int[,] multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[a.GetLength(0), a.GetLength(1)];
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    result[i, j] = b[i, j];
                }
            }
        }
    }
}

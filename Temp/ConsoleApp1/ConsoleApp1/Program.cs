using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parallel.For(0, 20, (i) =>
            //{
            //    Console.WriteLine("{0},", i);
            //});
            //Console.ReadKey();


            int[] data = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Parallel.ForEach(data, (i) =>
            {
                Console.WriteLine("{0}", i);
            });
            Console.ReadKey();
        }

        
    }
}

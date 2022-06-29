using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_of_Hanoi
{
    internal class Program
    {
        class HanoiCalcular
        {
            public ulong CalculateHanoi(int count)
            {
                ulong stepForOnlyCurrentDish = 1;
                if (count == 1)
                {
                    return stepForOnlyCurrentDish;
                }
                ulong totalStep = stepForOnlyCurrentDish + CalculateHanoi(count - 1) * 2;
                return totalStep;
            }
        }
        static void Main(string[] args)
        {
            HanoiCalcular c = new HanoiCalcular();
            Console.WriteLine(c.CalculateHanoi(64));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 骰子遊戲
{
    internal class Program
    {
        class Dice
        {
            private int faceValue = 1;
            private Random random;

            public Dice()
            {
                random = new Random();
            }
            public Dice(int seed)
            {
                random = new Random(seed);
            }
            public int FaceValue
            {
                get { return faceValue; }
            }
            ~Dice() { }

            public void Toss()
            {
                
                faceValue = random.Next() % 6 + 1;
            }
        }
        static void Main(string[] args)
        {
            int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int N = 12000;

            const int SEED_1 = 168;
            Dice dice1 = new Dice(SEED_1);

            const int SEED_2 = 777;
            Dice dice2 = new Dice(SEED_2);

            for (int i  =0; i < N; ++i)
            {
                dice1.Toss();
                dice2.Toss();

                count[dice1.FaceValue + dice2.FaceValue - 2]++;
            }

            // 會造成骰兩個骰子數字會一樣

            dice1.Toss();
            dice2.Toss();
            Console.WriteLine(dice1.ToString());
            Console.WriteLine(dice2.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    // 宣告變數
    //public enum WeekDay
    //{
    //    SUN = 1,
    //    MON = 2,
    //    TUE = 3,
    //    WED = 4,
    //    THU = 5,
    //    FRU = 6,
    //    SAT = 7
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //char aChar = 'a';
            //Console.WriteLine(aChar);
            //int anInt = 123;
            //Console.WriteLine(anInt);
            //double aDouble = 123.456;
            //Console.WriteLine(aDouble);
            //bool aBool = true;
            //Console.WriteLine(aBool);

            //// 示範程式UsingNumeric重要片段

            //int x = 256;
            //Console.WriteLine("x : " + x);
            //byte y = 255;
            //Console.WriteLine("y : " + y);
            //double z = 123.45;
            //Console.WriteLine("z : " + z);
            //float f = 123.45f;
            //Console.WriteLine("f : " + f);
            //decimal d = 123.34m;
            //Console.WriteLine("d : " + d);

            // 示範程式UsingMathOperator重要片段

            //Console.WriteLine("請輸入第一個整數值x : ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("請輸入第二個整數值y : ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine(" x + y = {0} ", x + y);
            //Console.WriteLine(" x - y = {0} ", x - y);
            //Console.WriteLine(" x * y = {0} ", x * y);
            //Console.WriteLine(" x / y = {0} ", x / y);
            //Console.WriteLine(" x % y = {0} ", x % y);

            //Console.WriteLine("Sqrt(2) = " + Math.Sqrt(2.0));
            //Console.WriteLine("PI = " + Math.PI);
            //Console.WriteLine("Sin(PI/6.0) = " + Math.Sin(Math.PI / 6.0));
            //Console.WriteLine("Pow(2.0, 0.5) = " + Math.Pow(2.0, 0.5));
            //Console.WriteLine("Exp(1) = " + Math.Exp(1.0));
            //Console.WriteLine("ln(e) = " + Math.Log(Math.E));
            //Console.WriteLine("log10(100) = " + Math.Log10(100.0));

            //const double G = 9.8; // const 限定使用 後面更改無法更改
            //Console.WriteLine("常數G = {0} ", G);
            //double t = 1.0;
            //double y = -(1.0 / 2.0) * G * t * t;
            //G = 9.8 / 6; //Error!

            //Console.WriteLine("請輸入整數變數x初值");
            //int x0 = int.Parse(Console.ReadLine());
            //Console.WriteLine("請輸入所要加總的總數值add");
            //int add = int.Parse(Console.ReadLine());
            //int x = x0;
            //x = x + add;
            //x = x0;
            //x += add;
            //int post;
            //x = x0;
            //post = x++;
            //int pre;
            //x = x0;
            //pre = ++x;

            // if 流程
            //Console.Write("請輸入一個小於100的整數原始成績:");
            //int score = int.Parse(Console.ReadLine());

            //// 條分公式
            //if (score < 60)
            //{
            //    score = 60;
            //};
            //Console.WriteLine("調分後成績: " + score);

            // if-else 流程與三元運算
            //Console.Write("請輸入一個小於100的整數原始成績: ");
            //int score = int.Parse(Console.ReadLine());
            //int result = score < 60 ? 60 : score;
            //// 調分公式

            //Console.WriteLine("調分後成績: " + result);

            //bool x = 7 > 3;
            //bool y = 2 < 0;
            //bool xORy = x | y;
            //bool xANDy = x & y;
            //bool xOy = (x & y) | (x | y);
            //bool xNy = (x & y) & (x | y);

            //string first = "one";
            //string second = "One";
            //string third = "one";
            //Console.WriteLine(first == second);
            //Console.WriteLine(first == third);
            //Console.WriteLine(first != second);
            //Console.Write(first != third);

            // 閏月算法
            //int y = int.Parse(Console.ReadLine());
            //bool isLeadYear = ((y % 4 == 0) && (y % 100 != 0)) || ((y % 100 == 0) && (y % 400 != 0));
            //string result = (isLeadYear) ? "Leap Year" : "Not Leap Year";
            //Console.WriteLine(result);

            // UsingSwitch.Program 片段
            //Console.Write("請輸入成績: A, B, C, F: ");
            //char grade = Console.ReadLine().ToCharArray()[0];
            //switch (grade)
            //{
            //    case 'A':
            //        Console.WriteLine("成績優異");
            //        break ;
            //    case 'B':
            //        Console.WriteLine("成績良好");
            //        break ;
            //    case 'C':
            //        Console.WriteLine("成績中等");
            //        break ;
            //    case 'D':
            //        Console.WriteLine("成績尚可");
            //        break;
            //    case 'E':
            //        Console.WriteLine("不及格");
            //        break;
            //    case 'F':
            //        Console.WriteLine("成績錯誤");
            //        break;
            //}

            // 程式 UsingEnum重要片段

            // enum 宣告於class 使用
            //WeekDay day = WeekDay.TUE;
            //switch (day)
            //{
            //    case WeekDay.SUN:
            //        Console.WriteLine("星期日為一週的第{0}天!!", (int) WeekDay.SUN);
            //        break;
            //    case WeekDay.TUE:
            //        Console.WriteLine("星期二為一週的第{0}天!!", (int) WeekDay.TUE);
            //        break;
            //    default:
            //        Console.WriteLine("一週的第{0}天!!", (int) day);
            //    break;
            //}
            //int i ;
            //int sum = 0;
            //for (i = 1; i <= 100; ++i)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("1~100 的加總等於 " + sum);

            // 設定Debug 檢查站
            //int i;
            //int sum = 0; 
            //Debug.Assert(sum == 0);
            //for (i = 0; i < args.Length; i++)
            //{
            //    sum += i;

            //}

            //Debug.Assert(sum == 101);
            // MTable.Program 片段
            //for (int i = 0; i < 10; ++i)
            //{
            //    for (int j = 0; j < 10; ++j)
            //    {
            //        Console.WriteLine("{0}*{1}={2} ", i, j, i * j);
            //    }
            //    // 印完一組變換行
            //    Console.WriteLine();
            //}

            //int sum = 0;
            //int i = 1;
            //while (i <= 100) 
            //{
            //    sum += i;
            //    ++i;
            //}
            //Console.WriteLine("1 ~ 100 的加總等於 " + sum);

            // 無窮級數計算
            //const double THRESHOLD = 1.0e-8; // 準確位數要求
            //double sum = 0;
            //int n = 0;
            //double term = 相當於a0 的計算式;

            //while (Math.Abs(term) > THRESHOLD)
            //{
            //    sum += term;
            //    ++n;
            //    term = 相當於an 的計算式 ;
            //}

            // Pythagofras.Program重要片段
            //int x,y,z;
            //int n = 0;

            //for(x = 1; x<= 100; ++x)
            //{
            //    for(y =x; y <=100; ++y)
            //    {
            //        for (z = 1; z <=150; ++z)
            //        {
            //            if (x * x + y * y != z * z) continue;
            //            ++n;

            //            Console.WriteLine("{0}: {1} * {1} + {2} * {2} = {3} * {3}", n, x, y, z);

            //            break;

            //        }
            //        if (n == 10) break;
            //    }
            //    if(n == 10) break;
            //}

            // VarScope 片段
            //Console.WriteLine("請輸入一個字元:　");
            //string s = Console.ReadLine();
            //if (s == "A")
            //{
            //    string s1 = s;
            //    Console.WriteLine(s1 + "為第一個英文字母!!");
            //}
            //else {
            //    string s1 = s;
            //    Console.WriteLine(s1 + "不是第一個英文字母!!");
            //}
            //for (int i = 0;i < 10; i++)
            //{
            //    string s1 = s;
            //    Console.WriteLine(s1);
            //}


        }
    }
}

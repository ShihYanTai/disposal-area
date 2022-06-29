using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 台大開放課程1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int grade;
            //Console.WriteLine("輸入成績: ");
            //grade = Convert.ToInt16(Console.ReadLine());
            //while(grade > 0 || grade > 100)
            //{
            //    Console.WriteLine("成績須在0到100之間,請重新輸入:");
            //    grade = Convert.ToInt16(Console.ReadLine());

            //}
            //Console.WriteLine("成績為: " + grade);

            //int grade = 0;
            //Console.WriteLine("輸入成績: ");
            //while (true)
            //{
            //    grade = Convert.ToInt16(Console.ReadLine());
            //    if (grade >= 0 && grade <= 100) break;
            //    // 數值合理則跳出無窮迴圈
            //    Console.Write(
            //        "成績須在0到100之間, 請重新輸入: ");
            //}
            //Console.WriteLine("成績為: " + grade);

            // Eulid.Program 程式片段
            //int x=0, y=0;
            //int remainder = 0;
            //if (x < y) // x 較小時, 需交換x 與y
            //{ 
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //}
            //while(y != 0)
            //{
            //    remainder = x % y;

            //    x = y;

            //    y = remainder;
            //}

            // 程式 Array1D.Program片段
            //const int N = 5;
            //int[] p = new int[N];
            //p[0] = 2;
            //p[1] = 3;
            //p[2] = 5;
            //p[3] = 7;
            //p[4] = 11;
            //int i;
            //for (i = 0; i < N; ++i)
            //{
            //    Console.WriteLine(p[i]);
            //}

            // 程式 Array1D2.Program片段
            //int[] p = { 2, 3, 5, 7, 11 };
            //int i;
            //for (i = 0;i < p.Length; ++i)
            //{
            //    Console.WriteLine(p[i]);
            //}

            //程式 Array1D3.Program片段
            //Console.Write("輸入年數: ");
            //int n = Int32.Parse(Console.ReadLine());
            //double c = 10000;
            //double p = 2.75; 

            //double[] m = new double[n];
            //int i;
            //for (i = 0; i < n; ++i) 
            //{
            //    m[i] = c * Math.Pow(1.0 + p, i + 1);
            //}
            //for (i = 0; i < n; i++)
            //{
            //    Console.WriteLine("第{0}年後的本利和為{1}", i+1, m[i]);
            //}

            // UsingRandom.Program片段
            //int seed = 123;
            //Random rand = new Random(seed);
            //// Random rand = new Random();
            //int[] count = new int[10];
            //int k;
            //int i;
            //for (k = 0;k < 10; ++k)
            //{
            //    count[k] = 0;

            //}
            //const int N = 1000;
            //for (i = 0; i < N; ++i)
            //{
            //    k = rand.Next() % 10;
            //    ++count[k];
            //}

            // GuessingNumber.Program片段
            //char[] xd = new char[4];
            //// 利用亂數產生一個四位數字都不同的四位數
            //// 最高位數可以是0
            //// x的四個位數為xd[0]~xd[3]
            //char[] d = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //int nGuess=0,i,j,k;
            //bool again;
            //Random rand = new Random();
            //for (i = 0; i < 4; ++i)
            //{
            //    do
            //    {
            //        k = rand.Next() % 10;
            //        // 檢查d[k]是否出現過
            //        again = false;
            //        for (j = 0; j < i; ++j)
            //        {
            //            if (d[k] != xd[j]) continue;
            //            again = true;
            //            break;
            //        }
            //    } while(again);
            //    xd[i] = d[k];
            //}

            /*
             //測試用
            xd[0] = '0';
            xd[1] = '5';
            xd[2] = '6';
            xd[3] = '7';

             */

            // 使用者開始猜測
            //Console.Write("輸入猜測次數上限: ");
            //int maxNGuess = Convert.ToInt16(Console.ReadLine());
            //int nGuess = 0;
            //char[] xd=new char[4];
            /*
             * 猜數字遊戲
             * 2/26/2013
             * 
             * 虛擬碼: 猜數字遊戲
             * 1    利用亂數產生一個四位數字都不同的四位數x高位數可以是0
             * 2    x的四個位數為xd[0]~xd[3]
             * 3    do
             *      {
             * 3.1   使用輸入所猜四位數y
             * 3.2   y的四個位數為yd[0]~yd[3]
             * 3.3   n = 0 // 位置正確的位數
             * 3.4   m = 0 // 正確數字的個數
             * 3.5   for(i=0; i<4; ++i)
             *       {
             */
            //int N_STUDENTS = 3;
            //string[] registerNumber = new string[N_STUDENTS];
            //registerNumber[0] = "B645330";
            //registerNumber[1] = "B645333";
            //registerNumber[2] = "B645332";
            //int[] score = new int[N_STUDENTS];
            //score[0] = 88;
            //score[1] = 92;
            //score[2] = 86;
            //Array.Sort(score, registerNumber);
            //Array.Reverse(registerNumber);
            //Array.Reverse(score);
            //Console.WriteLine("名次 \t 學號 \t 成績");
            //for (int k = 0; k < N_STUDENTS; ++k)
            //{
            //Console.WriteLine(
            //(k + 1) + "\t" + registerNumber[k] + "\t" + score[k]);
            //}

            // ArrayAssignmentAndCopy片段(1/2)

            //int seed = 123;
            //Random rand = new Random(seed);
            //const int N = 10;
            //int[] a = new int[N];
            //for (int k = 0; k < N; ++k)
            //{
            //    a[k] = rand.Next() % 10;
            //}
            //// 陣列直接設質的副作用:以偵錯去觀察b和a 的變化
            //int[] b = a;
            //Array.Sort(b); //a 已隨b改變

            //// ArrayAssignmentAndCopy片段(1/2)
            //// 陣列複製的效果:以偵錯器觀察c和a的變化
            //int[] c = new int[N];
            //for (int k = 0; k < N; ++k)
            //{
            //    c[k] = a[k];
            //}
            //Array.Reverse(c); //a 不隨c倒轉

            //// 陣列複製的效果:以偵錯器觀察d和a的變化
            //int[] d = new int[N];
            //Array.Copy(a, d, N);
            //Array.Reverse(d); //a 不隨d倒轉

            // Array2D.Program片段

            //// 寫法1.
            //const int N_STUDENTS = 3;
            //const int N_SUBJECTS = 2;
            //string[] registerNumber = new string[N_STUDENTS];
            //registerNumber[0] = "B645330";
            //registerNumber[1] = "B645331";
            //registerNumber[2] = "B645333"; 
            //string[] subject = new string[N_STUDENTS];
            //subject[0] = "計算機概論";
            //subject[1] = "計算機程式設計";
            //int[,] score = new int[N_STUDENTS, N_SUBJECTS];

            //score[0, 0] = 90;
            //score[0, 1] = 84;
            //score[1, 0] = 88;
            //score[1, 1] = 86;
            //score[2, 0] = 86;
            //score[2, 1] = 92;
            //double[] individualAverage = new double[N_STUDENTS];
            //double[] subjjectAverrage = new double[N_SUBJECTS];

            //for(int i = 0; i < N_STUDENTS; i++)
            //{
            //    int sum = 0;
            //    for(int j = 0; j < N_SUBJECTS; j++)
            //    {
            //        sum+=score[i,j];
            //    }
            //    individualAverage[i] = (double)sum / N_SUBJECTS;
            //}

            // 寫法2.

            //string[] registerNumber =
            //{
            //    "B645330","B645331","B645332"
            //};
            //int[,] score = { { 90, 84 }, { 88, 86 }, { 86, 92 } };
            //int nStudents = score.GetUpperBound(0) + 1;
            //int nSubjects = score.GetUpperBound(1) + 1;
            //double[] individualAverage=new double[nStudents];
            //double[] subjectAverage = new double[nSubjects];
            //Console.WriteLine("學號\\科目\t計算機概論\t計算機程式設計\t兩科平均成績");
            //for(int i = 0; i < nStudents; ++i)
            //{
            //    Console.Write(registerNumber[i] + " \t");
            //    for(int j=0;j<nSubjects; ++j)
            //    {
            //        Console.Write(score[i, j] + "\t\t");

            //    }
            //    Console.WriteLine("{0:F2}",individualAverage[i]); //F2意思為止取小數第二位
            //}
        }
    }
}

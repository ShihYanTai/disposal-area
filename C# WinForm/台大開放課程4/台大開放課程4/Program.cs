using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics

namespace 台大開放課程4
{
    internal class Program
    {
        static void PassArrayElementByValue(int x)
        {
            x*=2;
        }
        static void PassArrayElementByReference(ref int x)
        {
            x *= 2;
        }

        static void PassArrayElementAsOutParameter(out int x)
        {
            x = 3;
        }

        static void PassArrayByValue(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= 2;
            }
            a =new int[] {7,8,9};
        }

        static void PassArrayByReference(ref int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= 2;
            }
            a = new int[] { 7, 8, 9 };
        }

        static void PassArrayAsOutParameter(out int[] a)
        {
            a = new int[] { 1,2,3,4,5};
        }

        static void Main(string[] args)
        {
            int[] p = {1,2,3,4,5};
            int[] pCopy = p;

            PassArrayElementByValue(p[2]);
            PassArrayElementByReference(ref p[2]);
            PassArrayElementAsOutParameter(out p[2]);
            PassArrayByValue(p);
            Debug.Assert(p ==pCopy);
            PassArrayByReference(ref p);
            Debug.Assert(p !=pCopy);
            PassArrayAsOutParameter(out p);

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1(ref int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= 2;
            }
            a = new int[] { 7, 8, 9 };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Form);
            PropertyInfo[] pInfos = myType.GetProperties();
            MethodInfo[] mInfos = myType.GetMethods();
            foreach (var m in mInfos)
            {
                Console.WriteLine(m.Name);
            }
        }
    }
}

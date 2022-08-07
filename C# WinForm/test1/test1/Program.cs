using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "三月,四月,五月,六月,98637,18456654,245663245,135436";
            string[] sAry = data.Split(',');
            string[] title = new string[4];
            Array.Copy(sAry, title, 4);
            string[] incoming = new string[4];
            Array.Copy(sAry, 4, incoming, 0, 4);
            double total = 0;
            for(int i = 0; i < title.Length; i++)
            {
                Console.WriteLine($"{title[i]} 營業額為 {incoming[i]} 元");
                total +=double.Parse(incoming[i]);
            }
            Console.WriteLine($"營業合計{total} 元");
            Console.ReadLine();
        }
    }
}

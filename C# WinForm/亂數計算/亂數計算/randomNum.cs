using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 亂數計算
{
    internal class randomNum
    {
        int[] numbers;
        ~randomNum() { }
        public randomNum(int num = 10)
        {
            numbers = new int[num];
        }
        public void genNumbers()
        {
            Random rd = new Random();
            for(int i = 0; i < numbers.Length; i++) numbers[i] = rd.Next(1,101);
        }
        public void Show(TextBox tb)
        {
            foreach (var v in numbers) tb.AppendText(v.ToString() + "\r\n");
        }

    }
}

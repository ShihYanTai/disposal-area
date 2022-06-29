using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 時鐘
{
    internal class Program
    {
        class Clock

            private int hour = 0; // 0~ 23
            private int minute = 0; // 0~59
            private int second = 0; // 0~59

            private void SetValues(int h, int m, int s)
            {
                hour = h;
                minute = m; 
                second = s;
            }

            public void GetTime(out int h, out int m, out int s)
            {
                h = hour;
                m = minute;
                s = second;
            }

            public void SetTime(int h, int m, int s)
            {
                SetValues(h, m, s);
            }
            // 上下午制
            public void SetTime(int h, int m, int s, string aAMPM)
            {
                SetValues(h, m, s);
                if (aAMPM == "PM" && h != 12) hour += 12;
            }

        static void Main(string[] args)
        {
            Clock c = new Clock();
            c.SetTime(22, 40, 23);
            c.Tick();
            c.GetTime(out h, out m, out s);
            Debug.Assert(h == 22 && m == 40 && s == 24);
            c.SetTime(11, 59, 59, "PM");
            c.Tick();
            string aAMPM;
            c.GetTime(out h, out m, out s, out aAMPM);
            Debug.Assert(h == 0 && m == 0 && 0 s == 0 && aAMPM == "AM");

        }
    }
}

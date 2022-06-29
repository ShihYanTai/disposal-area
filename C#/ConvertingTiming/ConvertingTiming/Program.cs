using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConvertingTiming
{
    internal class TimeConversion
    {
        private const int HOURS_PER_DAY = 24;
        private const int MINS_PER_HOUR = 60;
        public static int HoursToMins(int hours)
        {
            return hours * MINS_PER_HOUR;
        }

        public static int DaysToHours(int days)
        {
            return days * HOURS_PER_DAY;
        }
        static void Main(string[] args)
        {
            Debug.Assert(TimeConversion.HoursToMins(5) == 300);
            Debug.Assert(TimeConversion.DaysToHours(4) == 96);
            Console.Write("請輸入要轉換的小時數(整數): ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("請輸入要轉換的天數(整數): ");
            int days = int.Parse(Console.ReadLine());
            int hoursToMins = TimeConversion.HoursToMins(hours);
            int daysToHours = TimeConversion.DaysToHours(days);
        }
    }
}

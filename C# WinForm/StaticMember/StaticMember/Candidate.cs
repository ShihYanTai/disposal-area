using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMember
{
    internal class Candidate
    {
        public string Name { get; set; }    // 候選人姓名(自動屬性實作)
        public static int num;              // 紀錄累計登記人數(私用靜態欄位成員)
        public static int Num
        {
            get { return num; }
        }
        public Candidate()
        {
            num++;
        }
        public Candidate(string Vname)
        {
            Name = Vname;
            num++;
        }
        public static string Msg()
        {
            return $"目前登記總人數 : {num} 人";
        }
    }
}

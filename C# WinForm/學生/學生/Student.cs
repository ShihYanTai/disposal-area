using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 學生
{
    internal class Student
    {
        // Property
        public int StudentID;
        public string Name;
        public int Grade;

        public int Score;
        public static int PassScore = 60;

        // Method
        // public output型別 method名稱(input 型別與名稱)
        public Student(int studentID, string name)
        {
            StudentID = studentID;
            Name = name;
            Grade = 1;
        }

        public Student(int studentID, string name, int grade)
        {
            StudentID = studentID;
            Name = name;
            Grade = grade;
        }

    }
}

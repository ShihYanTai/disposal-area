using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> mystr = new List<string>();
            mystr.Add("Tom");
            mystr.Add("Mary");
            mystr.Add("John");
            mystr.Add("Kevin");
            mystr.Add("Helen");
            foreach(string str in mystr)            // 顯示物件 mystr 內的所有資料
            {
                TxtString.Text += $"{mystr}\t\r\n";
            }

            List<double> mydouble = new List<double>();       // 建立處裡數值的物件
            mydouble.Add(262.52);                             // 物件 mydouble 加入數值資料
            mydouble.Add(-87);                             
            mydouble.Add(0.006);                             
            mydouble.Add(3.14158);                             
            mydouble.Add(-930000);
            foreach(double d in mydouble)
            {
                TxtDouble.Text += $"{d}\t\r\n";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GList<string> mystr = new GList<string>();          // 建立處裡字串型別的物件
            mystr.SaveToArray("Tom");
            mystr.SaveToArray("Mary");
            mystr.SaveToArray("John");
            mystr.SaveToArray("Kevin");
            mystr.SaveToArray("Helen");
            TxtString.Text = mystr.data();                      // 顯示物件 mystr 內所有資料

            GList<double> mydouble = new GList<double>();       // 建立可以處裡數值的物件
            mydouble.SaveToArray(67.4);                         // 物件 mydouble加入數值資料
            mydouble.SaveToArray(-85);
            mydouble.SaveToArray(0.000006);
            mydouble.SaveToArray(3.8455);
            mydouble.SaveToArray(-95284);
            TxtDouble.Text = mydouble.data();                   // 顯示物件 mydouble 內的所有資訊
        }
    }
}

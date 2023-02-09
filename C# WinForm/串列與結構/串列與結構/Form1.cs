using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 串列與結構
{
    public partial class Form1 : Form
    {
        struct Rect
        {
            public int w;
            public int h;
        }
        bool MyFinder(Rect rect)
        {
            if (rect.w * rect.h < 100) return true;
            else return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Rect> mylist, myFind1, myFind2;
            Predicate<Rect> myPredicate = MyFinder;
            mylist = new List<Rect>()
            {
                new Rect() { w = 10, h = 20},
                new Rect() { w = 8, h =10},
                new Rect() { w = 15, h =20},
                new Rect() { w = 10, h =7}
            };

            // 使用 add() 新增一筆資料
            mylist.Add(new Rect() { w = 11, h = 4 });

            // 使用 foreach 敘述顯示資料
            foreach(var item in mylist)
            {
                textBox1.AppendText(string.Format("x={0}, y={1}\r\n", item.w, item.h));
            }

            // 使用委派
            myFind1 = mylist.FindAll(myPredicate);
            textBox1.AppendText("--------------\r\n");
            foreach (var item in myFind1) textBox1.AppendText(String.Format("x = {0}, y = {1}\r\n", item.w, item.h));

            // 使用lamdba 運算式
            textBox1.AppendText("----使用 lambda --- \r\n");
            myFind2 = mylist.FindAll(x => (x.w * x.h) < 100);
            foreach (var item in myFind2) textBox1.AppendText(String.Format("x = {0}, y = {1} \r\n", item.w, item.h));
        }
    }
}

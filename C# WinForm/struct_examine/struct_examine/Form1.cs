using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace struct_examine
{
    public partial class Form1 : Form
    {
        enum PEOPLE { John, Mary, Leo};     // 三個摘水果的人
        struct _FRUIT
        {
            int guava;
            int tomato;
            int orange;

            public _FRUIT(int gu = 0, int to = 0, int or = 0)
            {
                guava = gu;
                tomato = to;
                orange = or;
            }
            public void add(int gu = 0, int to = 0, int ro = 0)
            {
                guava = gu;
                tomato = to;
                orange = ro;
            }
            public int getTotal()
            {
                return guava + tomato + orange;
            }
            public int getGuava()
            {
                return guava;
            }
            public int getTomato()
            {
                return tomato;
            }
            public int getOrange()
            {
                return orange;
            }
        }
        struct _ORCHARD
        {
            _FRUIT[] fruit;
            public _ORCHARD(int peo = 1)
            {
                if(peo < 1) peo = 1;
                fruit = new _FRUIT[peo];
            }
            public void add(PEOPLE no, int gu, int to, int ro)
            {
                fruit[(int)no].add(gu, to, ro);
            }
            public void getFruit(PEOPLE no, ref int total)
            {
                total = fruit[(int)no].getTotal();
            }
            public int countGuava()
            {
                int num = 0;
                for (int i = 0; i < fruit.Length; i++) num += fruit[i].getGuava();
                return num;
            }
            public int countTomato()
            {
                int num = 0;
                for (int i = 0; i < fruit.Length; i++) num += fruit[i].getTomato();
                return num;
            }
            public int countOrange()
            {
                int num = 0;
                for (int i = 0; i < fruit.Length; i++) num += fruit[i].getOrange();
                return num;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ORCHARD orchard = new _ORCHARD(3);
            int gu, to, ro;
            int total = 0;
            string strPeo = "", strFru = "";

            gu = Convert.ToInt32(textBox1.Text);
            to = Convert.ToInt32(textBox2.Text);
            ro = Convert.ToInt32(textBox3.Text);
            orchard.add(PEOPLE.John, gu, to, ro);
            orchard.getFruit(PEOPLE.John, ref total);
            strPeo = String.Format("{0}一共摘了{1}水果,\r\n", PEOPLE.John, total);
            gu = Convert.ToInt32(textBox4.Text);
            to = Convert.ToInt32(textBox5.Text);
            ro = Convert.ToInt32(textBox6.Text);
            orchard.add(PEOPLE.Mary, gu, to, ro);
            orchard.getFruit(PEOPLE.Mary, ref total);
            strPeo += String.Format("{0}一共摘了{1}水果,\r\n", PEOPLE.Mary, total);
            gu = Convert.ToInt32(textBox7.Text);
            to = Convert.ToInt32(textBox8.Text);
            ro = Convert.ToInt32(textBox9.Text);
            orchard.add(PEOPLE.Leo, gu, to, ro);
            orchard.getFruit(PEOPLE.Leo, ref total);
            strPeo += String.Format("{0}一共摘了{1}水果,\r\n", PEOPLE.Leo, total);
            strFru = String.Format("芭樂共摘了{0}個，番茄共摘了{1}個，柳丁共摘了{2}個", orchard.countGuava(), orchard.countTomato(), orchard.countOrange());
            textBox10.AppendText(strPeo);
            textBox10.AppendText(strFru);
        }
    }
}

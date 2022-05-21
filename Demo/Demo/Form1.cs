using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player p = new Player("勇者");
            Monster m = new Monster("史萊姆");
            Villager v = new Villager("歐比王");

            Creature c = m;

            string message = c.move();
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int power = 100; // 攻擊力

            Random random = new Random();

            int injured = random.Next(power / 2, power); // 受到傷害

            MessageBox.Show("小山受到傷害 " + injured + " 點! ");
        }
    }
}

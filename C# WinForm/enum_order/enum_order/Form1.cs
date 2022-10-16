using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enum_order
{
    public partial class Form1 : Form
    {
        enum days { Mondy = 4, Tuesday = 3, Wednesday = 5, Thursday = 7, Friday = 2, Saturday = 6, Sunday = 8 };
        int hour = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) hour += (int)days.Mondy;
            else hour -= (int)days.Mondy;
            label2.Text = "本週上班時數 = " + hour.ToString() + ", 薪資 = " + (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked) hour +=(int)days.Tuesday;
            else hour -= (int)days.Tuesday;
            label2.Text = "本週上班時數 = " + hour.ToString() + ", 薪資 = " + (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) hour += (int)days.Wednesday;
            else hour -= (int)days.Wednesday;
            label2.Text = "本週上班時數 = " + hour.ToString() + ", 薪資 = " + (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) hour += (int)days.Thursday;
            else hour -= (int)days.Thursday;
            label2.Text = "本週上班時數 = " + hour.ToString() + ", 薪資 = " + (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) hour += (int)days.Friday;
            else hour -= (int)days.Friday;
            label2.Text = "本週上班時數 = " + hour.ToString() + ", 薪資 = " + (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked) hour +=(int)days.Saturday;
            else hour -= (int)days.Saturday;
            label2.Text = "本週上班時數 = " + hour.ToString() + ", 薪資 = " + (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked) hour += (int)days.Sunday;
            else hour -= (int)days.Sunday;
            label2.Text = "本週上班時數 = " + hour.ToString() + ", 薪資 = " + (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }
    }
}

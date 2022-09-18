using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinosaur_warrior
{
    public partial class Form6 : Form
    {
        int[] score = new int[5];               // 儲存 5 個成績
        bool fgOK = true;                       // 輸入的成績是否正確
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[0] = Convert.ToInt32(textBox1.Text);
                fgOK = true;                                 // 可以順利轉成整數
                if (score[0] < 60)                           // 不及格以紅色顯示
                    textBox1.ForeColor = Color.Red;
                else                                         // 及格以黑色顯示
                    textBox1.ForeColor = Color.Black;
            }
            catch
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[1] = Convert.ToInt32(textBox1.Text);
                fgOK = true;                                 // 可以順利轉成整數
                if (score[0] < 60)                           // 不及格以紅色顯示
                    textBox1.ForeColor = Color.Red;
                else                                         // 及格以黑色顯示
                    textBox1.ForeColor = Color.Black;
            }
            catch
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[2] = Convert.ToInt32(textBox1.Text);
                fgOK = true;                                 // 可以順利轉成整數
                if (score[0] < 60)                           // 不及格以紅色顯示
                    textBox1.ForeColor = Color.Red;
                else                                         // 及格以黑色顯示
                    textBox1.ForeColor = Color.Black;
            }
            catch
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[3] = Convert.ToInt32(textBox1.Text);
                fgOK = true;                                 // 可以順利轉成整數
                if (score[0] < 60)                           // 不及格以紅色顯示
                    textBox1.ForeColor = Color.Red;
                else                                         // 及格以黑色顯示
                    textBox1.ForeColor = Color.Black;
            }
            catch
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[4] = Convert.ToInt32(textBox1.Text);
                fgOK = true;                                 // 可以順利轉成整數
                if (score[0] < 60)                           // 不及格以紅色顯示
                    textBox1.ForeColor = Color.Red;
                else                                         // 及格以黑色顯示
                    textBox1.ForeColor = Color.Black;
            }
            catch
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }
    }
}

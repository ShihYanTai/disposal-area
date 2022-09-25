using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 插入陣列資料
{
    public partial class Form1 : Form
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length, new_length;                     // 陣列長度,新的陣列長度
            int no;                                     // 使用者輸入的陣列插入位置
            int valㄝ, j;                               // 使用者輸入值
            int[] tmp;                                  // 暫存陣列

            length = array.Length;                      // 取得陣列長度

            no = Convert.ToInt32(textBox1.Text);
            val = Convert.ToInt32(textBox2.Text);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 刪除陣列元素
{
    public partial class Form1 : Form
    {
        int[] array = { 4, 12, 87, 45, 14, 13, 56, 9, 33, 6, 21, 8 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no = -1;                        // no = -1 表示沒有找到要刪除的值
            int val, j = 0;                     // 使用者輸入的值、臨時陣列的索引值
            int[] tmp;                          // 臨時使用的陣列
            int length, new_length;             // 原始的陣列長度、新的陣列長度
            
            if (textBox1.Text != "")
            {
                val = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                val = 0;
                
            }
            
            length = array.Length;              // 取得陣列的長度

            // 使用循序漸搜尋尋找要刪除的值
            for(int i = 0; i < length; i++)
            {
                if (array[i] == val)
                {
                    no = i;                     // 紀錄刪除的值在陣列裡的位置
                    textBox2.AppendText("原來陣列長度=" + array.Length.ToString() + "\r\n");
                    break;                      // 離開，不再繼續搜尋
                }
            }
            if(no == -1)
            {
                MessageBox.Show("沒有找到要刪除的值");

                return ;
            }
            // ------------------------------------------------------------------------
            textBox2.AppendText("原來陣列長度=" + array.Length.ToString() + "\r\n");
            new_length = length - 1;            // 新的陣列長度
            tmp = new int[new_length];          // 配置記憶體給臨時的陣列 tmmp

            // ------------------------------------------------------------------------
            for(int i = 0; i < length; i++)
            {
                if(i == 0)                      // 如遇到要刪除的那一筆資料則跳過
                {
                    continue;
                }
                tmp[i] = array[i];
                j++;                            // 陣列 tmp 的索引值加1
            }

            // -------------------------------------------------------------------------
            for(int i = 0; i < new_length; i++)
            {
                array[i] = tmp[i];
            }

            // 縮減陣列 array 的大小，以符合刪除後的陣列
            Array.Resize(ref array, new_length);
            foreach(var item in array)
            {
                textBox2.AppendText(item.ToString() + "\r\n");
            }
            textBox2.AppendText("陣列長度=" + array.Length.ToString() + "\r\n");
        }
    }
}

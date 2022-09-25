using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 生產動態控制
{
    public partial class Form1 : Form
    {
        TextBox tb = null;                      // 宣告 TextBox 型別的變數 tb
        Button btn = null;                      // 宣告 Button 型別的變數 btn
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb = new TextBox();                 // 透過 new 配置 TextBox 實體給tb
                                                // 設定tb 的位置
            tb.Location = new Point(25, button1.Location.Y + button1.Height + 10);
            tb.Text = "王小明";                // 設定 tb 的 text 屬性
            tb.Width = 150;
            this.Controls.Add(tb);              // 將 tb 加入表單Form1

            btn = new Button();                 // 透過new配置Button實體給btn
                                                // 設定btn的位置
            btn.Location =new Point(25, tb.Location.Y + tb.Height + 10);
            btn.Text = "Click me";              // 設定btn的text屬性
            btn.AutoSize = true;                // 設定tb的AutoSize屬性
            this.Controls.Add(btn);             // 將btn加入表單Form1
            btn.Click += MyClick;               // 設定自訂函式MyClick給btn的Click事件
        }
        private void MyClick(Object sender, EventArgs e)
        {
            MessageBox.Show("Hello, 動態按鈕");
            this.Controls.Remove(tb);           // 移除 tb 控制項
        }
    }
}

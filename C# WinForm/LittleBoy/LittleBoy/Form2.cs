using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleBoy
{
    public partial class Form2 : Form
    {
        bool fg;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            fg = true;
            while(fg == true)
            {
                i++;
                label1.Text = i.ToString();
                if (i == 10000)     // i 值等於10000
                    i = 0;          // 就將i值歸0

                Application.DoEvents(); // 讓表單能收到訊息 (表單會執行 1個Thread 執行此不會因此等待)

                ///備註/// 
                ///當您執行 Windows Form 時，它會建立新的表單，然後等候事件進行處理。 
                ///每次表單處理事件時，都會處理與該事件相關聯的所有程式碼。 
                ///所有其他事件都會在佇列中等候。 
                ///當您的程式碼處理事件時，您的應用程式不會回應。 
                ///例如，如果另一個視窗拖曳到頂端，則視窗不會重新繪製。
                ///如果您在程式碼中呼叫 DoEvents ，您的應用程式可以處理其他事件。 
                ///例如，如果您有一個將資料新增至 的表單，並新增 DoEvents 至 ListBox 您的程式碼，則當另一個視窗拖曳到另一個視窗時，
                ///您的表單會重新繪製。 如果您從程式碼中移除 DoEvents ，表單將不會重新繪製，直到按鈕的 click 事件處理常式完成執行為止。
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            fg = false;
        }
    }
}

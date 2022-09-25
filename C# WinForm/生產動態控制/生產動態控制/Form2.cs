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
    public partial class Form2 : Form
    {
        Button btn1 = null;
        Button btn2 = null;
        
        public Form2()
        {
            InitializeComponent();
            btn1 = new Button();
            btn2 = new Button();

            btn1.Location = new Point(25, button1.Location.Y + button1.Height + 10);
            btn2.Location = new Point(25, btn1.Location.Y + btn1.Height + 10);
            btn1.Text = "btn1";
            btn2.Text = "btn2";
            btn1.Width = 150;
            btn2.Width = 150;
            this.Controls.Add(btn1);
            this.Controls.Add(btn2);



        }
        private void Timer(object sender, EventArgs args)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            label1.Text = DateTime.Now.ToLongTimeString(); 
        }
    }
}

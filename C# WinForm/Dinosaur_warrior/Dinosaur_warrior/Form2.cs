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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
        }
        private System.Timers.Timer _TimersTimer;
        private void Form2_Load(object sender, EventArgs e)
        {
            this._TimersTimer = new System.Timers.Timer();
            this._TimersTimer.Interval = 100;
            this._TimersTimer.Elapsed += new System.Timers.ElapsedEventHandler(_TimersTimer_Elapsed);
            this._TimersTimer.SynchronizingObject = this;
            this._TimersTimer.Start();
        }
        void _TimersTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
        }
    }
}

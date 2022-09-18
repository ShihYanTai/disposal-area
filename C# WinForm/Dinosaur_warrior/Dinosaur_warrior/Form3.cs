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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private System.Timers.Timer _TimersTimer;

        private void Timer22_f_Load(object sender, EventArgs e)
        {
            this._TimersTimer = new System.Timers.Timer();
            this._TimersTimer.Interval = 100;
            this._TimersTimer.Elapsed += new System.Timers.ElapsedEventHandler(_TimersTimer_Elapsed);
            this._TimersTimer.Start();
        }

        private void Timer22_f_FormClosed(object sender, FormClosedEventArgs e)
        {
            _TimersTimer.Stop();//如果不停的話,timer會繼續跑而且找不到label就會出錯            
        }

        delegate void UpdateControl1(string Msg);
        private object _objLock1 = new object();
        void _mUpdateControl(string Msg)
        {
            lock (this._objLock1)
            {
                label1.Text = Msg;
            }
        }

        void _TimersTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            int iVal = (int.Parse(label1.Text) + 1);
            this.BeginInvoke(
                new UpdateControl1(_mUpdateControl)//fuction
                , new object[] { iVal }//param
                );
        }
    }
}

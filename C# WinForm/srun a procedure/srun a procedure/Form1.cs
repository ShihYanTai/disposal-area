using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srun_a_procedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private void InitializeTimer()
        //{
        //    // Call this procedure when the application starts.  
        //    // Set to 1 second.  
        //    Timer1.Interval = 1000;
        //    Timer1.Tick += new EventHandler(Timer1_Tick);

        //    // Enable timer.  
        //    Timer1.Enabled = true;

        //    Button1.Text = "Stop";
        //    Button1.Click += new EventHandler(Button1_Click);
        //}

        //private void Timer1_Tick(object Sender, EventArgs e)
        //{
        //    // Set the caption to the current time.  
        //    Label1.Text = DateTime.Now.ToString();
        //}

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    if (Button1.Text == "Stop")
        //    {
        //        Button1.Text = "Start";
        //        Timer1.Enabled = false;
        //    }
        //    else
        //    {
        //        Button1.Text = "Stop";
        //        Timer1.Enabled = true;
        //    }
        //}

        // This variable will be the loop counter.  
        private int counter;

        private void InitializeTimer()
        {
            // Run this procedure in an appropriate event.  
            counter = 0;
            timer1.Interval = 600;
            timer1.Enabled = true;
            // Hook up timer's tick event handler.  
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (counter >= 10)
            {
                // Exit loop code.  
                timer1.Enabled = false;
                counter = 0;
            }
            else
            {
                // Run your procedure here.  
                // Increment counter.  
                counter = counter + 1;
                label1.Text = "Procedures Run: " + counter.ToString();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}

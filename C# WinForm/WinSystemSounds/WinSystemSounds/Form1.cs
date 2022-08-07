using System;
using System.Windows.Forms;
using System.Media;

namespace WinSystemSounds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "請輸入額溫(可至小數)";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(TxtInput.Text);
                if(tmp < 35)
                {
                    SystemSounds.Question.Play();
                    LblMsg.Text = "額溫過低請重新測量!";
                }
                else if (tmp > 37)
                {
                    SystemSounds.Beep.Play();
                    LblMsg.Text = "額溫過高!不能進入!";

                }
                else
                {
                    LblMsg.Text = "額溫正常!歡迎參觀!";
                }
            }
            catch(Exception ex)
            {
                SystemSounds.Asterisk.Play();
                LblMsg.Text = "輸入資料不正確!";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtScore_TextChanged(object sender, EventArgs e)
        {
            if(TxtScore.Text != "")
            {
                try
                {
                    int keyin = int.Parse(TxtScore.Text);
                    CStudent student = new CStudent();
                    LblPass.Text = $"分數 : {student.Pass(keyin)}";
                    LblLevel.Text = $"評語 : {student.Level(keyin)}";
                }
                catch
                {
                    MessageBox.Show("請輸入整數值!", "錯誤");
                }
            }
        }
    }
}

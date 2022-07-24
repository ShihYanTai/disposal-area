using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticMember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblNo.Text = "";
            LblTot.Text = "";
            LblTot.Text = Candidate.Msg();      // 不能使用 person.Msg
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Candidate person = new Candidate();
            person.Name = TxtName.Text;
            LblNo.Text = $"第{Candidate.Num} 個候選人姓名 : {person.Name}";
            LblTot.Text = Candidate.Msg();      // 不能使用 person.Num 與 person.Msg
            BtnAdd.Enabled = false;
        }

        private void BtnCls_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            BtnAdd.Enabled = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

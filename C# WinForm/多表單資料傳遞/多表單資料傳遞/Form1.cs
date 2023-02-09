using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多表單資料傳遞
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 設定 button1 為OK
            button1.DialogResult = DialogResult.OK;
            // 設定 button2 為Cancel
            button2.DialogResult = DialogResult.Cancel;
        }
    }
}

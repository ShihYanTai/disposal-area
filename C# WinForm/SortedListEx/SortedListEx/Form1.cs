using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortedListEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SortedList SLScore;                 // 宣告 SortedList 類別物件 SLScore
        private void Form1_Load(object sender, EventArgs e)
        {
            SLScore = new SortedList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!(TxtName.Text == "" || TxtScore.Text == ""))           // 文字方塊有內容
            {
                if (SLScore.ContainsKey(TxtName.Text) == true)
                {
                    MessageBox.Show($"{TxtName.Text}資料已存在，不能重複加入!");
                }
                else
                {
                    SLScore.Add(TxtName.Text, TxtScore.Text);
                    TxtName.Text = "";
                    TxtScore.Text = "";

                    TxtBrows.Text = "目前資料 : \r\n";
                    foreach(DictionaryEntry de in SLScore)
                    {
                        TxtBrows.Text += $"Key={de.Key}\t Value={de.Value}\r\n";
                    }
                }
            }
        }
    }
}

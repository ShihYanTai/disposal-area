using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserRecord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct UserRec           // 宣告 UserRec 結構，內含三個成員
        {
            public string passwd, tel;  // 密碼、電話成員皆為 string 型別
            public bool sex;            // 性別成員為 bool 型別
        }
        UserRec rec;                    // 建立 UserRec 結構型別的變數 rec
        Dictionary<string, UserRec> userDict;// 宣告 Dictionary 類別物件
        private void Form1_Load(object sender, EventArgs e)
        {
            // 建立 Dictionary 類別物件 userDict 來存放使用者資料
            userDict = new Dictionary<string, UserRec>();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            rec.passwd = TxtPW.Text;                        // 指派結構變數 rec 成員變數
            if (RdbMale.Checked)
                rec.sex = true;
            else
                rec.sex = false;
            rec.tel = TxtTel.Text;
            userDict.Add(TxtName.Text, rec);                // 加入第一筆資料到 UserDict 物件中
            TxtName.Text = "";
            TxtPW.Text = "";
            TxtTel.Text = "";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string name, pw, msg;
            name = TxtInNa.Text;
            pw = TxtInPW.Text;
            if (!userDict.ContainsKey(name))                // 若 userDict 物件索引鍵不包含該姓名
                MessageBox.Show("查無此人");
            else
            {
                if (userDict[name].passwd == pw)
                {
                    msg = $"姓名 : {name} \r\n";
                    if (userDict[name].sex) msg += "性別 : 男 \r\n";
                    else msg += "性別 : 女 \r\n";
                    msg += $"密碼 : {pw} \r\n";
                    msg += $"電話 : {userDict[name].tel}";
                    MessageBox.Show(msg,"使用者資料");
                }
                else
                {
                    MessageBox.Show("密碼錯誤!");
                };
            }
        }

        private void BtnBrows_Click(object sender, EventArgs e)
        {
            string fm = "";
            TxtBrows.Text = "姓名 \t 性別 \r\n";
            TxtBrows.Text += "=======\t====\r\n";
            foreach(KeyValuePair<string, UserRec> kc in userDict)
            {
                if (kc.Value.sex) fm = "男";
                else fm = "女";
                TxtBrows.Text += $"{kc.Key}\t{fm}\r\n";
            }
        }
    }
}

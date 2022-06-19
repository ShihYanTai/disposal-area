using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDown_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] PicFire = new PictureBox[10];  // 宣告圖片控制對話項陣列
        private void Form1_Load(object sender, EventArgs e)
        {
            PicTank.Image = Image.FromFile("tank.png"); // 載入圖片
            PicTank.SizeMode = PictureBoxSizeMode.AutoSize;

            for(int i = 0;i < 10; i++)
            {
                PicFire[i] = new PictureBox();   // 建立物件
                PicFire[i].Size = new Size(6, 3); // 設定砲彈大小
                PicFire[i].BackColor = Color.Red;   // 砲彈顏色
                PicFire[i].Visible = false;         // 預設砲彈不可見
                this.Controls.Add(PicFire[i]);      // 將砲彈加入表單
            }
            timer1.Start();                 // 啟動計時器
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // 在表單的KeyDown事件中
            switch (e.KeyCode)              // 根據 e.KeyCode 分別執行
            {
                case Keys.Up:               // 若按向上鍵
                    PicTank.Top -= 5;       // 上移5點
                    break;
                case Keys.Down:
                    PicTank.Top += 5;       // 下移5點
                    break;
                case Keys.Space:           // 若按空白鍵
                    for(int i = 0;i < 10; i++)
                    {
                        if (PicFire[i].Visible == false)    // 若砲彈為不見
                        {
                            PicFire[i].Location = new Point(PicTank.Left + 16, 
                                PicTank.Top + 10);   // 設定砲彈位置為炮口位置
                            PicFire[i].Visible = true;  // 設定砲彈可見
                            break;  // 脫離迴圈
                        }
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0;i < 10; i++)
            {
                if(PicFire[i].Visible == true)
                {
                    PicFire[i].Left += 8;
                    if (PicFire[i].Left > 300) PicFire[i].Visible = false;
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar; 
            if(c<'A'|| c > 'Z') e.Handled = true;   // 檢查是否為非大寫字母,若非是大寫英文字母清除該字母，游標退回原處。
            char n = e.KeyChar;
            if (n < 65 || n > 90) e.Handled = true;  // 將按鍵字元鍵轉乘ASCII檢查非大寫字母，若不是退回原點。
        }
    }
}

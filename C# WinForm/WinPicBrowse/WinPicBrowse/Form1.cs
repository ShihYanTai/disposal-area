using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPicBrowse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;     // 設定 From1 為父表單
            // 設定篩選字串為只能為只能顯示 .jpg 、 .bmp 、 .gif 和 .png
            openFileDialog1.Filter = "JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|PNG|*.png";
        }

        private void MnuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FrmPic FPic = new FrmPic();             // 宣告 FPic 為表單實體
                    FPic.MdiParent = this;                  // 指定 parent 表單
                    FPic.Text = openFileDialog1.FileName;   // 設定子表單標題文字
                    // 子表單背景圖指定為開檔對話框指定的檔案
                    FPic.BackgroundImage=Image.FromFile(openFileDialog1.FileName);
                    FPic.Show();
                }catch (Exception ex)
                {
                    MessageBox.Show("請選取適當格式的圖檔", "注意");
                }
            }
        }

        private void MnuSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "jpg";     // 預設副檔名 .jpg
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form ActForm = this.ActiveMdiChild;
                ActForm.BackgroundImage.Save(saveFileDialog1.FileName);
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

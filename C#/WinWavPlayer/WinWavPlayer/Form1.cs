using System;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace WinWavPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            //String StFilter = "WAV(*.wav)|*.wav";
            //openFileDialog1.Filter = StFilter;
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|WAV(*.wav)|*.wav";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                TxtPath.Text = openFileDialog1.FileName;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer Player1 = new SoundPlayer();        // 建立播放物件
            Player1.SoundLocation = TxtPath.Text;           // 指定音效所在路徑檔名
            Player1.Load();
            Player1.Play();
        }

        private void BtnLoop_Click(object sender, EventArgs e)
        {
            SoundPlayer Player2 = new SoundPlayer(TxtPath.Text);        // 使用完整檔名建立物件
            Player2.PlayLooping();                                      // 重複播放
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            FileStream FIn = new FileStream(TxtPath.Text, FileMode.Open);
            SoundPlayer Player3 = new SoundPlayer(TxtPath.Text);        // 使用檔案串流建立物件
            Player3.Stop();                                             // 停止播放
            FIn.Close();                                                // 關閉串流
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

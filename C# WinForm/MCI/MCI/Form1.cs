using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MCI
{
    public partial class Form1 : Form
    {
        public enum psFlags { SYNC=0,ASYNC=1,NODEFAULT=2,LOOP=3};
        [DllImport("winmm.dll")]
        public static extern bool PlaySound(string Filename, int Mod, psFlags psFlags);
        [DllImport("winmm.dll")]
        static extern long mciSendString(string strCommand, string strReturn, int iReturnLength, IntPtr hwndCallback);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog1 = new OpenFileDialog();
            dialog1.Title = "選擇檔案";
            dialog1.InitialDirectory = Application.StartupPath;
            dialog1.Filter = "Wav Files (*.wav)|*.wav";
            if (dialog1.ShowDialog() == DialogResult.OK) PlaySound(dialog1.FileName, 0, psFlags.ASYNC);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlaySound(null, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strCommand = "play a.mp3";
            mciSendString(strCommand, null, 0, IntPtr.Zero);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "開始錄音") 
            {
                mciSendString("open new type WAVEAudio alias waveFile", "", 0, IntPtr.Zero);
                mciSendString("record waveFile", "", 0, IntPtr.Zero);
                button4.Text = "停止錄音";
            }
            else
            {
                string str = Application.StartupPath + @"\record.wav";
                mciSendString("stop waveFile", null, 0, IntPtr.Zero);
                mciSendString("save waveFile" + str, "", 0, IntPtr.Zero);
                mciSendString("close waveFile", null, 0, IntPtr.Zero);
                button4.Text = "開始錄音";
            }
        }
    }
}

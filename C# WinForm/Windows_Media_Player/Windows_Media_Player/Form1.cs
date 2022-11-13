using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;
using System.Windows.Forms.Design;

namespace Windows_Media_Player
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp;         // 只限播放 wav
            sp = new SoundPlayer();
            sp.SoundLocation = "c.wav";
            sp.Play();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = "b.mp3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            wmp.URL = "a.mp3";
            wmp.controls.play();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
        }
    }
}

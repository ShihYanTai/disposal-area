using System.IO;
using WMPLib;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;

namespace WMP
{
    public partial class Form1 : Form
    {
        enum PROCESS_DPI_AWARENESS
        {
            PROCESS_DPI_UNAWARE = 0,
            PROCESS_SYSTEM_DPI_AWARE = 1,
            PROCESS_PER_MONITOR_DPI_AWARE = 2
        }
        [DllImport("shcore.dll")]
        static extern int SetProcessDpiAwareness(PROCESS_DPI_AWARENESS v);
        public Form1()
        {
            InitializeComponent();
            if(Environment.OSVersion.Version.Major >= 6) SetProcessDpiAwareness(PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE);
            axWindowsMediaPlayer1.uiMode = "none";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IWMPMedia info;
            openFileDialog1.Title = "選擇播放影片檔";
            openFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            openFileDialog1.Filter = "Video Files (*.wmv)|*.wmv|" + 
                                        "Video FIles (*.mp4)|*.mp4";
            if(openFileDialog1.ShowDialog() != DialogResult.OK) return;
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            hScrollBar1.Value = axWindowsMediaPlayer1.settings.volume;
            hScrollBar2.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            info = axWindowsMediaPlayer1.newMedia(axWindowsMediaPlayer1.URL);
            this.Text = Path.GetFileName(axWindowsMediaPlayer1.URL);
            hScrollBar2.Maximum = (int)info.duration;
            button2.Text = "播放";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentMedia == null) return;
            if (button2.Text == "播放")
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                button2.Text = "暫停";
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                button2.Text = "播放";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentMedia == null) return;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            button2.Text = "播放";
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if(axWindowsMediaPlayer1.currentMedia == null) return;
            axWindowsMediaPlayer1.settings.volume = hScrollBar1.Value;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (axWindowsMediaPlayer1.currentMedia == null) return;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = hScrollBar2.Value;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            int w, h;
            if (e.newState == (int)WMPLib.WMPOpenState.wmposMediaOpen)
            {
                w = axWindowsMediaPlayer1.currentMedia.imageSourceWidth;
                h = axWindowsMediaPlayer1.currentMedia.imageSourceHeight;
                this.Text += "," + w.ToString() + "x " + h.ToString();
            }
        }
    }
}

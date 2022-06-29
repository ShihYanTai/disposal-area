using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; //        指定視窗最大化
            WebViewer.Url = new Uri("https://www.google.com.tw");       // 指定瀏覽頁網址
            MnuMsg.Text = "";
        }

        private void MTsTxtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')       // 若輸入 Enter鍵時
            {
                if (!String.IsNullOrEmpty(MTsTxtUrl.Text))      // 若輸入網址
                {
                    webBrowser.Navigate(MTsTxtUrl.Text);        // 移到指定的網址
                }
            }
        }

        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            MnuMsg.Text = "網頁下載中...";
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            MTsTxtUrl.Text = WebViewer.Url.ToString();      // 將目前網頁的網址顯示在 TsTxtUrl 
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MnuMsg.Text = "網頁下載完成";
        }

        private void MunBack_Click(object sender, EventArgs e)
        {
            if(!WebViewer.GoBack())     // 回到上一頁
            {
                MessageBox.Show("已經到最前面", "注意", MessageBoxButtons.OK);
            }
            else
            {
                WebViewer.GoBack();
            }
        }

        private void MunForward_Click(object sender, EventArgs e)
        {
            if (!WebViewer.GoForward()) // 回到下一頁
            {
                MessageBox.Show("已經到最後面","注意",MessageBoxButtons.OK);
            }
            else
            {
                WebViewer.GoForward();
            }
        }

        private void MunRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();       // 用 refresh 方法重新整理網頁
        }

        private void MnuHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();        // 用 GoHome 回到首頁
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

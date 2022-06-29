namespace WebBrower
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.WebViewer = new System.Windows.Forms.WebBrowser();
            this.MnusWeb = new System.Windows.Forms.MenuStrip();
            this.MnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.MunBack = new System.Windows.Forms.ToolStripMenuItem();
            this.MunForward = new System.Windows.Forms.ToolStripMenuItem();
            this.MunRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MTsTxtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.MnuMsg = new System.Windows.Forms.ToolStripTextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.MnusWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebViewer
            // 
            this.WebViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebViewer.Location = new System.Drawing.Point(0, 31);
            this.WebViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebViewer.Name = "WebViewer";
            this.WebViewer.Size = new System.Drawing.Size(800, 419);
            this.WebViewer.TabIndex = 1;
            // 
            // MnusWeb
            // 
            this.MnusWeb.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnusWeb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuView,
            this.MnuExit,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.MTsTxtUrl,
            this.MnuMsg});
            this.MnusWeb.Location = new System.Drawing.Point(0, 0);
            this.MnusWeb.Name = "MnusWeb";
            this.MnusWeb.Size = new System.Drawing.Size(800, 31);
            this.MnusWeb.TabIndex = 0;
            this.MnusWeb.Text = "menuStrip1";
            // 
            // MnuView
            // 
            this.MnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MunBack,
            this.MunForward,
            this.MunRefresh,
            this.MnuHome});
            this.MnuView.Name = "MnuView";
            this.MnuView.Size = new System.Drawing.Size(53, 27);
            this.MnuView.Text = "檢視";
            // 
            // MunBack
            // 
            this.MunBack.Name = "MunBack";
            this.MunBack.Size = new System.Drawing.Size(224, 26);
            this.MunBack.Text = "上一頁";
            this.MunBack.Click += new System.EventHandler(this.MunBack_Click);
            // 
            // MunForward
            // 
            this.MunForward.Name = "MunForward";
            this.MunForward.Size = new System.Drawing.Size(224, 26);
            this.MunForward.Text = "下一頁";
            this.MunForward.Click += new System.EventHandler(this.MunForward_Click);
            // 
            // MunRefresh
            // 
            this.MunRefresh.Name = "MunRefresh";
            this.MunRefresh.Size = new System.Drawing.Size(224, 26);
            this.MunRefresh.Text = "重新整理";
            this.MunRefresh.Click += new System.EventHandler(this.MunRefresh_Click);
            // 
            // MnuHome
            // 
            this.MnuHome.Name = "MnuHome";
            this.MnuHome.Size = new System.Drawing.Size(224, 26);
            this.MnuHome.Text = "到首頁";
            this.MnuHome.Click += new System.EventHandler(this.MnuHome_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(53, 27);
            this.MnuExit.Text = "結束";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(27, 27);
            this.toolStripMenuItem2.Text = "|";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 27);
            this.toolStripMenuItem1.Text = "網址 : ";
            // 
            // MTsTxtUrl
            // 
            this.MTsTxtUrl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.MTsTxtUrl.Name = "MTsTxtUrl";
            this.MTsTxtUrl.Size = new System.Drawing.Size(400, 27);
            this.MTsTxtUrl.Text = "\"\"";
            this.MTsTxtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTsTxtUrl_KeyPress);
            // 
            // MnuMsg
            // 
            this.MnuMsg.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.MnuMsg.Name = "MnuMsg";
            this.MnuMsg.Size = new System.Drawing.Size(100, 27);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 31);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(800, 419);
            this.webBrowser.TabIndex = 2;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            this.webBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Navigating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.WebViewer);
            this.Controls.Add(this.MnusWeb);
            this.MainMenuStrip = this.MnusWeb;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MnusWeb.ResumeLayout(false);
            this.MnusWeb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser WebViewer;
        private System.Windows.Forms.MenuStrip MnusWeb;
        private System.Windows.Forms.ToolStripMenuItem MnuView;
        private System.Windows.Forms.ToolStripMenuItem MunBack;
        private System.Windows.Forms.ToolStripMenuItem MunForward;
        private System.Windows.Forms.ToolStripMenuItem MunRefresh;
        private System.Windows.Forms.ToolStripMenuItem MnuHome;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox MTsTxtUrl;
        private System.Windows.Forms.ToolStripTextBox MnuMsg;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}


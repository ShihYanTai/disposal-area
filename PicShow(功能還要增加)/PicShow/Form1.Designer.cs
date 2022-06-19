namespace PicShow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsBtnStart = new System.Windows.Forms.ToolStripButton();
            this.TsBtnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TsCboPic = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TsTxtMsg = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.LblMsg = new System.Windows.Forms.Label();
            this.PicPicture1 = new System.Windows.Forms.PictureBox();
            this.TmrMove = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnStart,
            this.TsBtnStop,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.TsCboPic,
            this.toolStripLabel2,
            this.TsTxtMsg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 401);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(525, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TextChanged += new System.EventHandler(this.toolStrip1_TextChanged);
            // 
            // TsBtnStart
            // 
            this.TsBtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsBtnStart.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnStart.Image")));
            this.TsBtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnStart.Name = "TsBtnStart";
            this.TsBtnStart.Size = new System.Drawing.Size(29, 24);
            this.TsBtnStart.Text = "開始";
            this.TsBtnStart.Click += new System.EventHandler(this.TsBtnStart_Click);
            // 
            // TsBtnStop
            // 
            this.TsBtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsBtnStop.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnStop.Image")));
            this.TsBtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnStop.Name = "TsBtnStop";
            this.TsBtnStop.Size = new System.Drawing.Size(29, 24);
            this.TsBtnStop.Text = "暫停";
            this.TsBtnStop.Click += new System.EventHandler(this.TsBtnStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabel1.Text = "圖片 : ";
            // 
            // TsCboPic
            // 
            this.TsCboPic.Items.AddRange(new object[] {
            "第一張",
            "第二張",
            "第三張",
            "第四張",
            "第五張",
            "第六張"});
            this.TsCboPic.Name = "TsCboPic";
            this.TsCboPic.Size = new System.Drawing.Size(121, 27);
            this.TsCboPic.SelectedIndexChanged += new System.EventHandler(this.TsCboPic_SelectedIndexChanged_1);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabel2.Text = "標題 : ";
            // 
            // TsTxtMsg
            // 
            this.TsTxtMsg.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.TsTxtMsg.Name = "TsTxtMsg";
            this.TsTxtMsg.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LblMsg);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.PicPicture1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(525, 376);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(525, 401);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("標楷體", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.Location = new System.Drawing.Point(28, 296);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(170, 47);
            this.LblMsg.TabIndex = 1;
            this.LblMsg.Text = "label1";
            // 
            // PicPicture1
            // 
            this.PicPicture1.Image = global::PicShow.Properties.Resources._6;
            this.PicPicture1.Location = new System.Drawing.Point(12, 3);
            this.PicPicture1.Name = "PicPicture1";
            this.PicPicture1.Size = new System.Drawing.Size(503, 371);
            this.PicPicture1.TabIndex = 0;
            this.PicPicture1.TabStop = false;
            // 
            // TmrMove
            // 
            this.TmrMove.Tick += new System.EventHandler(this.TmrMove_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 428);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsBtnStart;
        private System.Windows.Forms.ToolStripButton TsBtnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Timer TmrMove;
        private System.Windows.Forms.PictureBox PicPicture1;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.ToolStripTextBox TsTxtMsg;
        private System.Windows.Forms.ToolStripComboBox TsCboPic;
    }
}


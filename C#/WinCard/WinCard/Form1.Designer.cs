namespace WinCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.列印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.MnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtCom = new System.Windows.Forms.RichTextBox();
            this.TxtTitle = new System.Windows.Forms.RichTextBox();
            this.TxtName = new System.Windows.Forms.RichTextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFont,
            this.列印ToolStripMenuItem,
            this.MnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuFont
            // 
            this.MnuFont.Name = "MnuFont";
            this.MnuFont.Size = new System.Drawing.Size(53, 26);
            this.MnuFont.Text = "字型";
            this.MnuFont.Click += new System.EventHandler(this.MnuFont_Click);
            // 
            // 列印ToolStripMenuItem
            // 
            this.列印ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSetup,
            this.MnuPreview,
            this.MnuPrint});
            this.列印ToolStripMenuItem.Name = "列印ToolStripMenuItem";
            this.列印ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.列印ToolStripMenuItem.Text = "列印";
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(53, 24);
            this.MnuExit.Text = "結束";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Location = new System.Drawing.Point(254, 59);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(285, 175);
            this.PicLogo.TabIndex = 4;
            this.PicLogo.TabStop = false;
            // 
            // MnuSetup
            // 
            this.MnuSetup.Name = "MnuSetup";
            this.MnuSetup.Size = new System.Drawing.Size(224, 26);
            this.MnuSetup.Text = "列印格式";
            this.MnuSetup.Click += new System.EventHandler(this.MnuSetup_Click);
            // 
            // MnuPreview
            // 
            this.MnuPreview.Name = "MnuPreview";
            this.MnuPreview.Size = new System.Drawing.Size(224, 26);
            this.MnuPreview.Text = "預覽列印";
            this.MnuPreview.Click += new System.EventHandler(this.MnuPreview_Click);
            // 
            // MnuPrint
            // 
            this.MnuPrint.Name = "MnuPrint";
            this.MnuPrint.Size = new System.Drawing.Size(224, 26);
            this.MnuPrint.Text = "列印";
            this.MnuPrint.Click += new System.EventHandler(this.MnuPrint_Click);
            // 
            // TxtCom
            // 
            this.TxtCom.Font = new System.Drawing.Font("新細明體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtCom.Location = new System.Drawing.Point(37, 59);
            this.TxtCom.Name = "TxtCom";
            this.TxtCom.Size = new System.Drawing.Size(191, 51);
            this.TxtCom.TabIndex = 5;
            this.TxtCom.Text = "";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtTitle.Location = new System.Drawing.Point(38, 148);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(190, 66);
            this.TxtTitle.TabIndex = 6;
            this.TxtTitle.Text = "";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtName.Location = new System.Drawing.Point(37, 261);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(272, 74);
            this.TxtName.TabIndex = 7;
            this.TxtName.Text = "";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 371);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.TxtCom);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuFont;
        private System.Windows.Forms.ToolStripMenuItem 列印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuSetup;
        private System.Windows.Forms.ToolStripMenuItem MnuPreview;
        private System.Windows.Forms.ToolStripMenuItem MnuPrint;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.RichTextBox TxtCom;
        private System.Windows.Forms.RichTextBox TxtTitle;
        private System.Windows.Forms.RichTextBox TxtName;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}


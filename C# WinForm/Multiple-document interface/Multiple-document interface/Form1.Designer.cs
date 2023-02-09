namespace Multiple_document_interface
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.開新檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.讀取檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取得子表單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開新檔案ToolStripMenuItem,
            this.讀取檔案ToolStripMenuItem,
            this.儲存檔案ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem1.Text = "檔案";
            // 
            // 開新檔案ToolStripMenuItem
            // 
            this.開新檔案ToolStripMenuItem.Name = "開新檔案ToolStripMenuItem";
            this.開新檔案ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.開新檔案ToolStripMenuItem.Text = "開新檔案";
            this.開新檔案ToolStripMenuItem.Click += new System.EventHandler(this.開新檔案ToolStripMenuItem_Click);
            // 
            // 讀取檔案ToolStripMenuItem
            // 
            this.讀取檔案ToolStripMenuItem.Name = "讀取檔案ToolStripMenuItem";
            this.讀取檔案ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.讀取檔案ToolStripMenuItem.Text = "讀取檔案";
            this.讀取檔案ToolStripMenuItem.Click += new System.EventHandler(this.讀取檔案ToolStripMenuItem_Click);
            // 
            // 儲存檔案ToolStripMenuItem
            // 
            this.儲存檔案ToolStripMenuItem.Name = "儲存檔案ToolStripMenuItem";
            this.儲存檔案ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.儲存檔案ToolStripMenuItem.Text = "儲存檔案";
            this.儲存檔案ToolStripMenuItem.Click += new System.EventHandler(this.儲存檔案ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.取得子表單ToolStripMenuItem,
            this.水平ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 取得子表單ToolStripMenuItem
            // 
            this.取得子表單ToolStripMenuItem.Name = "取得子表單ToolStripMenuItem";
            this.取得子表單ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.取得子表單ToolStripMenuItem.Text = "取得子表單";
            this.取得子表單ToolStripMenuItem.Click += new System.EventHandler(this.取得子表單ToolStripMenuItem_Click);
            // 
            // 水平ToolStripMenuItem
            // 
            this.水平ToolStripMenuItem.Name = "水平ToolStripMenuItem";
            this.水平ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.水平ToolStripMenuItem.Text = "水平並排";
            this.水平ToolStripMenuItem.Click += new System.EventHandler(this.水平ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.png";
            this.openFileDialog1.Filter = "Png files(*.png)|*.png\";";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 開新檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 讀取檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取得子表單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


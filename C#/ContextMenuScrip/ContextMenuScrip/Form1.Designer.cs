namespace ContextMenuScrip
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMnuEdit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CMnuEdit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CMnuEdit3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.字型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFont1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFont2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSize = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSize1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSize2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSize3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSize4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStyle1 = new System.Windows.Forms.ToolStripMenuItem();
            this.粗體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStyle2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSet1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSet2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSet3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtW = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMnuEdit1,
            this.CMnuEdit2,
            this.CMnuEdit3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // CMnuEdit1
            // 
            this.CMnuEdit1.Name = "CMnuEdit1";
            this.CMnuEdit1.Size = new System.Drawing.Size(108, 24);
            this.CMnuEdit1.Text = "複製";
            // 
            // CMnuEdit2
            // 
            this.CMnuEdit2.Name = "CMnuEdit2";
            this.CMnuEdit2.Size = new System.Drawing.Size(108, 24);
            this.CMnuEdit2.Text = "貼上";
            // 
            // CMnuEdit3
            // 
            this.CMnuEdit3.Name = "CMnuEdit3";
            this.CMnuEdit3.Size = new System.Drawing.Size(108, 24);
            this.CMnuEdit3.Text = "剪下";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字型ToolStripMenuItem,
            this.MnuSize,
            this.MnuStyle1,
            this.MnuSet,
            this.MnuEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 字型ToolStripMenuItem
            // 
            this.字型ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFont1,
            this.MnuFont2});
            this.字型ToolStripMenuItem.Name = "字型ToolStripMenuItem";
            this.字型ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.字型ToolStripMenuItem.Text = "字型";
            // 
            // MnuFont1
            // 
            this.MnuFont1.Name = "MnuFont1";
            this.MnuFont1.Size = new System.Drawing.Size(152, 26);
            this.MnuFont1.Text = "新細明體";
            // 
            // MnuFont2
            // 
            this.MnuFont2.Name = "MnuFont2";
            this.MnuFont2.Size = new System.Drawing.Size(152, 26);
            this.MnuFont2.Text = "標楷體";
            // 
            // MnuSize
            // 
            this.MnuSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSize1,
            this.MnuSize2,
            this.MnuSize3,
            this.MnuSize4});
            this.MnuSize.Name = "MnuSize";
            this.MnuSize.Size = new System.Drawing.Size(53, 24);
            this.MnuSize.Text = "大小";
            // 
            // MnuSize1
            // 
            this.MnuSize1.Name = "MnuSize1";
            this.MnuSize1.Size = new System.Drawing.Size(110, 26);
            this.MnuSize1.Text = "9";
            // 
            // MnuSize2
            // 
            this.MnuSize2.Name = "MnuSize2";
            this.MnuSize2.Size = new System.Drawing.Size(110, 26);
            this.MnuSize2.Text = "12";
            // 
            // MnuSize3
            // 
            this.MnuSize3.Name = "MnuSize3";
            this.MnuSize3.Size = new System.Drawing.Size(110, 26);
            this.MnuSize3.Text = "20";
            // 
            // MnuSize4
            // 
            this.MnuSize4.Name = "MnuSize4";
            this.MnuSize4.Size = new System.Drawing.Size(110, 26);
            this.MnuSize4.Text = "24";
            // 
            // MnuStyle1
            // 
            this.MnuStyle1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.粗體ToolStripMenuItem,
            this.MnuStyle2});
            this.MnuStyle1.Name = "MnuStyle1";
            this.MnuStyle1.Size = new System.Drawing.Size(53, 24);
            this.MnuStyle1.Text = "樣式";
            // 
            // 粗體ToolStripMenuItem
            // 
            this.粗體ToolStripMenuItem.Name = "粗體ToolStripMenuItem";
            this.粗體ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.粗體ToolStripMenuItem.Text = "粗體";
            // 
            // MnuStyle2
            // 
            this.MnuStyle2.Name = "MnuStyle2";
            this.MnuStyle2.Size = new System.Drawing.Size(122, 26);
            this.MnuStyle2.Text = "斜體";
            // 
            // MnuSet
            // 
            this.MnuSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSet1,
            this.MnuSet2,
            this.MnuSet3});
            this.MnuSet.Name = "MnuSet";
            this.MnuSet.Size = new System.Drawing.Size(53, 24);
            this.MnuSet.Text = "設定";
            this.MnuSet.Click += new System.EventHandler(this.MnuSet_Click);
            // 
            // MnuSet1
            // 
            this.MnuSet1.Name = "MnuSet1";
            this.MnuSet1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.MnuSet1.Size = new System.Drawing.Size(214, 26);
            this.MnuSet1.Text = "預設值(U)";
            this.MnuSet1.Click += new System.EventHandler(this.MnuSet1_Click);
            // 
            // MnuSet2
            // 
            this.MnuSet2.Name = "MnuSet2";
            this.MnuSet2.Size = new System.Drawing.Size(214, 26);
            this.MnuSet2.Text = "較大字體";
            // 
            // MnuSet3
            // 
            this.MnuSet3.Name = "MnuSet3";
            this.MnuSet3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MnuSet3.Size = new System.Drawing.Size(214, 26);
            this.MnuSet3.Text = "結束(X)";
            // 
            // MnuEdit
            // 
            this.MnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEdit1,
            this.MnuEdit2,
            this.MnuEdit3});
            this.MnuEdit.Name = "MnuEdit";
            this.MnuEdit.Size = new System.Drawing.Size(53, 24);
            this.MnuEdit.Text = "編輯";
            // 
            // MnuEdit1
            // 
            this.MnuEdit1.Name = "MnuEdit1";
            this.MnuEdit1.Size = new System.Drawing.Size(224, 26);
            this.MnuEdit1.Text = "複製";
            // 
            // MnuEdit2
            // 
            this.MnuEdit2.Name = "MnuEdit2";
            this.MnuEdit2.Size = new System.Drawing.Size(224, 26);
            this.MnuEdit2.Text = "貼上";
            this.MnuEdit2.Click += new System.EventHandler(this.MnuEdit2_Click);
            // 
            // MnuEdit3
            // 
            this.MnuEdit3.Name = "MnuEdit3";
            this.MnuEdit3.Size = new System.Drawing.Size(224, 26);
            this.MnuEdit3.Text = "剪下";
            this.MnuEdit3.Click += new System.EventHandler(this.MnuEdit3_Click);
            // 
            // TxtW
            // 
            this.TxtW.Location = new System.Drawing.Point(51, 118);
            this.TxtW.Name = "TxtW";
            this.TxtW.Size = new System.Drawing.Size(158, 25);
            this.TxtW.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 459);
            this.Controls.Add(this.TxtW);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CMnuEdit1;
        private System.Windows.Forms.ToolStripMenuItem CMnuEdit2;
        private System.Windows.Forms.ToolStripMenuItem CMnuEdit3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 字型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuFont1;
        private System.Windows.Forms.ToolStripMenuItem MnuFont2;
        private System.Windows.Forms.ToolStripMenuItem MnuSize;
        private System.Windows.Forms.ToolStripMenuItem MnuSize1;
        private System.Windows.Forms.ToolStripMenuItem MnuSize2;
        private System.Windows.Forms.ToolStripMenuItem MnuSize3;
        private System.Windows.Forms.ToolStripMenuItem MnuSize4;
        private System.Windows.Forms.ToolStripMenuItem MnuStyle1;
        private System.Windows.Forms.ToolStripMenuItem 粗體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStyle2;
        private System.Windows.Forms.ToolStripMenuItem MnuSet;
        private System.Windows.Forms.ToolStripMenuItem MnuSet1;
        private System.Windows.Forms.ToolStripMenuItem MnuSet2;
        private System.Windows.Forms.ToolStripMenuItem MnuSet3;
        private System.Windows.Forms.TextBox TxtW;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit1;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit2;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit3;
    }
}


namespace WinBtnDesigner
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.MnuFront = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.TstxtInput = new System.Windows.Forms.ToolStripTextBox();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDesign = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFront,
            this.MnuColor,
            this.TstxtInput,
            this.MnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuFront
            // 
            this.MnuFront.Name = "MnuFront";
            this.MnuFront.Size = new System.Drawing.Size(53, 27);
            this.MnuFront.Text = "字型";
            this.MnuFront.Click += new System.EventHandler(this.MnuFront_Click);
            // 
            // MnuColor
            // 
            this.MnuColor.Name = "MnuColor";
            this.MnuColor.Size = new System.Drawing.Size(83, 27);
            this.MnuColor.Text = "背景顏色";
            this.MnuColor.Click += new System.EventHandler(this.MnuColor_Click);
            // 
            // TstxtInput
            // 
            this.TstxtInput.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.TstxtInput.Name = "TstxtInput";
            this.TstxtInput.Size = new System.Drawing.Size(100, 27);
            this.TstxtInput.TextChanged += new System.EventHandler(this.TstxtInput_TextChanged);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(53, 27);
            this.MnuExit.Text = "結束";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // BtnDesign
            // 
            this.BtnDesign.Location = new System.Drawing.Point(12, 115);
            this.BtnDesign.Name = "BtnDesign";
            this.BtnDesign.Size = new System.Drawing.Size(284, 80);
            this.BtnDesign.TabIndex = 1;
            this.BtnDesign.Text = "button1";
            this.BtnDesign.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 227);
            this.Controls.Add(this.BtnDesign);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuFront;
        private System.Windows.Forms.ToolStripMenuItem MnuColor;
        private System.Windows.Forms.ToolStripTextBox TstxtInput;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnDesign;
    }
}


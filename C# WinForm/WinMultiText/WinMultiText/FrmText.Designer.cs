namespace WinMultiText
{
    partial class FrmText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmText));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.MnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripButton();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.MnuExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(348, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCopy,
            this.MnuPaste,
            this.MnuCut});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(58, 23);
            this.toolStripDropDownButton1.Text = "編輯";
            // 
            // MnuCopy
            // 
            this.MnuCopy.Name = "MnuCopy";
            this.MnuCopy.Size = new System.Drawing.Size(224, 26);
            this.MnuCopy.Text = "複製";
            this.MnuCopy.Click += new System.EventHandler(this.MnuCopy_Click);
            // 
            // MnuPaste
            // 
            this.MnuPaste.Name = "MnuPaste";
            this.MnuPaste.Size = new System.Drawing.Size(224, 26);
            this.MnuPaste.Text = "貼上";
            this.MnuPaste.Click += new System.EventHandler(this.MnuPaste_Click);
            // 
            // MnuCut
            // 
            this.MnuCut.Name = "MnuCut";
            this.MnuCut.Size = new System.Drawing.Size(224, 26);
            this.MnuCut.Text = "剪下";
            this.MnuCut.Click += new System.EventHandler(this.MnuCut_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MnuExit.Image = ((System.Drawing.Image)(resources.GetObject("MnuExit.Image")));
            this.MnuExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(43, 23);
            this.MnuExit.Text = "結束";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(12, 204);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(183, 25);
            this.TxtInput.TabIndex = 1;
            // 
            // FrmText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 281);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmText";
            this.Text = "FrmText";
            this.Load += new System.EventHandler(this.FrmText_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem MnuCopy;
        private System.Windows.Forms.ToolStripMenuItem MnuPaste;
        private System.Windows.Forms.ToolStripMenuItem MnuCut;
        private System.Windows.Forms.ToolStripButton MnuExit;
        private System.Windows.Forms.TextBox TxtInput;
    }
}
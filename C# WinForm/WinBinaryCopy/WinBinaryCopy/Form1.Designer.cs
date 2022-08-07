namespace WinBinaryCopy
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
            this.PicShow = new System.Windows.Forms.PictureBox();
            this.LblShow = new System.Windows.Forms.Label();
            this.BtnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).BeginInit();
            this.SuspendLayout();
            // 
            // PicShow
            // 
            this.PicShow.Location = new System.Drawing.Point(45, 33);
            this.PicShow.Name = "PicShow";
            this.PicShow.Size = new System.Drawing.Size(401, 307);
            this.PicShow.TabIndex = 0;
            this.PicShow.TabStop = false;
            // 
            // LblShow
            // 
            this.LblShow.AutoSize = true;
            this.LblShow.Location = new System.Drawing.Point(42, 363);
            this.LblShow.Name = "LblShow";
            this.LblShow.Size = new System.Drawing.Size(41, 15);
            this.LblShow.TabIndex = 1;
            this.LblShow.Text = "label1";
            // 
            // BtnCopy
            // 
            this.BtnCopy.Font = new System.Drawing.Font("新細明體", 18F);
            this.BtnCopy.Location = new System.Drawing.Point(285, 348);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(161, 45);
            this.BtnCopy.TabIndex = 2;
            this.BtnCopy.Text = "複製";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 422);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.LblShow);
            this.Controls.Add(this.PicShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicShow;
        private System.Windows.Forms.Label LblShow;
        private System.Windows.Forms.Button BtnCopy;
    }
}


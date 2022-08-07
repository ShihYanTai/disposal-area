namespace TouchPic
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
            this.PicT1 = new System.Windows.Forms.PictureBox();
            this.PicT2 = new System.Windows.Forms.PictureBox();
            this.PicT3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicT3)).BeginInit();
            this.SuspendLayout();
            // 
            // PicT1
            // 
            this.PicT1.Location = new System.Drawing.Point(35, 41);
            this.PicT1.Name = "PicT1";
            this.PicT1.Size = new System.Drawing.Size(190, 166);
            this.PicT1.TabIndex = 0;
            this.PicT1.TabStop = false;
            this.PicT1.Click += new System.EventHandler(this.PicT1_Click);
            this.PicT1.DoubleClick += new System.EventHandler(this.PicT1_DoubleClick);
            this.PicT1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicT1_MouseClick);
            // 
            // PicT2
            // 
            this.PicT2.Location = new System.Drawing.Point(180, 131);
            this.PicT2.Name = "PicT2";
            this.PicT2.Size = new System.Drawing.Size(190, 166);
            this.PicT2.TabIndex = 1;
            this.PicT2.TabStop = false;
            // 
            // PicT3
            // 
            this.PicT3.Location = new System.Drawing.Point(308, 238);
            this.PicT3.Name = "PicT3";
            this.PicT3.Size = new System.Drawing.Size(190, 166);
            this.PicT3.TabIndex = 2;
            this.PicT3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 429);
            this.Controls.Add(this.PicT3);
            this.Controls.Add(this.PicT2);
            this.Controls.Add(this.PicT1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicT3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicT1;
        private System.Windows.Forms.PictureBox PicT2;
        private System.Windows.Forms.PictureBox PicT3;
    }
}


namespace WinReader
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
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSum
            // 
            this.BtnSum.Font = new System.Drawing.Font("新細明體", 12F);
            this.BtnSum.Location = new System.Drawing.Point(32, 80);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(119, 40);
            this.BtnSum.TabIndex = 0;
            this.BtnSum.Text = "開始計算";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("新細明體", 12F);
            this.BtnExit.Location = new System.Drawing.Point(201, 80);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(119, 40);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "結束";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtShow
            // 
            this.TxtShow.Location = new System.Drawing.Point(32, 34);
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.Size = new System.Drawing.Size(288, 25);
            this.TxtShow.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 166);
            this.Controls.Add(this.TxtShow);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtShow;
    }
}


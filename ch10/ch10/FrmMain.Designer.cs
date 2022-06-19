namespace ch10
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMsg = new System.Windows.Forms.RichTextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "請按開始，填寫個人資料";
            // 
            // TxtMsg
            // 
            this.TxtMsg.Location = new System.Drawing.Point(43, 62);
            this.TxtMsg.Name = "TxtMsg";
            this.TxtMsg.Size = new System.Drawing.Size(339, 144);
            this.TxtMsg.TabIndex = 1;
            this.TxtMsg.Text = "";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(43, 229);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(124, 54);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "結束";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(251, 229);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(131, 54);
            this.BtnGo.TabIndex = 3;
            this.BtnGo.Text = "開始";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 306);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtMsg);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "主選單";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TxtMsg;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnGo;
    }
}


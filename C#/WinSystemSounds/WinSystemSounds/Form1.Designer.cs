namespace WinSystemSounds
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入額溫 :";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("新細明體", 20F);
            this.LblMsg.Location = new System.Drawing.Point(58, 217);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(0, 34);
            this.LblMsg.TabIndex = 1;
            // 
            // TxtInput
            // 
            this.TxtInput.Font = new System.Drawing.Font("新細明體", 20F);
            this.TxtInput.Location = new System.Drawing.Point(64, 125);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(200, 47);
            this.TxtInput.TabIndex = 2;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("新細明體", 20F);
            this.BtnOK.Location = new System.Drawing.Point(296, 117);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(140, 64);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 339);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button BtnOK;
    }
}


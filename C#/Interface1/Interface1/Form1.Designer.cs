namespace Interface1
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
            this.TxtWT = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入英制重量單位(磅) : ";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(48, 103);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(37, 15);
            this.LblMsg.TabIndex = 1;
            this.LblMsg.Text = "訊息";
            // 
            // TxtWT
            // 
            this.TxtWT.Location = new System.Drawing.Point(218, 41);
            this.TxtWT.Name = "TxtWT";
            this.TxtWT.Size = new System.Drawing.Size(92, 25);
            this.TxtWT.TabIndex = 2;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(218, 94);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(91, 32);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 166);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtWT);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.TextBox TxtWT;
        private System.Windows.Forms.Button BtnOK;
    }
}


namespace PlaySound
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
            this.LblQ = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.TxtAns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblQ
            // 
            this.LblQ.AutoSize = true;
            this.LblQ.Font = new System.Drawing.Font("新細明體", 16F);
            this.LblQ.Location = new System.Drawing.Point(32, 53);
            this.LblQ.Name = "LblQ";
            this.LblQ.Size = new System.Drawing.Size(74, 27);
            this.LblQ.TabIndex = 0;
            this.LblQ.Text = "label1";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("新細明體", 16F);
            this.LblMsg.Location = new System.Drawing.Point(32, 124);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(74, 27);
            this.LblMsg.TabIndex = 1;
            this.LblMsg.Text = "label2";
            // 
            // TxtAns
            // 
            this.TxtAns.Location = new System.Drawing.Point(123, 55);
            this.TxtAns.Name = "TxtAns";
            this.TxtAns.Size = new System.Drawing.Size(219, 25);
            this.TxtAns.TabIndex = 2;
            this.TxtAns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAns_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 180);
            this.Controls.Add(this.TxtAns);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.LblQ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblQ;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.TextBox TxtAns;
    }
}


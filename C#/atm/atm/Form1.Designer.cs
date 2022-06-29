namespace atm
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.TxtMoney = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "金鑰 : ";
            // 
            // TxtPW
            // 
            this.TxtPW.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxtPW.Location = new System.Drawing.Point(97, 42);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(258, 31);
            this.TxtPW.TabIndex = 3;
            this.TxtPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPW_KeyPress);
            // 
            // TxtMoney
            // 
            this.TxtMoney.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxtMoney.Location = new System.Drawing.Point(97, 111);
            this.TxtMoney.Name = "TxtMoney";
            this.TxtMoney.Size = new System.Drawing.Size(258, 31);
            this.TxtMoney.TabIndex = 4;
            this.TxtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMoney_KeyPress);
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(31, 208);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(41, 15);
            this.LblMsg.TabIndex = 5;
            this.LblMsg.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 263);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.TxtMoney);
            this.Controls.Add(this.TxtPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.TextBox TxtMoney;
        private System.Windows.Forms.Label LblMsg;
    }
}


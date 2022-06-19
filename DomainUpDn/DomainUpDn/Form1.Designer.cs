namespace DomainUpDn
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
            this.DudOpt = new System.Windows.Forms.DomainUpDown();
            this.DudNum = new System.Windows.Forms.DomainUpDown();
            this.TxtAns = new System.Windows.Forms.TextBox();
            this.LblTest = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DudOpt
            // 
            this.DudOpt.Location = new System.Drawing.Point(382, 62);
            this.DudOpt.Name = "DudOpt";
            this.DudOpt.Size = new System.Drawing.Size(187, 25);
            this.DudOpt.TabIndex = 0;
            this.DudOpt.Text = "domainUpDown1";
            // 
            // DudNum
            // 
            this.DudNum.Location = new System.Drawing.Point(382, 152);
            this.DudNum.Name = "DudNum";
            this.DudNum.Size = new System.Drawing.Size(187, 25);
            this.DudNum.TabIndex = 1;
            this.DudNum.Text = "domainUpDown2";
            // 
            // TxtAns
            // 
            this.TxtAns.Location = new System.Drawing.Point(233, 103);
            this.TxtAns.Name = "TxtAns";
            this.TxtAns.Size = new System.Drawing.Size(118, 25);
            this.TxtAns.TabIndex = 2;
            // 
            // LblTest
            // 
            this.LblTest.AutoSize = true;
            this.LblTest.Location = new System.Drawing.Point(31, 103);
            this.LblTest.Name = "LblTest";
            this.LblTest.Size = new System.Drawing.Size(41, 15);
            this.LblTest.TabIndex = 3;
            this.LblTest.Text = "label1";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(31, 204);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(41, 15);
            this.LblMsg.TabIndex = 4;
            this.LblMsg.Text = "label2";
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(212, 234);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(161, 66);
            this.BtnTest.TabIndex = 5;
            this.BtnTest.Text = "出題";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(408, 234);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(161, 66);
            this.BtnCheck.TabIndex = 6;
            this.BtnCheck.Text = "對答案";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 326);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.LblTest);
            this.Controls.Add(this.TxtAns);
            this.Controls.Add(this.DudNum);
            this.Controls.Add(this.DudOpt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown DudOpt;
        private System.Windows.Forms.DomainUpDown DudNum;
        private System.Windows.Forms.TextBox TxtAns;
        private System.Windows.Forms.Label LblTest;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnCheck;
    }
}


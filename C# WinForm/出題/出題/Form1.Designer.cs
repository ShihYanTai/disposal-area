namespace 出題
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
            this.ClsTest = new System.Windows.Forms.CheckedListBox();
            this.LblDiv = new System.Windows.Forms.Label();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClsTest
            // 
            this.ClsTest.FormattingEnabled = true;
            this.ClsTest.Location = new System.Drawing.Point(28, 87);
            this.ClsTest.Name = "ClsTest";
            this.ClsTest.Size = new System.Drawing.Size(389, 304);
            this.ClsTest.TabIndex = 0;
            // 
            // LblDiv
            // 
            this.LblDiv.AutoSize = true;
            this.LblDiv.Location = new System.Drawing.Point(40, 26);
            this.LblDiv.Name = "LblDiv";
            this.LblDiv.Size = new System.Drawing.Size(41, 15);
            this.LblDiv.TabIndex = 1;
            this.LblDiv.Text = "label1";
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(480, 96);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(165, 68);
            this.BtnNew.TabIndex = 2;
            this.BtnNew.Text = "出題";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(480, 196);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(165, 68);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "核對";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(480, 292);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(165, 68);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "重答";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.Location = new System.Drawing.Point(480, 38);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(134, 25);
            this.LblMsg.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 416);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.LblDiv);
            this.Controls.Add(this.ClsTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ClsTest;
        private System.Windows.Forms.Label LblDiv;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox LblMsg;
    }
}


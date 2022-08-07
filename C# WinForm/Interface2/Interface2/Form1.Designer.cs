namespace Interface2
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
            this.LblPass = new System.Windows.Forms.Label();
            this.LblLevel = new System.Windows.Forms.Label();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入學期成績 :";
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Location = new System.Drawing.Point(35, 105);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(41, 15);
            this.LblPass.TabIndex = 1;
            this.LblPass.Text = "label2";
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.Location = new System.Drawing.Point(35, 151);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(41, 15);
            this.LblLevel.TabIndex = 2;
            this.LblLevel.Text = "label3";
            // 
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(161, 46);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(100, 25);
            this.TxtScore.TabIndex = 3;
            this.TxtScore.TextChanged += new System.EventHandler(this.TxtScore_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 239);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.LblLevel);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.TextBox TxtScore;
    }
}


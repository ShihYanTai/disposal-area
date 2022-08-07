namespace CarRent
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
            this.MacDate = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MacDate
            // 
            this.MacDate.Location = new System.Drawing.Point(53, 44);
            this.MacDate.Name = "MacDate";
            this.MacDate.TabIndex = 0;
            this.MacDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MacDate_DateChanged);
            this.MacDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MacDate_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "請選擇租用範圍 : ( 1 ~ 7 日) ";
            // 
            // LblMoney
            // 
            this.LblMoney.AutoSize = true;
            this.LblMoney.Location = new System.Drawing.Point(50, 265);
            this.LblMoney.Name = "LblMoney";
            this.LblMoney.Size = new System.Drawing.Size(75, 15);
            this.LblMoney.TabIndex = 2;
            this.LblMoney.Text = "租金 : 0 元";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 304);
            this.Controls.Add(this.LblMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MacDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MacDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMoney;
    }
}


namespace ListEx
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
            this.String = new System.Windows.Forms.Label();
            this.Double = new System.Windows.Forms.Label();
            this.TxtString = new System.Windows.Forms.TextBox();
            this.TxtDouble = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // String
            // 
            this.String.AutoSize = true;
            this.String.Location = new System.Drawing.Point(45, 29);
            this.String.Name = "String";
            this.String.Size = new System.Drawing.Size(42, 15);
            this.String.TabIndex = 0;
            this.String.Text = "String";
            // 
            // Double
            // 
            this.Double.AutoSize = true;
            this.Double.Location = new System.Drawing.Point(236, 29);
            this.Double.Name = "Double";
            this.Double.Size = new System.Drawing.Size(48, 15);
            this.Double.TabIndex = 1;
            this.Double.Text = "Double";
            // 
            // TxtString
            // 
            this.TxtString.Location = new System.Drawing.Point(48, 62);
            this.TxtString.Multiline = true;
            this.TxtString.Name = "TxtString";
            this.TxtString.ReadOnly = true;
            this.TxtString.Size = new System.Drawing.Size(157, 155);
            this.TxtString.TabIndex = 2;
            // 
            // TxtDouble
            // 
            this.TxtDouble.Location = new System.Drawing.Point(239, 62);
            this.TxtDouble.Multiline = true;
            this.TxtDouble.Name = "TxtDouble";
            this.TxtDouble.ReadOnly = true;
            this.TxtDouble.Size = new System.Drawing.Size(157, 155);
            this.TxtDouble.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 247);
            this.Controls.Add(this.TxtDouble);
            this.Controls.Add(this.TxtString);
            this.Controls.Add(this.Double);
            this.Controls.Add(this.String);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label String;
        private System.Windows.Forms.Label Double;
        private System.Windows.Forms.TextBox TxtString;
        private System.Windows.Forms.TextBox TxtDouble;
    }
}


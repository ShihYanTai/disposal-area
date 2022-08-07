namespace BeepPlay
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
            this.Bn1 = new System.Windows.Forms.Button();
            this.Bn2 = new System.Windows.Forms.Button();
            this.Bn3 = new System.Windows.Forms.Button();
            this.Bn4 = new System.Windows.Forms.Button();
            this.Bn5 = new System.Windows.Forms.Button();
            this.Bn6 = new System.Windows.Forms.Button();
            this.Bn7 = new System.Windows.Forms.Button();
            this.Bn8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bn1
            // 
            this.Bn1.Location = new System.Drawing.Point(23, 76);
            this.Bn1.Name = "Bn1";
            this.Bn1.Size = new System.Drawing.Size(73, 72);
            this.Bn1.TabIndex = 0;
            this.Bn1.Text = "Do";
            this.Bn1.UseVisualStyleBackColor = true;
            this.Bn1.Click += new System.EventHandler(this.Bn1_Click);
            // 
            // Bn2
            // 
            this.Bn2.Location = new System.Drawing.Point(96, 76);
            this.Bn2.Name = "Bn2";
            this.Bn2.Size = new System.Drawing.Size(73, 72);
            this.Bn2.TabIndex = 1;
            this.Bn2.Text = "Re";
            this.Bn2.UseVisualStyleBackColor = true;
            // 
            // Bn3
            // 
            this.Bn3.Location = new System.Drawing.Point(169, 76);
            this.Bn3.Name = "Bn3";
            this.Bn3.Size = new System.Drawing.Size(73, 72);
            this.Bn3.TabIndex = 2;
            this.Bn3.Text = "Mi";
            this.Bn3.UseVisualStyleBackColor = true;
            // 
            // Bn4
            // 
            this.Bn4.Location = new System.Drawing.Point(242, 76);
            this.Bn4.Name = "Bn4";
            this.Bn4.Size = new System.Drawing.Size(73, 72);
            this.Bn4.TabIndex = 3;
            this.Bn4.Text = "Fa";
            this.Bn4.UseVisualStyleBackColor = true;
            // 
            // Bn5
            // 
            this.Bn5.Location = new System.Drawing.Point(315, 76);
            this.Bn5.Name = "Bn5";
            this.Bn5.Size = new System.Drawing.Size(73, 72);
            this.Bn5.TabIndex = 4;
            this.Bn5.Text = "Si";
            this.Bn5.UseVisualStyleBackColor = true;
            // 
            // Bn6
            // 
            this.Bn6.Location = new System.Drawing.Point(388, 76);
            this.Bn6.Name = "Bn6";
            this.Bn6.Size = new System.Drawing.Size(73, 72);
            this.Bn6.TabIndex = 5;
            this.Bn6.Text = "La";
            this.Bn6.UseVisualStyleBackColor = true;
            // 
            // Bn7
            // 
            this.Bn7.Location = new System.Drawing.Point(461, 76);
            this.Bn7.Name = "Bn7";
            this.Bn7.Size = new System.Drawing.Size(73, 72);
            this.Bn7.TabIndex = 6;
            this.Bn7.Text = "Ti";
            this.Bn7.UseVisualStyleBackColor = true;
            // 
            // Bn8
            // 
            this.Bn8.ForeColor = System.Drawing.Color.Red;
            this.Bn8.Location = new System.Drawing.Point(534, 76);
            this.Bn8.Name = "Bn8";
            this.Bn8.Size = new System.Drawing.Size(73, 72);
            this.Bn8.TabIndex = 7;
            this.Bn8.Text = "Do";
            this.Bn8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 195);
            this.Controls.Add(this.Bn8);
            this.Controls.Add(this.Bn7);
            this.Controls.Add(this.Bn6);
            this.Controls.Add(this.Bn5);
            this.Controls.Add(this.Bn4);
            this.Controls.Add(this.Bn3);
            this.Controls.Add(this.Bn2);
            this.Controls.Add(this.Bn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bn1;
        private System.Windows.Forms.Button Bn2;
        private System.Windows.Forms.Button Bn3;
        private System.Windows.Forms.Button Bn4;
        private System.Windows.Forms.Button Bn5;
        private System.Windows.Forms.Button Bn6;
        private System.Windows.Forms.Button Bn7;
        private System.Windows.Forms.Button Bn8;
    }
}


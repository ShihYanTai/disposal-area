namespace 放置圖片
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
            this.DogBox = new System.Windows.Forms.PictureBox();
            this.換照片 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DogBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DogBox
            // 
            this.DogBox.Image = global::放置圖片.Properties.Resources.dog1;
            this.DogBox.Location = new System.Drawing.Point(212, 43);
            this.DogBox.Name = "DogBox";
            this.DogBox.Size = new System.Drawing.Size(335, 261);
            this.DogBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogBox.TabIndex = 0;
            this.DogBox.TabStop = false;
            this.DogBox.Click += new System.EventHandler(this.DogBox_Click);
            // 
            // 換照片
            // 
            this.換照片.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.換照片.Location = new System.Drawing.Point(212, 327);
            this.換照片.Name = "換照片";
            this.換照片.Size = new System.Drawing.Size(335, 78);
            this.換照片.TabIndex = 1;
            this.換照片.Text = "換照片";
            this.換照片.UseVisualStyleBackColor = true;
            this.換照片.Click += new System.EventHandler(this.換照片_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.換照片);
            this.Controls.Add(this.DogBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DogBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DogBox;
        private System.Windows.Forms.Button 換照片;
    }
}


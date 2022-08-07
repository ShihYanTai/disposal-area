namespace ImageList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrFly = new System.Windows.Forms.Timer(this.components);
            this.ImageCat = new System.Windows.Forms.ImageList(this.components);
            this.ImageIcon = new System.Windows.Forms.ImageList(this.components);
            this.Btnplay = new System.Windows.Forms.Button();
            this.Btnstop = new System.Windows.Forms.Button();
            this.PicCat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicCat)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrFly
            // 
            this.tmrFly.Tick += new System.EventHandler(this.tmrFly_Tick);
            // 
            // ImageCat
            // 
            this.ImageCat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageCat.ImageStream")));
            this.ImageCat.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageCat.Images.SetKeyName(0, "1.png");
            this.ImageCat.Images.SetKeyName(1, "2.png");
            this.ImageCat.Images.SetKeyName(2, "3.png");
            this.ImageCat.Images.SetKeyName(3, "4.png");
            this.ImageCat.Images.SetKeyName(4, "5.png");
            this.ImageCat.Images.SetKeyName(5, "6.png");
            this.ImageCat.Images.SetKeyName(6, "7.png");
            this.ImageCat.Images.SetKeyName(7, "8.png");
            this.ImageCat.Images.SetKeyName(8, "9.png");
            this.ImageCat.Images.SetKeyName(9, "10.png");
            this.ImageCat.Images.SetKeyName(10, "11.png");
            this.ImageCat.Images.SetKeyName(11, "12.png");
            // 
            // ImageIcon
            // 
            this.ImageIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageIcon.ImageStream")));
            this.ImageIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageIcon.Images.SetKeyName(0, "play.jpg");
            this.ImageIcon.Images.SetKeyName(1, "stop.jpg");
            // 
            // Btnplay
            // 
            this.Btnplay.Location = new System.Drawing.Point(312, 319);
            this.Btnplay.Name = "Btnplay";
            this.Btnplay.Size = new System.Drawing.Size(217, 94);
            this.Btnplay.TabIndex = 0;
            this.Btnplay.UseVisualStyleBackColor = true;
            this.Btnplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btnstop
            // 
            this.Btnstop.Location = new System.Drawing.Point(571, 319);
            this.Btnstop.Name = "Btnstop";
            this.Btnstop.Size = new System.Drawing.Size(217, 94);
            this.Btnstop.TabIndex = 1;
            this.Btnstop.UseVisualStyleBackColor = true;
            this.Btnstop.Click += new System.EventHandler(this.button2_Click);
            // 
            // PicCat
            // 
            this.PicCat.Location = new System.Drawing.Point(108, 38);
            this.PicCat.Name = "PicCat";
            this.PicCat.Size = new System.Drawing.Size(591, 161);
            this.PicCat.TabIndex = 2;
            this.PicCat.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicCat);
            this.Controls.Add(this.Btnstop);
            this.Controls.Add(this.Btnplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrFly;
        private System.Windows.Forms.ImageList ImageCat;
        private System.Windows.Forms.ImageList ImageIcon;
        private System.Windows.Forms.Button Btnplay;
        private System.Windows.Forms.Button Btnstop;
        private System.Windows.Forms.PictureBox PicCat;
    }
}


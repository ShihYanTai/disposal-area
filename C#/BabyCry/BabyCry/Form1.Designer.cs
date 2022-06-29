namespace BabyCry
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
            this.PicBaby = new System.Windows.Forms.PictureBox();
            this.ImgBaby = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBaby)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBaby
            // 
            this.PicBaby.Location = new System.Drawing.Point(114, 154);
            this.PicBaby.Name = "PicBaby";
            this.PicBaby.Size = new System.Drawing.Size(87, 66);
            this.PicBaby.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBaby.TabIndex = 0;
            this.PicBaby.TabStop = false;
            this.PicBaby.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicBaby_MouseDown);
            this.PicBaby.MouseLeave += new System.EventHandler(this.PicBaby_MouseLeave);
            this.PicBaby.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicBaby_MouseMove);
            this.PicBaby.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicBaby_MouseUp);
            // 
            // ImgBaby
            // 
            this.ImgBaby.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgBaby.ImageStream")));
            this.ImgBaby.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgBaby.Images.SetKeyName(0, "baby1.gif");
            this.ImgBaby.Images.SetKeyName(1, "baby2.gif");
            this.ImgBaby.Images.SetKeyName(2, "baby3.gif");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicBaby);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PicBaby)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBaby;
        private System.Windows.Forms.ImageList ImgBaby;
    }
}


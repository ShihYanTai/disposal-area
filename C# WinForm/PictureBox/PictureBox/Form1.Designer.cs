namespace PictureBox
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
            this.PicShow = new System.Windows.Forms.PictureBox();
            this.RdbOn = new System.Windows.Forms.RadioButton();
            this.RdbOff = new System.Windows.Forms.RadioButton();
            this.RdbLeft = new System.Windows.Forms.RadioButton();
            this.RdbDown = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicShow
            // 
            this.PicShow.Image = global::PictureBox.Properties.Resources._6470c572e810c05e1da083439550f5a2;
            this.PicShow.Location = new System.Drawing.Point(12, 12);
            this.PicShow.Name = "PicShow";
            this.PicShow.Size = new System.Drawing.Size(460, 324);
            this.PicShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicShow.TabIndex = 0;
            this.PicShow.TabStop = false;
            this.PicShow.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RdbOn
            // 
            this.RdbOn.AutoSize = true;
            this.RdbOn.Location = new System.Drawing.Point(15, 25);
            this.RdbOn.Name = "RdbOn";
            this.RdbOn.Size = new System.Drawing.Size(43, 19);
            this.RdbOn.TabIndex = 1;
            this.RdbOn.TabStop = true;
            this.RdbOn.Text = "開";
            this.RdbOn.UseVisualStyleBackColor = true;
            this.RdbOn.CheckedChanged += new System.EventHandler(this.RdbOn_CheckedChanged);
            // 
            // RdbOff
            // 
            this.RdbOff.AutoSize = true;
            this.RdbOff.Location = new System.Drawing.Point(75, 25);
            this.RdbOff.Name = "RdbOff";
            this.RdbOff.Size = new System.Drawing.Size(43, 19);
            this.RdbOff.TabIndex = 2;
            this.RdbOff.TabStop = true;
            this.RdbOff.Text = "關";
            this.RdbOff.UseVisualStyleBackColor = true;
            this.RdbOff.CheckedChanged += new System.EventHandler(this.RdbOff_CheckedChanged);
            // 
            // RdbLeft
            // 
            this.RdbLeft.AutoSize = true;
            this.RdbLeft.Location = new System.Drawing.Point(16, 25);
            this.RdbLeft.Name = "RdbLeft";
            this.RdbLeft.Size = new System.Drawing.Size(88, 19);
            this.RdbLeft.TabIndex = 3;
            this.RdbLeft.TabStop = true;
            this.RdbLeft.Text = "向左移入";
            this.RdbLeft.UseVisualStyleBackColor = true;
            this.RdbLeft.CheckedChanged += new System.EventHandler(this.RdbLeft_CheckedChanged);
            // 
            // RdbDown
            // 
            this.RdbDown.AutoSize = true;
            this.RdbDown.Location = new System.Drawing.Point(132, 25);
            this.RdbDown.Name = "RdbDown";
            this.RdbDown.Size = new System.Drawing.Size(88, 19);
            this.RdbDown.TabIndex = 4;
            this.RdbDown.TabStop = true;
            this.RdbDown.Text = "向下拉出";
            this.RdbDown.UseVisualStyleBackColor = true;
            this.RdbDown.CheckedChanged += new System.EventHandler(this.RdbDown_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbOff);
            this.groupBox1.Controls.Add(this.RdbOn);
            this.groupBox1.Location = new System.Drawing.Point(21, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "動態秀圖";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbDown);
            this.groupBox2.Controls.Add(this.RdbLeft);
            this.groupBox2.Location = new System.Drawing.Point(232, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 59);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "設定";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PicShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicShow;
        private System.Windows.Forms.RadioButton RdbOn;
        private System.Windows.Forms.RadioButton RdbOff;
        private System.Windows.Forms.RadioButton RdbLeft;
        private System.Windows.Forms.RadioButton RdbDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace WinWavPlayer
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
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnLoop = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Font = new System.Drawing.Font("新細明體", 15F);
            this.BtnBrowse.Location = new System.Drawing.Point(494, 130);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(144, 46);
            this.BtnBrowse.TabIndex = 0;
            this.BtnBrowse.Text = "瀏覽";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Font = new System.Drawing.Font("新細明體", 15F);
            this.BtnPlay.Location = new System.Drawing.Point(12, 253);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(144, 46);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "播放一次";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnLoop
            // 
            this.BtnLoop.Font = new System.Drawing.Font("新細明體", 15F);
            this.BtnLoop.Location = new System.Drawing.Point(172, 253);
            this.BtnLoop.Name = "BtnLoop";
            this.BtnLoop.Size = new System.Drawing.Size(144, 46);
            this.BtnLoop.TabIndex = 2;
            this.BtnLoop.Text = "重複播放";
            this.BtnLoop.UseVisualStyleBackColor = true;
            this.BtnLoop.Click += new System.EventHandler(this.BtnLoop_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Font = new System.Drawing.Font("新細明體", 15F);
            this.BtnStop.Location = new System.Drawing.Point(332, 253);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(144, 46);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.Text = "停止播放";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Font = new System.Drawing.Font("新細明體", 15F);
            this.BtnEnd.Location = new System.Drawing.Point(492, 253);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(144, 46);
            this.BtnEnd.TabIndex = 4;
            this.BtnEnd.Text = "結束";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "音效位置 :";
            // 
            // TxtPath
            // 
            this.TxtPath.Font = new System.Drawing.Font("新細明體", 18F);
            this.TxtPath.Location = new System.Drawing.Point(143, 133);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(333, 43);
            this.TxtPath.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 323);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnLoop);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnLoop;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


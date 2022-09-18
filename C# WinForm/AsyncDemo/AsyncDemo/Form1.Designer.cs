namespace AsyncDemo
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.txtNo1 = new System.Windows.Forms.TextBox();
            this.txtNo2 = new System.Windows.Forms.TextBox();
            this.BtnSync = new System.Windows.Forms.Button();
            this.BtnAsync = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lstAnswers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTimer.Location = new System.Drawing.Point(76, 25);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(76, 28);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "label1";
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(34, 81);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(43, 15);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "No.1 :";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(34, 133);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(43, 15);
            this.txt2.TabIndex = 2;
            this.txt2.Text = "No.2 :";
            // 
            // txtNo1
            // 
            this.txtNo1.Location = new System.Drawing.Point(81, 78);
            this.txtNo1.Name = "txtNo1";
            this.txtNo1.Size = new System.Drawing.Size(163, 25);
            this.txtNo1.TabIndex = 3;
            // 
            // txtNo2
            // 
            this.txtNo2.Location = new System.Drawing.Point(81, 130);
            this.txtNo2.Name = "txtNo2";
            this.txtNo2.Size = new System.Drawing.Size(163, 25);
            this.txtNo2.TabIndex = 4;
            // 
            // BtnSync
            // 
            this.BtnSync.Location = new System.Drawing.Point(99, 179);
            this.BtnSync.Name = "BtnSync";
            this.BtnSync.Size = new System.Drawing.Size(123, 37);
            this.BtnSync.TabIndex = 6;
            this.BtnSync.Text = "同步計算";
            this.BtnSync.UseVisualStyleBackColor = true;
            this.BtnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // BtnAsync
            // 
            this.BtnAsync.Location = new System.Drawing.Point(99, 239);
            this.BtnAsync.Name = "BtnAsync";
            this.BtnAsync.Size = new System.Drawing.Size(123, 35);
            this.BtnAsync.TabIndex = 7;
            this.BtnAsync.Text = "非同步計算";
            this.BtnAsync.UseVisualStyleBackColor = true;
            this.BtnAsync.Click += new System.EventHandler(this.BtnAsync_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lstAnswers
            // 
            this.lstAnswers.HideSelection = false;
            this.lstAnswers.Location = new System.Drawing.Point(264, 78);
            this.lstAnswers.Name = "lstAnswers";
            this.lstAnswers.Size = new System.Drawing.Size(184, 195);
            this.lstAnswers.TabIndex = 8;
            this.lstAnswers.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 316);
            this.Controls.Add(this.lstAnswers);
            this.Controls.Add(this.BtnAsync);
            this.Controls.Add(this.BtnSync);
            this.Controls.Add(this.txtNo2);
            this.Controls.Add(this.txtNo1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.TextBox txtNo1;
        private System.Windows.Forms.TextBox txtNo2;
        private System.Windows.Forms.Button BtnSync;
        private System.Windows.Forms.Button BtnAsync;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView lstAnswers;
    }
}


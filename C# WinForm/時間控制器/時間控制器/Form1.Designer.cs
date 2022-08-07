namespace 時間控制器
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblTime = new System.Windows.Forms.Label();
            this.RdbTime = new System.Windows.Forms.RadioButton();
            this.RdbDat = new System.Windows.Forms.RadioButton();
            this.RdbSet1 = new System.Windows.Forms.RadioButton();
            this.RdbSet2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblTime
            // 
            this.LblTime.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblTime.Location = new System.Drawing.Point(58, 9);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(303, 85);
            this.LblTime.TabIndex = 0;
            this.LblTime.Text = "label1";
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RdbTime
            // 
            this.RdbTime.AutoSize = true;
            this.RdbTime.Location = new System.Drawing.Point(22, 19);
            this.RdbTime.Name = "RdbTime";
            this.RdbTime.Size = new System.Drawing.Size(58, 19);
            this.RdbTime.TabIndex = 1;
            this.RdbTime.TabStop = true;
            this.RdbTime.Text = "時間";
            this.RdbTime.UseVisualStyleBackColor = true;
            this.RdbTime.CheckedChanged += new System.EventHandler(this.RdbTime_CheckedChanged);
            // 
            // RdbDat
            // 
            this.RdbDat.AutoSize = true;
            this.RdbDat.Location = new System.Drawing.Point(22, 60);
            this.RdbDat.Name = "RdbDat";
            this.RdbDat.Size = new System.Drawing.Size(58, 19);
            this.RdbDat.TabIndex = 2;
            this.RdbDat.TabStop = true;
            this.RdbDat.Text = "日期";
            this.RdbDat.UseVisualStyleBackColor = true;
            // 
            // RdbSet1
            // 
            this.RdbSet1.AutoSize = true;
            this.RdbSet1.Location = new System.Drawing.Point(19, 24);
            this.RdbSet1.Name = "RdbSet1";
            this.RdbSet1.Size = new System.Drawing.Size(73, 19);
            this.RdbSet1.TabIndex = 3;
            this.RdbSet1.TabStop = true;
            this.RdbSet1.Text = "每一秒";
            this.RdbSet1.UseVisualStyleBackColor = true;
            this.RdbSet1.CheckedChanged += new System.EventHandler(this.RdbSet1_CheckedChanged);
            // 
            // RdbSet2
            // 
            this.RdbSet2.AutoSize = true;
            this.RdbSet2.Location = new System.Drawing.Point(19, 65);
            this.RdbSet2.Name = "RdbSet2";
            this.RdbSet2.Size = new System.Drawing.Size(73, 19);
            this.RdbSet2.TabIndex = 4;
            this.RdbSet2.TabStop = true;
            this.RdbSet2.Text = "每五秒";
            this.RdbSet2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbDat);
            this.groupBox1.Controls.Add(this.RdbTime);
            this.groupBox1.Location = new System.Drawing.Point(30, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "類型";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbSet2);
            this.groupBox2.Controls.Add(this.RdbSet1);
            this.groupBox2.Location = new System.Drawing.Point(245, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 106);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "設定";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 222);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.RadioButton RdbTime;
        private System.Windows.Forms.RadioButton RdbDat;
        private System.Windows.Forms.RadioButton RdbSet1;
        private System.Windows.Forms.RadioButton RdbSet2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


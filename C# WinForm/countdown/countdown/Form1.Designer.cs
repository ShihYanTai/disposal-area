namespace countdown
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSec = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NubMin = new System.Windows.Forms.NumericUpDown();
            this.NubSec = new System.Windows.Forms.NumericUpDown();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnResart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NubMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NubSec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "倒數時間:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "秒";
            // 
            // LblSec
            // 
            this.LblSec.AutoSize = true;
            this.LblSec.Location = new System.Drawing.Point(51, 223);
            this.LblSec.Name = "LblSec";
            this.LblSec.Size = new System.Drawing.Size(41, 15);
            this.LblSec.TabIndex = 5;
            this.LblSec.Text = "label4";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(269, 137);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(188, 43);
            this.BtnStart.TabIndex = 6;
            this.BtnStart.Text = "開始";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NubMin
            // 
            this.NubMin.Location = new System.Drawing.Point(113, 81);
            this.NubMin.Name = "NubMin";
            this.NubMin.Size = new System.Drawing.Size(101, 25);
            this.NubMin.TabIndex = 7;
            // 
            // NubSec
            // 
            this.NubSec.Location = new System.Drawing.Point(303, 81);
            this.NubSec.Name = "NubSec";
            this.NubSec.Size = new System.Drawing.Size(101, 25);
            this.NubSec.TabIndex = 8;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(269, 196);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(188, 51);
            this.BtnStop.TabIndex = 9;
            this.BtnStop.Text = "停止";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnResart
            // 
            this.BtnResart.Location = new System.Drawing.Point(269, 269);
            this.BtnResart.Name = "BtnResart";
            this.BtnResart.Size = new System.Drawing.Size(188, 51);
            this.BtnResart.TabIndex = 10;
            this.BtnResart.Text = "重新";
            this.BtnResart.UseVisualStyleBackColor = true;
            this.BtnResart.Click += new System.EventHandler(this.BtnResart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 332);
            this.Controls.Add(this.BtnResart);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.NubSec);
            this.Controls.Add(this.NubMin);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NubMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NubSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSec;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown NubMin;
        private System.Windows.Forms.NumericUpDown NubSec;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnResart;
    }
}


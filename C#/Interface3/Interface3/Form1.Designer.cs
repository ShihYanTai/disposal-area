namespace Interface3
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
            this.RdbJP = new System.Windows.Forms.RadioButton();
            this.RdbUSA = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCash = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RdbJP
            // 
            this.RdbJP.AutoSize = true;
            this.RdbJP.Location = new System.Drawing.Point(30, 61);
            this.RdbJP.Name = "RdbJP";
            this.RdbJP.Size = new System.Drawing.Size(58, 19);
            this.RdbJP.TabIndex = 0;
            this.RdbJP.TabStop = true;
            this.RdbJP.Text = "美元";
            this.RdbJP.UseVisualStyleBackColor = true;
            // 
            // RdbUSA
            // 
            this.RdbUSA.AutoSize = true;
            this.RdbUSA.Location = new System.Drawing.Point(112, 61);
            this.RdbUSA.Name = "RdbUSA";
            this.RdbUSA.Size = new System.Drawing.Size(58, 19);
            this.RdbUSA.TabIndex = 1;
            this.RdbUSA.TabStop = true;
            this.RdbUSA.Text = "日幣";
            this.RdbUSA.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbUSA);
            this.groupBox1.Controls.Add(this.RdbJP);
            this.groupBox1.Location = new System.Drawing.Point(30, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇要台幣兌換的外幣 :";
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(269, 66);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(96, 33);
            this.BtnConvert.TabIndex = 3;
            this.BtnConvert.Text = "兌換";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "請輸入要兌換的外幣金額:";
            // 
            // TxtCash
            // 
            this.TxtCash.Location = new System.Drawing.Point(220, 162);
            this.TxtCash.Name = "TxtCash";
            this.TxtCash.Size = new System.Drawing.Size(145, 25);
            this.TxtCash.TabIndex = 5;
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(27, 200);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(37, 15);
            this.LblMsg.TabIndex = 6;
            this.LblMsg.Text = "訊息";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 237);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.TxtCash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbJP;
        private System.Windows.Forms.RadioButton RdbUSA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCash;
        private System.Windows.Forms.Label LblMsg;
    }
}


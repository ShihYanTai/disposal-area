namespace ArrayList2
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPer = new System.Windows.Forms.TextBox();
            this.BtnPer = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.BtnRev = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "名單 : ";
            // 
            // TxtPer
            // 
            this.TxtPer.Location = new System.Drawing.Point(37, 72);
            this.TxtPer.Multiline = true;
            this.TxtPer.Name = "TxtPer";
            this.TxtPer.Size = new System.Drawing.Size(131, 91);
            this.TxtPer.TabIndex = 1;
            // 
            // BtnPer
            // 
            this.BtnPer.Location = new System.Drawing.Point(192, 39);
            this.BtnPer.Name = "BtnPer";
            this.BtnPer.Size = new System.Drawing.Size(78, 26);
            this.BtnPer.TabIndex = 2;
            this.BtnPer.Text = "原來名單";
            this.BtnPer.UseVisualStyleBackColor = true;
            this.BtnPer.Click += new System.EventHandler(this.BtnPer_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(192, 87);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(78, 26);
            this.BtnSort.TabIndex = 3;
            this.BtnSort.Text = "遞增順序";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnRev
            // 
            this.BtnRev.Location = new System.Drawing.Point(192, 137);
            this.BtnRev.Name = "BtnRev";
            this.BtnRev.Size = new System.Drawing.Size(78, 26);
            this.BtnRev.TabIndex = 4;
            this.BtnRev.Text = "遞減順序";
            this.BtnRev.UseVisualStyleBackColor = true;
            this.BtnRev.Click += new System.EventHandler(this.BtnRev_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "輸入名字 :";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(34, 234);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(37, 15);
            this.LblMsg.TabIndex = 6;
            this.LblMsg.Text = "訊息";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(115, 185);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(76, 25);
            this.TxtName.TabIndex = 7;
            // 
            // BtnIndex
            // 
            this.BtnIndex.Location = new System.Drawing.Point(206, 185);
            this.BtnIndex.Name = "BtnIndex";
            this.BtnIndex.Size = new System.Drawing.Size(64, 26);
            this.BtnIndex.TabIndex = 8;
            this.BtnIndex.Text = "搜尋";
            this.BtnIndex.UseVisualStyleBackColor = true;
            this.BtnIndex.Click += new System.EventHandler(this.BtnIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 275);
            this.Controls.Add(this.BtnIndex);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRev);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnPer);
            this.Controls.Add(this.TxtPer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPer;
        private System.Windows.Forms.Button BtnPer;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button BtnRev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnIndex;
    }
}


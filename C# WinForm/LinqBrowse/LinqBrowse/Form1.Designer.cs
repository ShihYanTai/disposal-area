namespace LinqBrowse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.LblIndex = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "書號 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "書名 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "定價 :";
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(316, 115);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(38, 35);
            this.BtnFirst.TabIndex = 3;
            this.BtnFirst.Text = "|<";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(373, 115);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(38, 35);
            this.BtnPrev.TabIndex = 4;
            this.BtnPrev.Text = "<";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(430, 115);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(38, 35);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(487, 115);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(38, 35);
            this.BtnLast.TabIndex = 6;
            this.BtnLast.Text = ">|";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // LblIndex
            // 
            this.LblIndex.AutoSize = true;
            this.LblIndex.Location = new System.Drawing.Point(313, 54);
            this.LblIndex.Name = "LblIndex";
            this.LblIndex.Size = new System.Drawing.Size(41, 15);
            this.LblIndex.TabIndex = 7;
            this.LblIndex.Text = "label4";
            // 
            // LblId
            // 
            this.LblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblId.Location = new System.Drawing.Point(77, 18);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(218, 32);
            this.LblId.TabIndex = 8;
            this.LblId.Text = "label5";
            // 
            // LblName
            // 
            this.LblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblName.Location = new System.Drawing.Point(77, 66);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(218, 32);
            this.LblName.TabIndex = 9;
            this.LblName.Text = "label6";
            // 
            // LblPrice
            // 
            this.LblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPrice.Location = new System.Drawing.Point(77, 114);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(218, 32);
            this.LblPrice.TabIndex = 10;
            this.LblPrice.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 178);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblIndex);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Label LblIndex;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblPrice;
    }
}


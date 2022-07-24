namespace StackEx
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
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnTop = new System.Windows.Forms.Button();
            this.BtnCln = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LBlMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(263, 20);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(97, 35);
            this.BtnDel.TabIndex = 0;
            this.BtnDel.Text = "刪除一筆";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnTop
            // 
            this.BtnTop.Location = new System.Drawing.Point(263, 80);
            this.BtnTop.Name = "BtnTop";
            this.BtnTop.Size = new System.Drawing.Size(97, 35);
            this.BtnTop.TabIndex = 1;
            this.BtnTop.Text = "Top資料";
            this.BtnTop.UseVisualStyleBackColor = true;
            this.BtnTop.Click += new System.EventHandler(this.BtnTop_Click);
            // 
            // BtnCln
            // 
            this.BtnCln.Location = new System.Drawing.Point(263, 138);
            this.BtnCln.Name = "BtnCln";
            this.BtnCln.Size = new System.Drawing.Size(97, 35);
            this.BtnCln.TabIndex = 2;
            this.BtnCln.Text = "清除堆疊";
            this.BtnCln.UseVisualStyleBackColor = true;
            this.BtnCln.Click += new System.EventHandler(this.BtnCln_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(263, 232);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(97, 35);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "加入";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LBlMsg
            // 
            this.LBlMsg.AutoSize = true;
            this.LBlMsg.Location = new System.Drawing.Point(27, 195);
            this.LBlMsg.Name = "LBlMsg";
            this.LBlMsg.Size = new System.Drawing.Size(41, 15);
            this.LBlMsg.TabIndex = 4;
            this.LBlMsg.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "輸入名字 :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(30, 20);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(194, 153);
            this.TxtName.TabIndex = 6;
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(121, 239);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(103, 25);
            this.TxtAdd.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 290);
            this.Controls.Add(this.TxtAdd);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBlMsg);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnCln);
            this.Controls.Add(this.BtnTop);
            this.Controls.Add(this.BtnDel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnTop;
        private System.Windows.Forms.Button BtnCln;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LBlMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAdd;
    }
}


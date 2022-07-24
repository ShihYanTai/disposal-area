namespace QueueEx
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnCln = new System.Windows.Forms.Button();
            this.BtnIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(28, 44);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(406, 25);
            this.TxtName.TabIndex = 0;
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(25, 93);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(41, 15);
            this.LblMsg.TabIndex = 1;
            this.LblMsg.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "輸入名字 : ";
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(110, 146);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(98, 25);
            this.TxtAdd.TabIndex = 3;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(227, 86);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(94, 28);
            this.BtnDel.TabIndex = 4;
            this.BtnDel.Text = "刪除一筆";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnCln
            // 
            this.BtnCln.Location = new System.Drawing.Point(340, 86);
            this.BtnCln.Name = "BtnCln";
            this.BtnCln.Size = new System.Drawing.Size(94, 28);
            this.BtnCln.TabIndex = 5;
            this.BtnCln.Text = "清除佇列";
            this.BtnCln.UseVisualStyleBackColor = true;
            this.BtnCln.Click += new System.EventHandler(this.BtnCln_Click);
            // 
            // BtnIndex
            // 
            this.BtnIndex.Location = new System.Drawing.Point(227, 149);
            this.BtnIndex.Name = "BtnIndex";
            this.BtnIndex.Size = new System.Drawing.Size(94, 28);
            this.BtnIndex.TabIndex = 6;
            this.BtnIndex.Text = "加入";
            this.BtnIndex.UseVisualStyleBackColor = true;
            this.BtnIndex.Click += new System.EventHandler(this.BtnIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 220);
            this.Controls.Add(this.BtnIndex);
            this.Controls.Add(this.BtnCln);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.TxtAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnCln;
        private System.Windows.Forms.Button BtnIndex;
    }
}


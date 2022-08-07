namespace WinStream
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
            this.TxtPad = new System.Windows.Forms.RichTextBox();
            this.TxtShow = new System.Windows.Forms.RichTextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnAppend = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPad
            // 
            this.TxtPad.Location = new System.Drawing.Point(53, 30);
            this.TxtPad.Name = "TxtPad";
            this.TxtPad.Size = new System.Drawing.Size(384, 226);
            this.TxtPad.TabIndex = 0;
            this.TxtPad.Text = "";
            // 
            // TxtShow
            // 
            this.TxtShow.Location = new System.Drawing.Point(53, 291);
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.Size = new System.Drawing.Size(384, 201);
            this.TxtShow.TabIndex = 1;
            this.TxtShow.Text = "";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(465, 477);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(41, 15);
            this.LblMsg.TabIndex = 3;
            this.LblMsg.Text = "label1";
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("新細明體", 18F);
            this.BtnClear.Location = new System.Drawing.Point(468, 30);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(159, 60);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "清除";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("新細明體", 18F);
            this.BtnCreate.Location = new System.Drawing.Point(468, 117);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(159, 60);
            this.BtnCreate.TabIndex = 5;
            this.BtnCreate.Text = "新增";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnAppend
            // 
            this.BtnAppend.Font = new System.Drawing.Font("新細明體", 18F);
            this.BtnAppend.Location = new System.Drawing.Point(468, 204);
            this.BtnAppend.Name = "BtnAppend";
            this.BtnAppend.Size = new System.Drawing.Size(159, 60);
            this.BtnAppend.TabIndex = 6;
            this.BtnAppend.Text = "加入";
            this.BtnAppend.UseVisualStyleBackColor = true;
            this.BtnAppend.Click += new System.EventHandler(this.BtnAppend_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Font = new System.Drawing.Font("新細明體", 18F);
            this.BtnEnd.Location = new System.Drawing.Point(468, 291);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(159, 60);
            this.BtnEnd.TabIndex = 7;
            this.BtnEnd.Text = "結束";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 518);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnAppend);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.TxtShow);
            this.Controls.Add(this.TxtPad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtPad;
        private System.Windows.Forms.RichTextBox TxtShow;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnAppend;
        private System.Windows.Forms.Button BtnEnd;
    }
}


namespace StaticMember
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblNo = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCls = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblTot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入姓名 :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(109, 55);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(169, 25);
            this.TxtName.TabIndex = 1;
            // 
            // LblNo
            // 
            this.LblNo.AutoSize = true;
            this.LblNo.Location = new System.Drawing.Point(28, 127);
            this.LblNo.Name = "LblNo";
            this.LblNo.Size = new System.Drawing.Size(41, 15);
            this.LblNo.TabIndex = 2;
            this.LblNo.Text = "label2";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(326, 35);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(114, 39);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "加入";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCls
            // 
            this.BtnCls.Location = new System.Drawing.Point(326, 103);
            this.BtnCls.Name = "BtnCls";
            this.BtnCls.Size = new System.Drawing.Size(114, 39);
            this.BtnCls.TabIndex = 4;
            this.BtnCls.Text = "清除";
            this.BtnCls.UseVisualStyleBackColor = true;
            this.BtnCls.Click += new System.EventHandler(this.BtnCls_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(326, 171);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(114, 39);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "離開";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.Location = new System.Drawing.Point(28, 195);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(41, 15);
            this.LblTot.TabIndex = 6;
            this.LblTot.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 254);
            this.Controls.Add(this.LblTot);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCls);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblNo);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblNo;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCls;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblTot;
    }
}


namespace OWinFileOperate
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
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.TxtDest = new System.Windows.Forms.TextBox();
            this.TxtDir = new System.Windows.Forms.TextBox();
            this.TxtShow = new System.Windows.Forms.RichTextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "來源檔案 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "目的檔案 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "資料夾名稱 :";
            // 
            // TxtSource
            // 
            this.TxtSource.Location = new System.Drawing.Point(126, 39);
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.Size = new System.Drawing.Size(515, 25);
            this.TxtSource.TabIndex = 3;
            // 
            // TxtDest
            // 
            this.TxtDest.Location = new System.Drawing.Point(126, 116);
            this.TxtDest.Name = "TxtDest";
            this.TxtDest.Size = new System.Drawing.Size(515, 25);
            this.TxtDest.TabIndex = 4;
            // 
            // TxtDir
            // 
            this.TxtDir.Location = new System.Drawing.Point(126, 198);
            this.TxtDir.Name = "TxtDir";
            this.TxtDir.Size = new System.Drawing.Size(515, 25);
            this.TxtDir.TabIndex = 5;
            // 
            // TxtShow
            // 
            this.TxtShow.Location = new System.Drawing.Point(31, 246);
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.Size = new System.Drawing.Size(610, 141);
            this.TxtShow.TabIndex = 6;
            this.TxtShow.Text = "";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(31, 432);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(119, 47);
            this.BtnCreate.TabIndex = 7;
            this.BtnCreate.Text = "建立";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnCopy
            // 
            this.BtnCopy.Location = new System.Drawing.Point(159, 432);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(119, 47);
            this.BtnCopy.TabIndex = 8;
            this.BtnCopy.Text = "複製";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(287, 432);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(119, 47);
            this.BtnCheck.TabIndex = 9;
            this.BtnCheck.Text = "查看";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(415, 432);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(119, 47);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "刪除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnMove
            // 
            this.BtnMove.Location = new System.Drawing.Point(543, 432);
            this.BtnMove.Name = "BtnMove";
            this.BtnMove.Size = new System.Drawing.Size(119, 47);
            this.BtnMove.TabIndex = 11;
            this.BtnMove.Text = "搬移";
            this.BtnMove.UseVisualStyleBackColor = true;
            this.BtnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 551);
            this.Controls.Add(this.BtnMove);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtShow);
            this.Controls.Add(this.TxtDir);
            this.Controls.Add(this.TxtDest);
            this.Controls.Add(this.TxtSource);
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
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.TextBox TxtDest;
        private System.Windows.Forms.TextBox TxtDir;
        private System.Windows.Forms.RichTextBox TxtShow;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnMove;
    }
}


namespace NameSort
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
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnASC = new System.Windows.Forms.Button();
            this.BtnDESC = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入查詢姓名 :";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(123, 22);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(270, 25);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(448, 21);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(126, 38);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "搜尋";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(448, 94);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(126, 38);
            this.BtnList.TabIndex = 3;
            this.BtnList.Text = "原始順序";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnASC
            // 
            this.BtnASC.Location = new System.Drawing.Point(448, 167);
            this.BtnASC.Name = "BtnASC";
            this.BtnASC.Size = new System.Drawing.Size(126, 38);
            this.BtnASC.TabIndex = 4;
            this.BtnASC.Text = "順序遞增";
            this.BtnASC.UseVisualStyleBackColor = true;
            this.BtnASC.Click += new System.EventHandler(this.BtnASC_Click);
            // 
            // BtnDESC
            // 
            this.BtnDESC.Location = new System.Drawing.Point(448, 240);
            this.BtnDESC.Name = "BtnDESC";
            this.BtnDESC.Size = new System.Drawing.Size(126, 38);
            this.BtnDESC.TabIndex = 5;
            this.BtnDESC.Text = "順序遞減";
            this.BtnDESC.UseVisualStyleBackColor = true;
            this.BtnDESC.Click += new System.EventHandler(this.BtnDESC_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(123, 72);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(269, 206);
            this.TxtName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 314);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnDESC);
            this.Controls.Add(this.BtnASC);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnASC;
        private System.Windows.Forms.Button BtnDESC;
        private System.Windows.Forms.TextBox TxtName;
    }
}


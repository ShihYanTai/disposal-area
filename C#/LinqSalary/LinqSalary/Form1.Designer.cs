namespace LinqSalary
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
            this.DgvSalary = new System.Windows.Forms.DataGridView();
            this.BtnId = new System.Windows.Forms.Button();
            this.BtnName = new System.Windows.Forms.Button();
            this.BtnSalary = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxTId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSalary
            // 
            this.DgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSalary.Location = new System.Drawing.Point(21, 36);
            this.DgvSalary.Name = "DgvSalary";
            this.DgvSalary.RowHeadersWidth = 51;
            this.DgvSalary.RowTemplate.Height = 27;
            this.DgvSalary.Size = new System.Drawing.Size(499, 374);
            this.DgvSalary.TabIndex = 0;
            // 
            // BtnId
            // 
            this.BtnId.Location = new System.Drawing.Point(548, 36);
            this.BtnId.Name = "BtnId";
            this.BtnId.Size = new System.Drawing.Size(132, 43);
            this.BtnId.TabIndex = 1;
            this.BtnId.Text = "依編號排";
            this.BtnId.UseVisualStyleBackColor = true;
            this.BtnId.Click += new System.EventHandler(this.BtnId_Click);
            // 
            // BtnName
            // 
            this.BtnName.Location = new System.Drawing.Point(548, 97);
            this.BtnName.Name = "BtnName";
            this.BtnName.Size = new System.Drawing.Size(132, 43);
            this.BtnName.TabIndex = 2;
            this.BtnName.Text = "依姓名排";
            this.BtnName.UseVisualStyleBackColor = true;
            this.BtnName.Click += new System.EventHandler(this.BtnName_Click);
            // 
            // BtnSalary
            // 
            this.BtnSalary.Location = new System.Drawing.Point(548, 162);
            this.BtnSalary.Name = "BtnSalary";
            this.BtnSalary.Size = new System.Drawing.Size(132, 43);
            this.BtnSalary.TabIndex = 3;
            this.BtnSalary.Text = "依薪資排";
            this.BtnSalary.UseVisualStyleBackColor = true;
            this.BtnSalary.Click += new System.EventHandler(this.BtnSalary_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(548, 290);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(132, 43);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "單筆查詢";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "員工編號 :";
            // 
            // TxTId
            // 
            this.TxTId.Location = new System.Drawing.Point(548, 240);
            this.TxTId.Name = "TxTId";
            this.TxTId.Size = new System.Drawing.Size(132, 25);
            this.TxTId.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxTId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnSalary);
            this.Controls.Add(this.BtnName);
            this.Controls.Add(this.BtnId);
            this.Controls.Add(this.DgvSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSalary;
        private System.Windows.Forms.Button BtnId;
        private System.Windows.Forms.Button BtnName;
        private System.Windows.Forms.Button BtnSalary;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxTId;
    }
}


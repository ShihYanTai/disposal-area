namespace LinqDataSet
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
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnPrice = new System.Windows.Forms.Button();
            this.BtnAmount = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DvgShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DvgShow)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInfo
            // 
            this.BtnInfo.Location = new System.Drawing.Point(472, 38);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(128, 46);
            this.BtnInfo.TabIndex = 0;
            this.BtnInfo.Text = "產品資訊";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnPrice
            // 
            this.BtnPrice.Location = new System.Drawing.Point(472, 113);
            this.BtnPrice.Name = "BtnPrice";
            this.BtnPrice.Size = new System.Drawing.Size(128, 46);
            this.BtnPrice.TabIndex = 1;
            this.BtnPrice.Text = "依單價遞增排序";
            this.BtnPrice.UseVisualStyleBackColor = true;
            this.BtnPrice.Click += new System.EventHandler(this.BtnPrice_Click);
            // 
            // BtnAmount
            // 
            this.BtnAmount.Location = new System.Drawing.Point(472, 188);
            this.BtnAmount.Name = "BtnAmount";
            this.BtnAmount.Size = new System.Drawing.Size(128, 46);
            this.BtnAmount.TabIndex = 2;
            this.BtnAmount.Text = "依庫存遞減排序";
            this.BtnAmount.UseVisualStyleBackColor = true;
            this.BtnAmount.Click += new System.EventHandler(this.BtnAmount_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(472, 315);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(128, 46);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "搜尋";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "產品關鍵查詢 :";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(472, 276);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(127, 25);
            this.TxtSearch.TabIndex = 5;
            // 
            // DvgShow
            // 
            this.DvgShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgShow.Location = new System.Drawing.Point(13, 38);
            this.DvgShow.Name = "DvgShow";
            this.DvgShow.RowHeadersWidth = 51;
            this.DvgShow.RowTemplate.Height = 27;
            this.DvgShow.Size = new System.Drawing.Size(432, 322);
            this.DvgShow.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 403);
            this.Controls.Add(this.DvgShow);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnAmount);
            this.Controls.Add(this.BtnPrice);
            this.Controls.Add(this.BtnInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnPrice;
        private System.Windows.Forms.Button BtnAmount;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DvgShow;
    }
}


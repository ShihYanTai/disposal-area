namespace LinqProduct
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
            this.DgvProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnASC = new System.Windows.Forms.Button();
            this.BtnDESC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProduct
            // 
            this.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduct.Location = new System.Drawing.Point(32, 44);
            this.DgvProduct.Name = "DgvProduct";
            this.DgvProduct.RowHeadersWidth = 51;
            this.DgvProduct.RowTemplate.Height = 27;
            this.DgvProduct.Size = new System.Drawing.Size(496, 271);
            this.DgvProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "輸入查詢品名 : ";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(566, 71);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(145, 25);
            this.TxtSearch.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(566, 120);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(145, 39);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "搜尋";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(566, 172);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(145, 39);
            this.BtnList.TabIndex = 4;
            this.BtnList.Text = "產品資料";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnASC
            // 
            this.BtnASC.Location = new System.Drawing.Point(566, 224);
            this.BtnASC.Name = "BtnASC";
            this.BtnASC.Size = new System.Drawing.Size(145, 39);
            this.BtnASC.TabIndex = 5;
            this.BtnASC.Text = "遞增排序";
            this.BtnASC.UseVisualStyleBackColor = true;
            this.BtnASC.Click += new System.EventHandler(this.BtnASC_Click);
            // 
            // BtnDESC
            // 
            this.BtnDESC.Location = new System.Drawing.Point(566, 276);
            this.BtnDESC.Name = "BtnDESC";
            this.BtnDESC.Size = new System.Drawing.Size(145, 39);
            this.BtnDESC.TabIndex = 6;
            this.BtnDESC.Text = "遞減排序";
            this.BtnDESC.UseVisualStyleBackColor = true;
            this.BtnDESC.Click += new System.EventHandler(this.BtnDESC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 346);
            this.Controls.Add(this.BtnDESC);
            this.Controls.Add(this.BtnASC);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnASC;
        private System.Windows.Forms.Button BtnDESC;
    }
}


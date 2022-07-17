namespace LinqXML
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
            this.DgvShow = new System.Windows.Forms.DataGridView();
            this.BtnCountry = new System.Windows.Forms.Button();
            this.BtnPM25 = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvShow
            // 
            this.DgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvShow.Location = new System.Drawing.Point(12, 32);
            this.DgvShow.Name = "DgvShow";
            this.DgvShow.RowHeadersWidth = 51;
            this.DgvShow.RowTemplate.Height = 27;
            this.DgvShow.Size = new System.Drawing.Size(444, 304);
            this.DgvShow.TabIndex = 0;
            // 
            // BtnCountry
            // 
            this.BtnCountry.Location = new System.Drawing.Point(478, 32);
            this.BtnCountry.Name = "BtnCountry";
            this.BtnCountry.Size = new System.Drawing.Size(170, 43);
            this.BtnCountry.TabIndex = 1;
            this.BtnCountry.Text = "依縣市遞增排序";
            this.BtnCountry.UseVisualStyleBackColor = true;
            this.BtnCountry.Click += new System.EventHandler(this.BtnCountry_Click);
            // 
            // BtnPM25
            // 
            this.BtnPM25.Location = new System.Drawing.Point(478, 81);
            this.BtnPM25.Name = "BtnPM25";
            this.BtnPM25.Size = new System.Drawing.Size(170, 43);
            this.BtnPM25.TabIndex = 2;
            this.BtnPM25.Text = "依 PM 2.5 遞減排序";
            this.BtnPM25.UseVisualStyleBackColor = true;
            this.BtnPM25.Click += new System.EventHandler(this.BtnPM25_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(497, 248);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(116, 43);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "搜尋";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "PM 2.5 濃度查詢 :";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(478, 203);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(169, 25);
            this.TxtSearch.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 376);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnPM25);
            this.Controls.Add(this.BtnCountry);
            this.Controls.Add(this.DgvShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvShow;
        private System.Windows.Forms.Button BtnCountry;
        private System.Windows.Forms.Button BtnPM25;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
    }
}


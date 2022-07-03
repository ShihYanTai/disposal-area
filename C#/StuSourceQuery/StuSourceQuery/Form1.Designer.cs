namespace StuSourceQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCopy1 = new System.Windows.Forms.Button();
            this.BtnCopy2 = new System.Windows.Forms.Button();
            this.TxtSqlCmd2 = new System.Windows.Forms.TextBox();
            this.TxtSqlCmd1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(149, 29);
            this.toolStripLabel1.Text = "SQL 查詢命令 : ";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 32);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 29);
            this.toolStripButton1.Text = "查詢";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(711, 213);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. 250 分 以上 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. 前三名 : ";
            // 
            // BtnCopy1
            // 
            this.BtnCopy1.Location = new System.Drawing.Point(601, 285);
            this.BtnCopy1.Name = "BtnCopy1";
            this.BtnCopy1.Size = new System.Drawing.Size(117, 50);
            this.BtnCopy1.TabIndex = 6;
            this.BtnCopy1.Text = "複製命令1";
            this.BtnCopy1.UseVisualStyleBackColor = true;
            this.BtnCopy1.Click += new System.EventHandler(this.BtnCopy1_Click);
            // 
            // BtnCopy2
            // 
            this.BtnCopy2.Location = new System.Drawing.Point(601, 407);
            this.BtnCopy2.Name = "BtnCopy2";
            this.BtnCopy2.Size = new System.Drawing.Size(117, 50);
            this.BtnCopy2.TabIndex = 7;
            this.BtnCopy2.Text = "複製命令2";
            this.BtnCopy2.UseVisualStyleBackColor = true;
            this.BtnCopy2.Click += new System.EventHandler(this.BtnCopy2_Click);
            // 
            // TxtSqlCmd2
            // 
            this.TxtSqlCmd2.Location = new System.Drawing.Point(152, 407);
            this.TxtSqlCmd2.Multiline = true;
            this.TxtSqlCmd2.Name = "TxtSqlCmd2";
            this.TxtSqlCmd2.Size = new System.Drawing.Size(392, 93);
            this.TxtSqlCmd2.TabIndex = 8;
            // 
            // TxtSqlCmd1
            // 
            this.TxtSqlCmd1.Location = new System.Drawing.Point(152, 285);
            this.TxtSqlCmd1.Multiline = true;
            this.TxtSqlCmd1.Name = "TxtSqlCmd1";
            this.TxtSqlCmd1.Size = new System.Drawing.Size(392, 95);
            this.TxtSqlCmd1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 567);
            this.Controls.Add(this.TxtSqlCmd1);
            this.Controls.Add(this.TxtSqlCmd2);
            this.Controls.Add(this.BtnCopy2);
            this.Controls.Add(this.BtnCopy1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCopy1;
        private System.Windows.Forms.Button BtnCopy2;
        private System.Windows.Forms.TextBox TxtSqlCmd2;
        private System.Windows.Forms.TextBox TxtSqlCmd1;
    }
}


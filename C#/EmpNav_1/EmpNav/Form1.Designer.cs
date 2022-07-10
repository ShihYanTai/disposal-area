namespace EmpNav
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtP = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtBirthday = new System.Windows.Forms.TextBox();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.CboName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "員工編號 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "地址 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "職稱 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "出生日期 :";
            // 
            // TxtP
            // 
            this.TxtP.Location = new System.Drawing.Point(368, 74);
            this.TxtP.Name = "TxtP";
            this.TxtP.Size = new System.Drawing.Size(188, 25);
            this.TxtP.TabIndex = 6;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(97, 74);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(188, 25);
            this.TxtId.TabIndex = 7;
            // 
            // TxtBirthday
            // 
            this.TxtBirthday.Location = new System.Drawing.Point(639, 74);
            this.TxtBirthday.Name = "TxtBirthday";
            this.TxtBirthday.Size = new System.Drawing.Size(188, 25);
            this.TxtBirthday.TabIndex = 8;
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(97, 144);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(730, 25);
            this.TxtAdd.TabIndex = 9;
            // 
            // CboName
            // 
            this.CboName.FormattingEnabled = true;
            this.CboName.Location = new System.Drawing.Point(97, 18);
            this.CboName.Name = "CboName";
            this.CboName.Size = new System.Drawing.Size(187, 23);
            this.CboName.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(782, 264);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CboName);
            this.Controls.Add(this.TxtAdd);
            this.Controls.Add(this.TxtBirthday);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "員工資料尋覽";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtP;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtBirthday;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.ComboBox CboName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


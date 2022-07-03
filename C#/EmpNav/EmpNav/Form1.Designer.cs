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
            this.CboName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtP = new System.Windows.Forms.TextBox();
            this.TxtBirthday = new System.Windows.Forms.TextBox();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CboName
            // 
            this.CboName.FormattingEnabled = true;
            this.CboName.Items.AddRange(new object[] {
            "張瑾雯",
            "陳季暄",
            "趙飛燕",
            "林美麗",
            "劉天王",
            "黎國明",
            "郭國臹",
            "蘇函蘊",
            "孟庭亭",
            "賴俊良",
            "何大樓",
            "王大德"});
            this.CboName.Location = new System.Drawing.Point(85, 37);
            this.CboName.Name = "CboName";
            this.CboName.Size = new System.Drawing.Size(117, 23);
            this.CboName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 8F);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 8F);
            this.label2.Location = new System.Drawing.Point(1, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "員工編號 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 8F);
            this.label3.Location = new System.Drawing.Point(217, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "職稱 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 8F);
            this.label4.Location = new System.Drawing.Point(398, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "出生日期 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 8F);
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "地址 :";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(85, 98);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(117, 25);
            this.TxtId.TabIndex = 6;
            // 
            // TxtP
            // 
            this.TxtP.Location = new System.Drawing.Point(278, 98);
            this.TxtP.Name = "TxtP";
            this.TxtP.Size = new System.Drawing.Size(117, 25);
            this.TxtP.TabIndex = 7;
            // 
            // TxtBirthday
            // 
            this.TxtBirthday.Location = new System.Drawing.Point(475, 98);
            this.TxtBirthday.Name = "TxtBirthday";
            this.TxtBirthday.Size = new System.Drawing.Size(117, 25);
            this.TxtBirthday.TabIndex = 8;
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(85, 174);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(507, 25);
            this.TxtAdd.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(563, 176);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtAdd);
            this.Controls.Add(this.TxtBirthday);
            this.Controls.Add(this.TxtP);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtP;
        private System.Windows.Forms.TextBox TxtBirthday;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


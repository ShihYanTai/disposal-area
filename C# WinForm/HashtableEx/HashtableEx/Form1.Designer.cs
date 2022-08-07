namespace HashtableEx
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tabpage1 = new System.Windows.Forms.TabPage();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tabpage2 = new System.Windows.Forms.TabPage();
            this.TxtBrows = new System.Windows.Forms.TextBox();
            this.Tabpage3 = new System.Windows.Forms.TabPage();
            this.BtnDel = new System.Windows.Forms.Button();
            this.TxtDel = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Tabpage1.SuspendLayout();
            this.Tabpage2.SuspendLayout();
            this.Tabpage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tabpage1);
            this.tabControl1.Controls.Add(this.Tabpage2);
            this.tabControl1.Controls.Add(this.Tabpage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // Tabpage1
            // 
            this.Tabpage1.Controls.Add(this.BtnAdd);
            this.Tabpage1.Controls.Add(this.TxtScore);
            this.Tabpage1.Controls.Add(this.TxtName);
            this.Tabpage1.Controls.Add(this.label2);
            this.Tabpage1.Controls.Add(this.label1);
            this.Tabpage1.Location = new System.Drawing.Point(4, 25);
            this.Tabpage1.Name = "Tabpage1";
            this.Tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.Tabpage1.Size = new System.Drawing.Size(486, 276);
            this.Tabpage1.TabIndex = 0;
            this.Tabpage1.Text = "新增";
            this.Tabpage1.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(302, 59);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(92, 33);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "加入";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(137, 65);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(122, 25);
            this.TxtScore.TabIndex = 3;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(137, 21);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(122, 25);
            this.TxtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入成績 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入名字 : ";
            // 
            // Tabpage2
            // 
            this.Tabpage2.Controls.Add(this.TxtBrows);
            this.Tabpage2.Location = new System.Drawing.Point(4, 25);
            this.Tabpage2.Name = "Tabpage2";
            this.Tabpage2.Padding = new System.Windows.Forms.Padding(3);
            this.Tabpage2.Size = new System.Drawing.Size(486, 276);
            this.Tabpage2.TabIndex = 1;
            this.Tabpage2.Text = "查詢";
            this.Tabpage2.UseVisualStyleBackColor = true;
            // 
            // TxtBrows
            // 
            this.TxtBrows.Location = new System.Drawing.Point(55, 43);
            this.TxtBrows.Multiline = true;
            this.TxtBrows.Name = "TxtBrows";
            this.TxtBrows.ReadOnly = true;
            this.TxtBrows.Size = new System.Drawing.Size(371, 198);
            this.TxtBrows.TabIndex = 0;
            // 
            // Tabpage3
            // 
            this.Tabpage3.Controls.Add(this.BtnDel);
            this.Tabpage3.Controls.Add(this.TxtDel);
            this.Tabpage3.Controls.Add(this.LblMsg);
            this.Tabpage3.Controls.Add(this.label3);
            this.Tabpage3.Location = new System.Drawing.Point(4, 25);
            this.Tabpage3.Name = "Tabpage3";
            this.Tabpage3.Size = new System.Drawing.Size(486, 276);
            this.Tabpage3.TabIndex = 2;
            this.Tabpage3.Text = "刪除";
            this.Tabpage3.UseVisualStyleBackColor = true;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(341, 67);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(85, 37);
            this.BtnDel.TabIndex = 3;
            this.BtnDel.Text = "刪除";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // TxtDel
            // 
            this.TxtDel.Location = new System.Drawing.Point(148, 35);
            this.TxtDel.Name = "TxtDel";
            this.TxtDel.Size = new System.Drawing.Size(109, 25);
            this.TxtDel.TabIndex = 2;
            this.TxtDel.TextChanged += new System.EventHandler(this.TxtDel_TextChanged);
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(41, 89);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(37, 15);
            this.LblMsg.TabIndex = 1;
            this.LblMsg.Text = "訊息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "請輸入名字 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 325);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tabpage1.ResumeLayout(false);
            this.Tabpage1.PerformLayout();
            this.Tabpage2.ResumeLayout(false);
            this.Tabpage2.PerformLayout();
            this.Tabpage3.ResumeLayout(false);
            this.Tabpage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tabpage1;
        private System.Windows.Forms.TabPage Tabpage2;
        private System.Windows.Forms.TabPage Tabpage3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBrows;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.TextBox TxtDel;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Label label3;
    }
}


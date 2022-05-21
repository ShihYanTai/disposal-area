namespace 活力早餐
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtM2 = new System.Windows.Forms.TextBox();
            this.TxtM1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ChkM2 = new System.Windows.Forms.CheckBox();
            this.ChkM1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtR2 = new System.Windows.Forms.TextBox();
            this.TxtR1 = new System.Windows.Forms.TextBox();
            this.ChkR2 = new System.Windows.Forms.CheckBox();
            this.ChkR1 = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(84, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 203);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtPW);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxtID);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(321, 174);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "登錄";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(79, 94);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(104, 25);
            this.TxtPW.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "使用者 :";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(79, 45);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(104, 25);
            this.TxtID.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TxtM2);
            this.tabPage2.Controls.Add(this.TxtM1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.ChkM2);
            this.tabPage2.Controls.Add(this.ChkM1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(321, 174);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "主餐";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "數量";
            // 
            // TxtM2
            // 
            this.TxtM2.Location = new System.Drawing.Point(153, 92);
            this.TxtM2.Name = "TxtM2";
            this.TxtM2.Size = new System.Drawing.Size(120, 25);
            this.TxtM2.TabIndex = 4;
            // 
            // TxtM1
            // 
            this.TxtM1.Location = new System.Drawing.Point(153, 36);
            this.TxtM1.Name = "TxtM1";
            this.TxtM1.Size = new System.Drawing.Size(121, 25);
            this.TxtM1.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(301, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(8, 25);
            this.textBox3.TabIndex = 2;
            // 
            // ChkM2
            // 
            this.ChkM2.AutoSize = true;
            this.ChkM2.Location = new System.Drawing.Point(28, 97);
            this.ChkM2.Name = "ChkM2";
            this.ChkM2.Size = new System.Drawing.Size(113, 19);
            this.ChkM2.TabIndex = 1;
            this.ChkM2.Text = "三明治(30元)";
            this.ChkM2.UseVisualStyleBackColor = true;
            this.ChkM2.CheckedChanged += new System.EventHandler(this.ChkM2_CheckedChanged);
            // 
            // ChkM1
            // 
            this.ChkM1.AutoSize = true;
            this.ChkM1.Location = new System.Drawing.Point(28, 42);
            this.ChkM1.Name = "ChkM1";
            this.ChkM1.Size = new System.Drawing.Size(98, 19);
            this.ChkM1.TabIndex = 0;
            this.ChkM1.Text = "蛋餅(20元)";
            this.ChkM1.UseVisualStyleBackColor = true;
            this.ChkM1.CheckedChanged += new System.EventHandler(this.ChkM1_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.TxtR2);
            this.tabPage3.Controls.Add(this.TxtR1);
            this.tabPage3.Controls.Add(this.ChkR2);
            this.tabPage3.Controls.Add(this.ChkR1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(321, 174);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "飲料";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "數量";
            // 
            // TxtR2
            // 
            this.TxtR2.Location = new System.Drawing.Point(145, 91);
            this.TxtR2.Name = "TxtR2";
            this.TxtR2.Size = new System.Drawing.Size(123, 25);
            this.TxtR2.TabIndex = 3;
            // 
            // TxtR1
            // 
            this.TxtR1.Location = new System.Drawing.Point(145, 37);
            this.TxtR1.Name = "TxtR1";
            this.TxtR1.Size = new System.Drawing.Size(123, 25);
            this.TxtR1.TabIndex = 2;
            // 
            // ChkR2
            // 
            this.ChkR2.AutoSize = true;
            this.ChkR2.Location = new System.Drawing.Point(27, 93);
            this.ChkR2.Name = "ChkR2";
            this.ChkR2.Size = new System.Drawing.Size(98, 19);
            this.ChkR2.TabIndex = 1;
            this.ChkR2.Text = "奶茶(20元)";
            this.ChkR2.UseVisualStyleBackColor = true;
            this.ChkR2.CheckedChanged += new System.EventHandler(this.ChkR2_CheckedChanged);
            // 
            // ChkR1
            // 
            this.ChkR1.AutoSize = true;
            this.ChkR1.Location = new System.Drawing.Point(27, 39);
            this.ChkR1.Name = "ChkR1";
            this.ChkR1.Size = new System.Drawing.Size(98, 19);
            this.ChkR1.TabIndex = 0;
            this.ChkR1.Text = "豆漿(15元)";
            this.ChkR1.UseVisualStyleBackColor = true;
            this.ChkR1.CheckedChanged += new System.EventHandler(this.ChkR1_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.LblTotal);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(321, 174);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "結帳";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(48, 29);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(41, 15);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "label5";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(81, 266);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(97, 15);
            this.LblMsg.TabIndex = 1;
            this.LblMsg.Text = "活力早餐系統";
            this.LblMsg.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 332);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "活力早餐店";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtM2;
        private System.Windows.Forms.TextBox TxtM1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox ChkM2;
        private System.Windows.Forms.CheckBox ChkM1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtR2;
        private System.Windows.Forms.TextBox TxtR1;
        private System.Windows.Forms.CheckBox ChkR2;
        private System.Windows.Forms.CheckBox ChkR1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblMsg;
    }
}


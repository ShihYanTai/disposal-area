namespace UserRecord
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.RdbMale = new System.Windows.Forms.RadioButton();
            this.RdbFemale = new System.Windows.Forms.RadioButton();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtInNa = new System.Windows.Forms.TextBox();
            this.TxtInPW = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtBrows = new System.Windows.Forms.TextBox();
            this.BtnBrows = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(41, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 269);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnAdd);
            this.tabPage1.Controls.Add(this.RdbFemale);
            this.tabPage1.Controls.Add(this.RdbMale);
            this.tabPage1.Controls.Add(this.TxtTel);
            this.tabPage1.Controls.Add(this.TxtPW);
            this.tabPage1.Controls.Add(this.TxtName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(378, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新增";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnLogin);
            this.tabPage2.Controls.Add(this.TxtInPW);
            this.tabPage2.Controls.Add(this.TxtInNa);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(378, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "查詢";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnBrows);
            this.tabPage3.Controls.Add(this.TxtBrows);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(378, 240);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "瀏覽";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "性別 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "密碼 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "電話 : ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(81, 32);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(172, 25);
            this.TxtName.TabIndex = 4;
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(81, 125);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(172, 25);
            this.TxtPW.TabIndex = 5;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(81, 180);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(172, 25);
            this.TxtTel.TabIndex = 6;
            // 
            // RdbMale
            // 
            this.RdbMale.AutoSize = true;
            this.RdbMale.Location = new System.Drawing.Point(89, 75);
            this.RdbMale.Name = "RdbMale";
            this.RdbMale.Size = new System.Drawing.Size(43, 19);
            this.RdbMale.TabIndex = 7;
            this.RdbMale.TabStop = true;
            this.RdbMale.Text = "男";
            this.RdbMale.UseVisualStyleBackColor = true;
            // 
            // RdbFemale
            // 
            this.RdbFemale.AutoSize = true;
            this.RdbFemale.Location = new System.Drawing.Point(168, 75);
            this.RdbFemale.Name = "RdbFemale";
            this.RdbFemale.Size = new System.Drawing.Size(43, 19);
            this.RdbFemale.TabIndex = 8;
            this.RdbFemale.TabStop = true;
            this.RdbFemale.Text = "女";
            this.RdbFemale.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(276, 170);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(77, 35);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = " 加入";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "姓名 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "密碼 : ";
            // 
            // TxtInNa
            // 
            this.TxtInNa.Location = new System.Drawing.Point(103, 36);
            this.TxtInNa.Name = "TxtInNa";
            this.TxtInNa.Size = new System.Drawing.Size(114, 25);
            this.TxtInNa.TabIndex = 2;
            // 
            // TxtInPW
            // 
            this.TxtInPW.Location = new System.Drawing.Point(103, 102);
            this.TxtInPW.Name = "TxtInPW";
            this.TxtInPW.Size = new System.Drawing.Size(114, 25);
            this.TxtInPW.TabIndex = 3;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(253, 96);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(90, 33);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "登入";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtBrows
            // 
            this.TxtBrows.Location = new System.Drawing.Point(40, 26);
            this.TxtBrows.Multiline = true;
            this.TxtBrows.Name = "TxtBrows";
            this.TxtBrows.ReadOnly = true;
            this.TxtBrows.Size = new System.Drawing.Size(220, 155);
            this.TxtBrows.TabIndex = 0;
            // 
            // BtnBrows
            // 
            this.BtnBrows.Location = new System.Drawing.Point(284, 143);
            this.BtnBrows.Name = "BtnBrows";
            this.BtnBrows.Size = new System.Drawing.Size(75, 38);
            this.BtnBrows.TabIndex = 1;
            this.BtnBrows.Text = "瀏覽";
            this.BtnBrows.UseVisualStyleBackColor = true;
            this.BtnBrows.Click += new System.EventHandler(this.BtnBrows_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 316);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.RadioButton RdbFemale;
        private System.Windows.Forms.RadioButton RdbMale;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtInPW;
        private System.Windows.Forms.TextBox TxtInNa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnBrows;
        private System.Windows.Forms.TextBox TxtBrows;
    }
}


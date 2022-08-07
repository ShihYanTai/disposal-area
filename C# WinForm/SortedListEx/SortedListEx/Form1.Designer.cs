namespace SortedListEx
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtBrows = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入名字 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "輸入成績 : ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(140, 30);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(144, 25);
            this.TxtName.TabIndex = 2;
            // 
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(140, 84);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(144, 25);
            this.TxtScore.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(74, 136);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(121, 35);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "加入";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtBrows
            // 
            this.TxtBrows.Location = new System.Drawing.Point(333, 33);
            this.TxtBrows.Multiline = true;
            this.TxtBrows.Name = "TxtBrows";
            this.TxtBrows.ReadOnly = true;
            this.TxtBrows.Size = new System.Drawing.Size(240, 136);
            this.TxtBrows.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 205);
            this.Controls.Add(this.TxtBrows);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtBrows;
    }
}


namespace Casher
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
            this.RdbWT = new System.Windows.Forms.RadioButton();
            this.RdbNum = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblBuy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblTot = new System.Windows.Forms.Label();
            this.BtnCal = new System.Windows.Forms.Button();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RdbWT
            // 
            this.RdbWT.AutoSize = true;
            this.RdbWT.Location = new System.Drawing.Point(19, 47);
            this.RdbWT.Name = "RdbWT";
            this.RdbWT.Size = new System.Drawing.Size(58, 19);
            this.RdbWT.TabIndex = 0;
            this.RdbWT.TabStop = true;
            this.RdbWT.Text = "公斤";
            this.RdbWT.UseVisualStyleBackColor = true;
            this.RdbWT.Click += new System.EventHandler(this.RdbWT_Click);
            // 
            // RdbNum
            // 
            this.RdbNum.AutoSize = true;
            this.RdbNum.Location = new System.Drawing.Point(92, 47);
            this.RdbNum.Name = "RdbNum";
            this.RdbNum.Size = new System.Drawing.Size(58, 19);
            this.RdbNum.TabIndex = 1;
            this.RdbNum.TabStop = true;
            this.RdbNum.Text = "個數";
            this.RdbNum.UseVisualStyleBackColor = true;
            this.RdbNum.Click += new System.EventHandler(this.RdbNum_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbNum);
            this.groupBox1.Controls.Add(this.RdbWT);
            this.groupBox1.Location = new System.Drawing.Point(31, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "結算的種類";
            // 
            // LblBuy
            // 
            this.LblBuy.AutoSize = true;
            this.LblBuy.Location = new System.Drawing.Point(32, 175);
            this.LblBuy.Name = "LblBuy";
            this.LblBuy.Size = new System.Drawing.Size(105, 15);
            this.LblBuy.TabIndex = 3;
            this.LblBuy.Text = "輸入購買數量 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "輸入單價(元) :";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(32, 273);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(41, 15);
            this.LblPrice.TabIndex = 5;
            this.LblPrice.Text = "label3";
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.Location = new System.Drawing.Point(199, 273);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(75, 15);
            this.LblTot.TabIndex = 6;
            this.LblTot.Text = "累計收費 :";
            // 
            // BtnCal
            // 
            this.BtnCal.Location = new System.Drawing.Point(240, 60);
            this.BtnCal.Name = "BtnCal";
            this.BtnCal.Size = new System.Drawing.Size(82, 48);
            this.BtnCal.TabIndex = 7;
            this.BtnCal.Text = "計算";
            this.BtnCal.UseVisualStyleBackColor = true;
            this.BtnCal.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(143, 172);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(97, 25);
            this.TxtNum.TabIndex = 8;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(143, 224);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(97, 25);
            this.TxtPrice.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 311);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.BtnCal);
            this.Controls.Add(this.LblTot);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblBuy);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbWT;
        private System.Windows.Forms.RadioButton RdbNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblTot;
        private System.Windows.Forms.Button BtnCal;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.TextBox TxtPrice;
    }
}


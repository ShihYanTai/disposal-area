namespace 點餐
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.TxtQty1 = new System.Windows.Forms.TextBox();
            this.TxtQty2 = new System.Windows.Forms.TextBox();
            this.TxtQty3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(56, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "布丁奶茶(50元)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(56, 99);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "冰晶咖啡(80元)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(56, 160);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(128, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "芋園豆花(60元)";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // TxtQty1
            // 
            this.TxtQty1.Location = new System.Drawing.Point(254, 48);
            this.TxtQty1.Name = "TxtQty1";
            this.TxtQty1.Size = new System.Drawing.Size(178, 25);
            this.TxtQty1.TabIndex = 3;
            this.TxtQty1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtQty2
            // 
            this.TxtQty2.Location = new System.Drawing.Point(254, 99);
            this.TxtQty2.Name = "TxtQty2";
            this.TxtQty2.Size = new System.Drawing.Size(178, 25);
            this.TxtQty2.TabIndex = 4;
            this.TxtQty2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtQty3
            // 
            this.TxtQty3.Location = new System.Drawing.Point(254, 154);
            this.TxtQty3.Name = "TxtQty3";
            this.TxtQty3.Size = new System.Drawing.Size(178, 25);
            this.TxtQty3.TabIndex = 5;
            this.TxtQty3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "結帳";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.Location = new System.Drawing.Point(40, 243);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(83, 24);
            this.LblMsg.TabIndex = 7;
            this.LblMsg.Text = "LblMsg";
            this.LblMsg.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 324);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtQty3);
            this.Controls.Add(this.TxtQty2);
            this.Controls.Add(this.TxtQty1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox TxtQty1;
        private System.Windows.Forms.TextBox TxtQty2;
        private System.Windows.Forms.TextBox TxtQty3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblMsg;
    }
}


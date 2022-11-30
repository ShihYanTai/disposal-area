namespace Auto_Run
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
            this.components = new System.ComponentModel.Container();
            this.Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Recalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Account = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GridView_Progress = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Progress)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(550, 128);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(78, 32);
            this.Login.TabIndex = 0;
            this.Login.Text = "User Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Windows system\'s time :";
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTime.Location = new System.Drawing.Point(44, 19);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(141, 22);
            this.StartTime.TabIndex = 2;
            // 
            // EndTime
            // 
            this.EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTime.Location = new System.Drawing.Point(44, 47);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(141, 22);
            this.EndTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "End :";
            // 
            // Recalculate
            // 
            this.Recalculate.Location = new System.Drawing.Point(223, 24);
            this.Recalculate.Name = "Recalculate";
            this.Recalculate.Size = new System.Drawing.Size(79, 42);
            this.Recalculate.TabIndex = 6;
            this.Recalculate.Text = "Execute";
            this.Recalculate.UseVisualStyleBackColor = true;
            this.Recalculate.Click += new System.EventHandler(this.Recalculate_Click);
            this.Recalculate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Recalculate_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Recalculate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EndTime);
            this.groupBox1.Controls.Add(this.StartTime);
            this.groupBox1.Location = new System.Drawing.Point(193, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recalculate Parameter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Recalculate Status : ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 71);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(175, 33);
            this.progressBar1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(550, 33);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(84, 22);
            this.Account.TabIndex = 11;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(550, 85);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(84, 22);
            this.Password.TabIndex = 12;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Account :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // GridView_Progress
            // 
            this.GridView_Progress.AllowUserToAddRows = false;
            this.GridView_Progress.AllowUserToDeleteRows = false;
            this.GridView_Progress.AllowUserToResizeColumns = false;
            this.GridView_Progress.AllowUserToResizeRows = false;
            this.GridView_Progress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Progress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Progress.Location = new System.Drawing.Point(12, 173);
            this.GridView_Progress.Name = "GridView_Progress";
            this.GridView_Progress.RowTemplate.Height = 24;
            this.GridView_Progress.Size = new System.Drawing.Size(447, 310);
            this.GridView_Progress.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(12, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Today Progress : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "App time :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "label11";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("0");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("15");
            this.domainUpDown1.Items.Add("20");
            this.domainUpDown1.Items.Add("25");
            this.domainUpDown1.Items.Add("30");
            this.domainUpDown1.Items.Add("35");
            this.domainUpDown1.Items.Add("40");
            this.domainUpDown1.Items.Add("45");
            this.domainUpDown1.Items.Add("50");
            this.domainUpDown1.Items.Add("55");
            this.domainUpDown1.Location = new System.Drawing.Point(125, 179);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(48, 22);
            this.domainUpDown1.TabIndex = 21;
            this.domainUpDown1.Text = "0";
            this.domainUpDown1.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "Set delay time :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.domainUpDown3);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.domainUpDown2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.domainUpDown1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(467, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 228);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set this App time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 27;
            this.label14.Text = "Hour";
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Items.Add("0");
            this.domainUpDown3.Items.Add("1");
            this.domainUpDown3.Items.Add("2");
            this.domainUpDown3.Items.Add("3");
            this.domainUpDown3.Items.Add("4");
            this.domainUpDown3.Items.Add("5");
            this.domainUpDown3.Items.Add("6");
            this.domainUpDown3.Items.Add("7");
            this.domainUpDown3.Items.Add("8");
            this.domainUpDown3.Items.Add("9");
            this.domainUpDown3.Items.Add("10");
            this.domainUpDown3.Items.Add("11");
            this.domainUpDown3.Items.Add("12");
            this.domainUpDown3.Items.Add("13");
            this.domainUpDown3.Items.Add("14");
            this.domainUpDown3.Items.Add("15");
            this.domainUpDown3.Items.Add("16");
            this.domainUpDown3.Items.Add("17");
            this.domainUpDown3.Items.Add("18");
            this.domainUpDown3.Items.Add("19");
            this.domainUpDown3.Items.Add("20");
            this.domainUpDown3.Items.Add("21");
            this.domainUpDown3.Items.Add("22");
            this.domainUpDown3.Items.Add("23");
            this.domainUpDown3.Items.Add("24");
            this.domainUpDown3.Location = new System.Drawing.Point(6, 179);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(48, 22);
            this.domainUpDown3.TabIndex = 26;
            this.domainUpDown3.Text = "0";
            this.domainUpDown3.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "Minute";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("0");
            this.domainUpDown2.Items.Add("5");
            this.domainUpDown2.Items.Add("10");
            this.domainUpDown2.Items.Add("15");
            this.domainUpDown2.Items.Add("20");
            this.domainUpDown2.Items.Add("25");
            this.domainUpDown2.Items.Add("30");
            this.domainUpDown2.Items.Add("35");
            this.domainUpDown2.Items.Add("40");
            this.domainUpDown2.Items.Add("45");
            this.domainUpDown2.Items.Add("50");
            this.domainUpDown2.Items.Add("55");
            this.domainUpDown2.Location = new System.Drawing.Point(68, 179);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(48, 22);
            this.domainUpDown2.TabIndex = 24;
            this.domainUpDown2.Text = "0";
            this.domainUpDown2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "Second";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GridView_Progress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "AutoRun app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Progress)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Recalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GridView_Progress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.Label label8;
    }
}


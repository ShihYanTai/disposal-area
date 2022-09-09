namespace CPMS_Report
{
    partial class frmRawData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawData));
            this.TableVeiw = new System.Windows.Forms.DataGridView();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.TableSelect = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFile = new System.Windows.Forms.ToolStripButton();
            this.SaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblQuery = new System.Windows.Forms.Label();
            this.LblTable = new System.Windows.Forms.Label();
            this.DbSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataItemGroup = new System.Windows.Forms.GroupBox();
            this.AllTime = new System.Windows.Forms.CheckBox();
            this.DataShowStatus = new System.Windows.Forms.CheckBox();
            this.DataAllSelected = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableVeiw)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.DataItemGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableVeiw
            // 
            this.TableVeiw.BackgroundColor = System.Drawing.Color.White;
            this.TableVeiw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableVeiw.Location = new System.Drawing.Point(12, 241);
            this.TableVeiw.Name = "TableVeiw";
            this.TableVeiw.RowTemplate.Height = 24;
            this.TableVeiw.Size = new System.Drawing.Size(1779, 582);
            this.TableVeiw.TabIndex = 0;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStart.Location = new System.Drawing.Point(66, 70);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(178, 27);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.Value = new System.DateTime(2022, 8, 19, 0, 0, 0, 0);
            // 
            // BtnQuery
            // 
            this.BtnQuery.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnQuery.Location = new System.Drawing.Point(1671, 96);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(120, 37);
            this.BtnQuery.TabIndex = 2;
            this.BtnQuery.Text = "查詢";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // TableSelect
            // 
            this.TableSelect.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TableSelect.FormattingEnabled = true;
            this.TableSelect.Location = new System.Drawing.Point(271, 176);
            this.TableSelect.Name = "TableSelect";
            this.TableSelect.Size = new System.Drawing.Size(166, 24);
            this.TableSelect.TabIndex = 3;
            this.TableSelect.SelectedIndexChanged += new System.EventHandler(this.TableSelect_SelectedIndexChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(66, 175);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(178, 27);
            this.dateTimePickerEnd.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.OldLace;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveFile,
            this.toolStripSeparator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1803, 33);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenFile
            // 
            this.OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenFile.Image")));
            this.OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(30, 30);
            this.OpenFile.Text = "開啟(&O)";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("SaveFile.Image")));
            this.SaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(30, 30);
            this.SaveFile.Text = "儲存(&S)";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblTime.Location = new System.Drawing.Point(64, 36);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(138, 19);
            this.LblTime.TabIndex = 6;
            this.LblTime.Text = "選擇查詢時間 : ";
            // 
            // LblQuery
            // 
            this.LblQuery.AutoSize = true;
            this.LblQuery.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblQuery.Location = new System.Drawing.Point(280, 36);
            this.LblQuery.Name = "LblQuery";
            this.LblQuery.Size = new System.Drawing.Size(157, 19);
            this.LblQuery.TabIndex = 7;
            this.LblQuery.Text = "選擇查詢資料庫 : ";
            // 
            // LblTable
            // 
            this.LblTable.AutoSize = true;
            this.LblTable.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblTable.Location = new System.Drawing.Point(292, 139);
            this.LblTable.Name = "LblTable";
            this.LblTable.Size = new System.Drawing.Size(133, 19);
            this.LblTable.TabIndex = 8;
            this.LblTable.Text = "選擇查詢表單 :";
            // 
            // DbSelect
            // 
            this.DbSelect.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DbSelect.FormattingEnabled = true;
            this.DbSelect.Location = new System.Drawing.Point(271, 71);
            this.DbSelect.Name = "DbSelect";
            this.DbSelect.Size = new System.Drawing.Size(166, 24);
            this.DbSelect.TabIndex = 9;
            this.DbSelect.SelectedIndexChanged += new System.EventHandler(this.DbSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "開始 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "結束 :";
            // 
            // DataItemGroup
            // 
            this.DataItemGroup.Controls.Add(this.AllTime);
            this.DataItemGroup.Controls.Add(this.DataShowStatus);
            this.DataItemGroup.Controls.Add(this.DataAllSelected);
            this.DataItemGroup.Font = new System.Drawing.Font("新細明體", 12F);
            this.DataItemGroup.Location = new System.Drawing.Point(443, 12);
            this.DataItemGroup.Name = "DataItemGroup";
            this.DataItemGroup.Size = new System.Drawing.Size(1222, 223);
            this.DataItemGroup.TabIndex = 12;
            this.DataItemGroup.TabStop = false;
            this.DataItemGroup.Text = "測項";
            // 
            // AllTime
            // 
            this.AllTime.AutoSize = true;
            this.AllTime.Location = new System.Drawing.Point(350, 0);
            this.AllTime.Name = "AllTime";
            this.AllTime.Size = new System.Drawing.Size(90, 20);
            this.AllTime.TabIndex = 2;
            this.AllTime.Text = "所有時間";
            this.AllTime.UseVisualStyleBackColor = true;
            // 
            // DataShowStatus
            // 
            this.DataShowStatus.AutoSize = true;
            this.DataShowStatus.Location = new System.Drawing.Point(229, 0);
            this.DataShowStatus.Name = "DataShowStatus";
            this.DataShowStatus.Size = new System.Drawing.Size(90, 20);
            this.DataShowStatus.TabIndex = 1;
            this.DataShowStatus.Text = "顯示狀態";
            this.DataShowStatus.UseVisualStyleBackColor = true;
            // 
            // DataAllSelected
            // 
            this.DataAllSelected.AutoSize = true;
            this.DataAllSelected.Location = new System.Drawing.Point(108, 0);
            this.DataAllSelected.Name = "DataAllSelected";
            this.DataAllSelected.Size = new System.Drawing.Size(90, 20);
            this.DataAllSelected.TabIndex = 0;
            this.DataAllSelected.Text = "所有測項";
            this.DataAllSelected.UseVisualStyleBackColor = true;
            this.DataAllSelected.Click += new System.EventHandler(this.DataAllSelected_Click);
            // 
            // frmRawData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1803, 835);
            this.Controls.Add(this.DataItemGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DbSelect);
            this.Controls.Add(this.LblTable);
            this.Controls.Add(this.LblQuery);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.TableSelect);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.TableVeiw);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRawData";
            this.Text = "CPMS_資料庫查詢系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmRawData_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TableVeiw)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.DataItemGroup.ResumeLayout(false);
            this.DataItemGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableVeiw;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.ComboBox TableSelect;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenFile;
        private System.Windows.Forms.ToolStripButton SaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblQuery;
        private System.Windows.Forms.Label LblTable;
        private System.Windows.Forms.ComboBox DbSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox DataItemGroup;
        private System.Windows.Forms.CheckBox DataShowStatus;
        private System.Windows.Forms.CheckBox DataAllSelected;
        private System.Windows.Forms.CheckBox AllTime;
    }
}


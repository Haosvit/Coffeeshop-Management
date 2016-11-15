namespace CoffeeManagement.Views.DetailViews
{
    partial class WorkTrackingWorker
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.shift3 = new System.Windows.Forms.CheckBox();
            this.shift2 = new System.Windows.Forms.CheckBox();
            this.shift1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStaffLevel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStaffName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShift1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colShift2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colShift3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTotalShift = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSelect, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.btnSave);
            this.panelInput.Controls.Add(this.tbNote);
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.shift3);
            this.panelInput.Controls.Add(this.shift2);
            this.panelInput.Controls.Add(this.shift1);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.dateTimePicker);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.labelStaffLevel);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.labelStaffName);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(3, 3);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(730, 74);
            this.panelInput.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(652, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbNote
            // 
            this.tbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNote.Location = new System.Drawing.Point(86, 46);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(561, 20);
            this.tbNote.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ghi chú:";
            // 
            // shift3
            // 
            this.shift3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shift3.AutoSize = true;
            this.shift3.Location = new System.Drawing.Point(680, 23);
            this.shift3.Name = "shift3";
            this.shift3.Size = new System.Drawing.Size(48, 17);
            this.shift3.TabIndex = 9;
            this.shift3.Text = "Ca 3";
            this.shift3.UseVisualStyleBackColor = true;
            // 
            // shift2
            // 
            this.shift2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shift2.AutoSize = true;
            this.shift2.Location = new System.Drawing.Point(626, 23);
            this.shift2.Name = "shift2";
            this.shift2.Size = new System.Drawing.Size(48, 17);
            this.shift2.TabIndex = 8;
            this.shift2.Text = "Ca 2";
            this.shift2.UseVisualStyleBackColor = true;
            // 
            // shift1
            // 
            this.shift1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shift1.AutoSize = true;
            this.shift1.Location = new System.Drawing.Point(572, 23);
            this.shift1.Name = "shift1";
            this.shift1.Size = new System.Drawing.Size(48, 17);
            this.shift1.TabIndex = 7;
            this.shift1.Text = "Ca 1";
            this.shift1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ca: ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(86, 23);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hôm nay:";
            // 
            // labelStaffLevel
            // 
            this.labelStaffLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStaffLevel.AutoSize = true;
            this.labelStaffLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffLevel.Location = new System.Drawing.Point(653, -3);
            this.labelStaffLevel.Name = "labelStaffLevel";
            this.labelStaffLevel.Size = new System.Drawing.Size(74, 17);
            this.labelStaffLevel.TabIndex = 3;
            this.labelStaffLevel.Text = "_LEVEL_";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chức vụ: ";
            // 
            // labelStaffName
            // 
            this.labelStaffName.AutoSize = true;
            this.labelStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffName.ForeColor = System.Drawing.Color.Red;
            this.labelStaffName.Location = new System.Drawing.Point(83, 0);
            this.labelStaffName.Name = "labelStaffName";
            this.labelStaffName.Size = new System.Drawing.Size(69, 17);
            this.labelStaffName.TabIndex = 1;
            this.labelStaffName.Text = "_NAME_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.colShift1,
            this.colShift2,
            this.colShift3,
            this.colNote});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 354);
            this.dataGridView1.TabIndex = 7;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date.FillWeight = 63.96397F;
            this.date.Frozen = true;
            this.date.HeaderText = "Ngày tháng";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 130;
            // 
            // colShift1
            // 
            this.colShift1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colShift1.FillWeight = 112.0537F;
            this.colShift1.Frozen = true;
            this.colShift1.HeaderText = "Ca 1";
            this.colShift1.Name = "colShift1";
            this.colShift1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colShift1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colShift1.Width = 60;
            // 
            // colShift2
            // 
            this.colShift2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colShift2.FillWeight = 133.1148F;
            this.colShift2.Frozen = true;
            this.colShift2.HeaderText = "Ca 2";
            this.colShift2.Name = "colShift2";
            this.colShift2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colShift2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colShift2.Width = 60;
            // 
            // colShift3
            // 
            this.colShift3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colShift3.FillWeight = 126.9036F;
            this.colShift3.Frozen = true;
            this.colShift3.HeaderText = "Ca 3";
            this.colShift3.Name = "colShift3";
            this.colShift3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colShift3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colShift3.Width = 60;
            // 
            // colNote
            // 
            this.colNote.FillWeight = 63.96397F;
            this.colNote.HeaderText = "Ghi chú";
            this.colNote.Name = "colNote";
            // 
            // panelSelect
            // 
            this.panelSelect.Controls.Add(this.label10);
            this.panelSelect.Controls.Add(this.labelTotalShift);
            this.panelSelect.Controls.Add(this.label11);
            this.panelSelect.Controls.Add(this.labelSalary);
            this.panelSelect.Controls.Add(this.label8);
            this.panelSelect.Controls.Add(this.dateTimePicker3);
            this.panelSelect.Controls.Add(this.dateTimePicker2);
            this.panelSelect.Controls.Add(this.button1);
            this.panelSelect.Controls.Add(this.label9);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelect.Location = new System.Drawing.Point(3, 83);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(730, 54);
            this.panelSelect.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tổng số ca";
            // 
            // labelTotalShift
            // 
            this.labelTotalShift.AutoSize = true;
            this.labelTotalShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalShift.Location = new System.Drawing.Point(91, 31);
            this.labelTotalShift.Name = "labelTotalShift";
            this.labelTotalShift.Size = new System.Drawing.Size(130, 17);
            this.labelTotalShift.TabIndex = 33;
            this.labelTotalShift.Text = "_TOTAL_SHIFT_";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(253, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Lương cơ bản";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(354, 31);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(135, 17);
            this.labelSalary.TabIndex = 34;
            this.labelSalary.Text = "_BASE_SALARY_";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Từ";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(211, 6);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker3.TabIndex = 29;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(37, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(171, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Đến";
            // 
            // WorkTrackingWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WorkTrackingWorker";
            this.Size = new System.Drawing.Size(736, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSelect.ResumeLayout(false);
            this.panelSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStaffName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStaffLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox shift1;
        private System.Windows.Forms.CheckBox shift2;
        private System.Windows.Forms.CheckBox shift3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colShift1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colShift2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colShift3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTotalShift;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}

namespace CoffeeManagement.Views.Popups
{
    partial class BillAndPay
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.expandLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.billCash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableListLB = new System.Windows.Forms.Label();
            this.discountPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.afterDiscountCash = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.discountRatio = new System.Windows.Forms.TextBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.returnedCash = new System.Windows.Forms.TextBox();
            this.givenCash = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.payBillBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.discountPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.topPanel);
            this.flowLayoutPanel1.Controls.Add(this.discountPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.expandLabel);
            this.topPanel.Controls.Add(this.label5);
            this.topPanel.Controls.Add(this.billCash);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.tableListLB);
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(281, 72);
            this.topPanel.TabIndex = 0;
            // 
            // expandLabel
            // 
            this.expandLabel.AutoSize = true;
            this.expandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandLabel.Location = new System.Drawing.Point(120, 56);
            this.expandLabel.Name = "expandLabel";
            this.expandLabel.Size = new System.Drawing.Size(68, 16);
            this.expandLabel.TabIndex = 8;
            this.expandLabel.Text = "▼ Mở rộng";
            this.expandLabel.Click += new System.EventHandler(this.expandLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Khuyến mãi";
            // 
            // billCash
            // 
            this.billCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billCash.Location = new System.Drawing.Point(123, 27);
            this.billCash.Name = "billCash";
            this.billCash.ReadOnly = true;
            this.billCash.Size = new System.Drawing.Size(50, 22);
            this.billCash.TabIndex = 6;
            this.billCash.Text = "00";
            this.billCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = ".000 đ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bàn số";
            // 
            // tableListLB
            // 
            this.tableListLB.AutoSize = true;
            this.tableListLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableListLB.Location = new System.Drawing.Point(120, 5);
            this.tableListLB.Name = "tableListLB";
            this.tableListLB.Size = new System.Drawing.Size(128, 16);
            this.tableListLB.TabIndex = 2;
            this.tableListLB.Text = "TABLE1, TABLE2";
            // 
            // discountPanel
            // 
            this.discountPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.discountPanel.Controls.Add(this.label14);
            this.discountPanel.Controls.Add(this.label13);
            this.discountPanel.Controls.Add(this.label11);
            this.discountPanel.Controls.Add(this.afterDiscountCash);
            this.discountPanel.Controls.Add(this.label12);
            this.discountPanel.Controls.Add(this.discountRatio);
            this.discountPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountPanel.Location = new System.Drawing.Point(3, 81);
            this.discountPanel.Name = "discountPanel";
            this.discountPanel.Size = new System.Drawing.Size(281, 56);
            this.discountPanel.TabIndex = 1;
            this.discountPanel.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Số tiền phải trả";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(173, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = ".000 đ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Khuyến mãi";
            // 
            // afterDiscountCash
            // 
            this.afterDiscountCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterDiscountCash.Location = new System.Drawing.Point(123, 32);
            this.afterDiscountCash.Name = "afterDiscountCash";
            this.afterDiscountCash.ReadOnly = true;
            this.afterDiscountCash.Size = new System.Drawing.Size(50, 22);
            this.afterDiscountCash.TabIndex = 6;
            this.afterDiscountCash.Text = "0000";
            this.afterDiscountCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(173, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "%";
            // 
            // discountRatio
            // 
            this.discountRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountRatio.Location = new System.Drawing.Point(123, 2);
            this.discountRatio.Name = "discountRatio";
            this.discountRatio.Size = new System.Drawing.Size(50, 22);
            this.discountRatio.TabIndex = 7;
            this.discountRatio.Text = "0.0";
            this.discountRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discountRatio.TextChanged += new System.EventHandler(this.discountRatio_TextChanged);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.returnedCash);
            this.bottomPanel.Controls.Add(this.givenCash);
            this.bottomPanel.Controls.Add(this.label10);
            this.bottomPanel.Controls.Add(this.label7);
            this.bottomPanel.Controls.Add(this.label9);
            this.bottomPanel.Controls.Add(this.label8);
            this.bottomPanel.Controls.Add(this.cancelBtn);
            this.bottomPanel.Controls.Add(this.payBillBtn);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 139);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(284, 122);
            this.bottomPanel.TabIndex = 1;
            // 
            // returnedCash
            // 
            this.returnedCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedCash.Location = new System.Drawing.Point(126, 35);
            this.returnedCash.Name = "returnedCash";
            this.returnedCash.ReadOnly = true;
            this.returnedCash.Size = new System.Drawing.Size(50, 22);
            this.returnedCash.TabIndex = 9;
            this.returnedCash.Text = "0000";
            this.returnedCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // givenCash
            // 
            this.givenCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givenCash.Location = new System.Drawing.Point(126, 5);
            this.givenCash.Name = "givenCash";
            this.givenCash.Size = new System.Drawing.Size(50, 22);
            this.givenCash.TabIndex = 10;
            this.givenCash.Text = "0000";
            this.givenCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.givenCash.TextChanged += new System.EventHandler(this.givenCash_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = ".000 đ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = ".000 đ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tiền cần trả lại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số tiền khách đưa";
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Image = global::CoffeeManagement.Properties.Resources.invalid;
            this.cancelBtn.Location = new System.Drawing.Point(170, 70);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 40);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // payBillBtn
            // 
            this.payBillBtn.FlatAppearance.BorderSize = 0;
            this.payBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBillBtn.Image = global::CoffeeManagement.Properties.Resources.print;
            this.payBillBtn.Location = new System.Drawing.Point(28, 70);
            this.payBillBtn.Name = "payBillBtn";
            this.payBillBtn.Size = new System.Drawing.Size(133, 40);
            this.payBillBtn.TabIndex = 4;
            this.payBillBtn.Text = "Thanh Toán";
            this.payBillBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.payBillBtn.UseVisualStyleBackColor = true;
            this.payBillBtn.Click += new System.EventHandler(this.payBillBtn_Click);
            // 
            // BillAndPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillAndPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận thanh toán";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BillAndPay2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.discountPanel.ResumeLayout(false);
            this.discountPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button payBillBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tableListLB;
        private System.Windows.Forms.TextBox billCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label expandLabel;
        private System.Windows.Forms.TextBox returnedCash;
        private System.Windows.Forms.TextBox givenCash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel discountPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox afterDiscountCash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox discountRatio;
    }
}
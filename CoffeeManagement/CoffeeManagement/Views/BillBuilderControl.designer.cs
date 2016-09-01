namespace CoffeeManagement.Views
{
    partial class BillBuilderControl
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.middleButtonPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.mergeTable = new System.Windows.Forms.Button();
            this.changeTableBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.middleButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel.Controls.Add(this.middleButtonPanel, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(600, 550);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // middleButtonPanel
            // 
            this.middleButtonPanel.Controls.Add(this.button6);
            this.middleButtonPanel.Controls.Add(this.button5);
            this.middleButtonPanel.Controls.Add(this.button4);
            this.middleButtonPanel.Controls.Add(this.button3);
            this.middleButtonPanel.Controls.Add(this.button2);
            this.middleButtonPanel.Controls.Add(this.button1);
            this.middleButtonPanel.Controls.Add(this.comboBox1);
            this.middleButtonPanel.Controls.Add(this.quantityLabel);
            this.middleButtonPanel.Controls.Add(this.mergeTable);
            this.middleButtonPanel.Controls.Add(this.changeTableBtn);
            this.middleButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleButtonPanel.Location = new System.Drawing.Point(333, 3);
            this.middleButtonPanel.Name = "middleButtonPanel";
            this.middleButtonPanel.Size = new System.Drawing.Size(64, 544);
            this.middleButtonPanel.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(0, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "1";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.quantityLabel.Location = new System.Drawing.Point(0, 128);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 5);
            this.quantityLabel.Size = new System.Drawing.Size(49, 38);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Số lượng";
            // 
            // mergeTable
            // 
            this.mergeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.mergeTable.Location = new System.Drawing.Point(0, 64);
            this.mergeTable.Name = "mergeTable";
            this.mergeTable.Size = new System.Drawing.Size(64, 64);
            this.mergeTable.TabIndex = 1;
            this.mergeTable.Text = "Ghép Bàn";
            this.mergeTable.UseVisualStyleBackColor = true;
            // 
            // changeTableBtn
            // 
            this.changeTableBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeTableBtn.Location = new System.Drawing.Point(0, 0);
            this.changeTableBtn.Name = "changeTableBtn";
            this.changeTableBtn.Size = new System.Drawing.Size(64, 64);
            this.changeTableBtn.TabIndex = 0;
            this.changeTableBtn.Text = "Đổi Bàn";
            this.changeTableBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "<< Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bớt >>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 6;
            this.button3.Text = "% Theo Nhóm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 64);
            this.button4.TabIndex = 7;
            this.button4.Text = "In Chế Biến (F10)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.Location = new System.Drawing.Point(0, 480);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 64);
            this.button5.TabIndex = 8;
            this.button5.Text = "Thống kê (F9)";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.Location = new System.Drawing.Point(0, 416);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 64);
            this.button6.TabIndex = 9;
            this.button6.Text = "Thanh Toán (F11)";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // BillBuilderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "BillBuilderControl";
            this.Size = new System.Drawing.Size(600, 550);
            this.Load += new System.EventHandler(this.BillBuilderControl_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.middleButtonPanel.ResumeLayout(false);
            this.middleButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel middleButtonPanel;
        private System.Windows.Forms.Button changeTableBtn;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button mergeTable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
    }
}

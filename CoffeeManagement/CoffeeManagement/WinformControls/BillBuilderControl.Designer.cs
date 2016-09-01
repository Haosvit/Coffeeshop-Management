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
            this.addBtn = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(600, 480);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // middleButtonPanel
            // 
            this.middleButtonPanel.Controls.Add(this.addBtn);
            this.middleButtonPanel.Controls.Add(this.comboBox1);
            this.middleButtonPanel.Controls.Add(this.quantityLabel);
            this.middleButtonPanel.Controls.Add(this.mergeTable);
            this.middleButtonPanel.Controls.Add(this.changeTableBtn);
            this.middleButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleButtonPanel.Location = new System.Drawing.Point(333, 3);
            this.middleButtonPanel.Name = "middleButtonPanel";
            this.middleButtonPanel.Size = new System.Drawing.Size(64, 474);
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
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addBtn.Location = new System.Drawing.Point(0, 187);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(64, 64);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "<< Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // BillBuilderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "BillBuilderControl";
            this.Size = new System.Drawing.Size(600, 480);
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
        private System.Windows.Forms.Button addBtn;
    }
}

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
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.quantityComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerCount = new System.Windows.Forms.NumericUpDown();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stopTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startBtn = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.orderingLabel = new System.Windows.Forms.Label();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.customerCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.billPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.billDataGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.foodList = new System.Windows.Forms.TabPage();
            this.drinkList = new System.Windows.Forms.TabPage();
            this.otherList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rightProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payBillBtn = new System.Windows.Forms.Button();
            this.viewStatBtn = new System.Windows.Forms.Button();
            this.printProfuctionBtn = new System.Windows.Forms.Button();
            this.groupPercentBtn = new System.Windows.Forms.Button();
            this.mergeTable = new System.Windows.Forms.Button();
            this.changeTableBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.middleButtonPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.leftLayoutPanel.SuspendLayout();
            this.informationPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerCount)).BeginInit();
            this.billPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel.Controls.Add(this.middleButtonPanel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.leftPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.splitContainer1, 2, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 550);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // middleButtonPanel
            // 
            this.middleButtonPanel.Controls.Add(this.payBillBtn);
            this.middleButtonPanel.Controls.Add(this.viewStatBtn);
            this.middleButtonPanel.Controls.Add(this.printProfuctionBtn);
            this.middleButtonPanel.Controls.Add(this.groupPercentBtn);
            this.middleButtonPanel.Controls.Add(this.removeBtn);
            this.middleButtonPanel.Controls.Add(this.addBtn);
            this.middleButtonPanel.Controls.Add(this.quantityComboBox);
            this.middleButtonPanel.Controls.Add(this.quantityLabel);
            this.middleButtonPanel.Controls.Add(this.mergeTable);
            this.middleButtonPanel.Controls.Add(this.changeTableBtn);
            this.middleButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleButtonPanel.Location = new System.Drawing.Point(533, 3);
            this.middleButtonPanel.Name = "middleButtonPanel";
            this.middleButtonPanel.Size = new System.Drawing.Size(64, 544);
            this.middleButtonPanel.TabIndex = 0;
            // 
            // removeBtn
            // 
            this.removeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeBtn.Location = new System.Drawing.Point(0, 210);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(64, 23);
            this.removeBtn.TabIndex = 5;
            this.removeBtn.Text = "Bớt >>";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addBtn.Location = new System.Drawing.Point(0, 187);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(64, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "<< Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // quantityComboBox
            // 
            this.quantityComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.quantityComboBox.FormattingEnabled = true;
            this.quantityComboBox.Items.AddRange(new object[] {
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
            this.quantityComboBox.Location = new System.Drawing.Point(0, 166);
            this.quantityComboBox.Name = "quantityComboBox";
            this.quantityComboBox.Size = new System.Drawing.Size(64, 21);
            this.quantityComboBox.TabIndex = 3;
            this.quantityComboBox.Text = "1";
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
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.leftLayoutPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(524, 544);
            this.leftPanel.TabIndex = 1;
            // 
            // leftLayoutPanel
            // 
            this.leftLayoutPanel.ColumnCount = 1;
            this.leftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftLayoutPanel.Controls.Add(this.informationPanel, 0, 0);
            this.leftLayoutPanel.Controls.Add(this.billPanel, 0, 1);
            this.leftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.leftLayoutPanel.Name = "leftLayoutPanel";
            this.leftLayoutPanel.RowCount = 2;
            this.leftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.26471F));
            this.leftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.73529F));
            this.leftLayoutPanel.Size = new System.Drawing.Size(524, 544);
            this.leftLayoutPanel.TabIndex = 0;
            // 
            // informationPanel
            // 
            this.informationPanel.Controls.Add(this.tableLayoutPanel1);
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationPanel.Location = new System.Drawing.Point(3, 3);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(518, 126);
            this.informationPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.customerCount, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.datePicker, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.stopBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.startTimePicker, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.stopTimePicker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderingLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.orderTextBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.customerCountLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 89);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // customerCount
            // 
            this.customerCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customerCount.Location = new System.Drawing.Point(415, 63);
            this.customerCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customerCount.Name = "customerCount";
            this.customerCount.Size = new System.Drawing.Size(100, 20);
            this.customerCount.TabIndex = 0;
            this.customerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.customerCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // datePicker
            // 
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datePicker.Location = new System.Drawing.Point(415, 3);
            this.datePicker.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(100, 20);
            this.datePicker.TabIndex = 2;
            // 
            // stopBtn
            // 
            this.stopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopBtn.Location = new System.Drawing.Point(106, 32);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(97, 23);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Kết Thúc";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // startTimePicker
            // 
            this.startTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(3, 33);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(97, 20);
            this.startTimePicker.TabIndex = 0;
            // 
            // stopTimePicker
            // 
            this.stopTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stopTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.stopTimePicker.Location = new System.Drawing.Point(3, 4);
            this.stopTimePicker.Name = "stopTimePicker";
            this.stopTimePicker.Size = new System.Drawing.Size(97, 20);
            this.stopTimePicker.TabIndex = 1;
            this.stopTimePicker.Value = new System.DateTime(2016, 9, 2, 18, 54, 37, 0);
            this.stopTimePicker.ValueChanged += new System.EventHandler(this.stopTimePicker_ValueChanged);
            // 
            // startBtn
            // 
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.Location = new System.Drawing.Point(106, 3);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(97, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Bắt đầu";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(377, 8);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(32, 13);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Ngày";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderingLabel
            // 
            this.orderingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orderingLabel.AutoSize = true;
            this.orderingLabel.Location = new System.Drawing.Point(381, 37);
            this.orderingLabel.Name = "orderingLabel";
            this.orderingLabel.Size = new System.Drawing.Size(28, 13);
            this.orderingLabel.TabIndex = 6;
            this.orderingLabel.Text = "STT";
            // 
            // orderTextBox
            // 
            this.orderTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orderTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.orderTextBox.Enabled = false;
            this.orderTextBox.Location = new System.Drawing.Point(415, 33);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderTextBox.TabIndex = 7;
            this.orderTextBox.Text = "1";
            this.orderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customerCountLabel
            // 
            this.customerCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customerCountLabel.AutoSize = true;
            this.customerCountLabel.Location = new System.Drawing.Point(356, 67);
            this.customerCountLabel.Name = "customerCountLabel";
            this.customerCountLabel.Size = new System.Drawing.Size(53, 13);
            this.customerCountLabel.TabIndex = 8;
            this.customerCountLabel.Text = "Số khách";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "TABLE_ID";
            // 
            // billPanel
            // 
            this.billPanel.Controls.Add(this.tableLayoutPanel2);
            this.billPanel.Controls.Add(this.billDataGridView);
            this.billPanel.Location = new System.Drawing.Point(3, 135);
            this.billPanel.Name = "billPanel";
            this.billPanel.Size = new System.Drawing.Size(518, 406);
            this.billPanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox6, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 281);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(518, 125);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiền Ăn Uống";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel2.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Location = new System.Drawing.Point(262, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phí Dịch Vụ";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(262, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "0.00";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(365, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(262, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "0.00";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(365, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giảm Giá";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(169, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng Cộng";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel2.SetColumnSpan(this.textBox6, 2);
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Red;
            this.textBox6.Location = new System.Drawing.Point(262, 96);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(253, 29);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // billDataGridView
            // 
            this.billDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.unit,
            this.quantity,
            this.price,
            this.discountPercent,
            this.amount});
            this.billDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.billDataGridView.Location = new System.Drawing.Point(0, 0);
            this.billDataGridView.Name = "billDataGridView";
            this.billDataGridView.RowHeadersVisible = false;
            this.billDataGridView.Size = new System.Drawing.Size(518, 281);
            this.billDataGridView.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(603, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(194, 544);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 128);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 24);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm";
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox7.Location = new System.Drawing.Point(31, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(157, 20);
            this.textBox7.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.foodList);
            this.tabControl1.Controls.Add(this.drinkList);
            this.tabControl1.Controls.Add(this.otherList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(188, 92);
            this.tabControl1.TabIndex = 1;
            // 
            // foodList
            // 
            this.foodList.Location = new System.Drawing.Point(4, 22);
            this.foodList.Name = "foodList";
            this.foodList.Padding = new System.Windows.Forms.Padding(3);
            this.foodList.Size = new System.Drawing.Size(180, 66);
            this.foodList.TabIndex = 0;
            this.foodList.Text = "Đồ Ăn";
            this.foodList.UseVisualStyleBackColor = true;
            // 
            // drinkList
            // 
            this.drinkList.Location = new System.Drawing.Point(4, 22);
            this.drinkList.Name = "drinkList";
            this.drinkList.Padding = new System.Windows.Forms.Padding(3);
            this.drinkList.Size = new System.Drawing.Size(180, 66);
            this.drinkList.TabIndex = 1;
            this.drinkList.Text = "Đồ Uống";
            this.drinkList.UseVisualStyleBackColor = true;
            // 
            // otherList
            // 
            this.otherList.Location = new System.Drawing.Point(4, 22);
            this.otherList.Name = "otherList";
            this.otherList.Size = new System.Drawing.Size(180, 66);
            this.otherList.TabIndex = 2;
            this.otherList.Text = "Khác";
            this.otherList.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rightProductName,
            this.rightUnit,
            this.rightPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(194, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // rightProductName
            // 
            this.rightProductName.HeaderText = "Tên Mặt Hàng";
            this.rightProductName.Name = "rightProductName";
            this.rightProductName.ReadOnly = true;
            // 
            // rightUnit
            // 
            this.rightUnit.HeaderText = "ĐVT";
            this.rightUnit.Name = "rightUnit";
            this.rightUnit.ReadOnly = true;
            this.rightUnit.Width = 80;
            // 
            // rightPrice
            // 
            this.rightPrice.HeaderText = "Giá";
            this.rightPrice.Name = "rightPrice";
            this.rightPrice.ReadOnly = true;
            this.rightPrice.Width = 80;
            // 
            // productName
            // 
            this.productName.HeaderText = "Tên Mặt Hàng";
            this.productName.MaxInputLength = 100;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 150;
            // 
            // unit
            // 
            this.unit.HeaderText = "ĐVT";
            this.unit.MaxInputLength = 20;
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 80;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "SL";
            this.quantity.Name = "quantity";
            this.quantity.Width = 50;
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // discountPercent
            // 
            this.discountPercent.HeaderText = "%CK";
            this.discountPercent.Name = "discountPercent";
            this.discountPercent.Width = 50;
            // 
            // amount
            // 
            this.amount.HeaderText = "Thành Tiền";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // payBillBtn
            // 
            this.payBillBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.payBillBtn.Image = global::CoffeeManagement.Properties.Resources.pay_bill_25px;
            this.payBillBtn.Location = new System.Drawing.Point(0, 416);
            this.payBillBtn.Name = "payBillBtn";
            this.payBillBtn.Size = new System.Drawing.Size(64, 64);
            this.payBillBtn.TabIndex = 9;
            this.payBillBtn.Text = "Th.Toán (F11)";
            this.payBillBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.payBillBtn.UseVisualStyleBackColor = true;
            // 
            // viewStatBtn
            // 
            this.viewStatBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewStatBtn.Image = global::CoffeeManagement.Properties.Resources.stat_25px;
            this.viewStatBtn.Location = new System.Drawing.Point(0, 480);
            this.viewStatBtn.Name = "viewStatBtn";
            this.viewStatBtn.Size = new System.Drawing.Size(64, 64);
            this.viewStatBtn.TabIndex = 8;
            this.viewStatBtn.Text = "Thống kê (F9)";
            this.viewStatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.viewStatBtn.UseVisualStyleBackColor = true;
            // 
            // printProfuctionBtn
            // 
            this.printProfuctionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.printProfuctionBtn.Image = global::CoffeeManagement.Properties.Resources.print_production_25px;
            this.printProfuctionBtn.Location = new System.Drawing.Point(0, 297);
            this.printProfuctionBtn.Name = "printProfuctionBtn";
            this.printProfuctionBtn.Size = new System.Drawing.Size(64, 64);
            this.printProfuctionBtn.TabIndex = 7;
            this.printProfuctionBtn.Text = "In Chế Biến (F10)";
            this.printProfuctionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printProfuctionBtn.UseVisualStyleBackColor = true;
            // 
            // groupPercentBtn
            // 
            this.groupPercentBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPercentBtn.Image = global::CoffeeManagement.Properties.Resources.group_25px;
            this.groupPercentBtn.Location = new System.Drawing.Point(0, 233);
            this.groupPercentBtn.Name = "groupPercentBtn";
            this.groupPercentBtn.Size = new System.Drawing.Size(64, 64);
            this.groupPercentBtn.TabIndex = 6;
            this.groupPercentBtn.Text = "% Theo Nhóm";
            this.groupPercentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.groupPercentBtn.UseVisualStyleBackColor = true;
            // 
            // mergeTable
            // 
            this.mergeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.mergeTable.Image = global::CoffeeManagement.Properties.Resources.merge_table_25px;
            this.mergeTable.Location = new System.Drawing.Point(0, 64);
            this.mergeTable.Name = "mergeTable";
            this.mergeTable.Size = new System.Drawing.Size(64, 64);
            this.mergeTable.TabIndex = 1;
            this.mergeTable.Text = "Ghép Bàn";
            this.mergeTable.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mergeTable.UseVisualStyleBackColor = true;
            // 
            // changeTableBtn
            // 
            this.changeTableBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeTableBtn.Image = global::CoffeeManagement.Properties.Resources.change_table_25px;
            this.changeTableBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changeTableBtn.Location = new System.Drawing.Point(0, 0);
            this.changeTableBtn.Name = "changeTableBtn";
            this.changeTableBtn.Size = new System.Drawing.Size(64, 64);
            this.changeTableBtn.TabIndex = 0;
            this.changeTableBtn.Text = "Đổi Bàn";
            this.changeTableBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.changeTableBtn.UseVisualStyleBackColor = true;
            // 
            // BillBuilderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "BillBuilderControl";
            this.Size = new System.Drawing.Size(800, 550);
            this.Load += new System.EventHandler(this.BillBuilderControl_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.middleButtonPanel.ResumeLayout(false);
            this.middleButtonPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftLayoutPanel.ResumeLayout(false);
            this.informationPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerCount)).EndInit();
            this.billPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel middleButtonPanel;
        private System.Windows.Forms.Button changeTableBtn;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button mergeTable;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button viewStatBtn;
        private System.Windows.Forms.Button printProfuctionBtn;
        private System.Windows.Forms.Button groupPercentBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button payBillBtn;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.TableLayoutPanel leftLayoutPanel;
        private System.Windows.Forms.Panel billPanel;
        private System.Windows.Forms.DateTimePicker stopTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label orderingLabel;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.Label customerCountLabel;
        private System.Windows.Forms.NumericUpDown customerCount;
        private System.Windows.Forms.ComboBox quantityComboBox;
        private System.Windows.Forms.DataGridView billDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage foodList;
        private System.Windows.Forms.TabPage drinkList;
        private System.Windows.Forms.TabPage otherList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}

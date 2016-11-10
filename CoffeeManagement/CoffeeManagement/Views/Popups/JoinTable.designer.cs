namespace CoffeeManagement.Views.Popups
{
    partial class JoinTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableListTB = new System.Windows.Forms.TextBox();
            this.newTableCB = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bàn cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bàn gộp thêm";
            // 
            // tableListTB
            // 
            this.tableListTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableListTB.Location = new System.Drawing.Point(110, 22);
            this.tableListTB.Name = "tableListTB";
            this.tableListTB.ReadOnly = true;
            this.tableListTB.Size = new System.Drawing.Size(155, 22);
            this.tableListTB.TabIndex = 1;
            this.tableListTB.Text = "Bàn 01";
            this.tableListTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newTableCB
            // 
            this.newTableCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTableCB.FormattingEnabled = true;
            this.newTableCB.Location = new System.Drawing.Point(110, 62);
            this.newTableCB.Name = "newTableCB";
            this.newTableCB.Size = new System.Drawing.Size(154, 24);
            this.newTableCB.TabIndex = 2;
            // 
            // okBtn
            // 
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Image = global::CoffeeManagement.Properties.Resources.valid;
            this.okBtn.Location = new System.Drawing.Point(47, 107);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(92, 40);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "Xác nhận";
            this.okBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Image = global::CoffeeManagement.Properties.Resources.invalid;
            this.cancelBtn.Location = new System.Drawing.Point(160, 107);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 40);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // JoinTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 168);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.newTableCB);
            this.Controls.Add(this.tableListTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JoinTable";
            this.Text = "Gộp bàn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tableListTB;
        private System.Windows.Forms.ComboBox newTableCB;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
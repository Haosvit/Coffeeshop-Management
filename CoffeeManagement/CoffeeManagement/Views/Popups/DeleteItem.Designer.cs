namespace CoffeeManagement.Views.Popups
{
    partial class DeleteItem
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
            this.messageLB = new System.Windows.Forms.Label();
            this.noBtn = new System.Windows.Forms.Button();
            this.yesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLB
            // 
            this.messageLB.AutoSize = true;
            this.messageLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLB.Location = new System.Drawing.Point(13, 13);
            this.messageLB.Name = "messageLB";
            this.messageLB.Size = new System.Drawing.Size(206, 16);
            this.messageLB.TabIndex = 0;
            this.messageLB.Text = "Bạn có chắc chắn xóa {0} không?";
            // 
            // noBtn
            // 
            this.noBtn.FlatAppearance.BorderSize = 0;
            this.noBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noBtn.Image = global::CoffeeManagement.Properties.Resources.invalid;
            this.noBtn.Location = new System.Drawing.Point(191, 39);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(80, 40);
            this.noBtn.TabIndex = 6;
            this.noBtn.Text = "Không";
            this.noBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // yesBtn
            // 
            this.yesBtn.FlatAppearance.BorderSize = 0;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.Image = global::CoffeeManagement.Properties.Resources.valid;
            this.yesBtn.Location = new System.Drawing.Point(78, 39);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(80, 40);
            this.yesBtn.TabIndex = 5;
            this.yesBtn.Text = "Có";
            this.yesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // DeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 92);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.messageLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteItem";
            this.Text = "Xóa mặt hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLB;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button yesBtn;
    }
}
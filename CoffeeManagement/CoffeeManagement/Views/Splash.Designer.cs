namespace CoffeeManagement
{
    partial class Splash
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
            this._backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this._lbStatus = new System.Windows.Forms.Label();
            this._lbAppName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(506, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _lbStatus
            // 
            this._lbStatus.AutoSize = true;
            this._lbStatus.BackColor = System.Drawing.Color.Transparent;
            this._lbStatus.Location = new System.Drawing.Point(12, 268);
            this._lbStatus.Name = "_lbStatus";
            this._lbStatus.Size = new System.Drawing.Size(0, 13);
            this._lbStatus.TabIndex = 1;
            // 
            // _lbAppName
            // 
            this._lbAppName.AutoSize = true;
            this._lbAppName.BackColor = System.Drawing.Color.Transparent;
            this._lbAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbAppName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._lbAppName.Location = new System.Drawing.Point(149, 127);
            this._lbAppName.Name = "_lbAppName";
            this._lbAppName.Size = new System.Drawing.Size(309, 24);
            this._lbAppName.TabIndex = 2;
            this._lbAppName.Text = "CFM - QUẢN LÝ QUÁN CÀ PHÊ";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeManagement.Properties.Resources.cropped_1366_768_374296;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this._lbAppName);
            this.Controls.Add(this._lbStatus);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker _backgroundWorker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _lbStatus;
        private System.Windows.Forms.Label _lbAppName;
    }
}


namespace CoffeeManagement.Views
{
    partial class MasterView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this._lbHello = new System.Windows.Forms.Label();
            this._lbScreenName = new System.Windows.Forms.Label();
            this._pMain = new System.Windows.Forms.Panel();
            this._menuLayout = new System.Windows.Forms.FlowLayoutPanel();
            this._menuSaleStatistics = new System.Windows.Forms.Button();
            this._menuMaterialStatistics = new System.Windows.Forms.Button();
            this._menuMaterialState = new System.Windows.Forms.Button();
            this._menuAddMaterial = new System.Windows.Forms.Button();
            this._menuSale = new System.Windows.Forms.Button();
            this._menuWorkTracking = new System.Windows.Forms.Button();
            this._menuStatistics = new System.Windows.Forms.Button();
            this._menuUserManagement = new System.Windows.Forms.Button();
            this._menuLogOut = new System.Windows.Forms.Button();
            this._btnMenu = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this._menuLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this._btnMenu);
            this.panel2.Controls.Add(this._lbHello);
            this.panel2.Controls.Add(this._lbScreenName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 36);
            this.panel2.TabIndex = 3;
            // 
            // _lbHello
            // 
            this._lbHello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lbHello.AutoSize = true;
            this._lbHello.BackColor = System.Drawing.Color.Transparent;
            this._lbHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._lbHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbHello.Location = new System.Drawing.Point(840, 10);
            this._lbHello.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this._lbHello.Name = "_lbHello";
            this._lbHello.Size = new System.Drawing.Size(91, 16);
            this._lbHello.TabIndex = 1;
            this._lbHello.Text = "Chào Admin";
            this._lbHello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lbScreenName
            // 
            this._lbScreenName.AutoSize = true;
            this._lbScreenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbScreenName.Location = new System.Drawing.Point(42, 6);
            this._lbScreenName.Name = "_lbScreenName";
            this._lbScreenName.Size = new System.Drawing.Size(0, 24);
            this._lbScreenName.TabIndex = 1;
            // 
            // _pMain
            // 
            this._pMain.BackColor = System.Drawing.Color.LightGray;
            this._pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pMain.Location = new System.Drawing.Point(0, 36);
            this._pMain.Margin = new System.Windows.Forms.Padding(0);
            this._pMain.Name = "_pMain";
            this._pMain.Size = new System.Drawing.Size(934, 475);
            this._pMain.TabIndex = 4;
            this._pMain.Click += new System.EventHandler(this._pMain_Click);
            // 
            // _menuLayout
            // 
            this._menuLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this._menuLayout.Controls.Add(this._menuSaleStatistics);
            this._menuLayout.Controls.Add(this._menuMaterialStatistics);
            this._menuLayout.Controls.Add(this._menuMaterialState);
            this._menuLayout.Controls.Add(this._menuAddMaterial);
            this._menuLayout.Controls.Add(this._menuSale);
            this._menuLayout.Controls.Add(this._menuWorkTracking);
            this._menuLayout.Controls.Add(this._menuStatistics);
            this._menuLayout.Controls.Add(this._menuUserManagement);
            this._menuLayout.Controls.Add(this._menuLogOut);
            this._menuLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this._menuLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._menuLayout.Location = new System.Drawing.Point(0, 36);
            this._menuLayout.Margin = new System.Windows.Forms.Padding(0);
            this._menuLayout.Name = "_menuLayout";
            this._menuLayout.Size = new System.Drawing.Size(198, 475);
            this._menuLayout.TabIndex = 5;
            this._menuLayout.Visible = false;
            // 
            // _menuSaleStatistics
            // 
            this._menuSaleStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._menuSaleStatistics.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._menuSaleStatistics.FlatAppearance.BorderSize = 0;
            this._menuSaleStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuSaleStatistics.Image = global::CoffeeManagement.Properties.Resources.sale_statistics;
            this._menuSaleStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuSaleStatistics.Location = new System.Drawing.Point(3, 3);
            this._menuSaleStatistics.Name = "_menuSaleStatistics";
            this._menuSaleStatistics.Size = new System.Drawing.Size(190, 38);
            this._menuSaleStatistics.TabIndex = 0;
            this._menuSaleStatistics.Tag = "Sale";
            this._menuSaleStatistics.Text = "Thống kê bán hàng";
            this._menuSaleStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuSaleStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._menuSaleStatistics.UseVisualStyleBackColor = true;
            this._menuSaleStatistics.Visible = false;
            this._menuSaleStatistics.Click += new System.EventHandler(this.OnMenuButtonClick);
            // 
            // _menuMaterialStatistics
            // 
            this._menuMaterialStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._menuMaterialStatistics.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._menuMaterialStatistics.FlatAppearance.BorderSize = 0;
            this._menuMaterialStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuMaterialStatistics.Image = global::CoffeeManagement.Properties.Resources.material_statistics;
            this._menuMaterialStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuMaterialStatistics.Location = new System.Drawing.Point(3, 47);
            this._menuMaterialStatistics.Name = "_menuMaterialStatistics";
            this._menuMaterialStatistics.Size = new System.Drawing.Size(190, 38);
            this._menuMaterialStatistics.TabIndex = 1;
            this._menuMaterialStatistics.Tag = "Sale";
            this._menuMaterialStatistics.Text = "Thống kê nguyên liệu";
            this._menuMaterialStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuMaterialStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._menuMaterialStatistics.UseVisualStyleBackColor = true;
            this._menuMaterialStatistics.Visible = false;
            this._menuMaterialStatistics.Click += new System.EventHandler(this.OnMenuButtonClick);
            // 
            // _menuMaterialState
            // 
            this._menuMaterialState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._menuMaterialState.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._menuMaterialState.FlatAppearance.BorderSize = 0;
            this._menuMaterialState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuMaterialState.Image = global::CoffeeManagement.Properties.Resources.material_state;
            this._menuMaterialState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuMaterialState.Location = new System.Drawing.Point(3, 91);
            this._menuMaterialState.Name = "_menuMaterialState";
            this._menuMaterialState.Size = new System.Drawing.Size(190, 38);
            this._menuMaterialState.TabIndex = 2;
            this._menuMaterialState.Tag = "Sale";
            this._menuMaterialState.Text = "Trạng thái kho";
            this._menuMaterialState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuMaterialState.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._menuMaterialState.UseVisualStyleBackColor = true;
            this._menuMaterialState.Visible = false;
            this._menuMaterialState.Click += new System.EventHandler(this.OnMenuButtonClick);
            // 
            // _menuAddMaterial
            // 
            this._menuAddMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._menuAddMaterial.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._menuAddMaterial.FlatAppearance.BorderSize = 0;
            this._menuAddMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuAddMaterial.Image = global::CoffeeManagement.Properties.Resources.add_material;
            this._menuAddMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuAddMaterial.Location = new System.Drawing.Point(3, 135);
            this._menuAddMaterial.Name = "_menuAddMaterial";
            this._menuAddMaterial.Size = new System.Drawing.Size(190, 38);
            this._menuAddMaterial.TabIndex = 3;
            this._menuAddMaterial.Tag = "Sale";
            this._menuAddMaterial.Text = "Nhập nguyên liệu";
            this._menuAddMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuAddMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._menuAddMaterial.UseVisualStyleBackColor = true;
            this._menuAddMaterial.Visible = false;
            this._menuAddMaterial.Click += new System.EventHandler(this.OnMenuButtonClick);
            // 
            // _menuSale
            // 
            this._menuSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._menuSale.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._menuSale.FlatAppearance.BorderSize = 0;
            this._menuSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuSale.Image = global::CoffeeManagement.Properties.Resources.sale;
            this._menuSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuSale.Location = new System.Drawing.Point(3, 179);
            this._menuSale.Name = "_menuSale";
            this._menuSale.Size = new System.Drawing.Size(190, 38);
            this._menuSale.TabIndex = 4;
            this._menuSale.Tag = "Sale";
            this._menuSale.Text = "Quản lý bán hàng";
            this._menuSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._menuSale.UseVisualStyleBackColor = true;
            this._menuSale.Visible = false;
            this._menuSale.Click += new System.EventHandler(this.OnMenuButtonClick);
            // 
            // _menuWorkTracking
            // 
            this._menuWorkTracking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._menuWorkTracking.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._menuWorkTracking.FlatAppearance.BorderSize = 0;
            this._menuWorkTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuWorkTracking.Image = global::CoffeeManagement.Properties.Resources.work_tracking;
            this._menuWorkTracking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuWorkTracking.Location = new System.Drawing.Point(3, 223);
            this._menuWorkTracking.Name = "_menuWorkTracking";
            this._menuWorkTracking.Size = new System.Drawing.Size(190, 38);
            this._menuWorkTracking.TabIndex = 5;
            this._menuWorkTracking.Tag = "";
            this._menuWorkTracking.Text = "Chấm công";
            this._menuWorkTracking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuWorkTracking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._menuWorkTracking.UseVisualStyleBackColor = true;
            this._menuWorkTracking.Visible = false;
            this._menuWorkTracking.Click += new System.EventHandler(this.OnMenuButtonClick);
            // 
            // _menuStatistics
            // 
            this._menuStatistics.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._menuStatistics.FlatAppearance.BorderSize = 0;
            this._menuStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuStatistics.Image = global::CoffeeManagement.Properties.Resources.statistics;
            this._menuStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuStatistics.Location = new System.Drawing.Point(3, 267);
            this._menuStatistics.Name = "_menuStatistics";
            this._menuStatistics.Size = new System.Drawing.Size(190, 38);
            this._menuStatistics.TabIndex = 6;
            this._menuStatistics.Tag = "Statistics";
            this._menuStatistics.Text = "Thống kê && kết ca";
            this._menuStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._menuStatistics.UseVisualStyleBackColor = true;
            this._menuStatistics.Visible = false;
            this._menuStatistics.Click += new System.EventHandler(this.OnMenuButtonClick);
            // 
            // _menuUserManagement
            // 
            this._menuUserManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._menuUserManagement.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._menuUserManagement.FlatAppearance.BorderSize = 0;
            this._menuUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuUserManagement.Image = global::CoffeeManagement.Properties.Resources.user_32;
            this._menuUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuUserManagement.Location = new System.Drawing.Point(3, 311);
            this._menuUserManagement.Name = "_menuUserManagement";
            this._menuUserManagement.Size = new System.Drawing.Size(190, 38);
            this._menuUserManagement.TabIndex = 8;
            this._menuUserManagement.Tag = "Sale";
            this._menuUserManagement.Text = "Quản lý tài khoản";
            this._menuUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuUserManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._menuUserManagement.UseVisualStyleBackColor = true;
            this._menuUserManagement.Visible = false;
            this._menuUserManagement.Click += new System.EventHandler(this.OnMenuButtonClick);
            // 
            // _menuLogOut
            // 
            this._menuLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._menuLogOut.FlatAppearance.BorderSize = 0;
            this._menuLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuLogOut.Image = global::CoffeeManagement.Properties.Resources.sale;
            this._menuLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuLogOut.Location = new System.Drawing.Point(3, 355);
            this._menuLogOut.Name = "_menuLogOut";
            this._menuLogOut.Size = new System.Drawing.Size(190, 38);
            this._menuLogOut.TabIndex = 7;
            this._menuLogOut.Tag = "LogOut";
            this._menuLogOut.Text = "Đăng xuất";
            this._menuLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._menuLogOut.UseVisualStyleBackColor = true;
            this._menuLogOut.Click += new System.EventHandler(this.OnMenuButtonClick);
            // 
            // _btnMenu
            // 
            this._btnMenu.BackColor = System.Drawing.Color.Transparent;
            this._btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this._btnMenu.FlatAppearance.BorderSize = 0;
            this._btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMenu.Image = global::CoffeeManagement.Properties.Resources.menu_32;
            this._btnMenu.Location = new System.Drawing.Point(0, 0);
            this._btnMenu.Name = "_btnMenu";
            this._btnMenu.Size = new System.Drawing.Size(36, 36);
            this._btnMenu.TabIndex = 0;
            this._btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._btnMenu.UseVisualStyleBackColor = false;
            this._btnMenu.Click += new System.EventHandler(this._btnMenu_Click);
            // 
            // MasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this._menuLayout);
            this.Controls.Add(this._pMain);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "MasterView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CFM - QUẢN LÝ QUÁN CÀ PHÊ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterView_FormClosing);
            this.Load += new System.EventHandler(this.MasterView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this._menuLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _lbHello;
        private System.Windows.Forms.Label _lbScreenName;
        private System.Windows.Forms.Panel _pMain;
        private System.Windows.Forms.Button _btnMenu;
        private System.Windows.Forms.FlowLayoutPanel _menuLayout;
        private System.Windows.Forms.Button _menuSale;
        private System.Windows.Forms.Button _menuWorkTracking;
        private System.Windows.Forms.Button _menuStatistics;
        private System.Windows.Forms.Button _menuLogOut;
        private System.Windows.Forms.Button _menuSaleStatistics;
        private System.Windows.Forms.Button _menuMaterialStatistics;
        private System.Windows.Forms.Button _menuMaterialState;
        private System.Windows.Forms.Button _menuAddMaterial;
        private System.Windows.Forms.Button _menuUserManagement;



    }
}
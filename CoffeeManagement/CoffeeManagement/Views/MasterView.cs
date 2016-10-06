using CoffeeManagement.BO;
using CoffeeManagement.Utilities;
using CoffeeManagement.Views.DetailViews;
using CoffeeManagement.Views.Popups;
using System;
using System.Drawing;
using System.Windows.Forms;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.Views
{
    public partial class MasterView : Form
    {
	    public static MasterView Instance;
        private Login _loginForm;
        private User _currentUser;
	    private static readonly string _helloString = Properties.Resources.Hello;

	    private Button _selectedMenuItem;
        private bool _isFormClosing;
        private Color _activeColor = Color.LightGray;
        public MasterView(Login loginForm)
        {
	        Instance = this;
            InitializeComponent();
            _currentUser = UserBo.CurrentUser;

            _loginForm = loginForm;
            _loginForm.Hide();

            InitMenuItems();
	        InitDefaultDetailView();
        }

		private void MasterView_Load(object sender, EventArgs e)
        {
			Text = Properties.Resources.AppName.ToUpper();
            _lbHello.Text = _helloString + _currentUser.FullName;
            _lbHello.Location = new Point(Width - _lbHello.Width - 20, _lbHello.Location.Y);
        }

        private void MasterView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isFormClosing)
            {
                if (MessageHelper.CreateYesNoQuestion("Bạn có muốn đăng xuất?") == DialogResult.Yes)
                {
                    LogOut();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void LogOut()
        {
            var userBo = new UserBo();
            userBo.LogOut();

            _isFormClosing = true;
            BackToLogin();
        }
        private void BackToLogin()
        {
            _loginForm.ClearText();
            _loginForm.Show();
            Close();
        }

        /// <summary>
        /// Menu navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMenuButtonClick(object sender, EventArgs e)
        {
            if (_selectedMenuItem != null) {
                _selectedMenuItem.BackColor = Color.Transparent;
            }
            _selectedMenuItem = (sender as Button);
            _selectedMenuItem.BackColor = _activeColor;

            ToggleMenuLayout();

            switch (_selectedMenuItem.Name)
            {
                case "_menuSaleManager":
                    ShowDetailView(new OrderView());
                    break;
                case "_menuWorkTracking":
                    break;
                case "_menuStatistics":
                    break;
                case "_menuLogOut":
                    LogOut();
                    break;
					// admin
                case "_menuUserManager":
					ShowDetailView(new UserManager());
                    break;
				case "_menuItemsManager":
					ShowDetailView(new ItemManagerView());
					break;
            }

        }

        public void ShowDetailView(UserControl view)
        {
            if (!_pMain.Controls.Contains(view))
            {
                view.Dock = DockStyle.Fill;
                _pMain.Controls.Clear();
                _pMain.Controls.Add(view);
                if (view is IDetailView)
                {
                    _lbScreenName.Text = (view as IDetailView).ScreenName.ToUpper();
                }
            }                        
        }

        public DialogResult ShowPopup(Form popup)
        {
            if (_menuLayout.Visible)
            {
                ToggleMenuLayout();
            }

            return popup.ShowDialog();
        }

        /// <summary>
        /// Expands, closes menu layout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnMenu_Click(object sender, EventArgs e)
        {
            ToggleMenuLayout();
        }

        private void ToggleMenuLayout()
        {
            _menuLayout.Visible = !_menuLayout.Visible;
            _btnMenu.BackColor = _menuLayout.Visible ? Color.LightGray : Color.Transparent;
        }

        /// <summary>
        ///  close menu when click on main layout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _pMain_Click(object sender, EventArgs e)
        {
            if (_menuLayout.Visible)
            {
                ToggleMenuLayout();
            }
        }

        private void InitMenuItems()
        {
            switch (_currentUser.Level)
            {
                case AppEnum.UserLevel.Admin:
					// thong ke ban hang
                    _menuSaleStatistics.Visible = true;
					// quan ly cham cong
                    _menuWorkTracking.Visible = true;
                    // quan ly mat hang
					_menuItemsManager.Visible = true;
					// quan ly tai khoan
                    _menuUserManager.Visible = true;
                    break;
                case AppEnum.UserLevel.Worker:
					// quan ly ban hang
                    _menuSaleManager.Visible = true;
					// cham cong
                    _menuWorkTracking.Visible = true;
					// thong ke ket ca
                    _menuShiftStatistics.Visible = true;
                    break;
            }
        }

		private void InitDefaultDetailView()
		{
			switch (_currentUser.Level)
			{
				case AppEnum.UserLevel.Admin:
					// thong ke ban hang
					break;
				case AppEnum.UserLevel.Worker:
					// quan ly ban hang
					ShowDetailView(new OrderView());
					break;
			}
		}

    }
}

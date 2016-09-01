using CoffeeManagement.BO;
using CoffeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.Views
{
    public partial class Login : Form
    {
        public Login(Form splashScreen)
        {
            InitializeComponent();
            splashScreen.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                var userBo = new UserBo();
                
                if (userBo.CheckLogin(_tbUsername.Text, _tbPassword.Text))
                {
                    MasterView masterView = new MasterView(this);
                    masterView.Show();
                }
                else
                {
                    MessageHelper.CreateErrorMessage("Thông tin đăng nhập không đúng!");
                }
            }
            else
            {
                MessageHelper.CreateErrorMessage("Bạn phải điền đủ thông tin!");
            }
        }

        private bool IsInputValid()
        {
            return ! (string.IsNullOrEmpty(_tbUsername.Text) || string.IsNullOrEmpty(_tbPassword.Text));
        }


        public void ClearText()
        {
            _tbPassword.Text = "";
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _btnLogin.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _lbAppName.Text = AppConstants.AppName.ToUpper();
        }
    }
}

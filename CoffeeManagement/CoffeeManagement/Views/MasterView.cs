using CoffeeManagement.BO;
using CoffeeManagement.Models;
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
    public partial class MasterView : Form
    {
        private Login _loginForm;
        private User _currentUser;

        public MasterView(Login loginForm)
        {
            InitializeComponent();
            _currentUser = UserBo.CurrentUser;
            MessageBox.Show("Welcome " + _currentUser.FullName);
            _loginForm = loginForm;
            _loginForm.Hide();
        }

        private void MasterView_Load(object sender, EventArgs e)
        {
            
        }

        private void MasterView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageHelper.CreateYesNoQuestion("Bạn có muốn đăng xuất?") == System.Windows.Forms.DialogResult.Yes)
                {
                    LogOut();
                    BackToLogin();
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
        }
        private void BackToLogin()
        {
            _loginForm.ClearText();
            _loginForm.Show();
        }
    }
}

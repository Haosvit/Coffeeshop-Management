using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManagement.BO;
using CoffeeManagement.DTOs;
using CoffeeManagement.Utilities;

namespace CoffeeManagement.Views.DetailViews
{
    public partial class WorkTrackingAdmin : UserControl, IDetailView
    {
        private UserBo _userBo;
        private BindingSource _bindingSource;
        private List<User> _users;

        public WorkTrackingAdmin()
        {
            InitializeComponent();
            _userBo = new UserBo();
            _bindingSource = new BindingSource();
        }

        public string ScreenName
        {
            get
            {
                return "Quản lí chấm công";
            }
        }

        private void panelStaffList_Paint(object sender, PaintEventArgs e)
        {
            StaffListControl c = new StaffListControl();
            this.panelStaffList.Controls.Add(c);
        }

        private void WorkTrackingAdmin_Load(object sender, EventArgs e)
        {
            _users = _userBo.GetAll();
            _bindingSource.DataSource = _users.Select(u => u.UserName).ToList();
            this.staffListBox.DataSource = _bindingSource;
        }


        private void staffListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if today is entered
            InitUserInfo();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            //throw new NotImplementedException();
        }

        private void InitUserInfo()
        {
            var selectedUser = _users[this.staffListBox.SelectedIndex];
            this.labelStaffName.Text = selectedUser.FullName;
            this.labelStaffLevel.Text = selectedUser.Level.ToString();
            this.labelTotalShift.Text = "0"; //TODO
            this.labelSalary.Text = "00.0000"; //TODO
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageHelper.CreateYesNoQuestion("Số liệu sau khi lưu không thể sửa, chắc chắn?") == DialogResult.Yes)
            {
                MessageHelper.CreateMessage("Đang chế tạo..."); //TODO
            }
            else // should eliminate
            {
                MessageHelper.CreateMessage("Tạm biệt cu!"); //TODO
            }
        }
    }
}

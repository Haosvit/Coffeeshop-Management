using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManagement.Utilities;
using CoffeeManagement.DTOs;
using CoffeeManagement.BO;

namespace CoffeeManagement.Views.DetailViews
{
    public partial class WorkTrackingWorker : UserControl, IDetailView
    {
        private User _curentUser;
        public WorkTrackingWorker()
        {
            InitializeComponent();
            _curentUser = UserBo.CurrentUser;
            this.labelStaffName.Text = _curentUser.FullName;
            this.labelStaffLevel.Text = _curentUser.Level.ToString();
        }

        public string ScreenName
        {
            get
            {
                return Properties.Resources.TitleWorkTrackingWorker;
            }
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

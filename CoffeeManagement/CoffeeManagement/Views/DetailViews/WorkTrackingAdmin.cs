using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManagement.Views.CustomControls;
namespace CoffeeManagement.Views.DetailViews
{
    public partial class WorkTrackingAdmin : UserControl, IDetailView
    {
        public WorkTrackingAdmin()
        {
            InitializeComponent();
        }

        public string ScreenName
        {
            get { return Properties.Resources.WorkTrackingAdmin; }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            StaffListControl slc = new StaffListControl();
            this.splitContainer1.Panel1.Controls.Add(slc);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            WorkTrackingControl wtc = new WorkTrackingControl();
            this.splitContainer1.Panel2.Controls.Add(wtc);
        }
    }
}

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
    public partial class WorkTrackingView : UserControl
    {
        public WorkTrackingView()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            StaffListControl c = new StaffListControl();
            //c.Dock = DockStyle.Top;
            this.splitContainer1.Panel1.Controls.Add(c);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            WorkTrackingContainerControl c = new WorkTrackingContainerControl();
            //c.Dock = DockStyle.Top;
            this.splitContainer1.Panel2.Controls.Add(c);
        }
    }
}

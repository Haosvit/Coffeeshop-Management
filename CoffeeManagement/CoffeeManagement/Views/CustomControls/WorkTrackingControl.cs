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
namespace CoffeeManagement.Views.CustomControls
{
    public partial class WorkTrackingControl : UserControl
    {
        public WorkTrackingControl()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            WorkTrackingDetailControl workTrackingDetailControl = new WorkTrackingDetailControl();
            this.splitContainer1.Panel1.Controls.Add(workTrackingDetailControl);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            WorkTrackingListControl wordTrackingListControl = new WorkTrackingListControl();
            this.splitContainer1.Panel2.Controls.Add(wordTrackingListControl);
        }
    }
}

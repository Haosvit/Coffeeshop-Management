using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.Views.DetailViews
{
    public partial class ExUC : UserControl, IDetailView
    {
        public ExUC()
        {
            InitializeComponent();
        }

        public string ScreenName
        {
            get { return "Quản lý bán hàng"; }
        }
    }
}

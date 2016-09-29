using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManagement.Utilities;

namespace CoffeeManagement.Views.Popups
{
    public partial class JoinTable : Form
    {
        public JoinTable()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (MessageHelper.CreateYesNoQuestion("Bạn thực sự muốn gộp bàn?") == DialogResult.Yes)
            {
                // Do joining Table List, Bill Data.
                MessageHelper.CreateMessage("Chức năng đang xây dựng");
            }
        }
    }
}

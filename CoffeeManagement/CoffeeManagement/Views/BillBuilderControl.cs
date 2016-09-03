using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.Views
{
    public partial class BillBuilderControl : UserControl
    {
        public BillBuilderControl()
        {
            InitializeComponent();
        }

        private void BillBuilderControl_Load(object sender, EventArgs e)
        {

        }

        private void stopTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void payBillBtn_Click(object sender, EventArgs e)
        {
            var payingBillConfirmationForm = new PayingBillConfirmationForm();
            payingBillConfirmationForm.Show();
        }
    }
}

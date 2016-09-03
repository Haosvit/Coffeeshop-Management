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
    public partial class PayingBillConfirmationForm : Form
    {
        public PayingBillConfirmationForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Caculate CASH automatically when the staff changes the Discount Value.
        /// Author: Nguyen Ba Anh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void discount_TextChanged(object sender, EventArgs e)
        {
            var discountValue = 0.0f;
            try
            {
                var discountTB = this.discount.Text;
                var totalAmountLB = this.totalAmount.Text;
                var totalAmountValue = Int16.Parse(totalAmountLB);
                discountValue = float.Parse(discountTB);

                if (discountValue < 0 || discountValue >= 100) // Limit percentage between 0 ~ 100
                {
                    discountValue = 0;
                    this.discount.Text = discountValue.ToString(); // reset to Zero if it was out of the range.
                } else
                {
                    var cashValue = totalAmountValue - totalAmountValue * discountValue / 100;
                    //cashValue = (float) Math.Round(cashValue, 3); // round it to thousands
                    this.cash.Text = cashValue.ToString(); // Update new value to Cash
                }
                
            } catch (FormatException ex) // for someone does not input numeric value
            {
                discountValue = 0;
                this.discount.Text = discountValue.ToString();
            }
        }
    }
}

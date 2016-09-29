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
    public partial class BillAndPay : Form
    {
        private bool parity;
        public BillAndPay()
        {
            InitializeComponent();
            this.Height -= this.discountPanel.Height;
            this.parity = true;

            this.billCash.Text = "100"; // Assume 100k

            // Do not edit after this
            this.givenCash.Text = this.billCash.Text;
            this.discountRatio.Text = "0.0";
            this.afterDiscountCash.Text = this.billCash.Text;
            this.givenCash.Text = this.billCash.Text;
            this.returnedCash.Text = "0.0";
        }

        private void BillAndPay2_Load(object sender, EventArgs e)
        {

        }

        private void expandLabel_Click(object sender, EventArgs e)
        {
            this.discountPanel.Visible = !this.discountPanel.Visible;
            this.Height += (this.parity ? 1 : -1) * this.discountPanel.Height;
            this.expandLabel.Text = (this.parity ? "▲ Thu hẹp" : "▼ Mở rộng");
            this.parity = !this.parity;
        }

        private void discountRatio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 billCashValue = Int32.Parse(this.billCash.Text);
                float discountValue = float.Parse(this.discountRatio.Text);
                if (discountValue < 0 || discountValue > 100)
                {
                    this.discountRatio.Text = "0.0";
                    MessageHelper.CreateErrorMessage("Lỗi nhập liệu: Xin nhập % Khuyến Mãi từ 0 ~ 100.");
                    return; // ==> stop!
                }
                this.discountRatio.BackColor = Color.AntiqueWhite;
                Int32 afterCashValue = billCashValue - (Int32) Math.Ceiling(billCashValue /100 * discountValue);
                this.afterDiscountCash.Text = afterCashValue.ToString();
                this.givenCash.Text = afterCashValue.ToString();
                this.returnedCash.Text = "0.0";
            }
            catch (FormatException ex)
            {
                this.discountRatio.Text = "0.0";
                MessageHelper.CreateErrorMessage("Lỗi nhập liệu: Xin nhập số.");
            }
        }

        private void givenCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 afterCashValue = Int32.Parse(this.afterDiscountCash.Text);
                Int32 givenCashValue = Int32.Parse(this.givenCash.Text);
                if (givenCashValue < afterCashValue)
                {
                    MessageHelper.CreateErrorMessage("Lỗi nghiệp vụ: Chưa đủ tiền.");
                    this.givenCash.BackColor = Color.Red;
                } else
                {
                    Int32 returnCashValue = givenCashValue - afterCashValue;
                    this.returnedCash.Text = returnCashValue.ToString();
                    this.givenCash.BackColor = Color.AntiqueWhite;
                }

            } catch(FormatException ex)
            {
                MessageHelper.CreateErrorMessage("Lỗi nhập liệu: Xin nhập số tự nhiên.");
                this.givenCash.BackColor = Color.OrangeRed;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageHelper.CreateYesNoQuestion("Bạn có chắc chắn muốn hủy đơn hàng không?") == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void payBillBtn_Click(object sender, EventArgs e)
        {
            MessageHelper.CreateMessage("Đang xây dựng tính năng này");
        }
    }
}

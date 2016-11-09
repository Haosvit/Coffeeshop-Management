using CoffeeManagement.BO;
using CoffeeManagement.DTOs;
using CoffeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.Views.Popups
{
	public partial class PaymentConfirm : Form
	{
		private Bill _bill;
		private bool parity;
		private BillBo _billBo = new BillBo();

		private int _discount;
		private int _finalTotal;
		private int _shortPreTotal;
		private int _receivedCash;
		public PaymentConfirm(Bill currentBill)
		{
			InitializeComponent();
			this.Height -= this.discountPanel.Height;
			this.parity = true;
			_bill = currentBill;
			UpdateForm();
			
		}

		private void UpdateForm()
		{
			_lbTableNames.Text = string.Join(";", _bill.Tables.Select(t => t.Name));

			_shortPreTotal = _bill.PreTotal / 1000;

			_tbBillPretotal.Text = _shortPreTotal.ToString();

				try {
					var discount = Convert.ToInt16(_tbDiscount.Text);	
					_finalTotal = _shortPreTotal * (100 - discount) / 100;
					_tbFinalTotal.Text = _finalTotal.ToString();
				}
			catch (FormatException) {
				_tbDiscount.SelectAll();
			}
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
				_discount = Convert.ToInt16(_tbDiscount.Text);
				if (_discount < 0)
				{
					_tbDiscount.Text = "0";
				}
				else if (_discount > 100)
				{
					_tbDiscount.Text = "100";
				}

				_finalTotal = _shortPreTotal * (100 - _discount) / 100;
				_tbFinalTotal.Text = _finalTotal.ToString();
				_tbReturnChanges.Text = (_receivedCash - _finalTotal).ToString();
			}
			catch (FormatException ex)
			{
				_tbDiscount.SelectAll();
			}
		}

		private void givenCash_TextChanged(object sender, EventArgs e)
	{
			try
			{
				_receivedCash = Convert.ToInt16(_tbReceive.Text);

				if (_receivedCash >= _shortPreTotal)
				{
					_tbReturnChanges.Text = (_receivedCash - _finalTotal).ToString();
				}								
			}
			catch (FormatException ex)
			{
				//this._tbReceive.BackColor = Color.OrangeRed;
			}
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
		//	if (MessageHelper.CreateYesNoQuestion("Bạn có chắc chắn muốn hủy đơn hàng không?") == DialogResult.Yes)
		//	{
		//		this.Close();
		//	}
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void payBillBtn_Click(object sender, EventArgs e)
		{
			_bill.DiscountRate = Convert.ToInt16(_tbDiscount.Text);
			_bill.Total = Convert.ToInt16(_tbFinalTotal.Text);

			_billBo.SaveBill(_bill);
			DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();

		}

	}
}

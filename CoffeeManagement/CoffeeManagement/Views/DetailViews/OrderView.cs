using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CoffeeManagement.Utilities;
using CoffeeManagement.BO;
using CoffeeManagement.DAO;
using CoffeeManagement.DTOs;
using CoffeeManagement.Properties;
using System;
using System.Drawing;
using CoffeeManagement.Views.Popups;

namespace CoffeeManagement.Views.DetailViews
{
	public partial class OrderView : UserControl, IDetailView
	{
		private ItemBo _itemBo = new ItemBo();
		private List<Item> _items;
		private BillBo _billBo = new BillBo();
		private TableBo _tableBo = new TableBo();
		private List<Table> _tables;

		private List<Bill> _temptBills = new List<Bill>();
		private Bill _currentBill;

		private bool _changedItemCheckStateFlag = false;

		private BindingSource _orderGVBindingSource = new BindingSource();
		public OrderView()
		{
			InitializeComponent();
			_itemBackgroundLoader.WorkerSupportsCancellation = true;
			_itemBackgroundLoader.DoWork += OnLoadItemsBackground;
			_itemBackgroundLoader.RunWorkerCompleted += OnLoadItemsCompleted;
			// setup searchbox
			_sbSearchItems.SearchClicked += OnSearchItems;
			_sbSearchItems.ClearClicked += OnClearSearchContent;
			_sbSearchItems.SearchContentChanged += OnSearchContentChanged;
		}

		public string ScreenName
		{
			get { return Properties.Resources.OrderViewTitle; }
		}

		private void OrderView_Load(object sender, System.EventArgs e)
		{
			LoadItems();
			LoadTables();
		}

		private void LoadTables()
		{
			_tables = _tableBo.GetTables();
			foreach (Table t in _tables) {				
				_listTables.Items.Add(t.Name, !t.IsAvailable);
			}
		}

		private void LoadItems()
		{
			_itemBackgroundLoader.RunWorkerAsync();
		}

		#region Search
		private void OnClearSearchContent(object sender, System.EventArgs e)
		{

		}

		private void OnSearchItems(object sender, System.EventArgs e)
		{

		}

		private void OnSearchContentChanged(object sender, System.EventArgs e)
		{
			var items =
				_items.Where(i => i.Name.ToLowerVietnameseNoTones().Contains(_sbSearchItems.SearchContent.ToLowerVietnameseNoTones()))
					.ToList();
			UpdateItemDataGridView(items);
		}
		#endregion

		#region Items
		private void OnLoadItemsBackground(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			_items = _itemBo.GetAll();
		}

		private void OnLoadItemsCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			UpdateItemDataGridView(_items);
		}

		private void UpdateItemDataGridView(List<Item> items)
		{
			_gvItems.DataSource = items.Select(i => new { i.Name, UnitName = i.Unit.Name, i.SalingPrice }).ToList();
			if (_gvItems.Columns.Count > 0)
			{
				_gvItems.Columns["Name"].HeaderText = Resources.ItemName;
				_gvItems.Columns["UnitName"].HeaderText = Resources.UnitName;
				_gvItems.Columns["SalingPrice"].HeaderText = Resources.SalingPrice;
			}
		}

		#endregion

		// Select item to add to order
		private void _gvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (_currentBill != null)
			{
				var selectedItem = _items[_gvItems.CurrentRow.Index];
				_currentBill.Items.Add(selectedItem);
				CalculateBillPrice();
				UpdateOrderGridView();
			}
			else
			{
				if (_listTables.SelectedIndex == -1)
				{
					_listTables.SetItemChecked(_listTables.SelectedIndex, true);
				}
			}
		}

		private void _btnPrint_Click(object sender, System.EventArgs e)
		{
		}

		// click table item to view bill
		private void _listTables_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (_listTables.SelectedIndex < 0)
			{
				return;
			}

			if (_listTables.GetItemCheckState(_listTables.SelectedIndex) == CheckState.Checked)
			{
				_currentBill = _temptBills.FirstOrDefault(b => b.Tables.Contains(_tables[_listTables.SelectedIndex]));
				if (_currentBill != null)
				{
					_lbTableNames.Text = string.Join(";", _currentBill.Tables.Select(t => t.Name));
					UpdateOrderGridView();
				}
			}
		}

		// table item check and uncheck
		private void _listTables_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Checked)
			{
				if (MessageHelper.CreateYesNoQuestion("Tạo hóa đơn cho bàn [" + _tables[e.Index].Name + "]?") == DialogResult.Yes)
				{
					// create new bill
					Bill bill = new Bill()
					{
						CreatedDateTime = DateTime.Now,
						CurrentUser = UserBo.CurrentUser
					};
					bill.Items = new List<Item>();

					var selectedTable = _tables[e.Index];
					bill.Tables.Add(selectedTable);
					_temptBills.Add(bill);
					_currentBill = bill;
					UpdateOrderGridView();
					_lbTableNames.Text = selectedTable.Name;
				}
				else
				{
					e.NewValue = CheckState.Unchecked;
				}				
			}
			else
			{
				if (!_changedItemCheckStateFlag)
				{
					e.NewValue = CheckState.Checked;
				}
				_changedItemCheckStateFlag = false;
			}

		}

		private void UpdateOrderGridView()
		{
			_orderGVBindingSource.DataSource = _currentBill.Items.Select( i => new { Name = i.Name, UnitName = i.Unit.Name, i.SalingPrice});
			_gvOrder.DataSource = _orderGVBindingSource;
			_orderGVBindingSource.ResetBindings(false);

			if (_gvOrder.Columns.Count > 0)
			{
				_gvItems.Columns["Name"].HeaderText = Resources.ItemName;
				_gvItems.Columns["UnitName"].HeaderText = Resources.UnitName;
				_gvItems.Columns["SalingPrice"].HeaderText = Resources.SalingPrice;
			}
		}

		private void _btnPay_Click(object sender, EventArgs e)
		{
			if (MasterView.Instance.ShowPopup(new PaymentConfirm(_currentBill)) == DialogResult.OK)
			{
				RemoveCurrentTemptBill();
			}
		}

		private void RemoveCurrentTemptBill()
		{
			foreach (Table t in _currentBill.Tables)
			{
				ChangeListItemCheckState(_tables.IndexOf(t), false);
			}

			_temptBills.Remove(_currentBill);
			_orderGVBindingSource.DataSource = null;
			_orderGVBindingSource.ResetBindings(false);
			_lbTableNames.Text = "";
		}

		private void ChangeListItemCheckState(int index, bool isChecked)
		{
			_changedItemCheckStateFlag = true;
			_listTables.SetItemChecked(index, isChecked);
		}

		private void _listTables_MouseClick(object sender, MouseEventArgs e)
		{
		}

		private void _listTables_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				var se = _listTables.SelectedIndex;
				_tableContextMenu.Show(_listTables, new Point(e.X, e.Y));
			}
		}

		// remove item from order
		private void _gvOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var selectedItem = _currentBill.Items.ToList()[_gvOrder.CurrentRow.Index];
			_currentBill.Items.Remove(selectedItem);
			CalculateBillPrice();
			UpdateOrderGridView();
		}

		private void CalculateBillPrice()
		{
			_currentBill.PreTotal = _currentBill.Items.Sum(i => i.SalingPrice);
			_lbTotalPrice.Text = _currentBill.PreTotal.ToString();
		}

		private void _btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageHelper.CreateYesNoQuestion("Bạn có chắc chắn xóa hóa đơn bàn [" + string.Join(";", _currentBill.Tables.Select(t => t.Name)) + "]?") == DialogResult.Yes)
			{
				_temptBills.Remove(_currentBill);
				RemoveCurrentTemptBill();
			}
		}

	}
}

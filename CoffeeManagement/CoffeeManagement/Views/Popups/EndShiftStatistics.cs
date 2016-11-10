using CoffeeManagement.BO;
using CoffeeManagement.DTOs.ViewModels;
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
	public partial class EndShiftStatistics : Form
	{
		private BillBo _billBO = new BillBo();
		private List<StatsByItems> _statsByItemsList = new List<StatsByItems>();
		
		public EndShiftStatistics()
		{
			InitializeComponent();			
		}
		private void EndShiftStatistics_Load(object sender, EventArgs e)
		{
			_lbDateTime.Text = string.Format("{DD/MM/YYYY", DateTime.Now);
			GenerateStatsByItems();
		}


		private void StatsByItemsCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
		}

		private void InBackgroundGenerateStatsByItems(object sender, DoWorkEventArgs e)
		{

		}


		private void StatsByBillsCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
		}

		private void InBackgroundGenerateStatsByBills(object sender, DoWorkEventArgs e)
		{

		}

		private void _btnStats_Click(object sender, EventArgs e)
		{
			GenerateStatsByItems();
		}

		private void GenerateStatsByItems()
		{
			_backgroundLoader.DoWork += InBackgroundGenerateStatsByItems;
			_backgroundLoader.DoWork -= InBackgroundGenerateStatsByBills;
			_backgroundLoader.RunWorkerCompleted += StatsByItemsCompleted;
			_backgroundLoader.RunWorkerCompleted -= StatsByBillsCompleted;
			_backgroundLoader.RunWorkerAsync();
		}

	}
}

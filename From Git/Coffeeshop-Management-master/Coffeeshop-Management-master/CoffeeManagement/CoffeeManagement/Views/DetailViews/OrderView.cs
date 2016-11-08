using System.Windows.Forms;
using CoffeeManagement.Utilities;

namespace CoffeeManagement.Views.DetailViews
{
	public partial class OrderView : UserControl, IDetailView
	{
		public OrderView()
		{
			InitializeComponent();
		}

		public string ScreenName
		{
			get { return Properties.Resources.OrderViewTitle; }
		}

		private void OrderView_Load(object sender, System.EventArgs e)
		{
			_sbSearchItems.SearchClicked += OnSearchItems;
			_sbSearchItems.ClearClicked += OnClearSearchContent;
		}

		private void OnClearSearchContent(object sender, System.EventArgs e)
		{

		}

		private void OnSearchItems(object sender, System.EventArgs e)
		{
			MessageHelper.CreateMessage("Search");
		}


	}
}

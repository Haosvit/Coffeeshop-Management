using System.Windows.Forms;

namespace CoffeeManagement.Views.DetailViews
{
	public partial class ItemManagerView : UserControl, IDetailView
	{
		public ItemManagerView()
		{
			InitializeComponent();
		}

		public string ScreenName
		{
			get { return Properties.Resources.ItemManagerView; }
		}
	}
}

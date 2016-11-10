using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DTOs.ViewModels
{
	public class StatsByItems
	{
		public string ItemName { get; set; }
		public int Quantity { get; set; }
		public string UnitName { get; set; }
		public int UnitPrice { get; set; }
		public int Total { get; set; }

	}
}

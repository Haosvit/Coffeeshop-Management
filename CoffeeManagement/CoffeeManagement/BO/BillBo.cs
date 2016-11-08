using CoffeeManagement.DAO;
using CoffeeManagement.DTOs;
namespace CoffeeManagement.BO
{
	public class BillBo
	{
		private BillDao _billDao = new BillDao();
		internal void SaveBill(Bill bill)
		{
			_billDao.Add(bill);
		}
	}
}

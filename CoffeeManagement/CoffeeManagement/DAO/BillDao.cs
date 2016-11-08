using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.DAO
{
	public class BillDao
	{
		CoffeeDbContext dbContext = new CoffeeDbContext();

		public List<Bill> GetAll()
		{
			return dbContext.Bills.ToList();
		}

		public void Add(Bill bill)
		{
			Bill billToSave = new Bill
			{
				CreatedDateTime = DateTime.Now,
				CurrentUser = bill.CurrentUser,
				DiscountRate = bill.DiscountRate,
				PreTotal = bill.PreTotal,
			};

			foreach (Item item in bill.Items)
			{
				billToSave.Items.Add(dbContext.Items.SingleOrDefault( it => it.Id == item.Id));
			}

			foreach (Table table in bill.Tables)
			{
				billToSave.Tables.Add(dbContext.Tables.SingleOrDefault(t => t.Id == table.Id));
			}

			billToSave.Total = (int) (billToSave.PreTotal * (100 - billToSave.DiscountRate) / 100.0);

			dbContext.Bills.Add(billToSave);
			dbContext.SaveChanges();
		}

		public void Update(Bill bill)
		{
			dbContext.Entry(bill).State = EntityState.Modified;
			dbContext.SaveChanges();
		}

		public void Delete(Bill bill)
		{
			dbContext.Bills.Remove(bill);
			dbContext.SaveChanges();
		}

		public void Dummy()
		{
			Add(new Bill
			{
				CreatedDateTime = DateTime.Now,
				Items = dbContext.Items.ToList(),
				Total = 1000
			});

		}
	}
}

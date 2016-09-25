using System;
using System.Data.Entity;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.DAO
{
    public class CoffeeDbContext : DbContext
    {
        private static string _dbName = "COFFEE_MANAGEMENT_DB";

		// DbSets
		public DbSet<BasicSalary> BasicSalaries { get; set; }
		public DbSet<Bill> Bills { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<ItemBill> ItemBills { get; set; }
		public DbSet<Shift> Shifts { get; set; }
		public DbSet<Table> Tables { get; set; }
		public DbSet<TableBill> TableBills { get; set; }
		public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }
        public CoffeeDbContext() : base(_dbName)
        {
        // switch on these lines to drop and create new database when model changes.
            //Database.SetInitializer(new DbInitializer());
            //Database.Initialize(false);

            if (Database.CreateIfNotExists())
            {
                InitDatabase();
            }
        }
        
        public class DbInitializer : DropCreateDatabaseIfModelChanges<CoffeeDbContext>
        {
            protected override void Seed(CoffeeDbContext context)
            {
                InitDatabase();
                base.Seed(context);
            }
        }

        public static void InitDatabase()
        {
            CoffeeDbContext context = new CoffeeDbContext();
            // Init database with context
            context.Users.Add(new User
            {
                UserName = "admin",
                Password = "admin",
                FullName = "Admin",
                Level = Utilities.AppEnum.UserLevel.Admin
            });

            context.Users.Add(new User
            {
                UserName = "baristar",
                Password = "123",
                FullName = "Baristar",
                Level = Utilities.AppEnum.UserLevel.Baristar

            });

            context.Users.Add(new User
            {
                UserName = "receptionist",
                Password = "123",
                FullName = "Receptionist",
                Level = Utilities.AppEnum.UserLevel.Worker

            });

            context.SaveChanges();
        }
    }
}

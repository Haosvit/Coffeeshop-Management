using CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    public class UserDao
    {
        CoffeeDbContext dbContext = new CoffeeDbContext();

        public List<User> GetAll()
        {
            return dbContext.Users.ToList();
        }
    }
}

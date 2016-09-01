using CoffeeManagement.DAO;
using CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.BO
{
    public class UserBo
    {
        UserDao userDao = new UserDao();
        public static User CurrentUser { get; private set; }
        public bool CheckLogin(string username, string password)
        {
            var uList = userDao.GetAll();
            CurrentUser = uList.SingleOrDefault(u => u.UserName == username && u.Password == password);
           
            return CurrentUser != null ? true : false;
        }

        internal void LogOut()
        {
            CurrentUser = null;
        }
    }
}

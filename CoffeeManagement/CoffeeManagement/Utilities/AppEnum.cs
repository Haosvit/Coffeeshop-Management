using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.Utilities
{
    public static class AppEnum
    {
        public enum UserLevel
        {
            Admin,
            Baristar,
            Worker
        }

        public enum MenuType
        {
            Sale,
            WorkTracking,
            Statistics,
            LogOut
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROPark_II.Models
{
    public static class Account
    {
        public static Boolean isLogged;

        public static int userId { get; set; }
        public static string userName { get; set; }

        public static void logOut()
        {
            if (isLogged)
            {
                userId = -1;
                userName = null;
                isLogged = false;
            }
        }
    }
}

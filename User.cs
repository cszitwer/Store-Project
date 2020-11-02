using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject
{
    class User
    {
        public bool loggedIn { get; set; } = false;
        public string userEmail {get; set;}
        public string userPass { get; set; }
        public int userId { get; set; }

        public decimal userBalance { get; set; }

        public User(string email, string pass, int id, decimal balance)
        {
            loggedIn = true;
            userEmail = email;
            userPass = pass;
            userId = id;
            userBalance = balance;

        }


    }
}

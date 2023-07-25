using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountService
    {
        public bool Login(string username, string password)
        {
            var dbUser = GetUsers();

            foreach (User user in dbUser)
            {
                if(user.Username == username && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        private User[] GetUsers()
        {
            User[] users =
            {
                new User
                {
                    Id = 1,
                    Username = "ismayil155",
                    Password = "ismayil123"
                },
                new User
                {
                    Id = 2,
                    Username = "xeyyam155",
                    Password = "xeyyam123"
                },

                new User
                {
                    Id = 3,
                    Username = "pervin55",
                    Password = "pervin123"
                },

            };

            return users;
        }
    }
}

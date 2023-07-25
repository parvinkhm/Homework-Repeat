using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Services.Controllers
{
    public class AccountController
    {
        private readonly AccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }
        public void Login()
        {
            Console.WriteLine("Usernamr");
            Username: string username = Console.ReadLine();

            Console.WriteLine("Password");
            string password = Console.ReadLine();
            bool isLogin = _accountService.Login(username, password);

            if (isLogin)
            {
                Console.WriteLine(AccountMessages.LoginSucces);
            }
            else
            {
                Console.WriteLine(AccountMessages.LoginFailed);

                goto Username;
            }
        }
    }
}

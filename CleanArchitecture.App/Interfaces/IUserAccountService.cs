using CleanArchitecture.App.Interfaces;
using CleanArchitecture.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.App.Services
{
   public interface IUserAccountService
    {
        UserAccountsViewModel GetUserAccounts();

        bool DeleteUser(string uid);

    }
}

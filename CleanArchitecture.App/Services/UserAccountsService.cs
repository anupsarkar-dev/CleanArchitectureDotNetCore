using CleanArchitecture.App.ViewModels;
using CleanArchitecture.Domain.Inferfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.App.Services
{
    public class UserAccountsService : IUserAccountService
    {
        private IUserAccountRepository _userAccountRepository;

       

        public UserAccountsService(IUserAccountRepository repo)
        {
            _userAccountRepository = repo;
        }

        public bool DeleteUser(string uid)
        {
            return _userAccountRepository.DeleteUser(uid);
        }

        public UserAccountsViewModel GetUserAccounts()
        {
            return new UserAccountsViewModel { UserAccounts = _userAccountRepository.GetUserAccounts() };
        }

         
    }
}
